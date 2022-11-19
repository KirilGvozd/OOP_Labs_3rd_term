using System.Collections;
namespace Lab9;

public class Set<T> : ISet<T>
{
    private readonly HashSet<T>? _ourSet;
    public int Count { get; }
    public bool IsReadOnly => throw new NotImplementedException();

    public Set()
    {
        _ourSet = new HashSet<T>();
    }

    public bool Remove(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException("Невозможно удалить объект");
        }
        _ourSet!.Remove(item);
        return true;
    }

    public void Print()
    {
        HashSet<T>? set = _ourSet;
        foreach (var item in set!)
        {
            Console.WriteLine(item!.ToString() + "\n");
        }
    }

    public bool Add(T item)
    {
        if (item == null)
        {
            return false;
        }
        _ourSet?.Add(item);
        return true;
    }
    public void FindItem(T item)
    {
        if (_ourSet!.Contains(item) == false)
        {
            throw new Exception("Данного элемента не существует.");
        }
        Console.WriteLine("Данный элемент существует в коллекции.\n");
    }
    
    public void Clear()
    {
        _ourSet!.Clear();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    void ICollection<T>.Add(T item)
    {
        throw new NotImplementedException();
    }

    public void ExceptWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public void IntersectWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool IsProperSubsetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool IsProperSupersetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool IsSubsetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool IsSupersetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool Overlaps(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool SetEquals(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public void SymmetricExceptWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public void UnionWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    bool ISet<T>.Add(T item)
    {
        throw new NotImplementedException();
    }
    
    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

}