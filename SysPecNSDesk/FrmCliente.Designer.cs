namespace SysPecNSDesk
{
    partial class FrmCliente
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
            dgvClientes = new DataGridView();
            clnidc = new DataGridViewTextBoxColumn();
            clnnomeCli = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnidc, clnnomeCli, clnCpf, clnTelefone, clnEmail, clnDataNasc, clnDataCad, clnAtivo });
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(0, 0);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1003, 269);
            dgvClientes.TabIndex = 3;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            dgvClientes.DoubleClick += dgvClientes_DoubleClick;
            // 
            // clnidc
            // 
            clnidc.Frozen = true;
            clnidc.HeaderText = "ID";
            clnidc.Name = "clnidc";
            clnidc.ReadOnly = true;
            clnidc.Width = 40;
            // 
            // clnnomeCli
            // 
            clnnomeCli.Frozen = true;
            clnnomeCli.HeaderText = "Nome";
            clnnomeCli.Name = "clnnomeCli";
            clnnomeCli.ReadOnly = true;
            clnnomeCli.Width = 220;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 240;
            // 
            // clnDataNasc
            // 
            clnDataNasc.Frozen = true;
            clnDataNasc.HeaderText = "Data Nasc";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            clnDataNasc.Width = 120;
            // 
            // clnDataCad
            // 
            clnDataCad.Frozen = true;
            clnDataCad.HeaderText = "Data Cad";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            clnDataCad.Width = 120;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 60;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 269);
            ControlBox = false;
            Controls.Add(dgvClientes);
            Name = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn clnidc;
        private DataGridViewTextBoxColumn clnnomeCli;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnDataCad;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}