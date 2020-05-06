namespace Aula_POO_04_05_2020
{
    partial class FormularioInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaFuncionarios = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalarioBruto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desconto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adicional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalarioLiquido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxNome = new System.Windows.Forms.MaskedTextBox();
            this.boxAdicional = new System.Windows.Forms.MaskedTextBox();
            this.boxDesconto = new System.Windows.Forms.MaskedTextBox();
            this.boxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.boxSalarioLiquido = new System.Windows.Forms.MaskedTextBox();
            this.boxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkDesconto = new System.Windows.Forms.CheckBox();
            this.checkAdicional = new System.Windows.Forms.CheckBox();
            this.BotaoLimpar = new System.Windows.Forms.Button();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.boxId = new System.Windows.Forms.MaskedTextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.Location = new System.Drawing.Point(543, 152);
            this.BotaoSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(76, 23);
            this.BotaoSalvar.TabIndex = 10;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = true;
            this.BotaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário Bruto:";
            // 
            // ListaFuncionarios
            // 
            this.ListaFuncionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.CPF,
            this.SalarioBruto,
            this.Desconto,
            this.Adicional,
            this.SalarioLiquido});
            this.ListaFuncionarios.HideSelection = false;
            this.ListaFuncionarios.Location = new System.Drawing.Point(13, 246);
            this.ListaFuncionarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListaFuncionarios.Name = "ListaFuncionarios";
            this.ListaFuncionarios.Size = new System.Drawing.Size(694, 173);
            this.ListaFuncionarios.TabIndex = 12;
            this.ListaFuncionarios.UseCompatibleStateImageBehavior = false;
            this.ListaFuncionarios.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 240;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            this.CPF.Width = 87;
            // 
            // SalarioBruto
            // 
            this.SalarioBruto.Text = "Salário Bruto";
            this.SalarioBruto.Width = 85;
            // 
            // Desconto
            // 
            this.Desconto.Text = "Desconto";
            this.Desconto.Width = 72;
            // 
            // Adicional
            // 
            this.Adicional.Text = "Adicional";
            this.Adicional.Width = 72;
            // 
            // SalarioLiquido
            // 
            this.SalarioLiquido.Text = "Salário Líquido";
            this.SalarioLiquido.Width = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adicional:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Salário Líquido:";
            // 
            // boxNome
            // 
            this.boxNome.Location = new System.Drawing.Point(148, 16);
            this.boxNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(178, 20);
            this.boxNome.TabIndex = 1;
            // 
            // boxAdicional
            // 
            this.boxAdicional.Location = new System.Drawing.Point(148, 120);
            this.boxAdicional.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxAdicional.Mask = "000000000000000.00";
            this.boxAdicional.Name = "boxAdicional";
            this.boxAdicional.Size = new System.Drawing.Size(178, 20);
            this.boxAdicional.TabIndex = 6;
            // 
            // boxDesconto
            // 
            this.boxDesconto.Location = new System.Drawing.Point(148, 94);
            this.boxDesconto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxDesconto.Mask = "000000000000000.00";
            this.boxDesconto.Name = "boxDesconto";
            this.boxDesconto.Size = new System.Drawing.Size(178, 20);
            this.boxDesconto.TabIndex = 4;
            // 
            // boxSalarioBruto
            // 
            this.boxSalarioBruto.Location = new System.Drawing.Point(148, 68);
            this.boxSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxSalarioBruto.Mask = "000000000000000.00";
            this.boxSalarioBruto.Name = "boxSalarioBruto";
            this.boxSalarioBruto.Size = new System.Drawing.Size(178, 20);
            this.boxSalarioBruto.TabIndex = 3;
            // 
            // boxSalarioLiquido
            // 
            this.boxSalarioLiquido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boxSalarioLiquido.Enabled = false;
            this.boxSalarioLiquido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boxSalarioLiquido.Location = new System.Drawing.Point(148, 193);
            this.boxSalarioLiquido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxSalarioLiquido.Name = "boxSalarioLiquido";
            this.boxSalarioLiquido.Size = new System.Drawing.Size(178, 20);
            this.boxSalarioLiquido.TabIndex = 11;
            this.boxSalarioLiquido.TabStop = false;
            // 
            // boxCpf
            // 
            this.boxCpf.Location = new System.Drawing.Point(148, 42);
            this.boxCpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxCpf.Mask = "000.000.000-00";
            this.boxCpf.Name = "boxCpf";
            this.boxCpf.Size = new System.Drawing.Size(178, 20);
            this.boxCpf.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "CPF:";
            // 
            // checkDesconto
            // 
            this.checkDesconto.AutoSize = true;
            this.checkDesconto.Location = new System.Drawing.Point(344, 96);
            this.checkDesconto.Name = "checkDesconto";
            this.checkDesconto.Size = new System.Drawing.Size(94, 17);
            this.checkDesconto.TabIndex = 5;
            this.checkDesconto.Text = "Sem desconto";
            this.checkDesconto.UseVisualStyleBackColor = true;
            this.checkDesconto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkDesconto_MouseClick);
            // 
            // checkAdicional
            // 
            this.checkAdicional.AutoSize = true;
            this.checkAdicional.Location = new System.Drawing.Point(344, 122);
            this.checkAdicional.Name = "checkAdicional";
            this.checkAdicional.Size = new System.Drawing.Size(92, 17);
            this.checkAdicional.TabIndex = 7;
            this.checkAdicional.Text = "Sem adicional";
            this.checkAdicional.UseVisualStyleBackColor = true;
            this.checkAdicional.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkAdicional_MouseClick);
            // 
            // BotaoLimpar
            // 
            this.BotaoLimpar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BotaoLimpar.Location = new System.Drawing.Point(543, 110);
            this.BotaoLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BotaoLimpar.Name = "BotaoLimpar";
            this.BotaoLimpar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotaoLimpar.Size = new System.Drawing.Size(76, 23);
            this.BotaoLimpar.TabIndex = 9;
            this.BotaoLimpar.Text = "Limpar";
            this.BotaoLimpar.UseVisualStyleBackColor = true;
            this.BotaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.Location = new System.Drawing.Point(543, 68);
            this.BotaoExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(76, 23);
            this.BotaoExcluir.TabIndex = 8;
            this.BotaoExcluir.Text = "Excluir";
            this.BotaoExcluir.UseVisualStyleBackColor = true;
            this.BotaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(625, 29);
            this.boxId.Mask = "0000";
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(31, 20);
            this.boxId.TabIndex = 19;
            this.boxId.Visible = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(395, 32);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(224, 13);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "Informe o ID do funcionário que será excluido:";
            this.lbId.Visible = false;
            // 
            // FormularioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(720, 431);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.BotaoExcluir);
            this.Controls.Add(this.BotaoLimpar);
            this.Controls.Add(this.checkAdicional);
            this.Controls.Add(this.checkDesconto);
            this.Controls.Add(this.boxCpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxSalarioLiquido);
            this.Controls.Add(this.boxSalarioBruto);
            this.Controls.Add(this.boxDesconto);
            this.Controls.Add(this.boxAdicional);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaFuncionarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoSalvar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ListaFuncionarios;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox boxNome;
        private System.Windows.Forms.MaskedTextBox boxAdicional;
        private System.Windows.Forms.MaskedTextBox boxDesconto;
        private System.Windows.Forms.MaskedTextBox boxSalarioBruto;
        private System.Windows.Forms.MaskedTextBox boxSalarioLiquido;
        private System.Windows.Forms.ColumnHeader SalarioBruto;
        private System.Windows.Forms.ColumnHeader Desconto;
        private System.Windows.Forms.ColumnHeader Adicional;
        private System.Windows.Forms.ColumnHeader SalarioLiquido;
        private System.Windows.Forms.MaskedTextBox boxCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkDesconto;
        private System.Windows.Forms.CheckBox checkAdicional;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button BotaoLimpar;
        private System.Windows.Forms.Button BotaoExcluir;
        private System.Windows.Forms.MaskedTextBox boxId;
        private System.Windows.Forms.Label lbId;
    }
}

