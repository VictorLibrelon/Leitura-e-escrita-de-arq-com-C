using CourseIO.Entities;
using System.Collections.Generic;
using System.IO;

namespace CourseIO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String path = @"C:\workspace\C#\csv\produtos.csv";
            string targetPath = @"C:\workspace\C#\csv\produtos1.csv";
            List<Product> product = [];

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    String[] lines = File.ReadAllLines(path);
                    foreach (String line in lines)
                    {
                        String[] fields = line.Split(',');
                        String name = fields[0];
                        double price = double.Parse(fields[1]);
                        int quantity = int.Parse(fields[2]);
                        product.Add(new Product(name, price, quantity));
                    }

                    using (StreamWriter sw = File.AppendText(targetPath))
                    {
                        foreach (Product p in product)
                        {
                            sw.WriteLine(p.Name + "," + p.TotalValue());
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
