using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork
{
    enum TypeCar { Plackard,Kupe,Sleep};
    class Train
    {
        public DateTime dateTime { get; set; }
        public int NumberTrain { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        
        
           /* this.NumberTrain = numberTrain;
            this.CityFrom = CityFrom;
            this.CityTo = CityTo;
            this.dateTime = dateTime;*/
        
        public override string ToString()
        {
            return $"{NumberTrain} : {CityFrom} : {CityTo} : {dateTime}";
        }
    }

    class TrainServcie
    {

        public List<Train> TrainList { get; set; } = new List<Train>();

        public void Add()
        {
            Train train = new Train();
            //new Train(1, "Kiev", "Rivne", new DateTime(20, 11, 13)),
            //new Train(2, "Kharkiv", "Kiev", new DateTime(20, 11, 15)),
            //new Train(3, "Dnipro", "Donetsk", new DateTime(20, 11, 16)),
            //new Train(4, "Rivne", "Lviv", new DateTime(20, 11, 16))

            TrainList.Add(new Train { NumberTrain = 1, CityFrom = "Kiev", CityTo = "Rivne", dateTime = new DateTime(2020, 11, 13) });
            TrainList.Add(new Train { NumberTrain = 2, CityFrom = "Kharkiv", CityTo = "Kiev", dateTime = new DateTime(2020, 11, 15) });
            TrainList.Add(new Train { NumberTrain = 3, CityFrom = "Dnipro", CityTo = "Donetsk", dateTime = new DateTime(2020, 11, 16) });
            TrainList.Add(new Train{NumberTrain = 4, CityFrom="Rivne", CityTo="Lviv", dateTime = new DateTime(2020, 11, 16)});

        }

        


    }


}

