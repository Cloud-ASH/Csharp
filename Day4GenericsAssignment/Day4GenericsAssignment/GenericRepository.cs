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


public class GenericRepository <T> : IRepository<T> where T : Entity
{
 private List<T> items = new List<T>();
  
  public void Add(T item)
  {
   items.Add(item);
  }

  public void Remove(T item)
  {
   items.Remove(item);
  }

  public void Save()
  {
   Console.WriteLine("Save");
   foreach (T item in items)
   {
    Console.WriteLine($"Saving item: {item.Id}");
   }
  }

  public IEnumerable<T> GetAll()
  {
   return items;
  }

  public T GetById(int id)
  {
   for (int i = 0; i < items.Count; i++)
   {
    if (items[i].Id == id)
    {
     return items[i];
    }
   }
   throw new KeyNotFoundException();
  }
}