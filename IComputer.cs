using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab7
{
    public interface IComputer
    {
        string ModelName { get; set; }
        string Processor { get; set; }
        int RAM { get; set; }
        int Storage { get; set; }
        double Price { get; set; }
        bool HasGraphicsCard { get; set; }
        bool HasWiFi { get; set; }
    }
}

