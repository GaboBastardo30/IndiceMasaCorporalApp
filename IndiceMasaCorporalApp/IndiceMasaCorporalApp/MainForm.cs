using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndiceMasaCorporalApp
{

	public partial class Prueba : Form
	{

		
		public Prueba()
		{
			InitializeComponent();
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			//LAS VARIABLES
			
			int peso;
		    Double altura;
		    Double imc;
		    Double imc2;
		    
		    //LOS CALCULOS
			
		    peso = Convert.ToInt32(txtPeso.Text);
		    altura = Convert.ToInt32(txtAltura.Text);
			
			Double.TryParse(txtAltura.Text, out altura);
			Int32.TryParse(txtPeso.Text, out peso);
			
			imc = Convert.ToDouble( peso/ (altura/100 * altura/100));
			imc2 = Convert.ToInt16(imc);
			
			//MOSTRANDO EL CALCULO EN LA TEXTBOX
			
			txtResultado.Text = imc2.ToString();
		}
		
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			//LIMPIANDO LOS TEXTBOXS Y HACIENDO FOCUS EN EL TEXTBOX DE ALTURA
			
			txtPeso.Clear();
			txtAltura.Clear();
			txtResultado.Clear();
			txtPeso.Focus();
		}
	}
}
