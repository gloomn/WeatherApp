
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
            this.minimizeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.exitButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.maximizeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.smallerButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.mainFormShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.sidePanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.closeMenu = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.menuBar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.navBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.sidePanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.slidePanelTimer = new System.Windows.Forms.Timer(this.components);
            this.hanriverTemp1 = new WeatherApp.hanriverTemp();
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.navBar.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.minimizeButton.Location = new System.Drawing.Point(102, 3);
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
            this.exitButton.Location = new System.Drawing.Point(182, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(40, 25);
            this.exitButton.TabIndex = 1;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.maximizeButton.Location = new System.Drawing.Point(142, 3);
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
            this.smallerButton.Location = new System.Drawing.Point(142, 3);
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
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.guna2GradientButton5);
            this.sidePanel.Controls.Add(this.guna2GradientButton4);
            this.sidePanel.Controls.Add(this.guna2GradientButton3);
            this.sidePanel.Controls.Add(this.guna2GradientButton2);
            this.sidePanel.Controls.Add(this.guna2GradientButton1);
            this.sidePanel.Controls.Add(this.closeMenu);
            this.sidePanel.Controls.Add(this.menuBar);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(125)))), ((int)(((byte)(182)))));
            this.sidePanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.sidePanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.sidePanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(125)))), ((int)(((byte)(182)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.ShadowDecoration.Parent = this.sidePanel;
            this.sidePanel.Size = new System.Drawing.Size(55, 720);
            this.sidePanel.TabIndex = 1;
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.CheckedState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.CustomImages.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton5.DisabledState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.HoverState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton5.Image")));
            this.guna2GradientButton5.Location = new System.Drawing.Point(3, 687);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.ShadowDecoration.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Size = new System.Drawing.Size(30, 30);
            this.guna2GradientButton5.TabIndex = 11;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.DisabledState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton4.Image")));
            this.guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2GradientButton4.Location = new System.Drawing.Point(0, 233);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(200, 55);
            this.guna2GradientButton4.TabIndex = 10;
            this.guna2GradientButton4.Text = "    한강물 온도";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.DisabledState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.Image")));
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2GradientButton3.Location = new System.Drawing.Point(0, 172);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(197, 55);
            this.guna2GradientButton3.TabIndex = 9;
            this.guna2GradientButton3.Text = "   월출 / 월몰";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.DisabledState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton2.Image")));
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2GradientButton2.Location = new System.Drawing.Point(0, 111);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(200, 55);
            this.guna2GradientButton2.TabIndex = 8;
            this.guna2GradientButton2.Text = "  일출 / 일몰";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.DisabledState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2GradientButton1.Location = new System.Drawing.Point(0, 50);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(200, 55);
            this.guna2GradientButton1.TabIndex = 7;
            this.guna2GradientButton1.Text = "날씨";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // closeMenu
            // 
            this.closeMenu.BackColor = System.Drawing.Color.Transparent;
            this.closeMenu.CheckedState.Parent = this.closeMenu;
            this.closeMenu.CustomImages.Parent = this.closeMenu;
            this.closeMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeMenu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeMenu.DisabledState.Parent = this.closeMenu;
            this.closeMenu.FillColor = System.Drawing.Color.Transparent;
            this.closeMenu.FillColor2 = System.Drawing.Color.Transparent;
            this.closeMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeMenu.ForeColor = System.Drawing.Color.White;
            this.closeMenu.HoverState.Parent = this.closeMenu;
            this.closeMenu.Image = ((System.Drawing.Image)(resources.GetObject("closeMenu.Image")));
            this.closeMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.closeMenu.Location = new System.Drawing.Point(142, 0);
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeMenu.ShadowDecoration.Parent = this.closeMenu;
            this.closeMenu.Size = new System.Drawing.Size(55, 55);
            this.closeMenu.TabIndex = 6;
            this.closeMenu.Visible = false;
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.Transparent;
            this.menuBar.CheckedState.Parent = this.menuBar;
            this.menuBar.CustomImages.Parent = this.menuBar;
            this.menuBar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menuBar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menuBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuBar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuBar.DisabledState.Parent = this.menuBar;
            this.menuBar.FillColor = System.Drawing.Color.Transparent;
            this.menuBar.FillColor2 = System.Drawing.Color.Transparent;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuBar.ForeColor = System.Drawing.Color.White;
            this.menuBar.HoverState.Parent = this.menuBar;
            this.menuBar.Image = ((System.Drawing.Image)(resources.GetObject("menuBar.Image")));
            this.menuBar.ImageSize = new System.Drawing.Size(35, 35);
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.ShadowDecoration.Parent = this.menuBar;
            this.menuBar.Size = new System.Drawing.Size(55, 55);
            this.menuBar.TabIndex = 6;
            this.menuBar.Click += new System.EventHandler(this.menuBar_Click);
            // 
            // elipse
            // 
            this.elipse.BorderRadius = 15;
            this.elipse.TargetControl = this;
            // 
            // drag
            // 
            this.drag.TargetControl = this.navBar;
            // 
            // navBar
            // 
            this.navBar.Controls.Add(this.label1);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(146)))), ((int)(((byte)(210)))));
            this.navBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.navBar.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.navBar.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.navBar.Location = new System.Drawing.Point(55, 0);
            this.navBar.Name = "navBar";
            this.navBar.ShadowDecoration.Parent = this.navBar;
            this.navBar.Size = new System.Drawing.Size(1000, 44);
            this.navBar.TabIndex = 6;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.exitButton);
            this.sidePanel2.Controls.Add(this.minimizeButton);
            this.sidePanel2.Controls.Add(this.maximizeButton);
            this.sidePanel2.Controls.Add(this.smallerButton);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(125)))), ((int)(((byte)(182)))));
            this.sidePanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.sidePanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.sidePanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(125)))), ((int)(((byte)(182)))));
            this.sidePanel2.Location = new System.Drawing.Point(1055, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.ShadowDecoration.Parent = this.sidePanel2;
            this.sidePanel2.Size = new System.Drawing.Size(225, 720);
            this.sidePanel2.TabIndex = 5;
            // 
            // slidePanelTimer
            // 
            this.slidePanelTimer.Interval = 10;
            this.slidePanelTimer.Tick += new System.EventHandler(this.slidePanelTimer_Tick);
            // 
            // hanriverTemp1
            // 
            this.hanriverTemp1.BackColor = System.Drawing.Color.White;
            this.hanriverTemp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hanriverTemp1.Location = new System.Drawing.Point(55, 44);
            this.hanriverTemp1.Name = "hanriverTemp1";
            this.hanriverTemp1.Size = new System.Drawing.Size(1000, 676);
            this.hanriverTemp1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "한강물 온도";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.hanriverTemp1);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ss";
            this.Load += new System.EventHandler(this.main_Load);
            this.sidePanel.ResumeLayout(false);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.sidePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm mainFormShadow;
        private Guna.UI2.WinForms.Guna2GradientButton exitButton;
        private Guna.UI2.WinForms.Guna2GradientButton minimizeButton;
        private Guna.UI2.WinForms.Guna2GradientButton maximizeButton;
        private Guna.UI2.WinForms.Guna2GradientButton smallerButton;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel sidePanel;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel sidePanel2;
        private Guna.UI2.WinForms.Guna2GradientButton menuBar;
        private Guna.UI2.WinForms.Guna2GradientCircleButton closeMenu;
        private System.Windows.Forms.Timer slidePanelTimer;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel navBar;
        private hanriverTemp hanriverTemp1;
        private System.Windows.Forms.Label label1;
    }
}

