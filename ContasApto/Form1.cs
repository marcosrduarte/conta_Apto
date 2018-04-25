using System;
using System.Windows.Forms;
using System.Globalization;


namespace ContasApto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        // RECEBE OS VALORES DAS VARIÁVEIS QUE O USUÁRIO INSERIU
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double aluguel, condominio, energia, gas, net, outros;
            double total, pessoa, qtdMoradores;

            // verificar se algum campo está vazio
            if ((txtOutros.Text == "") || (txtAluguel.Text == "") || (txtCondominio.Text == "") || (txtEnergia.Text == "") || (txtGas.Text == "") ||
                (txtNet.Text == "")||(cmbMoradores.Text == "") || (cmbMoradores.Text == null))
            {
                MessageBox.Show(" Verifique se todos os campos estão preenchidos ");
            }
            else
            {
                aluguel = Convert.ToDouble(txtAluguel.Text);
                condominio = Convert.ToDouble(txtCondominio.Text);
                energia = Convert.ToDouble(txtEnergia.Text);
                gas = Convert.ToDouble(txtGas.Text);
                net = Convert.ToDouble(txtNet.Text);
                outros = Convert.ToDouble(txtOutros.Text);
                qtdMoradores = Convert.ToDouble(cmbMoradores.Text);
                

                // FAZ O CÁLCULO DO RATEIO DAS DESPESAS E MOSTRA PARA O USUÁRIO
                total = aluguel + condominio + energia + gas + net + outros;

                pessoa = total / qtdMoradores;            

                MessageBox.Show((" Total das despesas - R$ " + total.ToString("N2") + " - Total por pessoa ("+(qtdMoradores)+")  - R$ " + pessoa.ToString("N2")));

            }
        }
        // LIMPA OS CAMPOS PARA NOVA ENTRADA DE DADOS
        private void apagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtAluguel.Text = "";
            txtCondominio.Text = "";
            txtEnergia.Text = "";
            txtGas.Text = "";
            txtNet.Text = "";
            txtOutros.Text = "";
            cmbMoradores.Text = null;
         }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Desenvolvido por Marcos Duarte, graduando em ADS pela UNIP Sorocaba ");
        }

        private void sobreOAplicativoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Versão Beta 1.0 - Aplicativo em contínuo desenvolvimento ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
        }
    }
}
