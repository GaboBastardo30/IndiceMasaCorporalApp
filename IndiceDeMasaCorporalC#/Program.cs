using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace IndiceDeMasaCorporalC
{
	class Program
	{
		public static void Main (string[] args)
		{
			// VARIABLES
			int peso;
			string nombre;
			Double altura;
			Double imc;
			int posIndiceMasaCorporal;

			// BIENVENIDA
			Console.WriteLine("Calculador de IMC (Indice de Masa Corporal) v1 \n");
			Console.WriteLine("Presione cualquier letra para continuar"); 
			Console.ReadKey();
			Console.Clear(); 


			// ALMACENANDO DATOS
			Console.WriteLine("¿Cual es tu nombre?"); 
			nombre = Convert.ToString(Console.ReadLine()); 
			Console.Clear();

			Console.WriteLine( "Mucho gusto " + nombre + ", Escriba su peso en kg para proceder:"); 
			peso = Convert.ToInt16(Console.ReadLine());
			Console.Clear();

			Console.WriteLine("Ahora ingrese su altura en centimetros \"Ejemplo: 154\":"); 
			altura = Convert.ToInt16(Console.ReadLine()); 
			Console.Clear();


			// AQUI EJECUTAMOS LA FORMULA MATEMATICA
			imc = Convert.ToDouble(peso / (altura/100 * altura/100)); // El resultado final
			posIndiceMasaCorporal = Convert.ToInt16(imc);

			// INICIAN LAS CONDICIONES
			if (imc > 50) 
			{
				Console.WriteLine ("Malisimas noticias " + nombre + "!, Padeces de obesidad nivel IV, " + "Tu salud está en un riesgo extremadamente alto\n");
				Console.WriteLine ("Tu Indice de Masa Corporal dio como resultado: " + posIndiceMasaCorporal);
				Console.WriteLine ("Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal) v1");
				Console.WriteLine ("Presiona cualquier letra para salir");
				Console.ReadKey ();
			} 

			else if (imc > 40 && imc < 50) 
			{
				Console.WriteLine ("Mala noticia " + nombre + "!, Padeces de obesidad nivel III, Tu salud está en un riesgo es muy alto\n");
				Console.WriteLine ("Tu Indice de Masa Corporal dio como resultado: " + posIndiceMasaCorporal);
				Console.WriteLine ("Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal) v1");
				Console.WriteLine ("Presiona cualquier letra para salir");
				Console.ReadKey ();
			} 

			else if (imc > 35 && imc < 40) 
			{
				Console.WriteLine ("Mala noticia " + nombre + ", Padeces de obesidad nivel II, Tu salud está en un riesgo es muy alto\n");
				Console.WriteLine ("Tu Indice de Masa Corporal dio como resultado: " + posIndiceMasaCorporal);
				Console.WriteLine ("Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal) v1");
				Console.WriteLine ("Presiona cualquier letra para salir");
				Console.ReadKey ();
			} 

			else if (imc > 30 && imc < 35) 
			{
				Console.WriteLine ("Mala noticia " + nombre + ", Padeces de sobrepeso nivel I, Tu salud está en riesgo\n");
				Console.WriteLine ("Tu Indice de Masa Corporal dio como resultado: " + posIndiceMasaCorporal);
				Console.WriteLine ("Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal) v1");
				Console.WriteLine ("Presiona cualquier letra para salir");
				Console.ReadKey ();
			} 

			else if (imc > 25 && imc < 30) 
			{
				Console.WriteLine ("Vaso medio lleno " + nombre + "!, Padeces de sobrepeso, Aunque si ejercitas y tienes una dieta balanceada puedes bajar a un peso normal :)\n");
				Console.WriteLine ("Tu Indice de Masa Corporal dio como resultado: " + posIndiceMasaCorporal);
				Console.WriteLine ("Gracias por utilizar la calculadora de IMC (Indice de Masa Corporal) v1");
				Console.WriteLine ("Presiona cualquier letra para salir");
				Console.ReadKey ();
			} 

			else if (imc > 18 && imc < 25) 
			{
				Console.WriteLine ("Buenas noticias " + nombre + "!, No corres ningun riesgo, Estás en el peso adecuado :)\n");
				Console.WriteLine ("Tu Indice de Masa Corporal dio como resultado: " + posIndiceMasaCorporal);
				Console.WriteLine ("Gracias por utilizar la calculadora de IMC");
				Console.WriteLine ("Presiona cualquier letra para salir");
				Console.ReadKey ();
			} 

			else if (imc < 18) 
			{
				Console.WriteLine ("Mala Noticia " + nombre + "!, Tu peso no es saludable, Estás muy delgado corres peligro de estar en desnutrición\n");
				Console.WriteLine ("Tu Indice de Masa Corporal dio como resultado: " + posIndiceMasaCorporal);
				Console.WriteLine ("Gracias por utilizar la calculadora de IMC");
				Console.WriteLine ("Presiona cualquier letra para salir");
				Console.ReadKey ();
			}

			else
			{
				Console.WriteLine("Algo paso mal, Por favor asegurate de seguir las instrucciones correctamente o agregar valores que sean lógicos\n");
				Console.WriteLine("Presiona cualquier letra para salir");
				Console.ReadKey();
			}
			// TERMINA EL PROGRAMA

		}
	}
}
	

