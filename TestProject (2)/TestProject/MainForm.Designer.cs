namespace TestProject
{
    partial class MainForm
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
            this.keyLabel1 = new System.Windows.Forms.Label();
            this.keyLabel2 = new System.Windows.Forms.Label();
            this.valueLabel2 = new System.Windows.Forms.Label();
            this.valueLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyLabel1
            // 
            this.keyLabel1.Location = new System.Drawing.Point(50, 50);
            this.keyLabel1.Name = "keyLabel1";
            this.keyLabel1.Size = new System.Drawing.Size(60, 30);
            this.keyLabel1.TabIndex = 0;
            this.keyLabel1.Text = "KEY #1";
            this.keyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // keyLabel2
            // 
            this.keyLabel2.Location = new System.Drawing.Point(50, 100);
            this.keyLabel2.Name = "keyLabel2";
            this.keyLabel2.Size = new System.Drawing.Size(60, 30);
            this.keyLabel2.TabIndex = 1;
            this.keyLabel2.Text = "KEY #2";
            this.keyLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valueLabel2
            // 
            this.valueLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueLabel2.Location = new System.Drawing.Point(120, 100);
            this.valueLabel2.Name = "valueLabel2";
            this.valueLabel2.Size = new System.Drawing.Size(200, 30);
            this.valueLabel2.TabIndex = 3;
            this.valueLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valueLabel1
            // 
            this.valueLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueLabel1.Location = new System.Drawing.Point(120, 50);
            this.valueLabel1.Name = "valueLabel1";
            this.valueLabel1.Size = new System.Drawing.Size(200, 30);
            this.valueLabel1.TabIndex = 2;
            this.valueLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valueLabel2);
            this.Controls.Add(this.valueLabel1);
            this.Controls.Add(this.keyLabel2);
            this.Controls.Add(this.keyLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "MainForm";
            this.Text = "다국어 테스트";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyLabel1;
        private System.Windows.Forms.Label keyLabel2;
        private System.Windows.Forms.Label valueLabel2;
        private System.Windows.Forms.Label valueLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

