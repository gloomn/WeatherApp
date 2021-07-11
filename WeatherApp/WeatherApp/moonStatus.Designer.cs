
namespace WeatherApp
{
    partial class moonStatus
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainPanelMoon = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.mainPanelSun = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.moonStatusPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.moonset = new System.Windows.Forms.Label();
            this.moonrise = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.showXmlCode = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dateTime = new System.Windows.Forms.Label();
            this.xmlCode = new System.Windows.Forms.RichTextBox();
            this.elipseListbox = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainPanelMoon.SuspendLayout();
            this.mainPanelSun.SuspendLayout();
            this.moonStatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanelMoon
            // 
            this.mainPanelMoon.Controls.Add(this.mainPanelSun);
            this.mainPanelMoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelMoon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.mainPanelMoon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.mainPanelMoon.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.mainPanelMoon.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.mainPanelMoon.Location = new System.Drawing.Point(0, 0);
            this.mainPanelMoon.Name = "mainPanelMoon";
            this.mainPanelMoon.ShadowDecoration.Parent = this.mainPanelMoon;
            this.mainPanelMoon.Size = new System.Drawing.Size(1225, 676);
            this.mainPanelMoon.TabIndex = 2;
            // 
            // mainPanelSun
            // 
            this.mainPanelSun.Controls.Add(this.moonStatusPanel);
            this.mainPanelSun.Controls.Add(this.xmlCode);
            this.mainPanelSun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelSun.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.mainPanelSun.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.mainPanelSun.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.mainPanelSun.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.mainPanelSun.Location = new System.Drawing.Point(0, 0);
            this.mainPanelSun.Name = "mainPanelSun";
            this.mainPanelSun.ShadowDecoration.Parent = this.mainPanelSun;
            this.mainPanelSun.Size = new System.Drawing.Size(1225, 676);
            this.mainPanelSun.TabIndex = 3;
            // 
            // moonStatusPanel
            // 
            this.moonStatusPanel.Controls.Add(this.moonset);
            this.moonStatusPanel.Controls.Add(this.moonrise);
            this.moonStatusPanel.Controls.Add(this.latitude);
            this.moonStatusPanel.Controls.Add(this.longitude);
            this.moonStatusPanel.Controls.Add(this.label6);
            this.moonStatusPanel.Controls.Add(this.label5);
            this.moonStatusPanel.Controls.Add(this.label4);
            this.moonStatusPanel.Controls.Add(this.label3);
            this.moonStatusPanel.Controls.Add(this.label2);
            this.moonStatusPanel.Controls.Add(this.label1);
            this.moonStatusPanel.Controls.Add(this.location);
            this.moonStatusPanel.Controls.Add(this.showXmlCode);
            this.moonStatusPanel.Controls.Add(this.dateTime);
            this.moonStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moonStatusPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.moonStatusPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.moonStatusPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.moonStatusPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.moonStatusPanel.Location = new System.Drawing.Point(0, 0);
            this.moonStatusPanel.Name = "moonStatusPanel";
            this.moonStatusPanel.ShadowDecoration.Parent = this.moonStatusPanel;
            this.moonStatusPanel.Size = new System.Drawing.Size(1225, 676);
            this.moonStatusPanel.TabIndex = 15;
            // 
            // moonset
            // 
            this.moonset.AutoSize = true;
            this.moonset.BackColor = System.Drawing.Color.Transparent;
            this.moonset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moonset.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.moonset.ForeColor = System.Drawing.Color.Transparent;
            this.moonset.Location = new System.Drawing.Point(113, 343);
            this.moonset.Name = "moonset";
            this.moonset.Size = new System.Drawing.Size(133, 37);
            this.moonset.TabIndex = 22;
            this.moonset.Text = "MoonSet";
            // 
            // moonrise
            // 
            this.moonrise.AutoSize = true;
            this.moonrise.BackColor = System.Drawing.Color.Transparent;
            this.moonrise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moonrise.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.moonrise.ForeColor = System.Drawing.Color.Transparent;
            this.moonrise.Location = new System.Drawing.Point(111, 282);
            this.moonrise.Name = "moonrise";
            this.moonrise.Size = new System.Drawing.Size(145, 37);
            this.moonrise.TabIndex = 21;
            this.moonrise.Text = "MoonRise";
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.BackColor = System.Drawing.Color.Transparent;
            this.latitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.latitude.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.latitude.ForeColor = System.Drawing.Color.Transparent;
            this.latitude.Location = new System.Drawing.Point(111, 226);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(121, 37);
            this.latitude.TabIndex = 20;
            this.latitude.Text = "Latitude";
            // 
            // longitude
            // 
            this.longitude.AutoSize = true;
            this.longitude.BackColor = System.Drawing.Color.Transparent;
            this.longitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.longitude.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.longitude.ForeColor = System.Drawing.Color.Transparent;
            this.longitude.Location = new System.Drawing.Point(109, 172);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(146, 37);
            this.longitude.TabIndex = 19;
            this.longitude.Text = "Longitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(34, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "월몰";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(34, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "월출";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(34, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "위도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(34, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "경도";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "날짜";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "지역";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.BackColor = System.Drawing.Color.Transparent;
            this.location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.location.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.location.ForeColor = System.Drawing.Color.Transparent;
            this.location.Location = new System.Drawing.Point(109, 74);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(119, 37);
            this.location.TabIndex = 10;
            this.location.Text = "location";
            // 
            // showXmlCode
            // 
            this.showXmlCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showXmlCode.BackColor = System.Drawing.Color.Transparent;
            this.showXmlCode.BorderRadius = 15;
            this.showXmlCode.CheckedState.Parent = this.showXmlCode;
            this.showXmlCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showXmlCode.CustomImages.Parent = this.showXmlCode;
            this.showXmlCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showXmlCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showXmlCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showXmlCode.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showXmlCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showXmlCode.DisabledState.Parent = this.showXmlCode;
            this.showXmlCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.showXmlCode.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(176)))));
            this.showXmlCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showXmlCode.ForeColor = System.Drawing.Color.White;
            this.showXmlCode.HoverState.Parent = this.showXmlCode;
            this.showXmlCode.Location = new System.Drawing.Point(0, 643);
            this.showXmlCode.Name = "showXmlCode";
            this.showXmlCode.ShadowDecoration.Parent = this.showXmlCode;
            this.showXmlCode.Size = new System.Drawing.Size(93, 30);
            this.showXmlCode.TabIndex = 12;
            this.showXmlCode.Text = "XML";
            this.showXmlCode.Click += new System.EventHandler(this.showXmlCode_Click);
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.BackColor = System.Drawing.Color.Transparent;
            this.dateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateTime.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTime.ForeColor = System.Drawing.Color.Transparent;
            this.dateTime.Location = new System.Drawing.Point(107, 124);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(140, 37);
            this.dateTime.TabIndex = 11;
            this.dateTime.Text = "DateTime";
            // 
            // xmlCode
            // 
            this.xmlCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xmlCode.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.xmlCode.Location = new System.Drawing.Point(10, 14);
            this.xmlCode.Name = "xmlCode";
            this.xmlCode.Size = new System.Drawing.Size(1201, 623);
            this.xmlCode.TabIndex = 14;
            this.xmlCode.Text = "";
            // 
            // elipseListbox
            // 
            this.elipseListbox.BorderRadius = 15;
            this.elipseListbox.TargetControl = this.xmlCode;
            // 
            // moonStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanelMoon);
            this.Name = "moonStatus";
            this.Size = new System.Drawing.Size(1225, 676);
            this.mainPanelMoon.ResumeLayout(false);
            this.mainPanelSun.ResumeLayout(false);
            this.moonStatusPanel.ResumeLayout(false);
            this.moonStatusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanelMoon;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanelSun;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel moonStatusPanel;
        private System.Windows.Forms.Label moonset;
        private System.Windows.Forms.Label moonrise;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.Label longitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label location;
        private Guna.UI2.WinForms.Guna2GradientButton showXmlCode;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.RichTextBox xmlCode;
        private Guna.UI2.WinForms.Guna2Elipse elipseListbox;
    }
}
