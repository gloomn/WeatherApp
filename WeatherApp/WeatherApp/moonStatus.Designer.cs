
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
            this.mainPanelMoon = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SuspendLayout();
            // 
            // mainPanelMoon
            // 
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
            // moonStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanelMoon);
            this.Name = "moonStatus";
            this.Size = new System.Drawing.Size(1225, 676);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanelMoon;
    }
}
