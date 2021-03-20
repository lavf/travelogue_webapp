using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelogueWebApp.Models
{
    public class Trip
    {
        public int ID { get; set; }
        public int TripArrivalYear { get; set; }
        public int TripArrivalMonth { get; set; }
        public int TripArrivalDay { get; set; }
        public int TripDepartureYear { get; set; }
        public int TripDepartureMonth { get; set; }
        public int TripDepartureDay { get; set; }
        public string TripCountry { get; set; }
        public string TripCity { get; set; }
        public string TripTransport { get; set; }


        public Trip()
        {

        }
    }
}
