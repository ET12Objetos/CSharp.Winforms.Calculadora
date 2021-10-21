using Calculadora.Core;
using System;
using System.Windows.Forms;

namespace Calculadora.UI
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboFiguras.SelectedIndex = -1;
            txtValorA.Clear();
            txtValorB.Clear();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            cboFiguras.Items.Clear();
            cboFiguras.Items.Add("Circunferencia");
            cboFiguras.Items.Add("Triangulo");
            cboFiguras.Items.Add("Cuadrado");

            //Combobox solo lectura
            cboFiguras.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblArea.Visible = false;
            lblPerimetro.Visible = false;
            txtArea.Visible = false;
            txtPerimetro.Visible = false;
            txtValorA.Clear();
            txtValorB.Clear();

            switch (cboFiguras.SelectedIndex)
            {
                case 0:
                    lblValorA.Text = "Radio";
                    lblValorA.Visible = true;
                    txtValorA.Visible = true;                   
                    lblValorB.Visible = false;
                    txtValorB.Visible = false;
                    break; 
                case 1:
                    lblValorA.Text = "Base";
                    lblValorA.Visible = true;
                    txtValorA.Visible = true;
                    lblValorB.Text = "Altura";
                    lblValorB.Visible = true;
                    txtValorB.Visible = true;
                    break; 
                case 2:
                    lblValorA.Text = "Lado";
                    lblValorA.Visible = true;
                    txtValorA.Visible = true;
                    lblValorB.Visible = false;
                    txtValorB.Visible = false;
                    break; 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_HacerClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorA.Text) || string.IsNullOrEmpty(txtValorB.Text))
            { 
                MessageBox.Show("Ingrese valores correctos de la figura");
                return; 
            }
           
            lblArea.Visible = true;
            lblPerimetro.Visible = true;
            txtArea.Visible = true;
            txtPerimetro.Visible = true;

            switch(cboFiguras.SelectedIndex)
            {
                case 0: 
                    Circunferencia circunferencia = new Circunferencia();
                    circunferencia.radio = Convert.ToDouble(txtValorA.Text);
                    txtArea.Text = circunferencia.CalcularArea().ToString("0.00");
                    txtPerimetro.Text = circunferencia.CalcularPerimetro().ToString("0.00");
                    break;
                case 1:
                    Triangulo triangulo = new Triangulo();
                    triangulo.altura = Convert.ToDouble(txtValorA.Text);
                    triangulo.Base = Convert.ToDouble(txtValorB.Text);
                    txtArea.Text = triangulo.CalcularArea().ToString("0.00");
                    txtPerimetro.Text = triangulo.CalcularPerimetro().ToString("0.00");
                    break;
                case 2:
                    Cuadrado cuadrado = new Cuadrado();
                    cuadrado.lado = Convert.ToDouble(txtValorA.Text);
                    txtArea.Text = cuadrado.CalcularArea().ToString("0.00");
                    txtPerimetro.Text = cuadrado.CalcularPerimetro().ToString("0.00");
                    break;
            }
        }
    }
}
