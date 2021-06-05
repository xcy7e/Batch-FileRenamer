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
            this.rbDirs = new System.Windows.Forms.RadioButton();
            this.rbFiles = new System.Windows.Forms.RadioButton();
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.lblRuleExplanation = new System.Windows.Forms.Label();
            this.lblRule_0_example = new System.Windows.Forms.Label();
            this.txtRule_0_pattern = new System.Windows.Forms.TextBox();
            this.lblRule_0_pattern = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRule_2_Replace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRule_2_Search = new System.Windows.Forms.TextBox();
            this.panelRenameResultExample = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOriginalName = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.lblResultingName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbFiles.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator_1)).BeginInit();
            this.pRule_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelRenameResultExample.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchPath
            // 
            this.btnSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPath.Location = new System.Drawing.Point(539, 23);
            this.btnSearchPath.Name = "btnSearchPath";
            this.btnSearchPath.Size = new System.Drawing.Size(114, 25);
            this.btnSearchPath.TabIndex = 99;
            this.btnSearchPath.Text = "Ordner wählen";
            this.btnSearchPath.UseVisualStyleBackColor = true;
            this.btnSearchPath.Click += new System.EventHandler(this.btnSearchPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(15, 23);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(518, 24);
            this.txtPath.TabIndex = 99;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 16;
            this.listBoxFiles.Location = new System.Drawing.Point(15, 21);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(316, 260);
            this.listBoxFiles.TabIndex = 99;
            this.listBoxFiles.SelectedValueChanged += new System.EventHandler(this.listBoxFiles_SelectedValueChanged);
            // 
            // gbFiles
            // 
            this.gbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiles.Controls.Add(this.listBoxFiles);
            this.gbFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiles.Location = new System.Drawing.Point(17, 105);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(345, 296);
            this.gbFiles.TabIndex = 3;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = " Inhalt ";
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.rbDirs);
            this.gbSource.Controls.Add(this.rbFiles);
            this.gbSource.Controls.Add(this.txtPath);
            this.gbSource.Controls.Add(this.btnSearchPath);
            this.gbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSource.Location = new System.Drawing.Point(17, 12);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(667, 87);
            this.gbSource.TabIndex = 4;
            this.gbSource.TabStop = false;
            this.gbSource.Text = " Quelle ";
            // 
            // rbDirs
            // 
            this.rbDirs.AutoSize = true;
            this.rbDirs.Location = new System.Drawing.Point(99, 55);
            this.rbDirs.Name = "rbDirs";
            this.rbDirs.Size = new System.Drawing.Size(110, 20);
            this.rbDirs.TabIndex = 99;
            this.rbDirs.Text = "Verzeichnisse";
            this.rbDirs.UseVisualStyleBackColor = true;
            // 
            // rbFiles
            // 
            this.rbFiles.AutoSize = true;
            this.rbFiles.Checked = true;
            this.rbFiles.Location = new System.Drawing.Point(15, 55);
            this.rbFiles.Name = "rbFiles";
            this.rbFiles.Size = new System.Drawing.Size(73, 20);
            this.rbFiles.TabIndex = 99;
            this.rbFiles.TabStop = true;
            this.rbFiles.Text = "Dateien";
            this.rbFiles.UseVisualStyleBackColor = true;
            this.rbFiles.CheckedChanged += new System.EventHandler(this.rbFiles_CheckedChanged);
            // 
            // gbRules
            // 
            this.gbRules.Controls.Add(this.lblRuleExplanation);
            this.gbRules.Controls.Add(this.lblRule_0_example);
            this.gbRules.Controls.Add(this.txtRule_0_pattern);
            this.gbRules.Controls.Add(this.lblRule_0_pattern);
            this.gbRules.Controls.Add(this.rbRule_0_after);
            this.gbRules.Controls.Add(this.rbRule_0_before);
            this.gbRules.Controls.Add(this.cbRule_0_Numbers);
            this.gbRules.Controls.Add(this.pbSeparator_1);
            this.gbRules.Controls.Add(this.pRule_1);
            this.gbRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRules.Location = new System.Drawing.Point(369, 106);
            this.gbRules.Name = "gbRules";
            this.gbRules.Size = new System.Drawing.Size(315, 295);
            this.gbRules.TabIndex = 5;
            this.gbRules.TabStop = false;
            this.gbRules.Text = " Regeln (optional) ";
            // 
            // lblRuleExplanation
            // 
            this.lblRuleExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleExplanation.Location = new System.Drawing.Point(6, 255);
            this.lblRuleExplanation.Name = "lblRuleExplanation";
            this.lblRuleExplanation.Size = new System.Drawing.Size(300, 37);
            this.lblRuleExplanation.TabIndex = 11;
            this.lblRuleExplanation.Text = "Klicke auf eine Datei um die angewendeten Regeln zu testen";
            // 
            // lblRule_0_example
            // 
            this.lblRule_0_example.Enabled = false;
            this.lblRule_0_example.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule_0_example.Location = new System.Drawing.Point(162, 51);
            this.lblRule_0_example.Name = "lblRule_0_example";
            this.lblRule_0_example.Size = new System.Drawing.Size(147, 19);
            this.lblRule_0_example.TabIndex = 8;
            this.lblRule_0_example.Text = "01-Dateiname";
            // 
            // txtRule_0_pattern
            // 
            this.txtRule_0_pattern.Enabled = false;
            this.txtRule_0_pattern.Location = new System.Drawing.Point(57, 48);
            this.txtRule_0_pattern.MaxLength = 7;
            this.txtRule_0_pattern.Name = "txtRule_0_pattern";
            this.txtRule_0_pattern.Size = new System.Drawing.Size(100, 22);
            this.txtRule_0_pattern.TabIndex = 0;
            this.txtRule_0_pattern.Text = "%nn-";
            this.txtRule_0_pattern.TextChanged += new System.EventHandler(this.txtRule_0_pattern_TextChanged);
            // 
            // lblRule_0_pattern
            // 
            this.lblRule_0_pattern.AutoSize = true;
            this.lblRule_0_pattern.Enabled = false;
            this.lblRule_0_pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule_0_pattern.Location = new System.Drawing.Point(6, 51);
            this.lblRule_0_pattern.Name = "lblRule_0_pattern";
            this.lblRule_0_pattern.Size = new System.Drawing.Size(45, 15);
            this.lblRule_0_pattern.TabIndex = 6;
            this.lblRule_0_pattern.Text = "Muster";
            // 
            // rbRule_0_after
            // 
            this.rbRule_0_after.AutoSize = true;
            this.rbRule_0_after.Enabled = false;
            this.rbRule_0_after.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRule_0_after.Location = new System.Drawing.Point(204, 21);
            this.rbRule_0_after.Name = "rbRule_0_after";
            this.rbRule_0_after.Size = new System.Drawing.Size(54, 19);
            this.rbRule_0_after.TabIndex = 99;
            this.rbRule_0_after.Text = "Nach";
            this.rbRule_0_after.UseVisualStyleBackColor = true;
            this.rbRule_0_after.CheckedChanged += new System.EventHandler(this.rbRule_0_after_CheckedChanged);
            // 
            // rbRule_0_before
            // 
            this.rbRule_0_before.AutoSize = true;
            this.rbRule_0_before.Checked = true;
            this.rbRule_0_before.Enabled = false;
            this.rbRule_0_before.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRule_0_before.Location = new System.Drawing.Point(155, 21);
            this.rbRule_0_before.Name = "rbRule_0_before";
            this.rbRule_0_before.Size = new System.Drawing.Size(43, 19);
            this.rbRule_0_before.TabIndex = 99;
            this.rbRule_0_before.TabStop = true;
            this.rbRule_0_before.Text = "Vor";
            this.rbRule_0_before.UseVisualStyleBackColor = true;
            // 
            // cbRule_0_Numbers
            // 
            this.cbRule_0_Numbers.AutoSize = true;
            this.cbRule_0_Numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRule_0_Numbers.Location = new System.Drawing.Point(9, 22);
            this.cbRule_0_Numbers.Name = "cbRule_0_Numbers";
            this.cbRule_0_Numbers.Size = new System.Drawing.Size(92, 19);
            this.cbRule_0_Numbers.TabIndex = 99;
            this.cbRule_0_Numbers.Text = "Numerieren";
            this.cbRule_0_Numbers.UseVisualStyleBackColor = true;
            this.cbRule_0_Numbers.CheckedChanged += new System.EventHandler(this.cbRule_0_Numbers_CheckedChanged);
            // 
            // pbSeparator_1
            // 
            this.pbSeparator_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbSeparator_1.Location = new System.Drawing.Point(0, 97);
            this.pbSeparator_1.Name = "pbSeparator_1";
            this.pbSeparator_1.Size = new System.Drawing.Size(315, 1);
            this.pbSeparator_1.TabIndex = 1;
            this.pbSeparator_1.TabStop = false;
            // 
            // pRule_1
            // 
            this.pRule_1.Controls.Add(this.pictureBox1);
            this.pRule_1.Controls.Add(this.lblRule_1_ReplaceLbl);
            this.pRule_1.Controls.Add(this.txtRule_1_Replace);
            this.pRule_1.Controls.Add(this.lblRule_1_SearchLbl);
            this.pRule_1.Controls.Add(this.txtRule_1_Search);
            this.pRule_1.Location = new System.Drawing.Point(1, 107);
            this.pRule_1.Name = "pRule_1";
            this.pRule_1.Size = new System.Drawing.Size(313, 64);
            this.pRule_1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 1);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblRule_1_ReplaceLbl
            // 
            this.lblRule_1_ReplaceLbl.AutoSize = true;
            this.lblRule_1_ReplaceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule_1_ReplaceLbl.Location = new System.Drawing.Point(5, 33);
            this.lblRule_1_ReplaceLbl.Name = "lblRule_1_ReplaceLbl";
            this.lblRule_1_ReplaceLbl.Size = new System.Drawing.Size(48, 15);
            this.lblRule_1_ReplaceLbl.TabIndex = 3;
            this.lblRule_1_ReplaceLbl.Text = "Ersetze";
            // 
            // txtRule_1_Replace
            // 
            this.txtRule_1_Replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRule_1_Replace.Location = new System.Drawing.Point(62, 30);
            this.txtRule_1_Replace.Name = "txtRule_1_Replace";
            this.txtRule_1_Replace.Size = new System.Drawing.Size(233, 21);
            this.txtRule_1_Replace.TabIndex = 2;
            this.txtRule_1_Replace.TextChanged += new System.EventHandler(this.txtRule_1_Replace_TextChanged);
            // 
            // lblRule_1_SearchLbl
            // 
            this.lblRule_1_SearchLbl.AutoSize = true;
            this.lblRule_1_SearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule_1_SearchLbl.Location = new System.Drawing.Point(5, 6);
            this.lblRule_1_SearchLbl.Name = "lblRule_1_SearchLbl";
            this.lblRule_1_SearchLbl.Size = new System.Drawing.Size(42, 15);
            this.lblRule_1_SearchLbl.TabIndex = 1;
            this.lblRule_1_SearchLbl.Text = "Suche";
            // 
            // txtRule_1_Search
            // 
            this.txtRule_1_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRule_1_Search.Location = new System.Drawing.Point(62, 3);
            this.txtRule_1_Search.Name = "txtRule_1_Search";
            this.txtRule_1_Search.Size = new System.Drawing.Size(233, 21);
            this.txtRule_1_Search.TabIndex = 1;
            this.txtRule_1_Search.TextChanged += new System.EventHandler(this.txtRule_1_Search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRule_2_Replace);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRule_2_Search);
            this.panel1.Location = new System.Drawing.Point(370, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 64);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(0, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 1);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ersetze";
            // 
            // txtRule_2_Replace
            // 
            this.txtRule_2_Replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRule_2_Replace.Location = new System.Drawing.Point(62, 30);
            this.txtRule_2_Replace.Name = "txtRule_2_Replace";
            this.txtRule_2_Replace.Size = new System.Drawing.Size(233, 21);
            this.txtRule_2_Replace.TabIndex = 4;
            this.txtRule_2_Replace.TextChanged += new System.EventHandler(this.txtRule_2_Replace_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suche";
            // 
            // txtRule_2_Search
            // 
            this.txtRule_2_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRule_2_Search.Location = new System.Drawing.Point(62, 3);
            this.txtRule_2_Search.Name = "txtRule_2_Search";
            this.txtRule_2_Search.Size = new System.Drawing.Size(233, 21);
            this.txtRule_2_Search.TabIndex = 3;
            this.txtRule_2_Search.TextChanged += new System.EventHandler(this.txtRule_2_Search_TextChanged);
            // 
            // panelRenameResultExample
            // 
            this.panelRenameResultExample.Controls.Add(this.lblOriginalName);
            this.panelRenameResultExample.Controls.Add(this.lblArrow);
            this.panelRenameResultExample.Controls.Add(this.lblResultingName);
            this.panelRenameResultExample.Location = new System.Drawing.Point(17, 408);
            this.panelRenameResultExample.Name = "panelRenameResultExample";
            this.panelRenameResultExample.Size = new System.Drawing.Size(668, 21);
            this.panelRenameResultExample.TabIndex = 10;
            // 
            // lblOriginalName
            // 
            this.lblOriginalName.AutoSize = true;
            this.lblOriginalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOriginalName.Location = new System.Drawing.Point(3, 0);
            this.lblOriginalName.Name = "lblOriginalName";
            this.lblOriginalName.Size = new System.Drawing.Size(111, 15);
            this.lblOriginalName.TabIndex = 11;
            this.lblOriginalName.Text = "OrdnerABC_P2P_x";
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblArrow.Location = new System.Drawing.Point(120, 0);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(21, 15);
            this.lblArrow.TabIndex = 12;
            this.lblArrow.Text = "=>";
            // 
            // lblResultingName
            // 
            this.lblResultingName.AutoSize = true;
            this.lblResultingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultingName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblResultingName.Location = new System.Drawing.Point(147, 0);
            this.lblResultingName.Name = "lblResultingName";
            this.lblResultingName.Size = new System.Drawing.Size(93, 15);
            this.lblResultingName.TabIndex = 13;
            this.lblResultingName.Text = "01-Ordner_ABC";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(326, 446);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 33);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(12, 474);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "by xcy7e";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 500);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelRenameResultExample);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbRules);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.gbFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch FileRenamer";
            this.gbFiles.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.gbRules.ResumeLayout(false);
            this.gbRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator_1)).EndInit();
            this.pRule_1.ResumeLayout(false);
            this.pRule_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelRenameResultExample.ResumeLayout(false);
            this.panelRenameResultExample.PerformLayout();
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
    }
}

