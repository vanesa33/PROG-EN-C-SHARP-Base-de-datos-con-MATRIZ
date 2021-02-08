using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace base_de_matos_con_matriz
{

    class Program
    {


        static void Main(string[] args)
        {

            
            
            string[,] datos = new string[5, 5];

            
            int i;



            string id, edad, dni;
            string nombre, apellido;








            for (i = 0; i < datos.Length; i++)
            {

                for (int j = 0; j < datos.GetLength(1); j++)
                {

                    Console.WriteLine("ingrese id: ");
                    id = Console.ReadLine();
                    datos[i, j] = id;

                    Console.WriteLine("ingrese dni: ");
                    dni = Console.ReadLine();
                    datos[i, j] = dni;


                    Console.WriteLine("ingrese nombre: ");
                    nombre = Console.ReadLine();
                    datos[i, j] = nombre;

                    Console.WriteLine("ingrese apellido: ");
                    apellido = Console.ReadLine();
                    datos[i, j] = apellido;

                    Console.WriteLine("ingrese edad: ");
                    edad = Console.ReadLine();
                    datos[i, j] = edad;



                    Console.Clear();

                }





                Console.ReadKey();

               
            }  

            }




    }


        
        
    }   
