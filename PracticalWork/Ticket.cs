using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork
{
    class Ticket
    {
        //public uint { get; set; }
        public Pasanger pasanger=new Pasanger();
        public Train train=new Train();
        public uint NumberCarr { get; set; }
        public uint seat { get; set; }
        public TypeCar typecar;
        public override string ToString()
        {
            return pasanger.ToString() + train.ToString() + $"{NumberCarr} : {seat} : {typecar.ToString()}";
        }



    }

    class Pasanger {

        public string NamePass { get; set; }
        public string SurnamePass{ get; set; }
        public override string ToString()
        {
            return $"{NamePass} : {SurnamePass}";
        }
    }

}
