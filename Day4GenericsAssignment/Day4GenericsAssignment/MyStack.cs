namespace Day4GenericsAssignment;

// Create a custom Stack class MyStack<T> that can be used with any data type which
//     has following methods
// 1. int Count()
// 2. T Pop()
// 3. Void Push()

public class MyStack <T>
{   
    private List<T> Data { get; set; } = new List<T>();
    
    public int Count()
    {
        return Data.Count;
    }

    public T Pop()
    {
        if (Data.Count() == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        T item = Data[Data.Count - 1];
        Data.RemoveAt(Data.Count - 1);
        return item;
    }

    public void Push(T value)
    {
        Data.Add(value);
    }
    
}