namespace SingletonPattern
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlShape = new System.Windows.Forms.Panel();
            this.btnThayDoiMau = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlShape
            // 
            this.pnlShape.Location = new System.Drawing.Point(147, 106);
            this.pnlShape.Name = "pnlShape";
            this.pnlShape.Size = new System.Drawing.Size(215, 132);
            this.pnlShape.TabIndex = 0;
            // 
            // btnThayDoiMau
            // 
            this.btnThayDoiMau.Location = new System.Drawing.Point(160, 264);
            this.btnThayDoiMau.Name = "btnThayDoiMau";
            this.btnThayDoiMau.Size = new System.Drawing.Size(177, 58);
            this.btnThayDoiMau.TabIndex = 1;
            this.btnThayDoiMau.Text = "Thay đổi màu";
            this.btnThayDoiMau.UseVisualStyleBackColor = true;
            this.btnThayDoiMau.Click += new System.EventHandler(this.btnThayDoiMau_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(406, 265);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(164, 56);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Mở form Văn bản";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnThayDoiMau);
            this.Controls.Add(this.pnlShape);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShape;
        private System.Windows.Forms.Button btnThayDoiMau;
        private System.Windows.Forms.Button btn1;
    }
}