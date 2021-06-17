using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BatchFileRenamer
{
    public partial class Form1 : LocalizedForm
    {

        public Dictionary<string, Dictionary<string, string>> translations = new Dictionary<string, Dictionary<string, string>>();

        public Form1(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.language);
            InitializeComponent();
            clearExampleLabels();
            setTranslations();
            setButtonTooltip();
            // if called from context menu set path of selected folder
            if(args.Length >= 1)
            {
                txtPath.Text = args[0].ToString();
            }
        }

        private void setTranslations()
        {
            Dictionary<string, string> tDE = new Dictionary<string, string>();
            Dictionary<string, string> tEN = new Dictionary<string, string>();
            tDE.Add("lblRuleExplanationTextFile", "Klicke auf eine Datei um die angewendeten Regeln zu testen");
            tEN.Add("lblRuleExplanationTextFile", "Click on a file to test the rules applied");
            tDE.Add("lblRuleExplanationTextDir", "Klicke auf einen Ordner um die angewendeten Regeln zu testen");
            tEN.Add("lblRuleExplanationTextDir", "Click on a directory to test the rules applied");
            tDE.Add("typFilename", "Dateiname");
            tEN.Add("typFilename", "Filename");
            tDE.Add("typDirname", "Ordnername");
            tEN.Add("typDirname", "Directoryname");
            tDE.Add("files", " Dateien");
            tEN.Add("files", " files");
            tDE.Add("dirs", " Verzeichnisse");
            tEN.Add("dirs", " directories");
            tDE.Add("error", "Fehler");
            tEN.Add("error", "Error");
            tDE.Add("error_pathnotexist", "Dieses Verzeichnis existiert nicht!");
            tEN.Add("error_pathnotexist", "This directory does not exist!");
            tDE.Add("rename_sure", " werden umbenannt!\nWirklich fortfahren ? ");
            tEN.Add("rename_sure", " will be renamed!\nProceed ? ");
            tDE.Add("rename_sure_title", "Sicher ? ");
            tEN.Add("rename_sure_title", "Sure ? ");
            tDE.Add("rename_nothingtodo", "Durch die gesetzten Regeln gibt es nichts umzubenennen.");
            tEN.Add("rename_nothingtodo", "By the rules set there is nothing to rename.");
            tDE.Add("rename_nothingtodo_title", "Nichts zu tun!");
            tEN.Add("rename_nothingtodo_title", "Nothing to do!");
            tDE.Add("btnOpenDir_tooltip", "Verzeichnis im Explorer öffnen");
            tEN.Add("btnOpenDir_tooltip", "Open directory in explorer");

            tDE.Add("settings_helpContextIntegration", "Fügt eine Funktion im Windows-Explorer Rechtsklickmenü ein,\num Batch FileRenamer vom jeweiligen Pfad auszuführen.");
            tEN.Add("settings_helpContextIntegration", "Adds an entry in windows-explorer rightclick menu,\nto start Batch FileRenamer from a respective location.");
            tDE.Add("context_menu_label", "Batch FileRenamer starten");
            tEN.Add("context_menu_label", "start batch fileRenamer");

            translations.Add("de", tDE);
            translations.Add("en", tEN);
        }

        private void setButtonTooltip()
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btnOpenDir, getLocStr(Properties.Settings.Default.language, "btnOpenDir_tooltip"));
        }

        public string getLocStr(string lang, string key)
        {
            return translations[lang][key];
        }

        private void btnSearchPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPath.Text = fbd.SelectedPath;
                    PopulateListBox(listBoxFiles, fbd.SelectedPath, "*.*");
                }
            }
        }

        private void rbFiles_CheckedChanged(object sender, EventArgs e)
        {
            if(txtPath.Text.Length > 0 && pathIsValid())
            {
                PopulateListBox(listBoxFiles, txtPath.Text, "*.*");
            }
            setExampleRuleText();
            if(rbFiles.Checked == true)
            {
                lblRuleExplanation.Text = getLocStr(Properties.Settings.Default.language, "lblRuleExplanationTextFile");
                pFileending.Visible = true;
            } else
            {
                lblRuleExplanation.Text = getLocStr(Properties.Settings.Default.language, "lblRuleExplanationTextDir");
                pFileending.Visible = false;
            }
        }

        private bool pathIsValid()
        {
            return Directory.Exists(txtPath.Text);
        }

        private void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            listBoxFiles.Items.Clear();
            clearExampleLabels();
            int itemsCount = 0;

            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            
            if(rbFiles.Checked == true)
            {
                string[] files = Directory.GetFiles(Folder);

                FileInfo[] Files = dinfo.GetFiles(FileType);
                foreach (FileInfo file in Files)
                {
                    if (cbFileending.Checked == true && txtFiletype.Text.Contains("*."))
                    {
                        // handle file endings
                        string[] endings = txtFiletype.Text.Split(',');
                        foreach (var ending in endings)
                        {
                            if (file.Name.EndsWith(ending.Replace("*","")))
                            {
                                lsb.Items.Add(file.Name);
                                itemsCount++;
                            }
                        }
                    } else
                    {
                        lsb.Items.Add(file.Name);
                        itemsCount++;
                    }
                }

            } else if(rbDirs.Checked == true)
            {
                string[] directories = Directory.GetDirectories(Folder);

                DirectoryInfo[] Dirs = dinfo.GetDirectories();
                foreach(DirectoryInfo dir in Dirs)
                {
                    lsb.Items.Add(dir.Name);
                    itemsCount++;
                }
            }
            if(itemsCount > 0)
            {
                btnStart.Enabled = true;
            } else
            {
                btnStart.Enabled = false;
            }
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
            string itemName = getLocStr(Properties.Settings.Default.language, "typFilename");
            if(rbDirs.Checked == true)
            {
                itemName = getLocStr(Properties.Settings.Default.language, "typDirname");
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
            ListBox listbox = listBoxFiles;
            if (listbox.SelectedIndex > -1)
            {
                lblOriginalName.Text = listbox.SelectedItem.ToString();
                lblArrow.Text = "=>";
                lblResultingName.Text = getRuledItemName(listbox.SelectedItem.ToString(), listbox.SelectedIndex);
            }
        }

        private string getRuledItemName(string originItemName, int originItemIndex)
        {
            string resultName = originItemName;
            // replace text
            if (txtRule_1_Search.Text.Length > 0)
            {
                resultName = resultName.Replace(txtRule_1_Search.Text, txtRule_1_Replace.Text);
            }
            if(txtRule_2_Search.Text.Length > 0)
            {
                resultName = resultName.Replace(txtRule_2_Search.Text, txtRule_2_Replace.Text);
            }
            
            // numbers
            if(cbRule_0_Numbers.Checked)
            {
                string number = (originItemIndex+1).ToString();
                string numberCharCountStr = txtRule_0_pattern.Text.Replace("%nnnnn", "5").Replace("%nnnn", "4").Replace("%nnn", "3").Replace("%nn", "2").Replace("%n", "1");

                int i = getNumberPatternStartIndex();
                if(i > 0)
                {
                    string afterNumberStr = txtRule_0_pattern.Text.Substring(txtRule_0_pattern.Text.IndexOf("%n") + i + 1);
                    string beforeNumberStr = txtRule_0_pattern.Text.Substring(0, txtRule_0_pattern.Text.Length - (afterNumberStr.Length + i + 1));
                    int numberCharCount = i;
                    number = number.ToString().PadLeft(numberCharCount, '0');
                    if (rbRule_0_before.Checked)
                    {
                        // vor
                        resultName = txtRule_0_pattern.Text.Replace("%nnnnn", number).Replace("%nnnn", number).Replace("%nnn", number).Replace("%nn", number).Replace("%n", number) + resultName;
                    }
                    else
                    {
                        // nach
                        resultName = resultName + txtRule_0_pattern.Text.Replace("%nnnnn", number).Replace("%nnnn", number).Replace("%nnn", number).Replace("%nn", number).Replace("%n", number);
                    }
                }
            }
            return resultName;
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

        private void clearExampleLabels()
        {
            lblOriginalName.Text = "";
            lblArrow.Text = "";
            lblResultingName.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtPath.Text))
            {
                MessageBox.Show(getLocStr(Properties.Settings.Default.language, "error_pathnotexist"), getLocStr(Properties.Settings.Default.language, "error"), MessageBoxButtons.OK);
                return;
            }
            string itemType = getLocStr(Properties.Settings.Default.language, "files");
            if (rbDirs.Checked) {
                itemType = getLocStr(Properties.Settings.Default.language, "dirs");
            }
            int itemCount = countRenameItems();
            if(itemCount == 0)
            {
                // no items to rename
                MessageBox.Show(getLocStr(Properties.Settings.Default.language, "rename_nothingtodo"), getLocStr(Properties.Settings.Default.language, "rename_nothingtodo_title"), MessageBoxButtons.OK);
            } else
            {
                DialogResult res = MessageBox.Show(itemCount.ToString() + itemType + getLocStr(Properties.Settings.Default.language, "rename_sure"), getLocStr(Properties.Settings.Default.language, "rename_sure_title"), MessageBoxButtons.YesNo);
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
                    string newFilename = getRuledItemName(file.Name, i);
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
                    string newDirname = getRuledItemName(dir.Name, i);
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
            Log log = new Log();
            log.Show();

            ListView logList = getLogList(log);

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
                        continue;  // if filetype is not in filter
                    }
                    string oldFilename = file.Name;
                    string newFilename = getRuledItemName(file.Name, i);
                    if(oldFilename != newFilename)
                    {
                        // RENAME
                        System.IO.File.Move(txtPath.Text + "\\" + oldFilename, txtPath.Text + "\\" + newFilename);
                        // add protocoll entry
                        ListViewItem logEntry = new ListViewItem(oldFilename);
                        logEntry.SubItems.Add(newFilename);
                        logList.Items.Add(logEntry);
                        i++;
                    }
                }

            }
            else if (rbDirs.Checked == true)
            {
                string[] directories = Directory.GetDirectories(txtPath.Text);

                DirectoryInfo[] Dirs = dinfo.GetDirectories();
                int i = 1;
                foreach (DirectoryInfo dir in Dirs)
                {
                    string oldDirname = dir.Name;
                    string newDirname = getRuledItemName(dir.Name, i);
                    if(oldDirname != newDirname)
                    {
                        // RENAME
                        System.IO.Directory.Move(txtPath.Text + "\\" + oldDirname, txtPath.Text + "\\" + newDirname);
                        // add protocoll entry
                        logList.Items.Add(new ListViewItem(new[] { oldDirname, newDirname }));
                        i++;
                    }
                }
            }


            finish();
        }

        private void finish()
        {
            if(rbFiles.Checked)
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
        }

        private ListView getLogList(Form log)
        {
            foreach (Control c in log.Controls)
            {
                if (c.Name == "listDone")
                {
                    return (ListView) c;
                }
            }
            return new ListView();
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
                PopulateListBox(listBoxFiles, txtPath.Text, "*.*");
            }
            setExampleRuleText();
            if (rbFiles.Checked == true)
            {
                lblRuleExplanation.Text = getLocStr(Properties.Settings.Default.language, "lblRuleExplanationTextFile");
                pFileending.Visible = true;
            }
            else
            {
                lblRuleExplanation.Text = getLocStr(Properties.Settings.Default.language, "lblRuleExplanationTextDir");
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
                    MessageBox.Show(getLocStr(Properties.Settings.Default.language, "error_pathnotexist"), getLocStr(Properties.Settings.Default.language, "error"), MessageBoxButtons.OK);
                }
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(txtPath.Text))
            {
                PopulateListBox(listBoxFiles, txtPath.Text, "*.*");
            } else
            {
                // clear list
                listBoxFiles.Items.Clear();
            }
        }
    }
}
