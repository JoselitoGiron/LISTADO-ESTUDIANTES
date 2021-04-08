using System;

namespace Program
{
    public class Estudiante {
        public string nombre;
        public int edad;
        public string carnet;
        public Boolean solvente;
        public string curso;
        public int parcial1;
        public int parcial2;
        public int Finalexamen;

        public Estudiante (string nombre, int edad, string carnet, Boolean solvente, string curso, int parcial1, int parcial2, int Finalexamen){
            this.nombre = nombre;
            this.edad = edad;
            this.carnet = carnet;
            this.solvente = solvente;
            this.curso = curso;
            this.parcial1 = parcial1;
            this.parcial2 = parcial2;
            this.Finalexamen = Finalexamen;
        }

    }
}

