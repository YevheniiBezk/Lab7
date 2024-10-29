using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "computer.bin");

            List<Computer> computers = ReadComputers(filePath);

            computers.Sort();

            Console.WriteLine("\nВідсортований список комп'ютерів:");
            foreach (var comp in computers)
            {
                Console.WriteLine(comp.ToString());
            }

            Console.WriteLine("\nНатисніть Enter, щоб завершити...");
            Console.ReadLine();
        }

        static List<Computer> ReadComputers(string filePath)
        {
            List<Computer> computers = new List<Computer>();

            try
            {
                using (BinaryReader br = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    while (br.BaseStream.Position != br.BaseStream.Length)
                    {
                        string modelName = br.ReadString();
                        string processor = br.ReadString();
                        int ram = br.ReadInt32();
                        int storage = br.ReadInt32();
                        double price = br.ReadDouble();
                        bool hasGraphicsCard = br.ReadBoolean();
                        bool hasWiFi = br.ReadBoolean();

                        Computer computer = new Computer(modelName, processor, ram, storage, price, hasGraphicsCard, hasWiFi);

                        computers.Add(computer);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при читанні файлу: {ex.Message}");
            }

            return computers;
        }
    }
}
