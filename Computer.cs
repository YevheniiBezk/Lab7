using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab7
{
    public class Computer : IComputer, IComparable<Computer>
    {
        public string ModelName { get; set; }
        public string Processor { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public double Price { get; set; }
        public bool HasGraphicsCard { get; set; }
        public bool HasWiFi { get; set; }

        public Computer() { }

        public Computer(string modelName, string processor, int ram, int storage, double price, bool hasGraphicsCard, bool hasWiFi)
        {
            ModelName = modelName;
            Processor = processor;
            RAM = ram;
            Storage = storage;
            Price = price;
            HasGraphicsCard = hasGraphicsCard;
            HasWiFi = hasWiFi;
        }

        public int CompareTo(Computer other)
        {
            if (other == null) return 1;
            return ModelName.CompareTo(other.ModelName);
        }

        public override string ToString()
        {
            return $"{ModelName}, Процесор: {Processor}, ОЗП: {RAM} ГБ, Пам'ять: {Storage} ГБ, Ціна: {Price:C}, Відеокарта: {(HasGraphicsCard ? "так" : "ні")}, WiFi: {(HasWiFi ? "так" : "ні")}";
        }
    }
}