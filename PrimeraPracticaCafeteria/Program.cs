using PracticaCafeteria;

namespace PrimeraPracticaCafeteria
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Bebida[] bebidas = new Bebida[3];

			string nombre, tamaño;
			double precio;
			// ciclo para pedir los datos de la bebida 
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"\nIngrese nombre de la bebida {i}:");
				nombre = Console.ReadLine();

				Console.WriteLine("Ingrese tamaño:");
				tamaño = Console.ReadLine();

				Console.WriteLine("Ingrese precio:");
				precio = Convert.ToDouble(Console.ReadLine());

				bebidas[i] = new Bebida(nombre, tamaño, precio);
			}
			//llamar a metodo para aplicar descuento 
			bebidas[0].AplicarDescuento(10);
			bebidas[1].AplicarDescuento(10);
			bebidas[2].AplicarDescuento(10);

			// cilo para llamar al metodo preparar de cada bebida
			Console.WriteLine("\nPreparación\n");


			for (int i = 0; i < 3; i++)
			{
				bebidas[i].Preparar();
			}

			// ciclo para llamar al metodo mostrar descripcion de cada bebida
			Console.WriteLine("\nDescripción\n");

			for (int i = 0; i < 3; i++)
			{
				bebidas[i].MostrarDescripcion();
			}
		}
	}
}
