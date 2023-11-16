
namespace Shop
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
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Shop_list = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(281, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 39);
            this.button5.TabIndex = 40;
            this.button5.Text = "매장 삭제";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "매장 등록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 39);
            this.button3.TabIndex = 39;
            this.button3.Text = "매장 수정";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(691, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 39);
            this.button6.TabIndex = 33;
            this.button6.Text = "상품 삭제";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(589, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 39);
            this.button4.TabIndex = 34;
            this.button4.Text = "상품 수정";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(691, 399);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 25);
            this.button8.TabIndex = 35;
            this.button8.Text = "상품 조회";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Shop_list
            // 
            this.Shop_list.Location = new System.Drawing.Point(315, 399);
            this.Shop_list.Name = "Shop_list";
            this.Shop_list.Size = new System.Drawing.Size(68, 25);
            this.Shop_list.TabIndex = 36;
            this.Shop_list.Text = "매장 조회";
            this.Shop_list.UseVisualStyleBackColor = true;
            this.Shop_list.Click += new System.EventHandler(this.shop_list_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 39);
            this.button2.TabIndex = 37;
            this.button2.Text = "상품 등록";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 21);
            this.txtName.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 21);
            this.textBox1.TabIndex = 31;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(134, 27);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(126, 21);
            this.txtid.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "상품 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "매장 주소";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "매장 이름";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(483, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(276, 238);
            this.dataGridView1.TabIndex = 25;
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(41, 155);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(342, 238);
            this.DBGrid.TabIndex = 41;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Shop_list);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "매장/상품 관리";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Shop_list;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView DBGrid;
    }
}

