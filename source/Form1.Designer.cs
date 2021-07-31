using System.Globalization;
using System.Threading;

namespace BatchFileRenamer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSearchPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.listViewContent = new System.Windows.Forms.ListView();
            this.colBefore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAfter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnOpenDir = new System.Windows.Forms.PictureBox();
            this.pFileending = new System.Windows.Forms.Panel();
            this.cbFileending = new System.Windows.Forms.CheckBox();
            this.txtFiletype = new System.Windows.Forms.TextBox();
            this.rbDirs = new System.Windows.Forms.RadioButton();
            this.rbFiles = new System.Windows.Forms.RadioButton();
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResetRules = new System.Windows.Forms.PictureBox();
            this.pRule_3 = new System.Windows.Forms.Panel();
            this.lblRule_3_Explanation = new System.Windows.Forms.Label();
            this.labellblRule_3_Append = new System.Windows.Forms.Label();
            this.txtRule_3_Append = new System.Windows.Forms.TextBox();
            this.lblRule_3_Prepend = new System.Windows.Forms.Label();
            this.txtRule_3_Prepend = new System.Windows.Forms.TextBox();
            this.lblRule_0_example = new System.Windows.Forms.Label();
            this.txtRule_0_pattern = new System.Windows.Forms.TextBox();
            this.lblRule_0_pattern = new System.Windows.Forms.Label();
            this.pRule_2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRule_2_ReplaceLbl = new System.Windows.Forms.Label();
            this.txtRule_2_Replace = new System.Windows.Forms.TextBox();
            this.lblRule_2_SearchLbl = new System.Windows.Forms.Label();
            this.txtRule_2_Search = new System.Windows.Forms.TextBox();
            this.rbRule_0_after = new System.Windows.Forms.RadioButton();
            this.rbRule_0_before = new System.Windows.Forms.RadioButton();
            this.cbRule_0_Numbers = new System.Windows.Forms.CheckBox();
            this.pbSeparator_1 = new System.Windows.Forms.PictureBox();
            this.pRule_1 = new System.Windows.Forms.Panel();
            this.lblRule_1_ReplaceLbl = new System.Windows.Forms.Label();
            this.txtRule_1_Replace = new System.Windows.Forms.TextBox();
            this.lblRule_1_SearchLbl = new System.Windows.Forms.Label();
            this.txtRule_1_Search = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbFiles.SuspendLayout();
            this.gbSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenDir)).BeginInit();
            this.pFileending.SuspendLayout();
            this.gbRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetRules)).BeginInit();
            this.pRule_3.SuspendLayout();
            this.pRule_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator_1)).BeginInit();
            this.pRule_1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPath
            // 
            resources.ApplyResources(this.btnSearchPath, "btnSearchPath");
            this.btnSearchPath.Name = "btnSearchPath";
            this.btnSearchPath.UseVisualStyleBackColor = true;
            this.btnSearchPath.Click += new System.EventHandler(this.btnSearchPath_Click);
            // 
            // txtPath
            // 
            resources.ApplyResources(this.txtPath, "txtPath");
            this.txtPath.Name = "txtPath";
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // gbFiles
            // 
            resources.ApplyResources(this.gbFiles, "gbFiles");
            this.gbFiles.Controls.Add(this.listViewContent);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.TabStop = false;
            // 
            // listViewContent
            // 
            resources.ApplyResources(this.listViewContent, "listViewContent");
            this.listViewContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBefore,
            this.colAfter});
            this.listViewContent.GridLines = true;
            this.listViewContent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewContent.HideSelection = false;
            this.listViewContent.Name = "listViewContent";
            this.listViewContent.UseCompatibleStateImageBehavior = false;
            this.listViewContent.View = System.Windows.Forms.View.Details;
            // 
            // colBefore
            // 
            resources.ApplyResources(this.colBefore, "colBefore");
            // 
            // colAfter
            // 
            resources.ApplyResources(this.colAfter, "colAfter");
            // 
            // gbSource
            // 
            resources.ApplyResources(this.gbSource, "gbSource");
            this.gbSource.Controls.Add(this.pictureBox4);
            this.gbSource.Controls.Add(this.btnOpenDir);
            this.gbSource.Controls.Add(this.pFileending);
            this.gbSource.Controls.Add(this.rbDirs);
            this.gbSource.Controls.Add(this.rbFiles);
            this.gbSource.Controls.Add(this.txtPath);
            this.gbSource.Controls.Add(this.btnSearchPath);
            this.gbSource.Name = "gbSource";
            this.gbSource.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Image = global::BatchFileRenamer.Properties.Resources.iconbg;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // btnOpenDir
            // 
            resources.ApplyResources(this.btnOpenDir, "btnOpenDir");
            this.btnOpenDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOpenDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnOpenDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDir.Image = global::BatchFileRenamer.Properties.Resources.shell32_319;
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.TabStop = false;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            this.btnOpenDir.MouseEnter += new System.EventHandler(this.btnOpenDir_MouseEnter);
            this.btnOpenDir.MouseLeave += new System.EventHandler(this.btnOpenDir_MouseLeave);
            // 
            // pFileending
            // 
            this.pFileending.Controls.Add(this.cbFileending);
            this.pFileending.Controls.Add(this.txtFiletype);
            resources.ApplyResources(this.pFileending, "pFileending");
            this.pFileending.Name = "pFileending";
            // 
            // cbFileending
            // 
            resources.ApplyResources(this.cbFileending, "cbFileending");
            this.cbFileending.Name = "cbFileending";
            this.cbFileending.UseVisualStyleBackColor = true;
            this.cbFileending.CheckedChanged += new System.EventHandler(this.cbFileending_CheckedChanged);
            // 
            // txtFiletype
            // 
            resources.ApplyResources(this.txtFiletype, "txtFiletype");
            this.txtFiletype.Name = "txtFiletype";
            this.txtFiletype.TextChanged += new System.EventHandler(this.txtFiletype_TextChanged);
            this.txtFiletype.Leave += new System.EventHandler(this.txtFiletype_Leave);
            // 
            // rbDirs
            // 
            resources.ApplyResources(this.rbDirs, "rbDirs");
            this.rbDirs.Checked = true;
            this.rbDirs.Name = "rbDirs";
            this.rbDirs.TabStop = true;
            this.rbDirs.UseVisualStyleBackColor = true;
            // 
            // rbFiles
            // 
            resources.ApplyResources(this.rbFiles, "rbFiles");
            this.rbFiles.Name = "rbFiles";
            this.rbFiles.UseVisualStyleBackColor = true;
            this.rbFiles.CheckedChanged += new System.EventHandler(this.rbFiles_CheckedChanged);
            // 
            // gbRules
            // 
            resources.ApplyResources(this.gbRules, "gbRules");
            this.gbRules.Controls.Add(this.pictureBox5);
            this.gbRules.Controls.Add(this.pictureBox1);
            this.gbRules.Controls.Add(this.btnResetRules);
            this.gbRules.Controls.Add(this.pRule_3);
            this.gbRules.Controls.Add(this.lblRule_0_example);
            this.gbRules.Controls.Add(this.txtRule_0_pattern);
            this.gbRules.Controls.Add(this.lblRule_0_pattern);
            this.gbRules.Controls.Add(this.pRule_2);
            this.gbRules.Controls.Add(this.rbRule_0_after);
            this.gbRules.Controls.Add(this.rbRule_0_before);
            this.gbRules.Controls.Add(this.cbRule_0_Numbers);
            this.gbRules.Controls.Add(this.pbSeparator_1);
            this.gbRules.Controls.Add(this.pRule_1);
            this.gbRules.Name = "gbRules";
            this.gbRules.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnResetRules
            // 
            this.btnResetRules.Image = global::BatchFileRenamer.Properties.Resources.shell32_16803_disabled;
            resources.ApplyResources(this.btnResetRules, "btnResetRules");
            this.btnResetRules.Name = "btnResetRules";
            this.btnResetRules.TabStop = false;
            this.btnResetRules.Click += new System.EventHandler(this.btnResetRules_Click);
            // 
            // pRule_3
            // 
            this.pRule_3.BackColor = System.Drawing.Color.Transparent;
            this.pRule_3.Controls.Add(this.lblRule_3_Explanation);
            this.pRule_3.Controls.Add(this.labellblRule_3_Append);
            this.pRule_3.Controls.Add(this.txtRule_3_Append);
            this.pRule_3.Controls.Add(this.lblRule_3_Prepend);
            this.pRule_3.Controls.Add(this.txtRule_3_Prepend);
            resources.ApplyResources(this.pRule_3, "pRule_3");
            this.pRule_3.Name = "pRule_3";
            // 
            // lblRule_3_Explanation
            // 
            this.lblRule_3_Explanation.CausesValidation = false;
            resources.ApplyResources(this.lblRule_3_Explanation, "lblRule_3_Explanation");
            this.lblRule_3_Explanation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRule_3_Explanation.Name = "lblRule_3_Explanation";
            // 
            // labellblRule_3_Append
            // 
            resources.ApplyResources(this.labellblRule_3_Append, "labellblRule_3_Append");
            this.labellblRule_3_Append.CausesValidation = false;
            this.labellblRule_3_Append.Name = "labellblRule_3_Append";
            // 
            // txtRule_3_Append
            // 
            resources.ApplyResources(this.txtRule_3_Append, "txtRule_3_Append");
            this.txtRule_3_Append.Name = "txtRule_3_Append";
            this.txtRule_3_Append.TextChanged += new System.EventHandler(this.txtRule_3_Append_TextChanged);
            // 
            // lblRule_3_Prepend
            // 
            resources.ApplyResources(this.lblRule_3_Prepend, "lblRule_3_Prepend");
            this.lblRule_3_Prepend.Name = "lblRule_3_Prepend";
            // 
            // txtRule_3_Prepend
            // 
            resources.ApplyResources(this.txtRule_3_Prepend, "txtRule_3_Prepend");
            this.txtRule_3_Prepend.Name = "txtRule_3_Prepend";
            this.txtRule_3_Prepend.TextChanged += new System.EventHandler(this.txtRule_3_Prepend_TextChanged);
            // 
            // lblRule_0_example
            // 
            resources.ApplyResources(this.lblRule_0_example, "lblRule_0_example");
            this.lblRule_0_example.Name = "lblRule_0_example";
            // 
            // txtRule_0_pattern
            // 
            resources.ApplyResources(this.txtRule_0_pattern, "txtRule_0_pattern");
            this.txtRule_0_pattern.Name = "txtRule_0_pattern";
            this.txtRule_0_pattern.TextChanged += new System.EventHandler(this.txtRule_0_pattern_TextChanged);
            // 
            // lblRule_0_pattern
            // 
            resources.ApplyResources(this.lblRule_0_pattern, "lblRule_0_pattern");
            this.lblRule_0_pattern.Name = "lblRule_0_pattern";
            // 
            // pRule_2
            // 
            this.pRule_2.BackColor = System.Drawing.Color.Transparent;
            this.pRule_2.Controls.Add(this.pictureBox2);
            this.pRule_2.Controls.Add(this.lblRule_2_ReplaceLbl);
            this.pRule_2.Controls.Add(this.txtRule_2_Replace);
            this.pRule_2.Controls.Add(this.lblRule_2_SearchLbl);
            this.pRule_2.Controls.Add(this.txtRule_2_Search);
            resources.ApplyResources(this.pRule_2, "pRule_2");
            this.pRule_2.Name = "pRule_2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // lblRule_2_ReplaceLbl
            // 
            resources.ApplyResources(this.lblRule_2_ReplaceLbl, "lblRule_2_ReplaceLbl");
            this.lblRule_2_ReplaceLbl.CausesValidation = false;
            this.lblRule_2_ReplaceLbl.Name = "lblRule_2_ReplaceLbl";
            // 
            // txtRule_2_Replace
            // 
            resources.ApplyResources(this.txtRule_2_Replace, "txtRule_2_Replace");
            this.txtRule_2_Replace.Name = "txtRule_2_Replace";
            this.txtRule_2_Replace.TextChanged += new System.EventHandler(this.txtRule_2_Replace_TextChanged);
            // 
            // lblRule_2_SearchLbl
            // 
            resources.ApplyResources(this.lblRule_2_SearchLbl, "lblRule_2_SearchLbl");
            this.lblRule_2_SearchLbl.Name = "lblRule_2_SearchLbl";
            // 
            // txtRule_2_Search
            // 
            resources.ApplyResources(this.txtRule_2_Search, "txtRule_2_Search");
            this.txtRule_2_Search.Name = "txtRule_2_Search";
            this.txtRule_2_Search.TextChanged += new System.EventHandler(this.txtRule_2_Search_TextChanged);
            // 
            // rbRule_0_after
            // 
            resources.ApplyResources(this.rbRule_0_after, "rbRule_0_after");
            this.rbRule_0_after.Name = "rbRule_0_after";
            this.rbRule_0_after.UseVisualStyleBackColor = true;
            this.rbRule_0_after.CheckedChanged += new System.EventHandler(this.rbRule_0_after_CheckedChanged);
            // 
            // rbRule_0_before
            // 
            resources.ApplyResources(this.rbRule_0_before, "rbRule_0_before");
            this.rbRule_0_before.Checked = true;
            this.rbRule_0_before.Name = "rbRule_0_before";
            this.rbRule_0_before.TabStop = true;
            this.rbRule_0_before.UseVisualStyleBackColor = true;
            // 
            // cbRule_0_Numbers
            // 
            resources.ApplyResources(this.cbRule_0_Numbers, "cbRule_0_Numbers");
            this.cbRule_0_Numbers.Name = "cbRule_0_Numbers";
            this.cbRule_0_Numbers.UseVisualStyleBackColor = true;
            this.cbRule_0_Numbers.CheckedChanged += new System.EventHandler(this.cbRule_0_Numbers_CheckedChanged);
            // 
            // pbSeparator_1
            // 
            this.pbSeparator_1.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.pbSeparator_1, "pbSeparator_1");
            this.pbSeparator_1.Name = "pbSeparator_1";
            this.pbSeparator_1.TabStop = false;
            // 
            // pRule_1
            // 
            this.pRule_1.BackColor = System.Drawing.Color.Transparent;
            this.pRule_1.Controls.Add(this.lblRule_1_ReplaceLbl);
            this.pRule_1.Controls.Add(this.txtRule_1_Replace);
            this.pRule_1.Controls.Add(this.lblRule_1_SearchLbl);
            this.pRule_1.Controls.Add(this.txtRule_1_Search);
            resources.ApplyResources(this.pRule_1, "pRule_1");
            this.pRule_1.Name = "pRule_1";
            // 
            // lblRule_1_ReplaceLbl
            // 
            resources.ApplyResources(this.lblRule_1_ReplaceLbl, "lblRule_1_ReplaceLbl");
            this.lblRule_1_ReplaceLbl.Name = "lblRule_1_ReplaceLbl";
            // 
            // txtRule_1_Replace
            // 
            resources.ApplyResources(this.txtRule_1_Replace, "txtRule_1_Replace");
            this.txtRule_1_Replace.Name = "txtRule_1_Replace";
            this.txtRule_1_Replace.TextChanged += new System.EventHandler(this.txtRule_1_Replace_TextChanged);
            // 
            // lblRule_1_SearchLbl
            // 
            resources.ApplyResources(this.lblRule_1_SearchLbl, "lblRule_1_SearchLbl");
            this.lblRule_1_SearchLbl.Name = "lblRule_1_SearchLbl";
            // 
            // txtRule_1_Search
            // 
            resources.ApplyResources(this.txtRule_1_Search, "txtRule_1_Search");
            this.txtRule_1_Search.Name = "txtRule_1_Search";
            this.txtRule_1_Search.TextChanged += new System.EventHandler(this.txtRule_1_Search_TextChanged);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRevert);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Name = "panel1";
            // 
            // btnRevert
            // 
            resources.ApplyResources(this.btnRevert, "btnRevert");
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.BackgroundImage = global::BatchFileRenamer.Properties.Resources.shell32_16826;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.TabStop = false;
            this.btnSettings.Tag = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbRules);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.gbFiles);
            this.Name = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.gbFiles.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenDir)).EndInit();
            this.pFileending.ResumeLayout(false);
            this.pFileending.PerformLayout();
            this.gbRules.ResumeLayout(false);
            this.gbRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetRules)).EndInit();
            this.pRule_3.ResumeLayout(false);
            this.pRule_3.PerformLayout();
            this.pRule_2.ResumeLayout(false);
            this.pRule_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator_1)).EndInit();
            this.pRule_1.ResumeLayout(false);
            this.pRule_1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.RadioButton rbDirs;
        private System.Windows.Forms.RadioButton rbFiles;
        private System.Windows.Forms.GroupBox gbRules;
        private System.Windows.Forms.Label lblRule_0_example;
        private System.Windows.Forms.TextBox txtRule_0_pattern;
        private System.Windows.Forms.Label lblRule_0_pattern;
        private System.Windows.Forms.RadioButton rbRule_0_after;
        private System.Windows.Forms.RadioButton rbRule_0_before;
        private System.Windows.Forms.CheckBox cbRule_0_Numbers;
        private System.Windows.Forms.PictureBox pbSeparator_1;
        private System.Windows.Forms.Panel pRule_1;
        private System.Windows.Forms.Label lblRule_1_ReplaceLbl;
        private System.Windows.Forms.TextBox txtRule_1_Replace;
        private System.Windows.Forms.Label lblRule_1_SearchLbl;
        private System.Windows.Forms.TextBox txtRule_1_Search;
        private System.Windows.Forms.Panel pRule_2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRule_2_ReplaceLbl;
        private System.Windows.Forms.TextBox txtRule_2_Replace;
        private System.Windows.Forms.Label lblRule_2_SearchLbl;
        private System.Windows.Forms.TextBox txtRule_2_Search;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.Panel pFileending;
        private System.Windows.Forms.CheckBox cbFileending;
        private System.Windows.Forms.TextBox txtFiletype;
        private System.Windows.Forms.PictureBox btnOpenDir;
        private System.Windows.Forms.Panel pRule_3;
        private System.Windows.Forms.Label labellblRule_3_Append;
        private System.Windows.Forms.TextBox txtRule_3_Append;
        private System.Windows.Forms.Label lblRule_3_Prepend;
        private System.Windows.Forms.TextBox txtRule_3_Prepend;
        private System.Windows.Forms.Label lblRule_3_Explanation;
        private System.Windows.Forms.ColumnHeader colBefore;
        private System.Windows.Forms.ColumnHeader colAfter;
        public System.Windows.Forms.ListView listViewContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnResetRules;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

