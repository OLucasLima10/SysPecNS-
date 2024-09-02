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
            groupBox1 = new GroupBox();
            tabCliente = new TabControl();
            tabPageCliente = new TabPage();
            tabPageEndereco = new TabPage();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            tabCliente.SuspendLayout();
            tabPageCliente.SuspendLayout();
            tabPageEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabCliente);
            groupBox1.Location = new Point(30, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 367);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(tabPageCliente);
            tabCliente.Controls.Add(tabPageEndereco);
            tabCliente.Location = new Point(6, 45);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(520, 251);
            tabCliente.TabIndex = 0;
            // 
            // tabPageCliente
            // 
            tabPageCliente.Controls.Add(button1);
            tabPageCliente.Controls.Add(textBox2);
            tabPageCliente.Controls.Add(textBox1);
            tabPageCliente.Location = new Point(4, 24);
            tabPageCliente.Name = "tabPageCliente";
            tabPageCliente.Padding = new Padding(3);
            tabPageCliente.Size = new Size(512, 223);
            tabPageCliente.TabIndex = 0;
            tabPageCliente.Text = "Dados Cliente";
            tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // tabPageEndereco
            // 
            tabPageEndereco.Controls.Add(dataGridView1);
            tabPageEndereco.Controls.Add(textBox3);
            tabPageEndereco.Location = new Point(4, 24);
            tabPageEndereco.Name = "tabPageEndereco";
            tabPageEndereco.Padding = new Padding(3);
            tabPageEndereco.Size = new Size(512, 223);
            tabPageEndereco.TabIndex = 1;
            tabPageEndereco.Text = "Enderecos";
            tabPageEndereco.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(416, 182);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(503, 91);
            dataGridView1.TabIndex = 1;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            groupBox1.ResumeLayout(false);
            tabCliente.ResumeLayout(false);
            tabPageCliente.ResumeLayout(false);
            tabPageCliente.PerformLayout();
            tabPageEndereco.ResumeLayout(false);
            tabPageEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabCliente;
        private TabPage tabPageCliente;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabPage tabPageEndereco;
        private TextBox textBox3;
        private DataGridView dataGridView1;
    }
}