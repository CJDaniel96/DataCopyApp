namespace WindowsFormsApp2
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
            this.Filefo = new System.Windows.Forms.Label();
            this.Filefotext = new System.Windows.Forms.TextBox();
            this.Filetotext = new System.Windows.Forms.TextBox();
            this.Fileto = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Endexit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Filefo
            // 
            this.Filefo.AutoSize = true;
            this.Filefo.Location = new System.Drawing.Point(185, 180);
            this.Filefo.Name = "Filefo";
            this.Filefo.Size = new System.Drawing.Size(41, 15);
            this.Filefo.TabIndex = 0;
            this.Filefo.Text = "label1";
            // 
            // Filefotext
            // 
            this.Filefotext.Location = new System.Drawing.Point(337, 170);
            this.Filefotext.Name = "Filefotext";
            this.Filefotext.Size = new System.Drawing.Size(224, 25);
            this.Filefotext.TabIndex = 1;
            this.Filefotext.TextChanged += new System.EventHandler(this.Filefotext_TextChanged);
            // 
            // Filetotext
            // 
            this.Filetotext.Location = new System.Drawing.Point(337, 233);
            this.Filetotext.Name = "Filetotext";
            this.Filetotext.Size = new System.Drawing.Size(224, 25);
            this.Filetotext.TabIndex = 2;
            // 
            // Fileto
            // 
            this.Fileto.AutoSize = true;
            this.Fileto.Location = new System.Drawing.Point(185, 243);
            this.Fileto.Name = "Fileto";
            this.Fileto.Size = new System.Drawing.Size(41, 15);
            this.Fileto.TabIndex = 3;
            this.Fileto.Text = "label2";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(188, 326);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "button1";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(337, 326);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "button2";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Endexit
            // 
            this.Endexit.Location = new System.Drawing.Point(486, 326);
            this.Endexit.Name = "Endexit";
            this.Endexit.Size = new System.Drawing.Size(75, 23);
            this.Endexit.TabIndex = 6;
            this.Endexit.Text = "button3";
            this.Endexit.UseVisualStyleBackColor = true;
            this.Endexit.Click += new System.EventHandler(this.Endexit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(185, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 15);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Endexit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Fileto);
            this.Controls.Add(this.Filetotext);
            this.Controls.Add(this.Filefotext);
            this.Controls.Add(this.Filefo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Filefo;
        private System.Windows.Forms.TextBox Filefotext;
        private System.Windows.Forms.TextBox Filetotext;
        private System.Windows.Forms.Label Fileto;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Endexit;
        private System.Windows.Forms.Label lblTitle;
    }
}

