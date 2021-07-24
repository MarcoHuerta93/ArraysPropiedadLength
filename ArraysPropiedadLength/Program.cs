using System;

namespace ArraysPropiedadLength
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Primera manera de crear arrays
            /*int[] calificaciones = new int[5];

            calificaciones[0] = 10;
            calificaciones[1] = 9;
            calificaciones[2] = 8;
            calificaciones[3] = 7;
            calificaciones[4] = 6;

            Console.WriteLine("Primera calificación : {0}", calificaciones[0]);
            

            //Segunda manera de crear arrays
            int[] edades = { 30, 29, 28, 27, 26};

            //Tercera manera de crear arrays

            int[] faltasAlColegio = new int[] { 1, 2, 3, 4, 5, 6};

            Console.WriteLine("El array faltaAlColegio tiene {0} casos", faltasAlColegio.Length);
            Console.Read();*/

            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)

            {
                nums[i] = i;
            }

            for(int j = 0; j < nums.Length; j++ )
            {
                Console.WriteLine("El valor del indice {0} es {1}", j, nums[j]); 

            }
            Console.Read();
        }
    }
}
