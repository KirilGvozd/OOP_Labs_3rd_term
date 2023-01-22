using System;

namespace Lab17_18
{
        interface ITransport
    {
        void Drive();
    }
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Вы едете на машине");
        }
    }
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
    interface IAnimal
    {
        void Move();
    }
    class Whale : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Кит плавает.");
        }
    }
    class SharkToTransportAdapter : ITransport
    {
        private Whale _whale;
        public SharkToTransportAdapter(Whale whale)
        {
            _whale = whale;
        }
 
        public void Drive()
        {
             Console.WriteLine("Вы плывёте на ките.");
        }
    }
}
