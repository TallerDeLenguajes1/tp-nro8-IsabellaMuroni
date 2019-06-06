using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp8
{
    class Empleados
    {
        //Siempre fuera de la clase
        public enum Genero { masculino, femenino };
        public enum EstadoCivil { casado, soltero };
        public enum Cargo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador };

        public class Empleado
        {
            string nombre;
            string apellido;
            DateTime fNac;
            int edad;
            EstadoCivil estadoCivil;
            Genero genero;
            DateTime fechaIng;
            int antiguedad;
            int sueldoBasico;
            Cargo cargo;

            public string Nombre
            {
                get
                {
                    return nombre;
                }

                set
                {
                    nombre = value;
                }
            }

            public string Apellido
            {
                get
                {
                    return apellido;
                }

                set
                {
                    apellido = value;
                }
            }

            public DateTime FNac
            {
                get
                {
                    return fNac;
                }

                set
                {
                    fNac = value;
                }
            }

            public int Edad
            {
                get
                {
                    return edad;
                }

                set
                {
                    edad = value;
                }
            }

            public EstadoCivil EstadoCivil
            {
                get
                {
                    return estadoCivil;
                }

                set
                {
                    estadoCivil = value;
                }
            }

            public Genero Genero
            {
                get
                {
                    return genero;
                }

                set
                {
                    genero = value;
                }
            }

            public DateTime FechaIng
            {
                get
                {
                    return fechaIng;
                }

                set
                {
                    fechaIng = value;
                }
            }

            public int Antiguedad
            {
                get
                {
                    return antiguedad;
                }

                set
                {
                    antiguedad = value;
                }
            }

            public int SueldoBasico
            {
                get
                {
                    return sueldoBasico;
                }

                set
                {
                    sueldoBasico = value;
                }
            }

            public Cargo Cargo
            {
                get
                {
                    return cargo;
                }

                set
                {
                    cargo = value;
                }
            }

            //Constructores
            public Empleado()
            { }


            public Empleado(string _Nombre, string _Apellido, DateTime _FNac, int _Edad, EstadoCivil _EstadoCivil, Genero _Genero, DateTime _FechaIng, int _Antiguedad, int _sueldoBasico, Cargo _Cargo)
            {
                Nombre = _Nombre;
                Apellido = _Apellido;
                FNac = _FNac;
                EstadoCivil = _EstadoCivil;
                Genero = _Genero;
                FechaIng = _FechaIng;
                Antiguedad = _Antiguedad;
                SueldoBasico = _sueldoBasico;
                Cargo = _Cargo;
            }

            public void MostrarEmpleados()
            {
                Console.WriteLine("Nombre: {0}", Nombre);
                Console.WriteLine("Apellido: {0}", Apellido);
                Console.WriteLine("Fecha de nacimiento: {0}", FNac);
                Console.WriteLine("Edad: {0}", Edad);
                Console.WriteLine("Estado civil: {0}", EstadoCivil);
                Console.WriteLine("Género: {0}", Genero);
                Console.WriteLine("Fecha de ingreso: {0}", FechaIng);
                Console.WriteLine("Antigüedad: {0}", Antiguedad);
                Console.WriteLine("Sueldo Básico: $ {0}", sueldoBasico);
                Console.WriteLine("Cargo: {0}", Cargo);
            }
        }

    }
}
