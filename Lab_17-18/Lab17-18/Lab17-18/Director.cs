using System;

namespace Lab17_18
{
    class Director
    {
        readonly Builder _builder;
        public Director(Builder builder) => _builder = builder;
        public void Construct(string partA = "", int partB = 0, string partC = "")
        {
            _builder.BuildPartA(partA);
            _builder.BuildPartB(partB);
            _builder.BuildPartC(partC);
        }
    }
    abstract class Builder
    {
        public abstract void BuildPartA(string item);
        public abstract void BuildPartB(int item);
        public abstract void BuildPartC(string item);
        public abstract Tour GetResult();
    }
    class ConcreteBuilder : Builder
    {
        private static readonly Tour Temp = new Tour();
        public override void BuildPartA(string item) => Temp.TourType = item;
        public override void BuildPartB(int item) => Temp.NumberOfTickets = item;
        public override void BuildPartC(string item) => Temp.NameOfTheTour = item;
        public override Tour GetResult()
        {
            Tour.Tours.Add(Temp);
            Console.WriteLine($"Название тура: {Temp.TourType}\nГород: {Temp.NameOfTheTour}\nКоличество путевок: {Temp.NumberOfTickets}");
            return Temp;
        }
    }
}
