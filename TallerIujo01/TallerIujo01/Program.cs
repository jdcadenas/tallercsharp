/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 17/4/2026
 * Time: 10:53 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TallerIujo01
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("===Taller 01 ===");
			
			// 1. El dato del usuario
			string registroUsuario = "    ID_777;   EVALUACION; 95";
			
			Console.WriteLine(registroUsuario);
			string registroLimpio = registroUsuario.Trim();
			Console.WriteLine(registroLimpio);
			
			string[] partes = registroLimpio.Split(';');
			string id = partes[0].Trim();
			string nombre = partes[1].Trim();
			string nota = partes[2].Trim();
			
			Console.WriteLine(string.Format("el id es: {0} del usuario {1} con la nota {2}",id,nombre, nota));
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}