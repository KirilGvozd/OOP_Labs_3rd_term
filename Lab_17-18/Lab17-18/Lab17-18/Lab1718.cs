using System;
using System.Collections.Generic;
using Lab17_18.AbstractFactory;

namespace Lab17_18
{
    internal static class Lab1718
    {
        public static void Main()
        {
            Console.WriteLine("\nAbstract Factory");
            ICarFactory factory = new ConcreteFactoryCar();

            ICar carAmericano = factory.CreateAmericanCar();
            carAmericano.Prepare();
 

            ICar carItalio = factory.CreateItalianCar();
            carItalio.Prepare();


            Console.WriteLine("\nТурагентство:");

            Tour firstTour = new Tour("Экскурсия", 120);
            Tour secondTour = new Tour("Шоппинг", 600);
            Tour thirdTour = new Tour("Отдых", 450);

            List<Tour> listOfTours = new List<Tour>()
            {
                firstTour,
                secondTour,
                thirdTour
            };

            //Singleton
            //Client test = Client.GetInstance("Антон"); 
            Client kirill = Client.GetInstance("Кирилл");

            var current = kirill.ToTour(listOfTours);

            TourAgent tourAgent = new TourAgent();
            TourAgent.TourStatus(current);

            tourAgent.GetSale(kirill, current);
            tourAgent.Pay(current);




            // Prototype
            Console.WriteLine("\nPrototype");
            IPrototype tourOld = new Tour();
            tourOld.GetTypeTour("TourType");

            IPrototype tourNew = tourOld.Clone();

            Console.WriteLine(tourOld.TypeTour());
            Console.WriteLine(tourNew.TypeTour());

            //Builder
            Console.WriteLine("\nBuilder");

            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct("Счастливого путешествия!", 3, "Астана");
            Tour product = builder.GetResult();

            //Adapter
            Console.WriteLine("Adapter");
            Driver driver = new Driver();
            Auto auto = new Auto();
            driver.Travel(auto);
            Whale whale = new Whale();
                whale.Move();
            //Используем адаптер
            ITransport whaleTransport = new SharkToTransportAdapter(whale);
            driver.Travel(whaleTransport);

            Console.WriteLine("Decorator");

            Colleague colleague = new University();
            colleague = new Master(colleague);
            Console.WriteLine("Образование: {0}", colleague.Education);
            Console.WriteLine("Возраст: {0}", colleague.GetAge());

            Console.WriteLine("\nFacade");

            TextEditor textEditor = new TextEditor();
            Compiller compiler = new Compiller();
            Clr clr = new Clr();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiler, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.WriteLine("\nStrategy");

            Client student1 = new Client("Антон", new SearchingForTour());
            student1.Move();
            student1.Movable = new FittingTour();
            student1.Move();

            Console.WriteLine("\nState");

            Client client = new Client(Client.States.Registration);
            client.Name = "Влад";
            client.Go();
            client.Go();
            client.Stop();

            Console.WriteLine("\nCommand");

            AnotherDriver anotherDriver = new AnotherDriver();
            Bus bus = new Bus();
            anotherDriver.SetCommand(new BusIsMovingCommand(bus));
            anotherDriver.PressGas();
            anotherDriver.PressBrakes();
        }
    }
}
