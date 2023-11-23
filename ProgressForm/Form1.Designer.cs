
namespace ProgressForm
{
    partial class Form1
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
            this.lblCompleteTime = new System.Windows.Forms.Label();
            this.lblInProgressTime = new System.Windows.Forms.Label();
            this.lblWaitingTime = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompleteTime
            // 
            this.lblCompleteTime.AutoSize = true;
            this.lblCompleteTime.Location = new System.Drawing.Point(44, 367);
            this.lblCompleteTime.Name = "lblCompleteTime";
            this.lblCompleteTime.Size = new System.Drawing.Size(38, 12);
            this.lblCompleteTime.TabIndex = 10;
            this.lblCompleteTime.Text = "label2";
            // 
            // lblInProgressTime
            // 
            this.lblInProgressTime.AutoSize = true;
            this.lblInProgressTime.Location = new System.Drawing.Point(44, 289);
            this.lblInProgressTime.Name = "lblInProgressTime";
            this.lblInProgressTime.Size = new System.Drawing.Size(38, 12);
            this.lblInProgressTime.TabIndex = 11;
            this.lblInProgressTime.Text = "label2";
            // 
            // lblWaitingTime
            // 
            this.lblWaitingTime.AutoSize = true;
            this.lblWaitingTime.Location = new System.Drawing.Point(44, 317);
            this.lblWaitingTime.Name = "lblWaitingTime";
            this.lblWaitingTime.Size = new System.Drawing.Size(38, 12);
            this.lblWaitingTime.TabIndex = 12;
            this.lblWaitingTime.Text = "label2";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(68, 123);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 9;
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(92, 64);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(38, 12);
            this.lblRemainingTime.TabIndex = 8;
            this.lblRemainingTime.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCompleteTime);
            this.Controls.Add(this.lblInProgressTime);
            this.Controls.Add(this.lblWaitingTime);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblRemainingTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompleteTime;
        private System.Windows.Forms.Label lblInProgressTime;
        private System.Windows.Forms.Label lblWaitingTime;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblRemainingTime;
    }
}

