namespace Lab7;

public class Stack<T> : IGeneralizedInterface<T> //where T : class //Это ограничение
{   
    public readonly List<T> List;
    private readonly int _top;
    public Stack()
    {
        this._top = 0;
        this.List = new List<T>();
    }
    public int TopElement
    {
        get { return this._top; }
    }

    public int Count
    {
        get { return this._top; }
    }
    public bool IsEmpty()
    {
        if (List.Count == 0)
            return true;
        else
            return false;
    }
    public void AddItem(T element)
    {
        this.List.Insert(_top, element);
    }
    public void DeleteItem()
    {
        if (IsEmpty())
            throw new InvalidOperationException();
        this.List.RemoveAt(_top);
    }
    public T Peek()
    {
        return List[_top];
    }
    public void LookUp()
    {
        if (IsEmpty())
            Console.WriteLine("Stack is empty");
        for (int i = 0; i < List.Count; i++)
        {
            Console.WriteLine("->" + List[i]);
        }
        Console.WriteLine($"Всего элементов в стеке: {List.Count}");
    }

    //Дополнительно перегрузить следующие 
    //операции: + - добавить элемент в стек; -- - извлечь элемент из
    //стека; true - проверка, пустой ли стек; > - копирование одного
    //стека в другой с сортировкой в возрастающем порядке.
    public static Stack<T> operator +(Stack<T> a, T elem)
    {
        a.AddItem(elem);
        return a;
    }
    public static Stack<T> operator --(Stack<T> a)
    {
        a.DeleteItem();
        return a;
    }
    public static bool operator true(Stack<T> a)
    {
        if(a.Count == 0)
            return false;
        return true;
    }
    public static bool operator false(Stack<T> a)
    {
        if(a.Count > 0)
            return true;
        return false;
    }
    public static Stack<T> operator >(Stack<T> a, Stack<T> b)
    {
        a.List.Sort();
        b = a;
        return b;
    }
    public static Stack<T> operator <(Stack<T> a, Stack<T> b)
    {
        a.List.Sort();
        b = a;
        return b;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}