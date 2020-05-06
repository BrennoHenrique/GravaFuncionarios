using System;
using Aula_POO_04_05_2020.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_POO_04_05_2020
{
    public partial class FormularioInicial : Form
    {
        private List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        public FormularioInicial()
        {
            InitializeComponent();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerificaCPF() && boxCpf.Text.Length == 14 && boxNome.Text != string.Empty)
                {
                    try { double.Parse(boxSalarioBruto.Text); }
                    catch { boxSalarioBruto.Text = "0"; }

                    try { double.Parse(boxDesconto.Text); }
                    catch { boxDesconto.Text = "0"; }

                    try { double.Parse(boxAdicional.Text); }
                    catch { boxAdicional.Text = "0"; }

                    Funcionarios.Add(new Funcionario(ReturnId(),
                                       boxNome.Text.ToUpper(),
                                       boxCpf.Text,
                                       double.Parse(boxSalarioBruto.Text),
                                       double.Parse(boxDesconto.Text),
                                       double.Parse(boxAdicional.Text)));

                    var indiceAux = Funcionarios.Count == 0 ? 0 : Funcionarios.Count - 1;

                    ListViewItem item = new ListViewItem(new[] {
                            Funcionarios[indiceAux].ID.ToString(),
                            Funcionarios[indiceAux].Nome,
                            Funcionarios[indiceAux].CPF,
                            Funcionarios[indiceAux].SalarioBruto.ToString("C"),
                            Funcionarios[indiceAux].Desconto.ToString("C"),
                            Funcionarios[indiceAux].Adicional.ToString("C"),
                            Funcionarios[indiceAux].SalarioLiquido.ToString("C")}); ;

                    boxSalarioLiquido.Text = Funcionarios[indiceAux].SalarioLiquido.ToString("C");

                    if (Funcionarios[indiceAux].Nome != string.Empty)
                        ListaFuncionarios.Items.Add(item);
                    else
                    {
                        MessageBox.Show("Preencha o campo 'nome'!", "Atenção",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                        Funcionarios.RemoveAt(indiceAux);
                    }
                }
                else
                    MessageBox.Show("CPF inválido ou já existi!", "ERROR",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "ERROR", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void checkDesconto_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkDesconto.Checked)
            {
                boxDesconto.Visible = false;
                boxDesconto.Text = "000000000000000.00";
            }
            else
            {
                boxDesconto.Visible = true;
                boxDesconto.Text = string.Empty;
            }
        }

        private void checkAdicional_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkAdicional.Checked)
            {
                boxAdicional.Visible = false;
                boxAdicional.Text = "000000000000000.00";
            }
            else
            {
                boxAdicional.Visible = true;
                boxAdicional.Text = string.Empty;
            }
        }

        

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            boxNome.Text = string.Empty;
            boxCpf.Text = string.Empty;
            boxSalarioBruto.Text = string.Empty;
            boxDesconto.Text = string.Empty;
            boxAdicional.Text = string.Empty;
            boxSalarioLiquido.Text = string.Empty;

            boxNome.Focus();
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            if (boxId.Visible == false)
            {
                boxId.Text = string.Empty;

                boxId.Visible = true;
                lbId.Visible = true;

                boxId.Focus();
            }
            else
            {
                try { int.Parse(boxId.Text); }
                catch { boxId.Text = "0000"; }

                if (VerificaId(int.Parse(boxId.Text)) != -1)
                {
                    DialogResult cond = MessageBox.Show("Tem certeza?", "ATENÇÃO!",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (cond == DialogResult.Yes)
                    {
                        ListaFuncionarios.Items.RemoveAt(VerificaId(int.Parse(boxId.Text)));
                        Funcionarios.RemoveAt(VerificaId(int.Parse(boxId.Text)));
                    }
                }
                else
                    MessageBox.Show("ID informado não encontrado!", "ERROR",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);

                boxId.Visible = false;
                lbId.Visible = false;

                boxNome.Focus();
            }
        }

        private int VerificaId(int id)
        {
            for (int contador = 0; contador < Funcionarios.Count; contador++)
                if (Funcionarios[contador].ID == id)
                    return contador;
            return -1;
        }

        private bool VerificaCPF()
        {
            for (int contador = 0; contador < Funcionarios.Count; contador++)
                if (boxCpf.Text == Funcionarios[contador].CPF)
                    return true;
            return false;
        }

        private int ReturnId()
        {
            int num = 1000;
            for (int contador = 0; contador < Funcionarios.Count; contador++)
                if (Funcionarios[contador].ID == num)
                    num++;
            return num;
        }
    }
}
