
namespace SearchForm
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
            this.sc_pay = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sc_basket = new System.Windows.Forms.DataGridView();
            this.sc_Pdin = new System.Windows.Forms.Button();
            this.sc_Pdlist = new System.Windows.Forms.Button();
            this.sc_in = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sc_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sc_item = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sc_list = new System.Windows.Forms.DataGridView();
            this.sc_hold = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sc_basket)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc_hold)).BeginInit();
            this.SuspendLayout();
            // 
            // sc_pay
            // 
            this.sc_pay.Location = new System.Drawing.Point(605, 482);
            this.sc_pay.Margin = new System.Windows.Forms.Padding(2);
            this.sc_pay.Name = "sc_pay";
            this.sc_pay.Size = new System.Drawing.Size(126, 22);
            this.sc_pay.TabIndex = 26;
            this.sc_pay.Text = "현장 결제";
            this.sc_pay.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(850, 104);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 20);
            this.button6.TabIndex = 25;
            this.button6.Text = "상품삭제";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(767, 482);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 22);
            this.button7.TabIndex = 24;
            this.button7.Text = "즉시 결제";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "담긴 상품";
            // 
            // sc_basket
            // 
            this.sc_basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sc_basket.Location = new System.Drawing.Point(536, 129);
            this.sc_basket.Margin = new System.Windows.Forms.Padding(2);
            this.sc_basket.Name = "sc_basket";
            this.sc_basket.RowHeadersWidth = 82;
            this.sc_basket.RowTemplate.Height = 37;
            this.sc_basket.Size = new System.Drawing.Size(412, 340);
            this.sc_basket.TabIndex = 22;
            // 
            // sc_Pdin
            // 
            this.sc_Pdin.Location = new System.Drawing.Point(477, 279);
            this.sc_Pdin.Margin = new System.Windows.Forms.Padding(2);
            this.sc_Pdin.Name = "sc_Pdin";
            this.sc_Pdin.Size = new System.Drawing.Size(52, 24);
            this.sc_Pdin.TabIndex = 19;
            this.sc_Pdin.Text = ">>";
            this.sc_Pdin.UseVisualStyleBackColor = true;
            // 
            // sc_Pdlist
            // 
            this.sc_Pdlist.Location = new System.Drawing.Point(411, 303);
            this.sc_Pdlist.Margin = new System.Windows.Forms.Padding(2);
            this.sc_Pdlist.Name = "sc_Pdlist";
            this.sc_Pdlist.Size = new System.Drawing.Size(52, 24);
            this.sc_Pdlist.TabIndex = 20;
            this.sc_Pdlist.Text = "조회";
            this.sc_Pdlist.UseVisualStyleBackColor = true;
            this.sc_Pdlist.Click += new System.EventHandler(this.sc_Pdlist_Click);
            // 
            // sc_in
            // 
            this.sc_in.Location = new System.Drawing.Point(208, 482);
            this.sc_in.Margin = new System.Windows.Forms.Padding(2);
            this.sc_in.Name = "sc_in";
            this.sc_in.Size = new System.Drawing.Size(96, 22);
            this.sc_in.TabIndex = 21;
            this.sc_in.Text = "담기";
            this.sc_in.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sc_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sc_item);
            this.groupBox1.Location = new System.Drawing.Point(53, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(410, 50);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상품검색";
            // 
            // sc_btn
            // 
            this.sc_btn.Location = new System.Drawing.Point(316, 18);
            this.sc_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sc_btn.Name = "sc_btn";
            this.sc_btn.Size = new System.Drawing.Size(81, 19);
            this.sc_btn.TabIndex = 2;
            this.sc_btn.Text = "조회";
            this.sc_btn.UseVisualStyleBackColor = true;
            this.sc_btn.Click += new System.EventHandler(this.sc_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품명";
            // 
            // sc_item
            // 
            this.sc_item.Location = new System.Drawing.Point(104, 19);
            this.sc_item.Margin = new System.Windows.Forms.Padding(2);
            this.sc_item.Name = "sc_item";
            this.sc_item.Size = new System.Drawing.Size(189, 21);
            this.sc_item.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "상품 목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "상품보유 매장";
            // 
            // sc_list
            // 
            this.sc_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sc_list.Location = new System.Drawing.Point(51, 329);
            this.sc_list.Margin = new System.Windows.Forms.Padding(2);
            this.sc_list.Name = "sc_list";
            this.sc_list.RowHeadersWidth = 82;
            this.sc_list.RowTemplate.Height = 37;
            this.sc_list.Size = new System.Drawing.Size(412, 140);
            this.sc_list.TabIndex = 14;
            // 
            // sc_hold
            // 
            this.sc_hold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sc_hold.Location = new System.Drawing.Point(51, 132);
            this.sc_hold.Margin = new System.Windows.Forms.Padding(2);
            this.sc_hold.Name = "sc_hold";
            this.sc_hold.RowHeadersWidth = 82;
            this.sc_hold.RowTemplate.Height = 37;
            this.sc_hold.Size = new System.Drawing.Size(412, 154);
            this.sc_hold.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 551);
            this.Controls.Add(this.sc_pay);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sc_basket);
            this.Controls.Add(this.sc_Pdin);
            this.Controls.Add(this.sc_Pdlist);
            this.Controls.Add(this.sc_in);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sc_list);
            this.Controls.Add(this.sc_hold);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sc_basket)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc_hold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sc_pay;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView sc_basket;
        private System.Windows.Forms.Button sc_Pdin;
        private System.Windows.Forms.Button sc_Pdlist;
        private System.Windows.Forms.Button sc_in;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sc_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sc_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView sc_list;
        private System.Windows.Forms.DataGridView sc_hold;
    }
}

