using System;
using System.Drawing;
using System.Windows.Forms;
using Correios;

namespace ConsultaCEP
{
    public partial class FrmConsultaCEP : Form
    {
        Processo.ProcessoCEP CEP = new Processo.ProcessoCEP();
        public FrmConsultaCEP()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(CEP.EhValidoCEP(txbCEP.Text)) {
                using (CorreiosApi correiosApi = new CorreiosApi())
                {
                    try
                    {
                        var endereco = correiosApi.consultaCEP(txbCEP.Text);
                        txbCidade.Text = endereco.cidade;
                        txbEstado.Text = endereco.uf;
                        txbBairro.Text = endereco.bairro;
                        txblogradouro.Text = endereco.end;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            } else
            {
                txbCEP.BackColor = Color.FromArgb(255, 95, 95);
                txbCEP.Focus();
                MessageBox.Show("Favor informe um CEP valido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbCEP.Text = String.Empty;
            txbEstado.Text = String.Empty;
            txbCidade.Text =String.Empty;
            txbBairro.Text = String.Empty;
            txblogradouro.Text = String.Empty;
            txbCEP.BackColor = Color.White;
            txbCEP.Focus();
        }

        private void txbBairro_TextChanged(object sender, EventArgs e)
        {
            txbBairro.SelectAll();
        }

        private void txblogradouro_TextChanged(object sender, EventArgs e)
        {
            txblogradouro.SelectAll();
        }

        private void txbEstado_TextChanged(object sender, EventArgs e)
        {
            txbEstado.SelectAll();
        }

        private void txbCidade_TextChanged(object sender, EventArgs e)
        {
            txbCidade.SelectAll();
        }

        private void txbCEP_Click(object sender, EventArgs e)
        {
            txbCEP.SelectAll();
        }
    }
}
