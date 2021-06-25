using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            DateTime fechaingresada = dtpFechaNac.Value;
            int FechaNac;
            int FechaHoy;
            int edad;
            int hoy = DateTime.Now.Year;
            int Antiguedad;
            decimal  Salario= Convert.ToInt32(txtSalario.Text);
            FechaNac = fechaingresada.Year;
            FechaHoy = hoy;
            edad = FechaHoy - FechaNac;
            Antiguedad = Convert.ToInt32(txtAntiguedad.Text); 
            if (Convert.ToInt32(txtVentas.Text) >= 10000)
            {
                if (edad>=30)
                {
                    if(Antiguedad >= 10)
                    {
                        Salario = Salario *(decimal ) .05;
                        Salario = Salario + Convert.ToInt32(txtSalario .Text);
                        MessageBox.Show($"Su nuevo salario es: { Salario  }");
                       
                    }
                    else
                    { MessageBox.Show("Ud no cumple los resquisitos para el aumento de salario");
                    }
                }
                else
                {
                    MessageBox.Show("Ud no cumple los resquisitos para el aumento de salario");

                }
            }
            else
            {
                MessageBox.Show("Ud no cumple los resquisitos para el aumento de salario");

            }

        }

        
    



        





    }
}
