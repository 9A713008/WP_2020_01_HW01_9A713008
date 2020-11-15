namespace WP_2020_01_HW01_9A713008
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tB1 = new System.Windows.Forms.TextBox();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB1
            // 
            this.tB1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tB1.Location = new System.Drawing.Point(47, 63);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(438, 35);
            this.tB1.TabIndex = 0;
            // 
            // tB2
            // 
            this.tB2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tB2.Location = new System.Drawing.Point(47, 206);
            this.tB2.Name = "tB2";
            this.tB2.Size = new System.Drawing.Size(438, 35);
            this.tB2.TabIndex = 1;
            // 
            // btnGo1
            // 
            this.btnGo1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGo1.Location = new System.Drawing.Point(575, 97);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(167, 112);
            this.btnGo1.TabIndex = 2;
            this.btnGo1.Text = "MD5";
            this.btnGo1.UseVisualStyleBackColor = true;
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.tB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.Button btnGo1;
    }
}

