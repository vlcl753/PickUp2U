
namespace UserForm
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
            this.user_grade = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_del = new System.Windows.Forms.Button();
            this.user_update = new System.Windows.Forms.Button();
            this.user_add = new System.Windows.Forms.Button();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.user_sc = new System.Windows.Forms.Button();
            this.user_num = new System.Windows.Forms.Label();
            this.user_pwt = new System.Windows.Forms.Label();
            this.user_pw = new System.Windows.Forms.TextBox();
            this.user_typet = new System.Windows.Forms.Label();
            this.user_type = new System.Windows.Forms.TextBox();
            this.user_phonet = new System.Windows.Forms.Label();
            this.uesr_emailt = new System.Windows.Forms.Label();
            this.user_phone = new System.Windows.Forms.TextBox();
            this.uesr_email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // user_grade
            // 
            this.user_grade.Location = new System.Drawing.Point(179, 141);
            this.user_grade.Name = "user_grade";
            this.user_grade.Size = new System.Drawing.Size(126, 21);
            this.user_grade.TabIndex = 24;
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(179, 108);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(126, 21);
            this.user_name.TabIndex = 25;
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(179, 71);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(126, 21);
            this.user_id.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "등급";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "id";
            // 
            // user_del
            // 
            this.user_del.Location = new System.Drawing.Point(311, 173);
            this.user_del.Name = "user_del";
            this.user_del.Size = new System.Drawing.Size(102, 39);
            this.user_del.TabIndex = 20;
            this.user_del.Text = "회원 삭제";
            this.user_del.UseVisualStyleBackColor = true;
            this.user_del.Click += new System.EventHandler(this.button5_Click);
            // 
            // user_update
            // 
            this.user_update.Location = new System.Drawing.Point(203, 173);
            this.user_update.Name = "user_update";
            this.user_update.Size = new System.Drawing.Size(102, 39);
            this.user_update.TabIndex = 19;
            this.user_update.Text = "회원 수정";
            this.user_update.UseVisualStyleBackColor = true;
            this.user_update.Click += new System.EventHandler(this.user_update_Click);
            // 
            // user_add
            // 
            this.user_add.Location = new System.Drawing.Point(91, 173);
            this.user_add.Name = "user_add";
            this.user_add.Size = new System.Drawing.Size(102, 39);
            this.user_add.TabIndex = 18;
            this.user_add.Text = "회원 등록";
            this.user_add.UseVisualStyleBackColor = true;
            this.user_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(91, 218);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(477, 178);
            this.DBGrid.TabIndex = 16;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            // 
            // user_sc
            // 
            this.user_sc.Location = new System.Drawing.Point(466, 397);
            this.user_sc.Name = "user_sc";
            this.user_sc.Size = new System.Drawing.Size(102, 39);
            this.user_sc.TabIndex = 20;
            this.user_sc.Text = "조회";
            this.user_sc.UseVisualStyleBackColor = true;
            this.user_sc.Click += new System.EventHandler(this.user_sc_Click);
            // 
            // user_num
            // 
            this.user_num.AutoSize = true;
            this.user_num.Location = new System.Drawing.Point(159, 25);
            this.user_num.Name = "user_num";
            this.user_num.Size = new System.Drawing.Size(71, 12);
            this.user_num.TabIndex = 27;
            this.user_num.Text = "유저 번호 = ";
            // 
            // user_pwt
            // 
            this.user_pwt.AutoSize = true;
            this.user_pwt.Location = new System.Drawing.Point(368, 68);
            this.user_pwt.Name = "user_pwt";
            this.user_pwt.Size = new System.Drawing.Size(22, 12);
            this.user_pwt.TabIndex = 23;
            this.user_pwt.Text = "pw";
            // 
            // user_pw
            // 
            this.user_pw.Location = new System.Drawing.Point(452, 68);
            this.user_pw.Name = "user_pw";
            this.user_pw.Size = new System.Drawing.Size(126, 21);
            this.user_pw.TabIndex = 26;
            // 
            // user_typet
            // 
            this.user_typet.AutoSize = true;
            this.user_typet.Location = new System.Drawing.Point(368, 95);
            this.user_typet.Name = "user_typet";
            this.user_typet.Size = new System.Drawing.Size(29, 12);
            this.user_typet.TabIndex = 23;
            this.user_typet.Text = "type";
            // 
            // user_type
            // 
            this.user_type.Location = new System.Drawing.Point(452, 95);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(126, 21);
            this.user_type.TabIndex = 26;
            // 
            // user_phonet
            // 
            this.user_phonet.AutoSize = true;
            this.user_phonet.Location = new System.Drawing.Point(368, 122);
            this.user_phonet.Name = "user_phonet";
            this.user_phonet.Size = new System.Drawing.Size(40, 12);
            this.user_phonet.TabIndex = 23;
            this.user_phonet.Text = "phone";
            // 
            // uesr_emailt
            // 
            this.uesr_emailt.AutoSize = true;
            this.uesr_emailt.Location = new System.Drawing.Point(368, 149);
            this.uesr_emailt.Name = "uesr_emailt";
            this.uesr_emailt.Size = new System.Drawing.Size(36, 12);
            this.uesr_emailt.TabIndex = 23;
            this.uesr_emailt.Text = "email";
            // 
            // user_phone
            // 
            this.user_phone.Location = new System.Drawing.Point(452, 122);
            this.user_phone.Name = "user_phone";
            this.user_phone.Size = new System.Drawing.Size(126, 21);
            this.user_phone.TabIndex = 26;
            // 
            // uesr_email
            // 
            this.uesr_email.Location = new System.Drawing.Point(452, 149);
            this.uesr_email.Name = "uesr_email";
            this.uesr_email.Size = new System.Drawing.Size(126, 21);
            this.uesr_email.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 448);
            this.Controls.Add(this.user_num);
            this.Controls.Add(this.user_grade);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.uesr_email);
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.user_phone);
            this.Controls.Add(this.user_pw);
            this.Controls.Add(this.uesr_emailt);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.user_typet);
            this.Controls.Add(this.user_phonet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_pwt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_sc);
            this.Controls.Add(this.user_del);
            this.Controls.Add(this.user_update);
            this.Controls.Add(this.user_add);
            this.Controls.Add(this.DBGrid);
            this.Name = "Form1";
            this.Text = "User";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_grade;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button user_del;
        private System.Windows.Forms.Button user_update;
        private System.Windows.Forms.Button user_add;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button user_sc;
        private System.Windows.Forms.Label user_num;
        private System.Windows.Forms.Label user_pwt;
        private System.Windows.Forms.TextBox user_pw;
        private System.Windows.Forms.Label user_typet;
        private System.Windows.Forms.TextBox user_type;
        private System.Windows.Forms.Label user_phonet;
        private System.Windows.Forms.Label uesr_emailt;
        private System.Windows.Forms.TextBox user_phone;
        private System.Windows.Forms.TextBox uesr_email;
    }
}

