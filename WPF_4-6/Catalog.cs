using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_4_6
{
    public class Phone
    {
        public string Title { get; set; } = "";
        public string Os { get; set; } = "";
        public int Memory { get; set; }
        public int CameraRes { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Название телефона: ({Title}) OС: ({Os}) Память: ({Memory}GB) Камера({CameraRes}) Стоимость: ({Price})";
        }
    }
    
    public class Tablet
    {
        public string Title { get; set; } = "";
        public string Os { get; set; } = "";
        public int Memory { get; set; }
        public int Screen { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Название планшета: ({Title})  ОС: {Os} Память: ({Memory})GB Экран({Screen}inch) Стоимость: ({Price} rub)";
        }
    }
    public class Notebook
    {
        public string Title { get; set; } = "";
        public string Os { get; set; } = "";
        public string Processor { get; set; } = "";
        public int RAM { get; set; }
        public int HDD { get; set; }
        public string VRAM { get; set; } = "";
        public int Screen { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Название: {Title} ОС: {Os} Процессор {Processor} RAM {RAM}GB HDD {HDD} VRAM {VRAM} Экран{Screen}inch Стоимость: {Price} rub";
        }
    }
}
