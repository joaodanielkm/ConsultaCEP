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

        public void btnBuscar_Click(object sender, EventArgs e)
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
                        txbCEP.BackColor = Color.FromArgb(255, 160, 160);
                        this.button2_Click(null, null);
                    }
                }
            } else
            {
                txbCEP.BackColor = Color.FromArgb(255, 160, 160);
                MessageBox.Show("Favor informe um CEP valido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.button2_Click(null, null);
                return;
            }
            txbCEP.Focus();
            txbCEP.SelectAll();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            txbCEP.Text = String.Empty;
            txbEstado.Text = String.Empty;
            txbCidade.Text =String.Empty;
            txbBairro.Text = String.Empty;
            txblogradouro.Text = String.Empty;
            txbCEP.BackColor = Color.White;
            txbCEP.Focus();
        }

        private void txbCEP_Click(object sender, EventArgs e)
        {
            txbCEP.SelectAll();
        }

        private void txbCidade_MouseClick(object sender, MouseEventArgs e)
        {
            txbCidade.SelectAll();
        }

        private void txbEstado_MouseClick(object sender, MouseEventArgs e)
        {
            txbEstado.SelectAll();
        }

        private void txbBairro_MouseClick(object sender, MouseEventArgs e)
        {
            txbBairro.SelectAll();
        }

        private void txblogradouro_MouseClick(object sender, MouseEventArgs e)
        {
            txblogradouro.SelectAll();
        }

        private void txbCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //this.btnBuscar_Click(sender, e);
                btnBuscar.Focus();
            }
        }

        private void txbCEP_TextChanged(object sender, EventArgs e)
        {
            txbCEP.BackColor = Color.White;
        }
    }
}
