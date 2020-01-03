namespace SoruÇöz
{
    partial class SoruCevaplama
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
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoruCevaplama));
            this.textBox_cevap = new System.Windows.Forms.TextBox();
            this.label_aciklama = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.simpleButton_cevap = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_cevap
            // 
            this.textBox_cevap.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.textBox_cevap.Location = new System.Drawing.Point(373, 337);
            this.textBox_cevap.Name = "textBox_cevap";
            this.textBox_cevap.Size = new System.Drawing.Size(447, 49);
            this.textBox_cevap.TabIndex = 0;
            // 
            // label_aciklama
            // 
            this.label_aciklama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_aciklama.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.label_aciklama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_aciklama.Location = new System.Drawing.Point(62, 119);
            this.label_aciklama.Name = "label_aciklama";
            this.label_aciklama.Size = new System.Drawing.Size(1063, 165);
            this.label_aciklama.TabIndex = 16;
            this.label_aciklama.Text = "Açıklama";
            this.label_aciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1176, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 612);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1176, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 612);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1176, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 612);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // navBarControl1
            // 
            this.navBarControl1.Location = new System.Drawing.Point(13, 13);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 300);
            this.navBarControl1.TabIndex = 21;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // simpleButton_cevap
            // 
            this.simpleButton_cevap.Appearance.Font = new System.Drawing.Font("Sitka Small", 24F);
            this.simpleButton_cevap.Appearance.Options.UseFont = true;
            this.simpleButton_cevap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_cevap.ImageOptions.Image")));
            this.simpleButton_cevap.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton_cevap.ImageOptions.ImageToTextIndent = 30;
            this.simpleButton_cevap.Location = new System.Drawing.Point(445, 454);
            this.simpleButton_cevap.Name = "simpleButton_cevap";
            this.simpleButton_cevap.Size = new System.Drawing.Size(305, 120);
            this.simpleButton_cevap.TabIndex = 1;
            this.simpleButton_cevap.Text = "CEVAPLA";
            this.simpleButton_cevap.Click += new System.EventHandler(this.simpleButton_cevap_Click);
            // 
            // progressBarControl
            // 
            this.progressBarControl.EditValue = 1;
            this.progressBarControl.Location = new System.Drawing.Point(370, 13);
            this.progressBarControl.MenuManager = this.barManager1;
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.Maximum = 20;
            this.progressBarControl.Properties.Step = 1;
            this.progressBarControl.Size = new System.Drawing.Size(450, 57);
            this.progressBarControl.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(502, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "İLERLEME DURUMU";
            // 
            // SoruCevaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarControl);
            this.Controls.Add(this.simpleButton_cevap);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.label_aciklama);
            this.Controls.Add(this.textBox_cevap);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoruCevaplama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoruCevaplama";
            this.Load += new System.EventHandler(this.SoruCevaplama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_cevap;
        public System.Windows.Forms.Label label_aciklama;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cevap;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
        private System.Windows.Forms.Label label1;
    }
}