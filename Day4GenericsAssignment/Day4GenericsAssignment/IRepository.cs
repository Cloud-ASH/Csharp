namespace Day4GenericsAssignment;
/*
 Implement a GenericRepository<T> class that implements IRepository<T> interface
that will have common /CRUD/ operations so that it can work with any data source
such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
on T were it should be of reference type and can be of type Entity which has one
property called Id. IRepository<T> should have following methods

1. void Add(T item)
2. void Remove(T item)
3. Void Save()
4. IEnumerable<T> GetAll()
5. T GetById(int id)
*/

// If T is only constrained as class, the compiler cannot guarantee that T has an Id property, 
// leading to compilation errors when accessing it. 
// By using where T : Entity, the compiler ensures that T must inherit from Entity, 
// making the Id property accessible and enabling type-safe operations.

public interface IRepository <T> where T : Entity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}