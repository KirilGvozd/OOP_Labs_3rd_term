namespace Lab7;

public interface IGeneralizedInterface<T>
{
    void AddItem(T element);
    void DeleteItem();
    void LookUp();
}