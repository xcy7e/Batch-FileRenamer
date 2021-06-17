using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BatchFileRenamer
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Log_Resize(object sender, EventArgs e)
        {
            if (listDone.Width % 2 != 0)
            {
                this.Width = this.Width + 1;
            }
            if (listDone.Width %2 == 0)
            {
                listDone.Columns[0].Width = listDone.Width / 2 - 4;
                listDone.Columns[1].Width = listDone.Width / 2 - 4;
            }
        }

        private void Log_Shown(object sender, EventArgs e)
        {
            if(listDone.Width % 2 != 0)
            {
                this.Width = this.Width + 1;
            }
            if (listDone.Width % 2 == 0)
            {
                listDone.Columns[0].Width = listDone.Width / 2 - 4;
                listDone.Columns[1].Width = listDone.Width / 2 - 4;
            }
        }
    }
}
