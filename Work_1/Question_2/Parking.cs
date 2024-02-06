using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    public class Parking
    {
        public int ParkingType { get; set; }
        public float ParkingFee { get; set; }
        public string LongTermParking { get; set; }
        public float NumberOfDays { get; set; }
        public float LongTermParkingOneTimeFee { get; set; }
        public float LongTermParkingOneDayFee { get; set; }
        public string ShortTermParking { get; set; }
        public float NumberOfHours { get; set; }
        public float ShortTermParkingFirstHourFee { get; set; }
        public float ShortTermParkingOneHourFee { get; set; }
        public float ShortTermParkingMaxFee { get; set; }
    }
}
