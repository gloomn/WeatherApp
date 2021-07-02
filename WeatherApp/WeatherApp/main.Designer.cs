
namespace WeatherApp
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.navBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.exitButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.navBarTitle = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.maximizeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.smallerButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.mainFormShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.navBar.Controls.Add(this.minimizeButton);
            this.navBar.Controls.Add(this.exitButton);
            this.navBar.Controls.Add(this.navBarTitle);
            this.navBar.Controls.Add(this.guna2PictureBox1);
            this.navBar.Controls.Add(this.maximizeButton);
            this.navBar.Controls.Add(this.smallerButton);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(125)))), ((int)(((byte)(182)))));
            this.navBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.navBar.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.navBar.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(125)))), ((int)(((byte)(182)))));
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.ShadowDecoration.BorderRadius = 10;
            this.navBar.ShadowDecoration.Parent = this.navBar;
            this.navBar.Size = new System.Drawing.Size(960, 25);
            this.navBar.TabIndex = 0;
            this.navBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseDown);
            this.navBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseMove);
            this.navBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.CheckedState.Parent = this.minimizeButton;
            this.minimizeButton.CustomImages.Parent = this.minimizeButton;
            this.minimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizeButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimizeButton.DisabledState.Parent = this.minimizeButton;
            this.minimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FillColor2 = System.Drawing.Color.Transparent;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.minimizeButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.minimizeButton.HoverState.Parent = this.minimizeButton;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageSize = new System.Drawing.Size(25, 25);
            this.minimizeButton.Location = new System.Drawing.Point(840, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.ShadowDecoration.Parent = this.minimizeButton;
            this.minimizeButton.Size = new System.Drawing.Size(40, 25);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.DisabledState.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.FillColor2 = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.exitButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(920, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(40, 25);
            this.exitButton.TabIndex = 1;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // navBarTitle
            // 
            this.navBarTitle.AutoSize = true;
            this.navBarTitle.BackColor = System.Drawing.Color.Transparent;
            this.navBarTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarTitle.ForeColor = System.Drawing.Color.White;
            this.navBarTitle.Location = new System.Drawing.Point(24, 3);
            this.navBarTitle.Name = "navBarTitle";
            this.navBarTitle.Size = new System.Drawing.Size(93, 19);
            this.navBarTitle.TabIndex = 1;
            this.navBarTitle.Text = "Weather App";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.CheckedState.Parent = this.maximizeButton;
            this.maximizeButton.CustomImages.Parent = this.maximizeButton;
            this.maximizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.maximizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.maximizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.maximizeButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.maximizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.maximizeButton.DisabledState.Parent = this.maximizeButton;
            this.maximizeButton.FillColor = System.Drawing.Color.Transparent;
            this.maximizeButton.FillColor2 = System.Drawing.Color.Transparent;
            this.maximizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maximizeButton.ForeColor = System.Drawing.Color.White;
            this.maximizeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.maximizeButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.maximizeButton.HoverState.Parent = this.maximizeButton;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.ImageSize = new System.Drawing.Size(15, 15);
            this.maximizeButton.Location = new System.Drawing.Point(880, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.ShadowDecoration.Parent = this.maximizeButton;
            this.maximizeButton.Size = new System.Drawing.Size(40, 25);
            this.maximizeButton.TabIndex = 2;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // smallerButton
            // 
            this.smallerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.smallerButton.BackColor = System.Drawing.Color.Transparent;
            this.smallerButton.CheckedState.Parent = this.smallerButton;
            this.smallerButton.CustomImages.Parent = this.smallerButton;
            this.smallerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.smallerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.smallerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.smallerButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.smallerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.smallerButton.DisabledState.Parent = this.smallerButton;
            this.smallerButton.FillColor = System.Drawing.Color.Transparent;
            this.smallerButton.FillColor2 = System.Drawing.Color.Transparent;
            this.smallerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.smallerButton.ForeColor = System.Drawing.Color.White;
            this.smallerButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.smallerButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.smallerButton.HoverState.Parent = this.smallerButton;
            this.smallerButton.Image = ((System.Drawing.Image)(resources.GetObject("smallerButton.Image")));
            this.smallerButton.ImageSize = new System.Drawing.Size(25, 25);
            this.smallerButton.Location = new System.Drawing.Point(880, 0);
            this.smallerButton.Name = "smallerButton";
            this.smallerButton.ShadowDecoration.Parent = this.smallerButton;
            this.smallerButton.Size = new System.Drawing.Size(40, 25);
            this.smallerButton.TabIndex = 4;
            this.smallerButton.Click += new System.EventHandler(this.smallerButton_Click);
            // 
            // mainFormShadow
            // 
            this.mainFormShadow.TargetForm = this;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(125)))), ((int)(((byte)(182)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(125)))), ((int)(((byte)(182)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 25);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(117, 515);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather App";
            this.Load += new System.EventHandler(this.main_Load);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel navBar;
        private System.Windows.Forms.Label navBarTitle;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm mainFormShadow;
        private Guna.UI2.WinForms.Guna2GradientButton exitButton;
        private Guna.UI2.WinForms.Guna2GradientButton minimizeButton;
        private Guna.UI2.WinForms.Guna2GradientButton maximizeButton;
        private Guna.UI2.WinForms.Guna2GradientButton smallerButton;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}

