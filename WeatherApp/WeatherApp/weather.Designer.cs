
namespace WeatherApp
{
    partial class weather
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
            this.mainPanelWeather = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.xmlCode = new System.Windows.Forms.RichTextBox();
            this.mainPanelWeather.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanelWeather
            // 
            this.mainPanelWeather.Controls.Add(this.xmlCode);
            this.mainPanelWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelWeather.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.mainPanelWeather.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.mainPanelWeather.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.mainPanelWeather.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.mainPanelWeather.Location = new System.Drawing.Point(0, 0);
            this.mainPanelWeather.Name = "mainPanelWeather";
            this.mainPanelWeather.ShadowDecoration.Parent = this.mainPanelWeather;
            this.mainPanelWeather.Size = new System.Drawing.Size(1225, 676);
            this.mainPanelWeather.TabIndex = 2;
            // 
            // xmlCode
            // 
            this.xmlCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xmlCode.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.xmlCode.Location = new System.Drawing.Point(12, 27);
            this.xmlCode.Name = "xmlCode";
            this.xmlCode.Size = new System.Drawing.Size(1201, 623);
            this.xmlCode.TabIndex = 15;
            this.xmlCode.Text = "";
            // 
            // weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanelWeather);
            this.Name = "weather";
            this.Size = new System.Drawing.Size(1225, 676);
            this.mainPanelWeather.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanelWeather;
        private System.Windows.Forms.RichTextBox xmlCode;
    }
}
