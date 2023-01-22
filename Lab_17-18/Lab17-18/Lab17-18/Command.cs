using System;

namespace Lab17_18
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver - Получатель
    class Bus
    {
        public void Edet()
        {
            Console.WriteLine("Автобус с туристами поехал");
        }

        public void Stand()
        {
            Console.WriteLine("Автобус с туристами остановился");
        }
    }

    class BusIsMovingCommand : ICommand
    {
        Bus _bus;
        public BusIsMovingCommand(Bus busSet)
        {
            _bus = busSet;
        }
        public void Execute()
        {
            _bus.Edet();
        }
        public void Undo()
        {
            _bus.Stand();
        }
    }

    // Invoker - инициатор
    class AnotherDriver
    {
        ICommand _command;

        public void SetCommand(ICommand com)
        {
            _command = com;
        }

        public void PressGas()
        {
            _command.Execute();
        }
        public void PressBrakes()
        {
            _command.Undo();
        }
    }
}
