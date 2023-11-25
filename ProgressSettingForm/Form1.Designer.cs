
namespace ProgressSettingForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtCompleteTime = new System.Windows.Forms.TextBox();
            this.txtWaitingTime = new System.Windows.Forms.TextBox();
            this.txtExpectedTime = new System.Windows.Forms.TextBox();
            this.txtInProgressTime = new System.Windows.Forms.TextBox();
            this.radPickupComplete = new System.Windows.Forms.RadioButton();
            this.radPickupWaiting = new System.Windows.Forms.RadioButton();
            this.radProductInProgress = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(48, 272);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 24);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(152, 272);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(83, 24);
            this.btnComplete.TabIndex = 51;
            this.btnComplete.Text = "완료";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtCompleteTime
            // 
            this.txtCompleteTime.Location = new System.Drawing.Point(59, 219);
            this.txtCompleteTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompleteTime.Name = "txtCompleteTime";
            this.txtCompleteTime.Size = new System.Drawing.Size(178, 21);
            this.txtCompleteTime.TabIndex = 46;
            // 
            // txtWaitingTime
            // 
            this.txtWaitingTime.Location = new System.Drawing.Point(59, 167);
            this.txtWaitingTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtWaitingTime.Name = "txtWaitingTime";
            this.txtWaitingTime.Size = new System.Drawing.Size(178, 21);
            this.txtWaitingTime.TabIndex = 47;
            // 
            // txtExpectedTime
            // 
            this.txtExpectedTime.Location = new System.Drawing.Point(167, 50);
            this.txtExpectedTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpectedTime.Name = "txtExpectedTime";
            this.txtExpectedTime.Size = new System.Drawing.Size(35, 21);
            this.txtExpectedTime.TabIndex = 48;
            this.txtExpectedTime.Text = "60";
            this.txtExpectedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInProgressTime
            // 
            this.txtInProgressTime.Location = new System.Drawing.Point(59, 115);
            this.txtInProgressTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtInProgressTime.Name = "txtInProgressTime";
            this.txtInProgressTime.Size = new System.Drawing.Size(178, 21);
            this.txtInProgressTime.TabIndex = 49;
            // 
            // radPickupComplete
            // 
            this.radPickupComplete.AutoSize = true;
            this.radPickupComplete.Location = new System.Drawing.Point(41, 197);
            this.radPickupComplete.Margin = new System.Windows.Forms.Padding(2);
            this.radPickupComplete.Name = "radPickupComplete";
            this.radPickupComplete.Size = new System.Drawing.Size(75, 16);
            this.radPickupComplete.TabIndex = 44;
            this.radPickupComplete.Text = "픽업 완료";
            this.radPickupComplete.UseVisualStyleBackColor = true;
            this.radPickupComplete.CheckedChanged += new System.EventHandler(this.radPickupComplete_CheckedChanged);
            // 
            // radPickupWaiting
            // 
            this.radPickupWaiting.AutoSize = true;
            this.radPickupWaiting.Location = new System.Drawing.Point(41, 144);
            this.radPickupWaiting.Margin = new System.Windows.Forms.Padding(2);
            this.radPickupWaiting.Name = "radPickupWaiting";
            this.radPickupWaiting.Size = new System.Drawing.Size(87, 16);
            this.radPickupWaiting.TabIndex = 45;
            this.radPickupWaiting.Text = "픽업 대기중";
            this.radPickupWaiting.UseVisualStyleBackColor = true;
            this.radPickupWaiting.CheckedChanged += new System.EventHandler(this.radPickupWaiting_CheckedChanged);
            // 
            // radProductInProgress
            // 
            this.radProductInProgress.AutoSize = true;
            this.radProductInProgress.Location = new System.Drawing.Point(41, 93);
            this.radProductInProgress.Margin = new System.Windows.Forms.Padding(2);
            this.radProductInProgress.Name = "radProductInProgress";
            this.radProductInProgress.Size = new System.Drawing.Size(87, 16);
            this.radProductInProgress.TabIndex = 43;
            this.radProductInProgress.Text = "상품 준비중";
            this.radProductInProgress.UseVisualStyleBackColor = true;
            this.radProductInProgress.CheckedChanged += new System.EventHandler(this.radProductInProgress_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "분";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "예상 준비시간:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtCompleteTime);
            this.Controls.Add(this.txtWaitingTime);
            this.Controls.Add(this.txtExpectedTime);
            this.Controls.Add(this.txtInProgressTime);
            this.Controls.Add(this.radPickupComplete);
            this.Controls.Add(this.radPickupWaiting);
            this.Controls.Add(this.radProductInProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtCompleteTime;
        private System.Windows.Forms.TextBox txtWaitingTime;
        private System.Windows.Forms.TextBox txtExpectedTime;
        private System.Windows.Forms.TextBox txtInProgressTime;
        private System.Windows.Forms.RadioButton radPickupComplete;
        private System.Windows.Forms.RadioButton radPickupWaiting;
        private System.Windows.Forms.RadioButton radProductInProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

