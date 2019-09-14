namespace _6_3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Integer1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Integer2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnExclusiveOr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Integer1
            // 
            this.Integer1.AutoSize = true;
            this.Integer1.Location = new System.Drawing.Point(12, 9);
            this.Integer1.Name = "Integer1";
            this.Integer1.Size = new System.Drawing.Size(71, 15);
            this.Integer1.TabIndex = 0;
            this.Integer1.Text = "Integer1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            // 
            // Integer2
            // 
            this.Integer2.AutoSize = true;
            this.Integer2.Location = new System.Drawing.Point(12, 52);
            this.Integer2.Name = "Integer2";
            this.Integer2.Size = new System.Drawing.Size(71, 15);
            this.Integer2.TabIndex = 2;
            this.Integer2.Text = "Integer2";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(15, 141);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(181, 141);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(75, 23);
            this.btnAnd.TabIndex = 8;
            this.btnAnd.Text = "AND";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(278, 141);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(75, 23);
            this.btnOr.TabIndex = 10;
            this.btnOr.Text = "OR";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnExclusiveOr
            // 
            this.btnExclusiveOr.Location = new System.Drawing.Point(372, 141);
            this.btnExclusiveOr.Name = "btnExclusiveOr";
            this.btnExclusiveOr.Size = new System.Drawing.Size(143, 23);
            this.btnExclusiveOr.TabIndex = 12;
            this.btnExclusiveOr.Text = "ExclusiveOR";
            this.btnExclusiveOr.UseVisualStyleBackColor = true;
            this.btnExclusiveOr.Click += new System.EventHandler(this.btnExclusiveOr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 194);
            this.Controls.Add(this.btnExclusiveOr);
            this.Controls.Add(this.btnOr);
            this.Controls.Add(this.btnAnd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Integer2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Integer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Integer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Integer2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnExclusiveOr;
    }
}

