using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Evaluacion:#3
// Ejercicio:
// Fecha: /5/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #12
// Instructora: Lizeth Carmeline Gochez De Peñate

namespace GM21057Eva3
{
	//Descripcion del programa:
	//La empresa automotriz Intromática tiene cinco agencias y cuenta con la información acerca de las ventas mensuales de automóviles
	//logradas el año pasado por cada una de éstas. A partir de estos datos la empresa construyó la siguiente tabla de “ventas mensuales por agencia”:

	class Program
	{
		public static void Main(string[] args)
		{
			//Identificacion del programa en pantalla
			Console.Title = ("Ventas mensuales por agencia");
			Console.WriteLine("Ventas mensuales por agencia ");
			Console.WriteLine("Autor:Brandon Gomez");

			//DECLARACION DE VARIABLES
			double ventasEnero, ventasFebrero, ventasMarzo, ventasAbril, ventasMayo, ventasJunio, ventasJulio, ventasAgosto, ventasSeptiembre, ventasOctubre, ventasNoviembre, ventasDiciembre;
			string agenciaMayorVentaMayo,mesMenorVenta;

			int[] agenciaRabida = { 10, 12, 14, 6, 7, 13, 12, 8, 10, 13, 7, 16 };
			int[] agenciaUniversitaria = { 9, 2, 4, 6, 10, 11, 20, 17, 14, 15, 4, 6 };
			int[] agenciaMetro = { 10, 14, 15, 12, 16, 11, 12, 5, 13, 13, 5, 20 };
			int[] agenciaGalerias = { 7, 18, 8, 3, 9, 16, 17, 21, 30, 15, 17, 8 };
			int[] agenciaMerliot = { 4, 6, 16, 7, 9, 15, 11, 18, 17, 23, 21, 25 };

			//ENTRADA DE DATOS
			int[,] totalVentas = { {10, 12, 14, 6, 7, 13, 12, 8, 10, 13, 7, 16 },
								  { 9, 2, 4, 6, 10, 11, 20, 17, 14, 15, 4, 6 },
								  { 10, 14, 15, 12, 16, 11, 12, 5, 13, 13, 5,20},
								  { 7, 18, 8, 3, 9, 16, 17, 21, 30, 15, 17, 8 },
								  { 4, 6, 16, 7, 9, 15, 11, 18, 17, 23, 21, 25 } };
		
			//PROCESO DE DATOS
			ventasEnero = totalVentas[0, 0] + totalVentas[1, 0] + totalVentas[2, 0] + totalVentas[3, 0] + totalVentas[4, 0];
			ventasFebrero = totalVentas[0, 1] + totalVentas[1, 1] + totalVentas[2, 1] + totalVentas[3, 1] + totalVentas[4, 1];
			ventasMarzo = totalVentas[0, 2] + totalVentas[1, 2] + totalVentas[2, 2] + totalVentas[3, 2] + totalVentas[4, 2];
			ventasAbril = totalVentas[0, 3] + totalVentas[1, 3] + totalVentas[2, 3] + totalVentas[3, 3] + totalVentas[4, 3];
			ventasMayo = totalVentas[0, 4] + totalVentas[1, 4] + totalVentas[2, 4] + totalVentas[3, 4] + totalVentas[4, 4];
			ventasJunio = totalVentas[0, 5] + totalVentas[1, 5] + totalVentas[2, 5] + totalVentas[3, 5] + totalVentas[4, 5];
			ventasJulio = totalVentas[0, 6] + totalVentas[1, 6] + totalVentas[2, 6] + totalVentas[3, 6] + totalVentas[4, 6];
			ventasAgosto = totalVentas[0, 7] + totalVentas[1, 7] + totalVentas[2, 7] + totalVentas[3, 7] + totalVentas[4, 7];
			ventasSeptiembre = totalVentas[0, 8] + totalVentas[1, 9] + totalVentas[2, 8] + totalVentas[3, 8] + totalVentas[4, 8];
			ventasOctubre = totalVentas[0, 9] + totalVentas[1, 9] + totalVentas[2, 9] + totalVentas[3, 9] + totalVentas[4, 9];
			ventasNoviembre = totalVentas[0, 10] + totalVentas[1, 10] + totalVentas[2, 10] + totalVentas[3, 10] + totalVentas[4, 10];
			ventasDiciembre = totalVentas[0, 11] + totalVentas[1, 11] + totalVentas[2, 11] + totalVentas[3, 11] + totalVentas[4, 11];
			agenciaMayorVentaMayo = AgenciaMayorVentaMayo(agenciaRabida, agenciaUniversitaria,agenciaMetro,agenciaGalerias,agenciaMerliot);
			mesMenorVenta = MesMenorVenta(ventasEnero, ventasFebrero, ventasMarzo, ventasAbril, ventasMayo, ventasJunio, ventasJulio, ventasAgosto, ventasSeptiembre, ventasOctubre, ventasNoviembre, ventasDiciembre);

			//SALIDA DE DATOS
			Imprimir(agenciaMetro,ventasDiciembre, agenciaMayorVentaMayo,mesMenorVenta);
			Console.ReadKey();
		
			//PROCESO DE DATOS
			static void Imprimir(int[] agenciaMetro, double ventasDiciembre, string agenciaMayorVentaMayo, string mesMenorVenta)
			{
				int opc;
				double totalVentaMetro = 0, promVentasDiciembre;
				totalVentaMetro = agenciaMetro[0] + agenciaMetro[1] + agenciaMetro[2] + agenciaMetro[3] + agenciaMetro[4] + agenciaMetro[5] + agenciaMetro[6] + agenciaMetro[7] + agenciaMetro[8] + agenciaMetro[9] + agenciaMetro[10] + agenciaMetro[11];
				promVentasDiciembre = ventasDiciembre / 5;
				Console.WriteLine("1= Total venta en agencia metro; 2= Promedio de venta mes de diciembre; 3=Agencia con mayor venta en el mes de mayo; 4=Mes con menor venta de la empresa; 5= todas las opciones, ");
				Console.WriteLine("Ingrese la opcion que requiera:"); opc = int.Parse(Console.ReadLine());


				switch (opc)
				{
					case 1:
						Console.WriteLine("Total venta de auto es en agencia metro:" + totalVentaMetro);
						break;
					case 2:
						Console.WriteLine("Promedio de venta en mes de diciembre:" + promVentasDiciembre);
						break;

					case 3:
						Console.WriteLine("La agencia con mayor venta en mes de mayo:" + agenciaMayorVentaMayo);
						break;
					case 4:
						Console.WriteLine("El mes con menos ventas de la empresa:" + mesMenorVenta);
						break;
					case 5:
						Console.WriteLine("Total venta de auto es en agencia metro:    " + totalVentaMetro);
						Console.WriteLine("Promedio de venta en mes de diciembre:" + promVentasDiciembre);
						Console.WriteLine("La agencia con mayor venta en mes de mayo:" + agenciaMayorVentaMayo);
						Console.WriteLine("El mes con menos ventas de la empresa:" + mesMenorVenta);

						break;

				}
			
				
			}
			//PROCESO DE DATOS
			static string AgenciaMayorVentaMayo(int[] agenciaRabida, int[] agenciaUniversitaria, int[] agenciaMetro, int[] agenciaGalerias, int[] agenciaMerliot)
			{
				string agenciaMayorVentaMayo=" ";
                if (agenciaRabida[4] > agenciaUniversitaria[4] && agenciaRabida[4] > agenciaMetro[4] && agenciaRabida[4] > agenciaGalerias[4] && agenciaRabida[4] > agenciaMerliot[4])
                {
					agenciaMayorVentaMayo = "Agencia Rabida";
                }
				if (agenciaUniversitaria[4] > agenciaRabida[4] && agenciaUniversitaria[4] > agenciaMetro[4] && agenciaUniversitaria[4] > agenciaGalerias[4] && agenciaUniversitaria[4] > agenciaMerliot[4])
				{
					agenciaMayorVentaMayo = "Agencia Universitaria";
				}
				if (agenciaMetro[4] > agenciaUniversitaria[4] && agenciaMetro[4] > agenciaRabida[4] && agenciaMetro[4] > agenciaGalerias[4] && agenciaMetro[4] > agenciaMerliot[4])
				{
					agenciaMayorVentaMayo = "Agencia Metro";
				}
				if (agenciaGalerias[4] > agenciaUniversitaria[4] && agenciaGalerias[4] > agenciaMetro[4] && agenciaGalerias[4] > agenciaRabida[4] && agenciaGalerias[4] > agenciaMerliot[4])
				{
					agenciaMayorVentaMayo = "Agencia Galerias";
				}
				if (agenciaMerliot[4] > agenciaUniversitaria[4] && agenciaMerliot[4] > agenciaMetro[4] && agenciaMerliot[4] > agenciaRabida[4] && agenciaMerliot[4] > agenciaGalerias[4])
				{
					agenciaMayorVentaMayo = "Agencia Merliot ";
				}
				return agenciaMayorVentaMayo;

			}

			//PROCESO DE DATOS
			static string MesMenorVenta(double ventasEnero, double ventasFebrero, double ventasMarzo, double ventasAbril, double ventasMayo, double ventasJunio, double ventasJulio, double ventasAgosto, double ventasSeptiembre, double ventasOctubre, double ventasNoviembre, double ventasDiciembre)
			{
				string mesMenorVentas="";

                if (ventasEnero < ventasFebrero && ventasEnero < ventasMarzo && ventasEnero < ventasAbril && ventasEnero < ventasMayo && ventasEnero < ventasJunio && ventasEnero < ventasJulio && ventasEnero < ventasAgosto && ventasEnero < ventasSeptiembre && ventasEnero < ventasOctubre && ventasEnero < ventasNoviembre && ventasEnero < ventasDiciembre)
                {
					mesMenorVentas = "Mes de enero ";
                }
				if (ventasFebrero < ventasEnero  && ventasFebrero < ventasMarzo && ventasFebrero < ventasAbril && ventasFebrero < ventasMayo && ventasFebrero < ventasJunio && ventasFebrero < ventasJulio && ventasFebrero < ventasAgosto && ventasFebrero < ventasSeptiembre && ventasFebrero < ventasOctubre && ventasFebrero < ventasNoviembre && ventasFebrero < ventasDiciembre)
				{
					mesMenorVentas = "Mes de febrero ";
				}
				if (ventasMarzo < ventasFebrero && ventasMarzo < ventasEnero && ventasMarzo < ventasAbril && ventasMarzo < ventasMayo && ventasMarzo < ventasJunio && ventasMarzo < ventasJulio && ventasMarzo < ventasAgosto && ventasMarzo < ventasSeptiembre && ventasMarzo < ventasOctubre && ventasMarzo < ventasNoviembre && ventasMarzo < ventasDiciembre)
				{
					mesMenorVentas = "Mes de marzo";
				}
				if (ventasAbril < ventasFebrero && ventasAbril < ventasMarzo && ventasAbril < ventasEnero && ventasAbril < ventasMayo && ventasAbril < ventasJunio && ventasAbril < ventasJulio && ventasAbril < ventasAgosto && ventasAbril < ventasSeptiembre && ventasAbril < ventasOctubre && ventasAbril < ventasNoviembre && ventasAbril < ventasDiciembre)
				{
					mesMenorVentas = "Mes de abril";
				}
				if (ventasMayo < ventasFebrero && ventasMayo < ventasMarzo && ventasMayo < ventasAbril && ventasMayo < ventasEnero && ventasMayo < ventasJunio && ventasMayo < ventasJulio && ventasMayo < ventasAgosto && ventasMayo < ventasSeptiembre && ventasMayo < ventasOctubre && ventasMayo < ventasNoviembre && ventasMayo < ventasDiciembre)
					{
					mesMenorVentas = "Mes de mayo";
				}
				if (ventasJunio < ventasFebrero && ventasJunio < ventasMarzo && ventasJunio < ventasAbril && ventasJunio < ventasMayo && ventasJunio < ventasEnero &&  ventasJunio < ventasJulio && ventasJunio < ventasAgosto && ventasJunio < ventasSeptiembre && ventasJunio < ventasOctubre && ventasJunio < ventasNoviembre && ventasJunio < ventasDiciembre)
					{
					mesMenorVentas = "Mes de junio";
				}
				if (ventasJulio < ventasFebrero && ventasJulio < ventasMarzo && ventasJulio < ventasAbril && ventasJulio < ventasMayo && ventasJulio < ventasJunio && ventasJulio < ventasEnero &&  ventasJulio < ventasAgosto && ventasJulio < ventasSeptiembre && ventasJulio < ventasOctubre && ventasJulio < ventasNoviembre && ventasJulio < ventasDiciembre)
					{
					mesMenorVentas = "Mes de julio ";
				}
				if (ventasAgosto < ventasFebrero && ventasAgosto < ventasMarzo && ventasAgosto < ventasAbril && ventasAgosto < ventasMayo && ventasAgosto < ventasJunio && ventasAgosto < ventasJulio && ventasAgosto < ventasEnero && ventasAgosto < ventasSeptiembre && ventasAgosto < ventasOctubre && ventasAgosto < ventasNoviembre && ventasAgosto < ventasDiciembre)
					{
					mesMenorVentas = "Mes de agosto";
				}
				if (ventasSeptiembre < ventasFebrero && ventasSeptiembre < ventasMarzo && ventasSeptiembre < ventasAbril && ventasSeptiembre < ventasMayo && ventasSeptiembre < ventasJunio && ventasSeptiembre < ventasJulio && ventasSeptiembre < ventasAgosto && ventasSeptiembre < ventasEnero && ventasSeptiembre < ventasOctubre && ventasSeptiembre < ventasNoviembre && ventasSeptiembre < ventasDiciembre)
					{
					mesMenorVentas = "Mes de septiembre";
				}
				if (ventasOctubre < ventasFebrero && ventasOctubre < ventasMarzo && ventasOctubre < ventasAbril && ventasOctubre < ventasMayo && ventasOctubre < ventasJunio && ventasOctubre < ventasJulio && ventasOctubre < ventasAgosto && ventasOctubre < ventasSeptiembre && ventasOctubre < ventasEnero && ventasOctubre < ventasNoviembre && ventasOctubre < ventasDiciembre)
					{
					mesMenorVentas = "Mes de octubre";
				}
				if (ventasNoviembre < ventasFebrero && ventasNoviembre < ventasMarzo && ventasNoviembre < ventasAbril && ventasNoviembre < ventasMayo && ventasNoviembre < ventasJunio && ventasNoviembre < ventasJulio && ventasNoviembre < ventasAgosto && ventasNoviembre < ventasSeptiembre && ventasNoviembre < ventasOctubre && ventasNoviembre < ventasEnero && ventasNoviembre < ventasDiciembre)
					{
					mesMenorVentas = "Mes de noviembre";
				}
				if (ventasDiciembre < ventasFebrero && ventasDiciembre < ventasMarzo && ventasDiciembre < ventasAbril && ventasDiciembre < ventasMayo && ventasDiciembre < ventasJunio && ventasDiciembre < ventasJulio && ventasDiciembre < ventasAgosto && ventasDiciembre < ventasSeptiembre && ventasDiciembre < ventasOctubre && ventasDiciembre < ventasNoviembre && ventasDiciembre < ventasEnero)
					{
					mesMenorVentas = "Mes de diciembre";
				}
					return mesMenorVentas;			
			}


		}
	}
}
