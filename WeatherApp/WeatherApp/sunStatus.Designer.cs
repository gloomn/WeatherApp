
namespace WeatherApp
{
    partial class sunStatus
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
            this.mainPanelSun = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.sunRiseTitle = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.mainPanelSun.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanelSun
            // 
            this.mainPanelSun.Controls.Add(this.sunrise);
            this.mainPanelSun.Controls.Add(this.sunRiseTitle);
            this.mainPanelSun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelSun.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.mainPanelSun.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.mainPanelSun.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.mainPanelSun.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(157)))));
            this.mainPanelSun.Location = new System.Drawing.Point(0, 0);
            this.mainPanelSun.Name = "mainPanelSun";
            this.mainPanelSun.ShadowDecoration.Parent = this.mainPanelSun;
            this.mainPanelSun.Size = new System.Drawing.Size(1225, 676);
            this.mainPanelSun.TabIndex = 2;
            // 
            // sunRiseTitle
            // 
            this.sunRiseTitle.AutoSize = true;
            this.sunRiseTitle.BackColor = System.Drawing.Color.Transparent;
            this.sunRiseTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunRiseTitle.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sunRiseTitle.ForeColor = System.Drawing.Color.Transparent;
            this.sunRiseTitle.Location = new System.Drawing.Point(19, 14);
            this.sunRiseTitle.Name = "sunRiseTitle";
            this.sunRiseTitle.Size = new System.Drawing.Size(134, 37);
            this.sunRiseTitle.TabIndex = 9;
            this.sunRiseTitle.Text = "일출 시간";
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunrise.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sunrise.ForeColor = System.Drawing.Color.Transparent;
            this.sunrise.Location = new System.Drawing.Point(19, 62);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(109, 37);
            this.sunrise.TabIndex = 10;
            this.sunrise.Text = "Sunrise";
            // 
            // sunStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanelSun);
            this.Name = "sunStatus";
            this.Size = new System.Drawing.Size(1225, 676);
            this.mainPanelSun.ResumeLayout(false);
            this.mainPanelSun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanelSun;
        private System.Windows.Forms.Label sunRiseTitle;
        private System.Windows.Forms.Label sunrise;
    }
}
