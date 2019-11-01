namespace AppG2.View
{
    partial class frmContact
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgContact = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsContact = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblJ = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContact)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(204, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(363, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(448, 99);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 42);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Add";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(554, 99);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 42);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Edit";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(668, 99);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // dtgContact
            // 
            this.dtgContact.AutoGenerateColumns = false;
            this.dtgContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgContact.DataSource = this.bdsContact;
            this.dtgContact.Location = new System.Drawing.Point(34, 163);
            this.dtgContact.Name = "dtgContact";
            this.dtgContact.RowHeadersWidth = 51;
            this.dtgContact.RowTemplate.Height = 24;
            this.dtgContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgContact.Size = new System.Drawing.Size(742, 349);
            this.dtgContact.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "FirstCharacter";
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Phone";
            this.Column3.HeaderText = "Phone";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Email";
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Id";
            this.Column5.HeaderText = "IdContact";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // bdsContact
            // 
            this.bdsContact.Sort = "Name";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(679, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 41);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(794, 199);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 17);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "A";
            this.lblA.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(793, 235);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(18, 17);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "D";
            this.lblD.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(793, 271);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(19, 17);
            this.lblG.TabIndex = 9;
            this.lblG.Text = "G";
            this.lblG.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblJ
            // 
            this.lblJ.AutoSize = true;
            this.lblJ.Location = new System.Drawing.Point(795, 307);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(15, 17);
            this.lblJ.TabIndex = 10;
            this.lblJ.Text = "J";
            this.lblJ.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(793, 343);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(19, 17);
            this.lblM.TabIndex = 11;
            this.lblM.Text = "M";
            this.lblM.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(794, 379);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(17, 17);
            this.lblP.TabIndex = 12;
            this.lblP.Text = "P";
            this.lblP.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(794, 415);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(17, 17);
            this.lblS.TabIndex = 13;
            this.lblS.Text = "S";
            this.lblS.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(794, 451);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(17, 17);
            this.lblV.TabIndex = 14;
            this.lblV.Text = "V";
            this.lblV.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(794, 487);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(17, 17);
            this.lblZ.TabIndex = 15;
            this.lblZ.Text = "Z";
            this.lblZ.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(791, 163);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(23, 17);
            this.lblAll.TabIndex = 16;
            this.lblAll.Text = "All";
            this.lblAll.Click += new System.EventHandler(this.Label_Click);
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(834, 591);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblJ);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtgContact);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmContact";
            this.Text = "frmContact";
            ((System.ComponentModel.ISupportInitialize)(this.dtgContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.BindingSource bdsContact;
        private System.Windows.Forms.DataGridView dtgContact;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblJ;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblAll;
    }
}