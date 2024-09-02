namespace SysPecNSDesk
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem1 = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem2 = new ToolStripMenuItem();
            movimentoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            operaçãoToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, movimentoToolStripMenuItem, operaçãoToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, usuáriosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, listaToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "&Clientes";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(103, 22);
            novoToolStripMenuItem.Text = "&Novo";
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(103, 22);
            listaToolStripMenuItem.Text = "&Lista";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem1, listarToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // novoToolStripMenuItem1
            // 
            novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            novoToolStripMenuItem1.Size = new Size(103, 22);
            novoToolStripMenuItem1.Text = "&Novo";
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(103, 22);
            listarToolStripMenuItem.Text = "&Listar";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem2 });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(180, 22);
            usuáriosToolStripMenuItem.Text = "&Usuários";
            // 
            // novoToolStripMenuItem2
            // 
            novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            novoToolStripMenuItem2.Size = new Size(103, 22);
            novoToolStripMenuItem2.Text = "&Novo";
            novoToolStripMenuItem2.Click += novoToolStripMenuItem2_Click;
            // 
            // movimentoToolStripMenuItem
            // 
            movimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidosToolStripMenuItem });
            movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            movimentoToolStripMenuItem.Size = new Size(81, 20);
            movimentoToolStripMenuItem.Text = "&Movimento";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(180, 22);
            pedidosToolStripMenuItem.Text = "&Pedidos";
            // 
            // operaçãoToolStripMenuItem
            // 
            operaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caixaToolStripMenuItem });
            operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            operaçãoToolStripMenuItem.Size = new Size(70, 20);
            operaçãoToolStripMenuItem.Text = "&Operação";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(180, 22);
            caixaToolStripMenuItem.Text = "&Caixa";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.vendas;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem1;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem2;
        private ToolStripMenuItem movimentoToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem operaçãoToolStripMenuItem;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}