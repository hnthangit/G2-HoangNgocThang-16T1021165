namespace AppG2.View
{
    partial class frmImport
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
            this.components = new System.ComponentModel.Container();
            this.dtgImport = new System.Windows.Forms.DataGridView();
            this.bdsImport = new System.Windows.Forms.BindingSource(this.components);
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgImport
            // 
            this.dtgImport.AutoGenerateColumns = false;
            this.dtgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Column1,
            this.Column2});
            this.dtgImport.DataSource = this.bdsImport;
            this.dtgImport.Location = new System.Drawing.Point(12, 28);
            this.dtgImport.Name = "dtgImport";
            this.dtgImport.RowHeadersWidth = 51;
            this.dtgImport.RowTemplate.Height = 24;
            this.dtgImport.Size = new System.Drawing.Size(450, 259);
            this.dtgImport.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Phone";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Email";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(13, 297);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(148, 23);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "Chọn đường dẫn";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(383, 297);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click_1);
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 332);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.dtgImport);
            //this.Name = "frmImport";
            this.Text = "Nội dung liên hệ";
            ((System.ComponentModel.ISupportInitialize)(this.dtgImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsImport;
        private System.Windows.Forms.DataGridView dtgImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnImport;
    }
}