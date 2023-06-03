namespace SalesKingAuto; 

public abstract class ListTransaction< T > {
    public abstract void Add(T item);
    public abstract void Remove(T item);
}