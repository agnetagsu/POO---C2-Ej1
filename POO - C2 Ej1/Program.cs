using System;

namespace POO___C2_Ej1
{
    class Alumno
    {
        private string nombre;
        private int edad;

        public Alumno(string nombre,int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public void printAlumno()
        {
            System.Console.WriteLine("Nombre: {0}\nEdad: {1}", nombre, edad);
        }

        public int Edad
        {
            get { return edad; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public void MayordeEdad()
        {
            if(this.edad>=18)
            {
                System.Console.WriteLine("{0} es mayor de edad", this.nombre);
            }
            else
            {
                System.Console.WriteLine("{0} es menor de edad", this.nombre);
            }
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Alumno A1 = new Alumno("Cristina", 18);
            A1.printAlumno();
            A1.MayordeEdad();
           
        }
    }
}
