using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BatchFileRenamer
{
    public partial class Form1 : LocalizedForm
    {
        public Localization Loc = new Localization();

        public bool renamingCompleted = false;
        private bool rulesChanged = true;
        private bool simulateRename = false; // true = do not change any file/dir names

        private Dictionary<string, string> lastRules = new Dictionary<string, string>();
        private Dictionary<int, Dictionary<string, string>> renamedFiles = new Dictionary<int, Dictionary<string, string>>();
        private string renamedItemType;

        public Form1(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.language);
            InitializeComponent();
            resizeContentList();
            setButtonTooltip();
            if (args.Length >= 1)
            {
                // if called from context menu set path of selected folder
                txtPath.Text = args[0].ToString();
                btnStart.Enabled = true;
            }
            firstStart();
        }

        private void firstStart()
        {
            if(Properties.Settings.Default.first_start==true)
            {
                // Change icon of application in Windows AddOrRemove (Control Panel)
                RegistryKey myUninstallKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
                string iconSourcePath = System.Reflection.Assembly.GetExecutingAssembly().Location+",0";
                string[] mySubKeyNames = myUninstallKey.GetSubKeyNames();
                for (int i = 0; i <= mySubKeyNames.Length - 1; i++)
                {
                    RegistryKey myKey = myUninstallKey.OpenSubKey(mySubKeyNames[i], true);
                    object myValue = myKey.GetValue("DisplayName");
                    if (myValue != null && myValue.ToString() == "Batch FileRenamer")
                    {
                        myKey.SetValue("DisplayIcon", iconSourcePath);
                        break;
                    }
                }
                // done forever!
                Properties.Settings.Default.first_start = false;
                Properties.Settings.Default.Save();
            }
        }

        private void setButtonTooltip()
        {
            ToolTip t = new ToolTip();
            ToolTip t2 = new ToolTip();
            t.SetToolTip(btnOpenDir, null);
            t2.SetToolTip(btnRevert, null);
            t.SetToolTip(btnOpenDir, getLocStr("btnOpenDir_tooltip"));
            if (rbDirs.Checked)
            {
                // dirs
                t2.SetToolTip(btnRevert, getLocStr("btnRevert_dirs_tt"));
            } else
            {
                // files
                t2.SetToolTip(btnRevert, getLocStr("btnRevert_files_tt"));
            }
        }

        private void setLabelText()
        {
            if (rbFiles.Checked == true)
            {
                lblRule_3_Explanation.Text = getLocStr("label_rule3_explanation_file");
            }
            else
            {
                lblRule_3_Explanation.Text = getLocStr("label_rule3_explanation_dir");
            }
            listViewContent.Columns[0].Text = getLocStr("list_col_before");
            listViewContent.Columns[1].Text = getLocStr("list_col_after");
        }

        public string getLocStr(string key, string lang = null)
        {
            return Loc.getLocStr(key, lang);
        }

        private void btnSearchPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPath.Text = fbd.SelectedPath;
                    PopulateListView(listViewContent, fbd.SelectedPath, "*.*");
                }
            }
        }

        private void rbFiles_CheckedChanged(object sender, EventArgs e)
        {
            if(txtPath.Text.Length > 0 && pathIsValid())
            {
                PopulateListView(listViewContent, txtPath.Text, "*.*");
            }
            setExampleRuleText();
            if(rbFiles.Checked == true)
            {
                lblRule_3_Explanation.Text = getLocStr("label_rule3_explanation_file");
                pFileending.Visible = true;
                ToolTip t = new ToolTip();
                t.SetToolTip(btnRevert, null);
                t.SetToolTip(btnRevert, getLocStr("btnRevert_files_tt"));
            } else
            {
                lblRule_3_Explanation.Text = getLocStr("label_rule3_explanation_dir");
                pFileending.Visible = false;
                ToolTip t = new ToolTip();
                t.SetToolTip(btnRevert, null);
                t.SetToolTip(btnRevert, getLocStr("btnRevert_dirs_tt"));
            }
        }

        private bool pathIsValid()
        {
            return Directory.Exists(txtPath.Text);
        }


        private void PopulateListView(ListView list, string dir, string fileTypes)
        {
            if(renamingCompleted || dir.Length == 0)
            {
                return;
            }
            list.Items.Clear();
            int itemsCount = 0;

            DirectoryInfo dinfo = new DirectoryInfo(dir);

            if (rbFiles.Checked == true)
            {
                string[] files = Directory.GetFiles(dir);

                FileInfo[] Files = dinfo.GetFiles(fileTypes);
                foreach (FileInfo file in Files)
                {
                    if (cbFileending.Checked == true && txtFiletype.Text.Contains("*."))
                    {
                        // handle file endings
                        string[] endings = txtFiletype.Text.Split(',');
                        foreach (var ending in endings)
                        {
                            if (file.Name.EndsWith(ending.Replace("*", "")))
                            {
                                string oldFilename = file.Name;
                                string newFilename = applyRules(file.Name, itemsCount + 1);
                                ListViewItem itemListRow = new ListViewItem(oldFilename);
                                itemListRow.UseItemStyleForSubItems = false;
                                itemListRow.SubItems.Add(newFilename);
                                if(oldFilename == newFilename)
                                {
                                    // not affected by renaming
                                    itemListRow.SubItems[1].ForeColor = Color.Gray;
                                } else
                                {
                                    // IS affected by renaming
                                    itemListRow.SubItems[1].ForeColor = Color.Blue;
                                }
                                list.Items.Add(itemListRow);
                                itemsCount++;
                            }
                        }
                    }
                    else
                    {
                        string oldFilename = file.Name;
                        string newFilename = applyRules(file.Name, itemsCount + 1);
                        ListViewItem itemListRow = new ListViewItem(oldFilename);
                        itemListRow.UseItemStyleForSubItems = false;
                        itemListRow.SubItems.Add(newFilename);
                        if(oldFilename == newFilename)
                        {
                            // not affected by renaming
                            itemListRow.SubItems[1].ForeColor = Color.Gray;
                        } else
                        {
                            // IS affected by renaming
                            itemListRow.SubItems[1].ForeColor = Color.Blue;
                        }
                        list.Items.Add(itemListRow);
                        itemsCount++;
                    }
                }

            }
            else if (rbDirs.Checked == true)
            {
                string[] directories = Directory.GetDirectories(dir);

                DirectoryInfo[] Dirs = dinfo.GetDirectories();
                foreach (DirectoryInfo d in Dirs)
                {
                    string oldDirname = d.Name;
                    string newDirname = applyRules(d.Name, itemsCount + 1);
                    ListViewItem itemListRow = new ListViewItem(oldDirname);
                    itemListRow.UseItemStyleForSubItems = false;
                    itemListRow.SubItems.Add(newDirname);
                    if(oldDirname == newDirname)
                    {
                        // not affected by renaming
                        itemListRow.SubItems[1].ForeColor = Color.Gray;
                    } else
                    {
                        // IS affected by renaming#
                        itemListRow.SubItems[1].ForeColor = Color.Blue;
                    }
                    list.Items.Add(itemListRow);
                    itemsCount++;
                }
            }
            if (itemsCount > 0)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
            this.Cursor = Cursors.Default;
        }

        private void cbRule_0_Numbers_CheckedChanged(object sender, EventArgs e)
        {
            lblRule_0_example.Enabled = cbRule_0_Numbers.Checked;
            txtRule_0_pattern.Enabled = cbRule_0_Numbers.Checked;
            lblRule_0_pattern.Enabled = cbRule_0_Numbers.Checked;
            rbRule_0_after.Enabled = cbRule_0_Numbers.Checked;
            rbRule_0_before.Enabled = cbRule_0_Numbers.Checked;
            updateResultExample();
        }

        private void rbRule_0_after_CheckedChanged(object sender, EventArgs e)
        {
            setExampleRuleText();
            updateResultExample();
        }

        private void setExampleRuleText()
        {
            if (rbRule_0_after.Checked)
            {
                // after (XXX-01)
                lblRule_0_example.Text = getPatternExample(false);
            }
            else
            {
                // before (01-XXX)
                lblRule_0_example.Text = getPatternExample(true);
            }
        }

        private string getPatternExample(bool before)
        {
            string exampleStr = "";
            string pattern = txtRule_0_pattern.Text;
            string itemName = getLocStr("typFilename");
            if(rbDirs.Checked == true)
            {
                itemName = getLocStr("typDirname");
            }
            exampleStr = txtRule_0_pattern.Text.Replace("%nnnnn", "00001").Replace("%nnnn", "0001").Replace("%nnn", "001").Replace("%nn", "01").Replace("%n", "1");
            if(before)
            {
                exampleStr = exampleStr + itemName;
            } else
            {
                exampleStr = itemName + exampleStr;
            }
            return exampleStr;
        }

        private string applyRules(string itemName, int itemPos)
        {
            string newName = itemName;
            // 1. Numbering
            if(cbRule_0_Numbers.Checked)
            {
                int padDigits = 1;
                if(txtRule_0_pattern.Text.Contains("%nnnnn"))
                {
                    padDigits = 5;
                } else if(txtRule_0_pattern.Text.Contains("%nnnn"))
                {
                    padDigits = 4;
                } else if(txtRule_0_pattern.Text.Contains("%nnn"))
                {
                    padDigits = 3;
                } else if(txtRule_0_pattern.Text.Contains("%nn"))
                {
                    padDigits = 2;
                } else
                {
                    padDigits = 1;
                }
                string nNbr = pad_an_int(itemPos, padDigits);
                string nTxt = txtRule_0_pattern.Text.Replace("%nnnnn", nNbr).Replace("%nnnn",nNbr).Replace("%nnn",nNbr).Replace("%nn",nNbr).Replace("%n",nNbr);
                if (rbRule_0_before.Checked)
                {
                    newName = nTxt + newName;   // prepend
                } else
                {
                    if(rbFiles.Checked)
                    {
                        // do append numbering before filetype
                        string ftypeN = Path.GetExtension(newName);
                        newName = replaceLastOccurrence(newName, ftypeN, "") + nTxt + ftypeN;   // append
                    } else
                    {
                        newName = newName + nTxt;
                    }
                }
            }
            // 2. Search Replace #1
            if(txtRule_1_Search.Text.Length > 0)
            {
                newName = newName.Replace(txtRule_1_Search.Text, txtRule_1_Replace.Text);
            }
            // 3. Search Replace #2
            if(txtRule_2_Search.Text.Length > 0)
            {
                newName = newName.Replace(txtRule_2_Search.Text, txtRule_2_Replace.Text);
            }
            // 4. Prepend
            newName = txtRule_3_Prepend.Text + newName;
            // 5. Append
            if (rbFiles.Checked)
            {
                // append before filetype 
                string ftype = Path.GetExtension(newName);
                newName = replaceLastOccurrence(newName, ftype, "") + txtRule_3_Append.Text + ftype;
            } else
            {
                newName = newName + txtRule_3_Append.Text;
            }
            return newName;
        }
        static string replaceLastOccurrence(string Source, string Find, string Replace)
        {
            int place = Source.LastIndexOf(Find);

            if (place == -1)
                return Source;

            string result = Source.Remove(place, Find.Length).Insert(place, Replace);
            return result;
        }
        static string pad_an_int(int number, int digits)
        {
            string s = "";
            for (int i = 0; i < digits; i++)
            {
                s += "0";
            }
            return number.ToString(s);
        }

        private void txtRule_0_pattern_TextChanged(object sender, EventArgs e)
        {
            setExampleRuleText();
            updateResultExample();
        }

        private void listBoxFiles_SelectedValueChanged(object sender, EventArgs e)
        {
            updateResultExample();
        }

        private void updateResultExample()
        {
            rulesChanged = true;
            btnResetRules.Image = Properties.Resources.shell32_16803;
            btnResetRules.Cursor = Cursors.Hand;
            ToolTip brrtt = new ToolTip();
            brrtt.SetToolTip(btnResetRules, null);
            brrtt.SetToolTip(btnResetRules, getLocStr("btnResetRules_tt"));
            if (!renamingCompleted)
            {
                PopulateListView(listViewContent, txtPath.Text, "*.*");
            }
        }
    

        private int getNumberPatternStartIndex()
        {
            if(txtRule_0_pattern.Text.IndexOf("%nnnnn")> -1)
            {
                return 5;
            }
            if (txtRule_0_pattern.Text.IndexOf("%nnnn") > -1)
            {
                return 4;
            }
            if (txtRule_0_pattern.Text.IndexOf("%nnn") > -1)
            {
                return 3;
            }
            if (txtRule_0_pattern.Text.IndexOf("%nn") > -1)
            {
                return 2;
            }
            if (txtRule_0_pattern.Text.IndexOf("%n") > -1)
            {
                return 1;
            }
            return 0;
        }

        private void txtRule_1_Search_TextChanged(object sender, EventArgs e)
        {
            updateResultExample();
        }

        private void txtRule_1_Replace_TextChanged(object sender, EventArgs e)
        {
            updateResultExample();
        }

        private void txtRule_2_Search_TextChanged(object sender, EventArgs e)
        {
            updateResultExample();
        }

        private void txtRule_2_Replace_TextChanged(object sender, EventArgs e)
        {
            updateResultExample();
        }

        private void txtRule_3_Prepend_TextChanged(object sender, EventArgs e)
        {
            updateResultExample();
        }

        private void txtRule_3_Append_TextChanged(object sender, EventArgs e)
        {
            updateResultExample();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtPath.Text))
            {
                MessageBox.Show(getLocStr("error_pathnotexist"), getLocStr("error"), MessageBoxButtons.OK);
                return;
            }
            string itemType = getLocStr("files");
            if (rbDirs.Checked) {
                itemType = getLocStr("dirs");
            }
            int itemCount = countRenameItems();
            if(itemCount == 0)
            {
                // no items to rename
                MessageBox.Show(getLocStr("rename_nothingtodo"), getLocStr("rename_nothingtodo_title"), MessageBoxButtons.OK);
            } else
            {
                DialogResult res = MessageBox.Show(itemCount.ToString() + itemType + getLocStr("rename_sure"), getLocStr("rename_sure_title"), MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    startRenaming();
                }
            }
        }

        private int countRenameItems()
        {
            int renameItemsCount = 0;
            DirectoryInfo dinfo = new DirectoryInfo(txtPath.Text);
            if (rbFiles.Checked == true)
            {
                string[] files = Directory.GetFiles(txtPath.Text);

                FileInfo[] Files = dinfo.GetFiles("*.*");
                int i = 1;
                foreach (FileInfo file in Files)
                {
                    bool skipFile = true;
                    if (cbFileending.Checked == true && txtFiletype.Text.Contains("*."))
                    {
                        // handle file endings
                        string[] endings = txtFiletype.Text.Split(',');
                        foreach (var ending in endings)
                        {
                            if (file.Name.EndsWith(ending.Replace("*", "")))
                            {
                                skipFile = false;
                            }
                        }
                    }
                    else
                    {
                        skipFile = false;
                    }
                    if(skipFile)
                    {
                        continue;
                    }

                    string oldFilename = file.Name;
                    string newFilename = applyRules(file.Name, i);
                    if (oldFilename != newFilename)
                    {
                        renameItemsCount++;
                        i++;
                    }
                }
            } else if(rbDirs.Checked == true)
            {
                DirectoryInfo[] Dirs = dinfo.GetDirectories();
                int i = 1;
                foreach (DirectoryInfo dir in Dirs)
                {
                    string oldDirname = dir.Name;
                    string newDirname = applyRules(dir.Name, i);
                    if (oldDirname != newDirname)
                    {
                        renameItemsCount++;
                        i++;
                    }
                }
            }
            return renameItemsCount;
        }

        /** magic happens here: */
        private void startRenaming()
        {
            listViewContent.Items.Clear();
            renamedFiles.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(txtPath.Text);

            if (rbFiles.Checked == true)
            {
                string[] files = Directory.GetFiles(txtPath.Text);

                FileInfo[] Files = dinfo.GetFiles("*.*");
                int i = 1;
                foreach (FileInfo file in Files)
                {
                    bool skipFile = true;
                    if (cbFileending.Checked == true && txtFiletype.Text.Contains("*."))
                    {
                        // handle file endings
                        string[] endings = txtFiletype.Text.Split(',');
                        foreach (var ending in endings)
                        {
                            if (file.Name.EndsWith(ending.Replace("*", "")))
                            {
                                skipFile = false;
                            }
                        }
                    } else
                    {
                        skipFile = false;
                    }
                    if(skipFile)
                    {
                        // if filetype is not in filter
                        continue; 
                    }
                    string oldFilename = file.Name;
                    string newFilename = applyRules(file.Name, i);
                    string oldFilenameFullPath = txtPath.Text + "\\" + oldFilename;
                    string newFilenameFullPath = txtPath.Text + "\\" + newFilename;
                    if (oldFilename != newFilename)
                    {
                        // RENAME
                        if(simulateRename==false)
                        {
                            System.IO.File.Move(oldFilenameFullPath, newFilenameFullPath);
                        }
                        // add list entry
                        ListViewItem itemListRow = new ListViewItem(oldFilename);
                        itemListRow.UseItemStyleForSubItems = false;
                        itemListRow.SubItems.Add(newFilename);
                        itemListRow.SubItems[1].ForeColor = Color.Green;
                        listViewContent.Items.Add(itemListRow);

                        // store entry for possible reverting
                        Dictionary<string, string> renamedFile = new Dictionary<string, string>();
                        renamedFile.Add(oldFilenameFullPath, newFilenameFullPath);
                        renamedFiles.Add(i, renamedFile);

                        i++;
                    } else
                    {
                        // add list entry
                        ListViewItem itemListRow = new ListViewItem(file.Name);
                        itemListRow.UseItemStyleForSubItems = false;
                        itemListRow.SubItems.Add(file.Name);
                        itemListRow.SubItems[1].ForeColor = Color.Black;
                        listViewContent.Items.Add(itemListRow);
                    }
                }
                renamedItemType = "files";
            }
            else if (rbDirs.Checked == true)
            {
                string[] directories = Directory.GetDirectories(txtPath.Text);

                DirectoryInfo[] Dirs = dinfo.GetDirectories();
                int i = 1;
                foreach (DirectoryInfo dir in Dirs)
                {
                    string oldDirname = dir.Name;
                    string newDirname = applyRules(dir.Name, i);
                    string oldDirnameFullPath = txtPath.Text + "\\" + oldDirname;
                    string newDirnameFullPath = txtPath.Text + "\\" + newDirname;
                    if(oldDirname != newDirname)
                    {
                        // RENAME
                        if (simulateRename==false)
                        {
                            System.IO.Directory.Move(oldDirnameFullPath, newDirnameFullPath);
                        }
                        // add protocoll entry
                        ListViewItem itemListRow = new ListViewItem(oldDirname);
                        itemListRow.UseItemStyleForSubItems = false;
                        itemListRow.SubItems.Add(newDirname);
                        itemListRow.SubItems[1].ForeColor = Color.Green;
                        listViewContent.Items.Add(itemListRow);

                        // store entry for possible reverting
                        Dictionary<string, string> renamedDir = new Dictionary<string, string>();
                        renamedDir.Add(oldDirnameFullPath, newDirnameFullPath);
                        renamedFiles.Add(i, renamedDir);

                        i++;
                    } else
                    {
                        // add list entry
                        ListViewItem itemListRow = new ListViewItem(dir.Name);
                        itemListRow.UseItemStyleForSubItems = false;
                        itemListRow.SubItems.Add(dir.Name);
                        itemListRow.SubItems[1].ForeColor = Color.Black;
                        listViewContent.Items.Add(itemListRow);
                    }
                }
                renamedItemType = "dirs";
            }
            saveRules();
            finish();
        }

        private void finish()
        {
            renamingCompleted = true;   // limit view resetting
            // trigger view reset
            if (rbFiles.Checked)
            {
                rbDirs.Checked = true;
                rbFiles.Checked = true;
                rbDirs.Checked = false;
            } else
            {
                rbFiles.Checked = true;
                rbDirs.Checked = true;
                rbFiles.Checked = false;
            }
            txtRule_1_Search.Text = "";
            txtRule_1_Replace.Text = "";
            txtRule_2_Search.Text = "";
            txtRule_2_Replace.Text = "";
            txtRule_0_pattern.Text = "%nn-";
            btnRevert.Enabled = true;
            renamingCompleted = false;
        }

        private void saveRules()
        {
            lastRules.Clear();
            lastRules["numbering"] = cbRule_0_Numbers.Checked.ToString();
            if(rbRule_0_before.Checked)
            {
                lastRules["numbering_pos"] = "before";
            } else
            {
                lastRules["numbering_pos"] = "after";
            }
            lastRules["numbering_pattern"] = txtRule_0_pattern.Text;
            lastRules["rule_1_search"] = txtRule_1_Search.Text;
            lastRules["rule_1_replace"] = txtRule_1_Replace.Text;
            lastRules["rule_2_search"] = txtRule_2_Search.Text;
            lastRules["rule_2_replace"] = txtRule_2_Replace.Text;
            lastRules["rule_3_prepend"] = txtRule_3_Prepend.Text;
            lastRules["rule_3_append"] = txtRule_3_Append.Text;
        }

        private void resetRules()
        {
            renamingCompleted = true;

            txtRule_1_Search.Text = "";
            txtRule_1_Replace.Text = "";
            txtRule_2_Search.Text = "";
            txtRule_2_Replace.Text = "";
            txtRule_0_pattern.Text = "%nn-";
            cbRule_0_Numbers.Checked = false;
            rbRule_0_before.Checked = true;
            lblRule_0_example.Text = "";
            setExampleRuleText();

            btnResetRules.Image = Properties.Resources.shell32_16803_disabled;
            btnResetRules.Cursor = Cursors.Default;
            ToolTip brrtt = new ToolTip();
            brrtt.SetToolTip(btnResetRules, null);
            brrtt.SetToolTip(btnResetRules, "");

            renamingCompleted = false;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.xcy7e.de");
            Process.Start(sInfo);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings(this);
            frmSettings.Show();
        }

        public void updateLanguage()
        {
            GlobalUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.language);
            setButtonTooltip();
            setLabelText();
            refreshFileList();
        }

        public static CultureInfo GlobalUICulture
        {
            get { return Thread.CurrentThread.CurrentUICulture; }
            set
            {
                if (GlobalUICulture.Equals(value) == false)
                {
                    foreach (var form in Application.OpenForms.OfType<LocalizedForm>())
                    {
                        form.Culture = value;
                    }

                    Thread.CurrentThread.CurrentUICulture = value;
                }
            }
        }

        private void txtFiletype_Leave(object sender, EventArgs e)
        {
            string[] filetypes = txtFiletype.Text.Split(',');
            if (filetypes.Count() > 0)
            {
                // > 1 filetypes given
                for (int k = 0; k < filetypes.Count(); k++)
                {
                    string s = "*." + filetypes[k].Replace(".", String.Empty).Replace("*", String.Empty).Trim();
                    filetypes[k] = s;
                }
                txtFiletype.Text = String.Join(",", filetypes);
            }
            else
            {
                // 0-1 filetypes given
                if (txtFiletype.Text.Length > 0)
                {
                    string filetypeStr = txtFiletype.Text.Replace(".", String.Empty).Replace("*", String.Empty).Trim();
                    if (filetypeStr.Length > 0)
                    {
                        txtFiletype.Text = "*." + filetypeStr;  // ensure correct format "*.txt"
                    }
                    else
                    {
                        txtFiletype.Text = "";  // no filetype given
                    }
                }
            }
            refreshFileList();
        }

        private void cbFileending_CheckedChanged(object sender, EventArgs e)
        {
            refreshFileList();
        }

        private void refreshFileList()
        {
            if (txtPath.Text.Length > 0 && pathIsValid())
            {
                PopulateListView(listViewContent, txtPath.Text, "*.*");
            }
            setExampleRuleText();
            if (rbFiles.Checked == true)
            {
                lblRule_3_Explanation.Text = getLocStr("label_rule3_explanation_file");
                pFileending.Visible = true;
            }
            else
            {
                lblRule_3_Explanation.Text = getLocStr("label_rule3_explanation_dir");
                pFileending.Visible = false;
            }
        }

        private void txtFiletype_TextChanged(object sender, EventArgs e)
        {
            if(txtFiletype.Text.Length > 0 && cbFileending.Checked == false)
            {
                cbFileending.Checked = true;
            }
        }

        private void btnOpenDir_MouseEnter(object sender, EventArgs e)
        {
            if(txtPath.Text.Length == 0)
            {
                btnOpenDir.Cursor = Cursors.Default;
            } else
            {
                btnOpenDir.Cursor = Cursors.Hand;
                btnOpenDir.BackColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void btnOpenDir_MouseLeave(object sender, EventArgs e)
        {
            btnOpenDir.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            if(txtPath.Text.Length > 0)
            {
                if(Directory.Exists(txtPath.Text))
                {
                    Process.Start(txtPath.Text);
                } else
                {
                    MessageBox.Show(getLocStr("error_pathnotexist"), getLocStr("error"), MessageBoxButtons.OK);
                }
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Directory.Exists(txtPath.Text))
            {
                PopulateListView(listViewContent, txtPath.Text, "*.*");
            } else
            {
                // clear list
                listViewContent.Items.Clear();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeContentList();
        }

        private void resizeContentList()
        {
            if (listViewContent.Width % 2 != 0)
            {
                this.Width = this.Width + 1;
            }
            if (listViewContent.Width % 2 == 0)
            {
                listViewContent.Columns[0].Width = listViewContent.Width / 2 - 4;
                listViewContent.Columns[1].Width = listViewContent.Width / 2 - 4;
            }
        }

        private void btnResetRules_Click(object sender, EventArgs e)
        {
            if(rulesChanged)
            {
                resetRules();
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            revertRenaming();
        }

        private void revertRenaming()
        {
            DialogResult r = MessageBox.Show(getLocStr("revert_rename_dialog_msg").Replace("%n", renamedFiles.Count.ToString()), getLocStr("rename_sure_title"), MessageBoxButtons.YesNoCancel);
            if(r == DialogResult.Yes)
            {
                int i = 1;
                // revert renamed files
                try
                {
                    int changedFiles = 0;
                    foreach (Dictionary<string, string> item in renamedFiles.Values)
                    {
                        // RENAME
                        if (simulateRename == false)
                        {
                            string originalName = item.Keys.First();
                            string renamedName = item.Values.First();
                            if(renamedItemType == "files")
                            {
                                System.IO.File.Move(renamedName, originalName);
                            } else
                            {
                                System.IO.Directory.Move(renamedName, originalName);
                            }
                            replaceListItem(renamedName, originalName);
                            changedFiles++;
                            i++;
                        }
                    }
                    MessageBox.Show(getLocStr("revert_rename_dialog_success_msg").Replace("%n", changedFiles.ToString()).Replace("%e", getLocStr(renamedItemType)), "OK", MessageBoxButtons.OK);
                    // has EVERYTHING been reverted?
                    if(changedFiles < renamedFiles.Count)
                    {
                        // no!
                        MessageBox.Show(getLocStr("revert_rename_dialog_error_msg").Replace("%n", (renamedFiles.Count-changedFiles).ToString()).Replace("%e", getLocStr(renamedItemType)), getLocStr("error"), MessageBoxButtons.OK);
                    }
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message, getLocStr("error"), MessageBoxButtons.OK);
                }
                btnRevert.Enabled = false;
            }
        }

        private void replaceListItem(string rightName, string leftName)
        {
            foreach(ListViewItem row in listViewContent.Items)
            {
                string newFileName = leftName.Replace(txtPath.Text, "").Replace(@"\", "");
                string oldFileName = rightName.Replace(txtPath.Text, "").Replace(@"\", "");
                if (row.SubItems[0].Text == newFileName)
                {
                    row.SubItems[0].Text = oldFileName;
                    row.SubItems[0].ForeColor = Color.Green;
                    row.SubItems[1].Text = newFileName;
                    row.SubItems[1].ForeColor = Color.Black;
                }
            }
        }
    }
}
