using System;

namespace ConsoleApp11
{
    public class Seans : Entity
    {
        public Zal zal { get; set; }
        public Film film { get; set; }
        public DateTime StartingTime { get; set; }

        public override string ToString()
        {
            return $"{Id} Filmin Adi:{film}\n Filmin Kecirileceyi Zal:{zal}\n Filmin Baslama Vaxti:{StartingTime}\n";
        }
    }   
}