using System;
using System.Collections.Generic;

namespace Lab17_18
{
    // Strategy 
    interface IMovable //интерфейс, общий для всех вариаций алгоритма
    {
        void Move();
    }
    class SearchingForTour : IMovable    //Конкретные стратегии
    {
        public void Move() => Console.WriteLine("Я ищу тур для отдыха.");
    }

    class FittingTour : IMovable
    {
        public void Move() => Console.WriteLine("Я нашел подходящий тур. Я лечу в Казахстан");
    }
    class Client : WrapperOverIMovementTour, IMovable
    {
        //Контекст 
        public IMovable Movable { private get; set; }

        public Client(string name, IMovable movable)
        {
            Console.WriteLine("Клиент ищет тур");
            Movable = movable;
            Name = name;
        }
        public void Move() => Movable.Move();




        //Singleton
        private static Client _instance; //Поле для хранения объекта-одиночки
        public string Name { get; set; }

        List<Tour> _tours = new List<Tour>();
        private Client(string name) => Name = name;
        public static Client GetInstance(string name)   // Возвращает единственный экземпляр своего класса
        {
            if (_instance == null)
                _instance = new Client(name);
            return _instance;
        }





        // State
        public enum States   
        {
            Registration,
            Choose,
            Paying
        }
        public States State { get; set; }
        public Client(States ws) => State = ws;


        public void Go()
        {
            if (State == States.Registration)
            {
                Console.WriteLine($"Клиент {Name} зарегистрировался");
                State = States.Choose;
            }
            else if (State == States.Choose)
            {
                Console.WriteLine($"Клиент {Name} выбирает тур");
                State = States.Paying;
            }
            else if (State == States.Paying)
            {
                Console.WriteLine($"Клиент {Name} оплачивает тур");
            }
        }
        public void Stop()
        {
            if (State == States.Choose)
            {
                Console.WriteLine($"Клиент {Name} закончил оформление тура");
                State = States.Registration;
            }
            else if (State == States.Paying)
            {
                Console.WriteLine($"Клиент {Name} выходит из системы");
                State = States.Choose;
            }
        }
    }


    internal class TourAgent
    {
        public static void TourStatus(Tour tour)
        {
            tour.TourStatus = "Горящий";
            Console.WriteLine("Турагент изменил статус тура на: " + tour.TourStatus);
        }
        public void Pay(Tour tour)
        {
            Console.WriteLine("Оплата тура:");
            Console.WriteLine("Стоимость тура " + tour.TourType + " равна " + tour.Price);
            Console.WriteLine("Вы успешно оплатили тур!");
        }
        public double GetSale(Client client, Tour tour)
        {
            Console.WriteLine("Система скидок постоянным клиентам");
            string[] constClient = { "Кирилл", "Влад" };
            for (int i = 0; i < constClient.Length; i++)
            {
                if (client.Name == constClient[i])
                {
                    Console.WriteLine($"{client.Name} является постоянным клиентом!");
                    Console.WriteLine("Скидка для постоянных клиентов 30%!");
                    tour.Price *= 0.7;
                    return tour.Price;
                }

                Console.WriteLine($"{client.Name} не является постоянным клиентом!");
                return tour.Price;
            }
            return tour.Price;
        }

    }






    internal interface IMovementClient
    {
        Tour ToTour(List<Tour> list);
    }

    class WrapperOverIMovementTour : IMovementClient
    {
        public Tour ToTour(List<Tour> list)
        {
            Console.WriteLine("Список туров: ");
            foreach (Tour item in list)
            {
                Console.WriteLine(item.TourType + " " + item.Price);
            }
            Console.WriteLine("Введите название выбранного тура и его стоимость: ");
            string name = Console.ReadLine();
            double price = Convert.ToDouble(Console.ReadLine());
            Tour tour = new Tour(name, price);
            Console.WriteLine("Клиент выбрал тур " + tour.TourType);

            return tour;
        }
    }
}
