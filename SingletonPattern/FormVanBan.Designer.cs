namespace SingletonPattern
{
    partial class FormVanBan
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
            this.txtVanBanGoVao = new System.Windows.Forms.TextBox();
            this.lblVanBanHienThi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVanBanGoVao
            // 
            this.txtVanBanGoVao.Location = new System.Drawing.Point(194, 225);
            this.txtVanBanGoVao.Multiline = true;
            this.txtVanBanGoVao.Name = "txtVanBanGoVao";
            this.txtVanBanGoVao.Size = new System.Drawing.Size(369, 74);
            this.txtVanBanGoVao.TabIndex = 0;
            this.txtVanBanGoVao.TextChanged += new System.EventHandler(this.TxtVanBanGoVao_TextChanged);
            // 
            // lblVanBanHienThi
            // 
            this.lblVanBanHienThi.AutoSize = true;
            this.lblVanBanHienThi.Location = new System.Drawing.Point(244, 84);
            this.lblVanBanHienThi.Name = "lblVanBanHienThi";
            this.lblVanBanHienThi.Size = new System.Drawing.Size(62, 17);
            this.lblVanBanHienThi.TabIndex = 1;
            this.lblVanBanHienThi.Text = "Van Ban";
            // 
            // FormVanBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVanBanHienThi);
            this.Controls.Add(this.txtVanBanGoVao);
            this.Name = "FormVanBan";
            this.Text = "FormVanBan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVanBan_FormClosed);
            this.Load += new System.EventHandler(this.FormVanBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVanBanGoVao;
        private System.Windows.Forms.Label lblVanBanHienThi;
    }
}