namespace Lab17_18
{
    abstract class Colleague //Абстрактный класс, который определяет интерфейс для наследуемых объектов
    {
        protected Colleague(string education) => Education = education;
        public string WorkerName { get; set; }
        public string Education { get; set; }
        public abstract int GetAge();
    }
    class School : Colleague
    {
        public School() : base("Закончил школу") { }
        public override int GetAge() => 17;
    }
    class University : Colleague     //Конкретная реализация компонента, в которую с помощью декоратора добавляется новая функциональность
    {
        public University() : base("Закончил университет") { }
        public override int GetAge() => 22;
    }
    abstract class ColleagueDecorator : Colleague
    {
        protected readonly Colleague Colleague;
        protected ColleagueDecorator(string n, Colleague colleague) : base(n) => Colleague = colleague;
    }
    class Master : ColleagueDecorator
    {
        public Master(Colleague colleague) : base(colleague.Education + ", степень магистра", colleague) { }
        public override int GetAge() => Colleague.GetAge() + 3;
    }
    class BachelorDegree : ColleagueDecorator
    {
        public BachelorDegree(Colleague colleague) : base(colleague.Education + ", бакалавр", colleague) { }
        public override int GetAge() => Colleague.GetAge() + 3;
    }
}