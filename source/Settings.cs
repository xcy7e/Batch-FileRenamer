using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BatchFileRenamer
{
    public partial class Settings : Form
    {

        public Form1 mainFrm;

        public Settings(Form1 form)
        {
            mainFrm = form;
            InitializeComponent();
            cbLanguage.Focus();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            int preselLang = 0;
            switch (Properties.Settings.Default.language)
            {
                case "fr":
                    preselLang = 2;
                    break;
                case "de":
                    preselLang = 1;
                    break;
                case "en":
                default:
                    preselLang = 0;
                    break;
            }
            cbLanguage.SelectedIndex = preselLang;
            cbContextIntegration.Checked = Properties.Settings.Default.explorer_context;
            initHelpTooltip();
            initVersionLabels();
        }

        private void initVersionLabels()
        {
            lblVersion.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ToolTip vtt = new ToolTip();
            vtt.SetToolTip(lblVersion, null);
            vtt.SetToolTip(lblVersion, mainFrm.getLocStr("lblVersion_tooltip"));
            ToolTip ctt = new ToolTip();
            ctt.SetToolTip(lblCreator, null);
            ctt.SetToolTip(lblCreator, mainFrm.getLocStr("lblCreator_tooltip"));
        }

        private void initHelpTooltip()
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(helpContextSetting, null);
            tt.SetToolTip(helpContextSetting, mainFrm.getLocStr("settings_helpContextIntegration"));
        }

        private void saveSettings()
        {

            switch (cbLanguage.SelectedIndex)
            {
                case 2:
                    Properties.Settings.Default.language = "fr";
                    break;
                case 1:
                    Properties.Settings.Default.language = "de";
                    break;
                case 0:
                default:
                    Properties.Settings.Default.language = "en";
                    break;
            }    
            setContextIntegration(cbContextIntegration.Checked);

            mainFrm.updateLanguage();
            this.Close();
        }

        private void setContextIntegration(bool status)
        {
            RegistryKey regmenu = null;
            RegistryKey regicon = null;
            RegistryKey regcmd = null;

            string menuEntry = "Folder\\shell\\startBatchFileRenamer";
            string menuCommand = menuEntry + "\\command";
            string menuCmdExecutable = System.Reflection.Assembly.GetEntryAssembly().Location+ " \"%1\"";
            string labelText = mainFrm.getLocStr("context_menu_label");

            if (status) 
            {
                // enable
                try
                {
                    // ensure app-icon is stored in bin-path
                    string execFullPath = System.Reflection.Assembly.GetEntryAssembly().Location;
                    string execPath = execFullPath.Replace(System.Reflection.Assembly.GetEntryAssembly().ManifestModule.Name, "");
                    File.WriteAllBytes(execPath + "\\contexticon.ico", Properties.Resources.contexicon);

                    // entry 
                    regmenu = Registry.ClassesRoot.CreateSubKey(menuEntry);
                    if (regmenu != null)
                    {
                        regmenu.SetValue("", labelText);
                        // icon
                        string iconPath = execPath + "\\contexticon.ico";
                        regmenu.SetValue("Icon", iconPath + ",0",RegistryValueKind.String);

                        // command
                        regcmd = Registry.ClassesRoot.CreateSubKey(menuCommand);
                        if (regcmd != null)
                            regcmd.SetValue("", menuCmdExecutable);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString());
                }
                finally
                {
                    if (regmenu != null)
                        regmenu.Close();
                    if (regcmd != null)
                        regcmd.Close();

                    Properties.Settings.Default.explorer_context = true;
                }
            }
            else
            {
                // disable
                try
                {
                    RegistryKey reg = Registry.ClassesRoot.OpenSubKey(menuCommand);
                    if (reg != null)
                    {
                        reg.Close();
                        Registry.ClassesRoot.DeleteSubKey(menuCommand);
                    }
                    reg = Registry.ClassesRoot.OpenSubKey(menuEntry);
                    if (reg != null)
                    {
                        reg.Close();
                        Registry.ClassesRoot.DeleteSubKey(menuEntry);
                    }

                    Properties.Settings.Default.explorer_context = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/xcy7e/Batch-FileRenamer");
            Process.Start(sInfo);
        }

        private void lblCreator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.xcy7e.de");
            Process.Start(sInfo);
        }
    }
}
