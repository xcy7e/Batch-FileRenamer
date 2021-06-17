using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
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
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            int preselLang = 0;
            switch (Properties.Settings.Default.language)
            {
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
            vtt.SetToolTip(lblVersion, mainFrm.getLocStr(Properties.Settings.Default.language, "lblVersion_tooltip"));
            ToolTip ctt = new ToolTip();
            ctt.SetToolTip(lblCreator, mainFrm.getLocStr(Properties.Settings.Default.language, "lblCreator_tooltip"));
        }

        private void initHelpTooltip()
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(helpContextSetting, mainFrm.getLocStr(Properties.Settings.Default.language, "settings_helpContextIntegration"));
        }

        private void saveSettings()
        {

            switch (cbLanguage.SelectedIndex)
            {
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
            RegistryKey regcmd = null;

            string menuEntry = "Folder\\shell\\startBatchFileRenamer";
            string menuCommand = menuEntry + "\\command";
            string menuCmdExecutable = System.Reflection.Assembly.GetEntryAssembly().Location+ " \"%1\"";
            string labelText = mainFrm.getLocStr(Properties.Settings.Default.language, "context_menu_label");

            if (status) 
            {
                // enable
                try
                {
                    regmenu = Registry.ClassesRoot.CreateSubKey(menuEntry);
                    if (regmenu != null)
                        regmenu.SetValue("", labelText);
                    regcmd = Registry.ClassesRoot.CreateSubKey(menuCommand);
                    if (regcmd != null)
                        regcmd.SetValue("", menuCmdExecutable);
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
