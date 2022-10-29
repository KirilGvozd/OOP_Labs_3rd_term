namespace Lab7;

public interface IGeneralizedInterface<T>
{
    void AddItem(T element);
    void DeleteItem(T element);
    void LookUp();
}