namespace BatchFileRenamer
{
    partial class Log
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listDone = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(375, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Schließen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listDone
            // 
            this.listDone.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listDone.GridLines = true;
            this.listDone.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listDone.HideSelection = false;
            this.listDone.LabelWrap = false;
            this.listDone.Location = new System.Drawing.Point(12, 12);
            this.listDone.Name = "listDone";
            this.listDone.Size = new System.Drawing.Size(463, 455);
            this.listDone.TabIndex = 1;
            this.listDone.UseCompatibleStateImageBehavior = false;
            this.listDone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quelle";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ziel";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 511);
            this.Controls.Add(this.listDone);
            this.Controls.Add(this.button1);
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protokoll";
            this.Shown += new System.EventHandler(this.Log_Shown);
            this.Resize += new System.EventHandler(this.Log_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listDone;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}