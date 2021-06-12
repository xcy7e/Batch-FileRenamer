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
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.pFileending = new System.Windows.Forms.Panel();
            this.cbFileending = new System.Windows.Forms.CheckBox();
            this.txtFiletype = new System.Windows.Forms.TextBox();
            this.rbDirs = new System.Windows.Forms.RadioButton();
            this.rbFiles = new System.Windows.Forms.RadioButton();
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.lblRuleExplanation = new System.Windows.Forms.Label();
            this.lblRule_0_example = new System.Windows.Forms.Label();
            this.txtRule_0_pattern = new System.Windows.Forms.TextBox();
            this.lblRule_0_pattern = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRule_2_Replace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRule_2_Search = new System.Windows.Forms.TextBox();
            this.rbRule_0_after = new System.Windows.Forms.RadioButton();
            this.rbRule_0_before = new System.Windows.Forms.RadioButton();
            this.cbRule_0_Numbers = new System.Windows.Forms.CheckBox();
            this.pbSeparator_1 = new System.Windows.Forms.PictureBox();
            this.pRule_1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRule_1_ReplaceLbl = new System.Windows.Forms.Label();
            this.txtRule_1_Replace = new System.Windows.Forms.TextBox();
            this.lblRule_1_SearchLbl = new System.Windows.Forms.Label();
            this.txtRule_1_Search = new System.Windows.Forms.TextBox();
            this.panelRenameResultExample = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOriginalName = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.lblResultingName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.gbFiles.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.pFileending.SuspendLayout();
            this.gbRules.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator_1)).BeginInit();
            this.pRule_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRenameResultExample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
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
            // 
            // listBoxFiles
            // 
            resources.ApplyResources(this.listBoxFiles, "listBoxFiles");
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.SelectedValueChanged += new System.EventHandler(this.listBoxFiles_SelectedValueChanged);
            // 
            // gbFiles
            // 
            resources.ApplyResources(this.gbFiles, "gbFiles");
            this.gbFiles.Controls.Add(this.listBoxFiles);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.TabStop = false;
            // 
            // gbSource
            // 
            resources.ApplyResources(this.gbSource, "gbSource");
            this.gbSource.Controls.Add(this.pFileending);
            this.gbSource.Controls.Add(this.rbDirs);
            this.gbSource.Controls.Add(this.rbFiles);
            this.gbSource.Controls.Add(this.txtPath);
            this.gbSource.Controls.Add(this.btnSearchPath);
            this.gbSource.Name = "gbSource";
            this.gbSource.TabStop = false;
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
            this.gbRules.Controls.Add(this.lblRuleExplanation);
            this.gbRules.Controls.Add(this.lblRule_0_example);
            this.gbRules.Controls.Add(this.txtRule_0_pattern);
            this.gbRules.Controls.Add(this.lblRule_0_pattern);
            this.gbRules.Controls.Add(this.panel1);
            this.gbRules.Controls.Add(this.rbRule_0_after);
            this.gbRules.Controls.Add(this.rbRule_0_before);
            this.gbRules.Controls.Add(this.cbRule_0_Numbers);
            this.gbRules.Controls.Add(this.pbSeparator_1);
            this.gbRules.Controls.Add(this.pRule_1);
            this.gbRules.Name = "gbRules";
            this.gbRules.TabStop = false;
            // 
            // lblRuleExplanation
            // 
            resources.ApplyResources(this.lblRuleExplanation, "lblRuleExplanation");
            this.lblRuleExplanation.Name = "lblRuleExplanation";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRule_2_Replace);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRule_2_Search);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.CausesValidation = false;
            this.label1.Name = "label1";
            // 
            // txtRule_2_Replace
            // 
            resources.ApplyResources(this.txtRule_2_Replace, "txtRule_2_Replace");
            this.txtRule_2_Replace.Name = "txtRule_2_Replace";
            this.txtRule_2_Replace.TextChanged += new System.EventHandler(this.txtRule_2_Replace_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            this.pRule_1.Controls.Add(this.pictureBox1);
            this.pRule_1.Controls.Add(this.lblRule_1_ReplaceLbl);
            this.pRule_1.Controls.Add(this.txtRule_1_Replace);
            this.pRule_1.Controls.Add(this.lblRule_1_SearchLbl);
            this.pRule_1.Controls.Add(this.txtRule_1_Search);
            resources.ApplyResources(this.pRule_1, "pRule_1");
            this.pRule_1.Name = "pRule_1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
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
            // panelRenameResultExample
            // 
            resources.ApplyResources(this.panelRenameResultExample, "panelRenameResultExample");
            this.panelRenameResultExample.Controls.Add(this.lblOriginalName);
            this.panelRenameResultExample.Controls.Add(this.lblArrow);
            this.panelRenameResultExample.Controls.Add(this.lblResultingName);
            this.panelRenameResultExample.Name = "panelRenameResultExample";
            // 
            // lblOriginalName
            // 
            resources.ApplyResources(this.lblOriginalName, "lblOriginalName");
            this.lblOriginalName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOriginalName.Name = "lblOriginalName";
            // 
            // lblArrow
            // 
            resources.ApplyResources(this.lblArrow, "lblArrow");
            this.lblArrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblArrow.Name = "lblArrow";
            // 
            // lblResultingName
            // 
            resources.ApplyResources(this.lblResultingName, "lblResultingName");
            this.lblResultingName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblResultingName.Name = "lblResultingName";
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelRenameResultExample);
            this.Controls.Add(this.gbRules);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.gbFiles);
            this.Name = "Form1";
            this.gbFiles.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.pFileending.ResumeLayout(false);
            this.pFileending.PerformLayout();
            this.gbRules.ResumeLayout(false);
            this.gbRules.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator_1)).EndInit();
            this.pRule_1.ResumeLayout(false);
            this.pRule_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRenameResultExample.ResumeLayout(false);
            this.panelRenameResultExample.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ListBox listBoxFiles;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRule_1_ReplaceLbl;
        private System.Windows.Forms.TextBox txtRule_1_Replace;
        private System.Windows.Forms.Label lblRule_1_SearchLbl;
        private System.Windows.Forms.TextBox txtRule_1_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRule_2_Replace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRule_2_Search;
        private System.Windows.Forms.Label lblRuleExplanation;
        private System.Windows.Forms.FlowLayoutPanel panelRenameResultExample;
        private System.Windows.Forms.Label lblOriginalName;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Label lblResultingName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.Panel pFileending;
        private System.Windows.Forms.CheckBox cbFileending;
        private System.Windows.Forms.TextBox txtFiletype;
    }
}

