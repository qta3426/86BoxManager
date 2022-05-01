namespace _86boxManager
{
    partial class dlgSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgSettings));
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxShowConsole = new System.Windows.Forms.CheckBox();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.cbxLocal = new System.Windows.Forms.GroupBox();
            this.cbbLocal = new System.Windows.Forms.ComboBox();
            this.gbxBehaviour = new System.Windows.Forms.GroupBox();
            this.cbxMinimizeTray = new System.Windows.Forms.CheckBox();
            this.cbxCloseTray = new System.Windows.Forms.CheckBox();
            this.cbxMinimize = new System.Windows.Forms.CheckBox();
            this.gbxPaths = new System.Windows.Forms.GroupBox();
            this.lbl86BoxVer1 = new System.Windows.Forms.Label();
            this.lbl86BoxVer = new System.Windows.Forms.Label();
            this.lblCFGdir = new System.Windows.Forms.Label();
            this.txtCFGdir = new System.Windows.Forms.TextBox();
            this.txtEXEdir = new System.Windows.Forms.TextBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.lblEXEdir = new System.Windows.Forms.Label();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.gbxLogging = new System.Windows.Forms.GroupBox();
            this.cbxLogging = new System.Windows.Forms.CheckBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.gbxMisc = new System.Windows.Forms.GroupBox();
            this.cbxGrid = new System.Windows.Forms.CheckBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblVersion1 = new System.Windows.Forms.Label();
            this.lnkGithub2 = new System.Windows.Forms.LinkLabel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom.SuspendLayout();
            this.tbcSettings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.cbxLocal.SuspendLayout();
            this.gbxBehaviour.SuspendLayout();
            this.gbxPaths.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.gbxLogging.SuspendLayout();
            this.gbxMisc.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxShowConsole
            // 
            resources.ApplyResources(this.cbxShowConsole, "cbxShowConsole");
            this.cbxShowConsole.Name = "cbxShowConsole";
            this.cbxShowConsole.UseVisualStyleBackColor = true;
            this.cbxShowConsole.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // btnDefaults
            // 
            resources.ApplyResources(this.btnDefaults, "btnDefaults");
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnApply);
            this.pnlBottom.Controls.Add(this.btnDefaults);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOK);
            resources.ApplyResources(this.pnlBottom, "pnlBottom");
            this.pnlBottom.Name = "pnlBottom";
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tabGeneral);
            this.tbcSettings.Controls.Add(this.tabAdvanced);
            this.tbcSettings.Controls.Add(this.tabAbout);
            resources.ApplyResources(this.tbcSettings, "tbcSettings");
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.cbxLocal);
            this.tabGeneral.Controls.Add(this.gbxBehaviour);
            this.tabGeneral.Controls.Add(this.gbxPaths);
            resources.ApplyResources(this.tabGeneral, "tabGeneral");
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // cbxLocal
            // 
            this.cbxLocal.Controls.Add(this.cbbLocal);
            resources.ApplyResources(this.cbxLocal, "cbxLocal");
            this.cbxLocal.Name = "cbxLocal";
            this.cbxLocal.TabStop = false;
            // 
            // cbbLocal
            // 
            this.cbbLocal.FormattingEnabled = true;
            this.cbbLocal.Items.AddRange(new object[] {
            resources.GetString("cbbLocal.Items"),
            resources.GetString("cbbLocal.Items1")});
            resources.ApplyResources(this.cbbLocal, "cbbLocal");
            this.cbbLocal.Name = "cbbLocal";
            this.cbbLocal.SelectedIndexChanged += new System.EventHandler(this.cbbLocal_SelectedIndexChanged);
            // 
            // gbxBehaviour
            // 
            this.gbxBehaviour.Controls.Add(this.cbxMinimizeTray);
            this.gbxBehaviour.Controls.Add(this.cbxCloseTray);
            this.gbxBehaviour.Controls.Add(this.cbxMinimize);
            resources.ApplyResources(this.gbxBehaviour, "gbxBehaviour");
            this.gbxBehaviour.Name = "gbxBehaviour";
            this.gbxBehaviour.TabStop = false;
            // 
            // cbxMinimizeTray
            // 
            resources.ApplyResources(this.cbxMinimizeTray, "cbxMinimizeTray");
            this.cbxMinimizeTray.Name = "cbxMinimizeTray";
            this.cbxMinimizeTray.UseVisualStyleBackColor = true;
            this.cbxMinimizeTray.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // cbxCloseTray
            // 
            resources.ApplyResources(this.cbxCloseTray, "cbxCloseTray");
            this.cbxCloseTray.Name = "cbxCloseTray";
            this.cbxCloseTray.UseVisualStyleBackColor = true;
            this.cbxCloseTray.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // cbxMinimize
            // 
            resources.ApplyResources(this.cbxMinimize, "cbxMinimize");
            this.cbxMinimize.Name = "cbxMinimize";
            this.cbxMinimize.UseVisualStyleBackColor = true;
            this.cbxMinimize.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // gbxPaths
            // 
            this.gbxPaths.Controls.Add(this.lbl86BoxVer1);
            this.gbxPaths.Controls.Add(this.lbl86BoxVer);
            this.gbxPaths.Controls.Add(this.lblCFGdir);
            this.gbxPaths.Controls.Add(this.txtCFGdir);
            this.gbxPaths.Controls.Add(this.txtEXEdir);
            this.gbxPaths.Controls.Add(this.btnBrowse2);
            this.gbxPaths.Controls.Add(this.lblEXEdir);
            this.gbxPaths.Controls.Add(this.btnBrowse1);
            resources.ApplyResources(this.gbxPaths, "gbxPaths");
            this.gbxPaths.Name = "gbxPaths";
            this.gbxPaths.TabStop = false;
            // 
            // lbl86BoxVer1
            // 
            resources.ApplyResources(this.lbl86BoxVer1, "lbl86BoxVer1");
            this.lbl86BoxVer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl86BoxVer1.Name = "lbl86BoxVer1";
            // 
            // lbl86BoxVer
            // 
            resources.ApplyResources(this.lbl86BoxVer, "lbl86BoxVer");
            this.lbl86BoxVer.Name = "lbl86BoxVer";
            // 
            // lblCFGdir
            // 
            resources.ApplyResources(this.lblCFGdir, "lblCFGdir");
            this.lblCFGdir.Name = "lblCFGdir";
            // 
            // txtCFGdir
            // 
            resources.ApplyResources(this.txtCFGdir, "txtCFGdir");
            this.txtCFGdir.Name = "txtCFGdir";
            this.txtCFGdir.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtEXEdir
            // 
            resources.ApplyResources(this.txtEXEdir, "txtEXEdir");
            this.txtEXEdir.Name = "txtEXEdir";
            this.txtEXEdir.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnBrowse2
            // 
            resources.ApplyResources(this.btnBrowse2, "btnBrowse2");
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // lblEXEdir
            // 
            resources.ApplyResources(this.lblEXEdir, "lblEXEdir");
            this.lblEXEdir.Name = "lblEXEdir";
            // 
            // btnBrowse1
            // 
            resources.ApplyResources(this.btnBrowse1, "btnBrowse1");
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.gbxLogging);
            this.tabAdvanced.Controls.Add(this.gbxMisc);
            resources.ApplyResources(this.tabAdvanced, "tabAdvanced");
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // gbxLogging
            // 
            this.gbxLogging.Controls.Add(this.cbxLogging);
            this.gbxLogging.Controls.Add(this.txtLogPath);
            this.gbxLogging.Controls.Add(this.btnBrowse3);
            resources.ApplyResources(this.gbxLogging, "gbxLogging");
            this.gbxLogging.Name = "gbxLogging";
            this.gbxLogging.TabStop = false;
            // 
            // cbxLogging
            // 
            resources.ApplyResources(this.cbxLogging, "cbxLogging");
            this.cbxLogging.Name = "cbxLogging";
            this.cbxLogging.UseVisualStyleBackColor = true;
            this.cbxLogging.CheckedChanged += new System.EventHandler(this.cbxLogging_CheckedChanged);
            // 
            // txtLogPath
            // 
            resources.ApplyResources(this.txtLogPath, "txtLogPath");
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnBrowse3
            // 
            resources.ApplyResources(this.btnBrowse3, "btnBrowse3");
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.UseVisualStyleBackColor = true;
            this.btnBrowse3.Click += new System.EventHandler(this.btnBrowse3_Click);
            // 
            // gbxMisc
            // 
            this.gbxMisc.Controls.Add(this.cbxGrid);
            this.gbxMisc.Controls.Add(this.cbxShowConsole);
            resources.ApplyResources(this.gbxMisc, "gbxMisc");
            this.gbxMisc.Name = "gbxMisc";
            this.gbxMisc.TabStop = false;
            // 
            // cbxGrid
            // 
            resources.ApplyResources(this.cbxGrid, "cbxGrid");
            this.cbxGrid.Name = "cbxGrid";
            this.cbxGrid.UseVisualStyleBackColor = true;
            this.cbxGrid.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lnkGithub);
            this.tabAbout.Controls.Add(this.imgLogo);
            this.tabAbout.Controls.Add(this.lblVersion1);
            this.tabAbout.Controls.Add(this.lnkGithub2);
            this.tabAbout.Controls.Add(this.lblCopyright);
            this.tabAbout.Controls.Add(this.lblVersion);
            this.tabAbout.Controls.Add(this.lblDesc);
            this.tabAbout.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.tabAbout, "tabAbout");
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lnkGithub
            // 
            resources.ApplyResources(this.lnkGithub, "lnkGithub");
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.TabStop = true;
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
            // 
            // imgLogo
            // 
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            // 
            // lblVersion1
            // 
            resources.ApplyResources(this.lblVersion1, "lblVersion1");
            this.lblVersion1.Name = "lblVersion1";
            // 
            // lnkGithub2
            // 
            resources.ApplyResources(this.lnkGithub2, "lnkGithub2");
            this.lnkGithub2.Name = "lnkGithub2";
            this.lnkGithub2.TabStop = true;
            this.lnkGithub2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub2_LinkClicked);
            // 
            // lblCopyright
            // 
            resources.ApplyResources(this.lblCopyright, "lblCopyright");
            this.lblCopyright.Name = "lblCopyright";
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // lblDesc
            // 
            resources.ApplyResources(this.lblDesc, "lblDesc");
            this.lblDesc.Name = "lblDesc";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // dlgSettings
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.tbcSettings);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dlgSettings_FormClosing);
            this.Load += new System.EventHandler(this.dlgSettings_Load);
            this.pnlBottom.ResumeLayout(false);
            this.tbcSettings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.cbxLocal.ResumeLayout(false);
            this.gbxBehaviour.ResumeLayout(false);
            this.gbxBehaviour.PerformLayout();
            this.gbxPaths.ResumeLayout(false);
            this.gbxPaths.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.gbxLogging.ResumeLayout(false);
            this.gbxLogging.PerformLayout();
            this.gbxMisc.ResumeLayout(false);
            this.gbxMisc.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbxShowConsole;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox gbxBehaviour;
        private System.Windows.Forms.CheckBox cbxMinimizeTray;
        private System.Windows.Forms.CheckBox cbxCloseTray;
        private System.Windows.Forms.CheckBox cbxMinimize;
        private System.Windows.Forms.GroupBox gbxPaths;
        private System.Windows.Forms.Label lblCFGdir;
        private System.Windows.Forms.TextBox txtCFGdir;
        private System.Windows.Forms.TextBox txtEXEdir;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Label lblEXEdir;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.Label lbl86BoxVer1;
        private System.Windows.Forms.Label lbl86BoxVer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbxMisc;
        private System.Windows.Forms.CheckBox cbxLogging;
        private System.Windows.Forms.Button btnBrowse3;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.CheckBox cbxGrid;
        private System.Windows.Forms.GroupBox gbxLogging;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblVersion1;
        private System.Windows.Forms.LinkLabel lnkGithub2;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox cbxLocal;
        private System.Windows.Forms.ComboBox cbbLocal;
    }
}