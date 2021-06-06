using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            mainFrm.updateLanguage();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveSettings();
        }
    }
}
