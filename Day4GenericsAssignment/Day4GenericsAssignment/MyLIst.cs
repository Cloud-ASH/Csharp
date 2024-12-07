namespace Day4GenericsAssignment;

// Create a Generic List data structure MyList<T> that can store any data type.
//     Implement the following methods.
// 1. void Add (T element)
// 2. T Remove (int index)
// 3. bool Contains (T element)
// 4. void Clear ()
// 5. void InsertAt (T element, int index)
// 6. void DeleteAt (int index)
// 7. T Find (int index)


public class MyList <T>
{
    private List<T> Data = new List<T>();
    
    public void Add(T element)
    {
        Data.Add(element);
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= Data.Count)
        {
            throw new IndexOutOfRangeException();
        }
        T element = Data[index];
        Data.RemoveAt(index);
        return element;
    }

    public bool Contains(T element)
    {
        foreach (T i in Data)
        {
            if (i.Equals(element))
            {
                return true;
            }
        }
        return false;
    }

    public void Clear()
    {
        Data.Clear();
    }

    public void InsertAt(T element, int index)
    {
        // index can be the same as Data.Count when we want to insert at the end of list
        if (index < 0 || index > Data.Count)
        {
            throw new IndexOutOfRangeException();
        }
        Data.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        Data.RemoveAt(index);
    }

    public T Find(int index)
    {
        return Data[index];
    }
}