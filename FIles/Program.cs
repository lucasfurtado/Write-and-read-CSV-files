using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIles
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string fileSource = @"E:\__Meu Repositorio\Estudos\Pasta de Testes\buyItens.csv";
                string fileOut = @"E:\__Meu Repositorio\Estudos\Pasta de Testes\itensValue.csv";

                if (!File.Exists(fileSource)) using (FileStream fs = File.Create(fileSource)) { };

                using (StreamWriter fs = new StreamWriter(fileSource))
                {
                    string item = null;
                    while(item != "exit")
                    {
                        if(item != null) fs.WriteLine(item);
                        item = Console.ReadLine();
                    }
                };

                if (!File.Exists(fileOut)) using (FileStream fs = File.Create(fileOut)) { }

                string[] lines = File.ReadAllLines(fileSource);

                using (StreamWriter fs = new StreamWriter(fileOut))
                {
                    int cont = 1;
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(new char[] { ',' });
                        if (parts.Count() == 3)
                        {
                            decimal aux = Convert.ToDecimal(parts[1]) * Convert.ToDecimal(parts[2]);
                            fs.Write(parts[0] + ",");
                            fs.WriteLine(aux);
                        }
                        else
                        {
                            Console.WriteLine($"Something is wrong in line {cont}");
                        }
                        cont++;
                    }
                }


            }
            catch (Exception exception)
            {
                Console.WriteLine("Unexpected error: "+exception.Message);
            }


        }
    }
}
