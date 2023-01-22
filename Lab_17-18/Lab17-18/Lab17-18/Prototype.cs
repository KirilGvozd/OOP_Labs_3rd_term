using System.Collections.Generic;

namespace Lab17_18
{
    internal interface IPrototype
    {
        string TypeTour();
        void GetTypeTour(string tourType);

        IPrototype Clone();
    }


    class Tour : IPrototype
    {
        public int NumberOfTickets { get; set; }
        public string NameOfTheTour { get; set; }

        public double Price;
        public string TourType { get; set; }

        public static readonly List<Tour> Tours = new List<Tour>();
        public Tour() { }
        public Tour(string tourType, double price)
        {
            TourType = tourType;
            Price = price;
        }

        private Tour(Tour donor) => TourType = donor.TourType;

        public string TourStatus { get; set; } = "Обычный";
        public string TypeTour() => TourType;
        public void GetTypeTour(string tourType) => TourType = tourType;
        public IPrototype Clone() => new Tour(this);
    }

}