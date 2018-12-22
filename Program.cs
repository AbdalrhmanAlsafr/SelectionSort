using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
    
        public static void diziyedegerat()
        {
            Random uretec = new Random();
           
            for(int i=0;i<dizi.Length;i++)
            {
                dizi[i] = uretec.Next(20,50);
            }
        }
        public static int[] dizi = new int[10];
        public static void dizisirala()
        {
         
            int min, temp;
            for (int i = 0; i < dizi.Length; i++)
            {
                min = i;
                for (int inner = i + 1; inner < dizi.Length; inner++)
                { 
                    if (dizi[inner] < dizi[min])
                        min = inner;
                }
                temp = dizi[i];
                dizi[i] = dizi[min];
                dizi[min] = temp;
            }

        }
        
        static void Main(string[] args)
        {
           
            diziyedegerat();
            Console.WriteLine("işlem biti");
            dizisirala();
            

            for (int i=0;i<dizi.Length;i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();
        }








    }
}
