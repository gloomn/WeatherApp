
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
            this.hanriverButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.moonButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sunButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.weatherButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.closeMenu = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.menuBar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.navBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.slidePanelTimer = new System.Windows.Forms.Timer(this.components);
            this.weather1 = new WeatherApp.weather();
            this.sunStatus1 = new WeatherApp.sunStatus();
            this.moonStatus1 = new WeatherApp.moonStatus();
            this.hanriverTemp2 = new WeatherApp.hanriverTemp();
            this.hanriverTemp1 = new WeatherApp.hanriverTemp();
            this.sidePanel.SuspendLayout();
            this.navBar.SuspendLayout();
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
            this.minimizeButton.Location = new System.Drawing.Point(1093, 7);
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
            this.exitButton.Location = new System.Drawing.Point(1173, 7);
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
            this.maximizeButton.Location = new System.Drawing.Point(1133, 7);
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
            this.smallerButton.Location = new System.Drawing.Point(1133, 7);
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
            this.sidePanel.Controls.Add(this.hanriverButton);
            this.sidePanel.Controls.Add(this.moonButton);
            this.sidePanel.Controls.Add(this.sunButton);
            this.sidePanel.Controls.Add(this.weatherButton);
            this.sidePanel.Controls.Add(this.closeMenu);
            this.sidePanel.Controls.Add(this.menuBar);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.sidePanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.sidePanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.sidePanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.ShadowDecoration.Parent = this.sidePanel;
            this.sidePanel.Size = new System.Drawing.Size(55, 720);
            this.sidePanel.TabIndex = 1;
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            // hanriverButton
            // 
            this.hanriverButton.BackColor = System.Drawing.Color.Transparent;
            this.hanriverButton.CheckedState.Parent = this.hanriverButton;
            this.hanriverButton.CustomImages.Parent = this.hanriverButton;
            this.hanriverButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hanriverButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hanriverButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hanriverButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hanriverButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hanriverButton.DisabledState.Parent = this.hanriverButton;
            this.hanriverButton.FillColor = System.Drawing.Color.Transparent;
            this.hanriverButton.FillColor2 = System.Drawing.Color.Transparent;
            this.hanriverButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanriverButton.ForeColor = System.Drawing.Color.White;
            this.hanriverButton.HoverState.Parent = this.hanriverButton;
            this.hanriverButton.Image = ((System.Drawing.Image)(resources.GetObject("hanriverButton.Image")));
            this.hanriverButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.hanriverButton.ImageSize = new System.Drawing.Size(35, 35);
            this.hanriverButton.Location = new System.Drawing.Point(0, 233);
            this.hanriverButton.Name = "hanriverButton";
            this.hanriverButton.ShadowDecoration.Parent = this.hanriverButton;
            this.hanriverButton.Size = new System.Drawing.Size(200, 55);
            this.hanriverButton.TabIndex = 10;
            this.hanriverButton.Text = "    한강물 온도";
            this.hanriverButton.Click += new System.EventHandler(this.hanriverButton_Click);
            // 
            // moonButton
            // 
            this.moonButton.BackColor = System.Drawing.Color.Transparent;
            this.moonButton.CheckedState.Parent = this.moonButton;
            this.moonButton.CustomImages.Parent = this.moonButton;
            this.moonButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.moonButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.moonButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.moonButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.moonButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.moonButton.DisabledState.Parent = this.moonButton;
            this.moonButton.FillColor = System.Drawing.Color.Transparent;
            this.moonButton.FillColor2 = System.Drawing.Color.Transparent;
            this.moonButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moonButton.ForeColor = System.Drawing.Color.White;
            this.moonButton.HoverState.Parent = this.moonButton;
            this.moonButton.Image = ((System.Drawing.Image)(resources.GetObject("moonButton.Image")));
            this.moonButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.moonButton.ImageSize = new System.Drawing.Size(35, 35);
            this.moonButton.Location = new System.Drawing.Point(0, 172);
            this.moonButton.Name = "moonButton";
            this.moonButton.ShadowDecoration.Parent = this.moonButton;
            this.moonButton.Size = new System.Drawing.Size(197, 55);
            this.moonButton.TabIndex = 9;
            this.moonButton.Text = "   월출 / 월몰";
            this.moonButton.Click += new System.EventHandler(this.moonButton_Click);
            // 
            // sunButton
            // 
            this.sunButton.BackColor = System.Drawing.Color.Transparent;
            this.sunButton.CheckedState.Parent = this.sunButton;
            this.sunButton.CustomImages.Parent = this.sunButton;
            this.sunButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sunButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sunButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sunButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sunButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sunButton.DisabledState.Parent = this.sunButton;
            this.sunButton.FillColor = System.Drawing.Color.Transparent;
            this.sunButton.FillColor2 = System.Drawing.Color.Transparent;
            this.sunButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunButton.ForeColor = System.Drawing.Color.White;
            this.sunButton.HoverState.Parent = this.sunButton;
            this.sunButton.Image = ((System.Drawing.Image)(resources.GetObject("sunButton.Image")));
            this.sunButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sunButton.ImageSize = new System.Drawing.Size(35, 35);
            this.sunButton.Location = new System.Drawing.Point(0, 111);
            this.sunButton.Name = "sunButton";
            this.sunButton.ShadowDecoration.Parent = this.sunButton;
            this.sunButton.Size = new System.Drawing.Size(200, 55);
            this.sunButton.TabIndex = 8;
            this.sunButton.Text = "  일출 / 일몰";
            this.sunButton.Click += new System.EventHandler(this.sunButton_Click);
            // 
            // weatherButton
            // 
            this.weatherButton.BackColor = System.Drawing.Color.Transparent;
            this.weatherButton.CheckedState.Parent = this.weatherButton;
            this.weatherButton.CustomImages.Parent = this.weatherButton;
            this.weatherButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.weatherButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.weatherButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.weatherButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.weatherButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.weatherButton.DisabledState.Parent = this.weatherButton;
            this.weatherButton.FillColor = System.Drawing.Color.Transparent;
            this.weatherButton.FillColor2 = System.Drawing.Color.Transparent;
            this.weatherButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherButton.ForeColor = System.Drawing.Color.White;
            this.weatherButton.HoverState.Parent = this.weatherButton;
            this.weatherButton.Image = ((System.Drawing.Image)(resources.GetObject("weatherButton.Image")));
            this.weatherButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.weatherButton.ImageSize = new System.Drawing.Size(35, 35);
            this.weatherButton.Location = new System.Drawing.Point(0, 50);
            this.weatherButton.Name = "weatherButton";
            this.weatherButton.ShadowDecoration.Parent = this.weatherButton;
            this.weatherButton.Size = new System.Drawing.Size(200, 55);
            this.weatherButton.TabIndex = 7;
            this.weatherButton.Text = "날씨";
            this.weatherButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.weatherButton.Click += new System.EventHandler(this.weatherButton_Click);
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
            this.navBar.Controls.Add(this.exitButton);
            this.navBar.Controls.Add(this.mainTitle);
            this.navBar.Controls.Add(this.minimizeButton);
            this.navBar.Controls.Add(this.maximizeButton);
            this.navBar.Controls.Add(this.smallerButton);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.navBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.navBar.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.navBar.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.navBar.Location = new System.Drawing.Point(55, 0);
            this.navBar.Name = "navBar";
            this.navBar.ShadowDecoration.Parent = this.navBar;
            this.navBar.Size = new System.Drawing.Size(1225, 44);
            this.navBar.TabIndex = 6;
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTitle.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainTitle.ForeColor = System.Drawing.Color.Transparent;
            this.mainTitle.Location = new System.Drawing.Point(3, 7);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(145, 37);
            this.mainTitle.TabIndex = 8;
            this.mainTitle.Text = "Main Title";
            // 
            // slidePanelTimer
            // 
            this.slidePanelTimer.Interval = 10;
            this.slidePanelTimer.Tick += new System.EventHandler(this.slidePanelTimer_Tick);
            // 
            // weather1
            // 
            this.weather1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weather1.Location = new System.Drawing.Point(55, 44);
            this.weather1.Name = "weather1";
            this.weather1.Size = new System.Drawing.Size(1225, 676);
            this.weather1.TabIndex = 10;
            // 
            // sunStatus1
            // 
            this.sunStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sunStatus1.Location = new System.Drawing.Point(55, 44);
            this.sunStatus1.Name = "sunStatus1";
            this.sunStatus1.Size = new System.Drawing.Size(1225, 676);
            this.sunStatus1.TabIndex = 9;
            // 
            // moonStatus1
            // 
            this.moonStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moonStatus1.Location = new System.Drawing.Point(55, 44);
            this.moonStatus1.Name = "moonStatus1";
            this.moonStatus1.Size = new System.Drawing.Size(1225, 676);
            this.moonStatus1.TabIndex = 8;
            // 
            // hanriverTemp2
            // 
            this.hanriverTemp2.BackColor = System.Drawing.Color.White;
            this.hanriverTemp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hanriverTemp2.Location = new System.Drawing.Point(55, 44);
            this.hanriverTemp2.Name = "hanriverTemp2";
            this.hanriverTemp2.Size = new System.Drawing.Size(1225, 676);
            this.hanriverTemp2.TabIndex = 7;
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
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.weather1);
            this.Controls.Add(this.sunStatus1);
            this.Controls.Add(this.moonStatus1);
            this.Controls.Add(this.hanriverTemp2);
            this.Controls.Add(this.navBar);
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
        private Guna.UI2.WinForms.Guna2GradientButton menuBar;
        private Guna.UI2.WinForms.Guna2GradientCircleButton closeMenu;
        private System.Windows.Forms.Timer slidePanelTimer;
        private Guna.UI2.WinForms.Guna2GradientButton weatherButton;
        private Guna.UI2.WinForms.Guna2GradientButton moonButton;
        private Guna.UI2.WinForms.Guna2GradientButton sunButton;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton hanriverButton;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel navBar;
        private hanriverTemp hanriverTemp1;
        private System.Windows.Forms.Label mainTitle;
        private hanriverTemp hanriverTemp2;
        private weather weather1;
        private sunStatus sunStatus1;
        private moonStatus moonStatus1;
    }
}

