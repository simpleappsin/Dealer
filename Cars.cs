using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer
{
    class Cars
    {
        public string carname { get; }
        public string carmodel { get; }
        public string cartur { get; }
        public int year;
        public int carHP;
        public decimal cost;

        public Cars(string name, string model,string tur , int yil,int beygirgucu , decimal cost)
        {
            carname = name;
            carmodel = model;
            cartur = tur;
            year = yil;
            carHP = beygirgucu;
            Cost = cost;
        }

        public decimal Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if(value > 0M)
                {
                    cost = value;
                }
            }
        }

        public override string ToString() =>
            $"{carname, -10} {carmodel, -10} {cartur, -10} {year, -10} {carHP, -10} {cost,10:C}";
    }
}
