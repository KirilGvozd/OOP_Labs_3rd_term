using System;

namespace Lab17_18
{
    namespace AbstractFactory
    {

        public interface ICar     
        {
            string Name { get; set; }

            string Manufacturer { get; set; }


            void Prepare();
            
            void Start();

            void SpeedingUp();
        }

        public class ItalianCar : ICar
        {
            public ItalianCar()
            {
                Name = "Lamborghini Aventador";
                Manufacturer = "Lamborghini";
            }

            public string Name { get; set; }
            public string Manufacturer { get; set; }
            
            public void SpeedingUp() => Console.WriteLine("Набираем скорость до 200 км/ч.");

            public void Start() => Console.WriteLine("Ставим коробку в Drive.");

            public void Prepare()
            {
                Console.WriteLine("Садимся в машину");
                Console.WriteLine("Заводим " + Name);
            }
        }
        public class AmericanCar : ICar
        {
            public AmericanCar()
            {
                Name = "Chevrolet Camaro";
                Manufacturer = "General Motors (GM)";
            }

            public string Name { get; set; }
            public string Manufacturer { get; set; }
            public string Sauce { get; set; }


            public void SpeedingUp() => Console.WriteLine("Разгоняемся до 150 км/ч.");

            public void Start() => Console.WriteLine("Набираем обороты на нейтральной передаче. Ставим коробку в Sport.");

            public void Prepare()
            {
                Console.WriteLine("Садимся в масл-кар");
                Console.WriteLine("Заводим " + Name);
            }
        }


        interface ICarFactory
        {
            ICar CreateAmericanCar();
            ICar CreateItalianCar();
        }

        class ConcreteFactoryCar : ICarFactory
        {
            public ICar CreateAmericanCar()
            {
                return new AmericanCar();
            }

            public ICar CreateItalianCar()
            {
                return new ItalianCar();
            }
        }


    }
}
