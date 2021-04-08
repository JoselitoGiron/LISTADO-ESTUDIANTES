using System;

namespace Program
{
    public class Programa{
        public static void Main(string[] args){
            Estudiante[] listaEstudiantes = new Estudiante[2];
            int contador = 0;
            while (contador < 2)
            {
                Console.WriteLine("INGRESE ESTUDIANTE");
                string nombre = Console.ReadLine();
//-------------------------------------------------------------------------------------------
                Console.WriteLine("INGRESE EDAD");
                int edad = Convert.ToInt32(Console.ReadLine());
//-------------------------------------------------------------------------------------------
                Console.WriteLine("INGRESE CARNET");
                string carnet = Console.ReadLine();
//-------------------------------------------------------------------------------------------
                Console.WriteLine("INGRESE SI ESTA SOLVENTE");
                Boolean solvente = Convert.ToBoolean(Console.ReadLine());
//-------------------------------------------------------------------------------------------
                Console.WriteLine("INGRESE CURSO");
                string curso = Console.ReadLine();
//-------------------------------------------------------------------------------------------                
                Console.WriteLine("INGRESE NOTAS DEL CURSO\nPRIMERA PARCIAL: ");
                int parcial1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("SEGUNDO PARCIAL: ");
                int parcial2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("EXAMEN FINAL: ");
                int Finalexamen = Convert.ToInt32(Console.ReadLine());
//-------------------------------------------------------------------------------------------
                Estudiante estudiante = new Estudiante(nombre, edad, carnet, solvente, curso, parcial1, parcial2, Finalexamen);
                listaEstudiantes[contador] = estudiante;
                contador++;
                Console.Clear();
            }
            Console.WriteLine("LISTA DE ESTUDIANTES");

            for (int i = 0; i < 2; i++)
            {
                Estudiante estudiante = listaEstudiantes[i];
                Console.WriteLine("Nombre del estudiante: "+ estudiante.nombre + "\nEdad: " + estudiante.edad + "\nCarnet: " + estudiante.carnet
                + "\nEstá solvente: " + estudiante.solvente + "\nCurso: " + estudiante.curso + "\nNOTAS\nPrimer Parcial: " + estudiante.parcial1
                + "\nSegundo Parcial: " + estudiante.parcial2 + "\nÉxamen Final: " + estudiante.Finalexamen);
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}