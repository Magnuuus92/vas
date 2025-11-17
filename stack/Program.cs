namespace stack;

class Program
{
    public class GenericList<T>
    {

        static void Main(string[] args)
        {




        private List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }
        public T Get(int index)
        {
            return list[index];
        }

        }
        
    }
    /*    var objStack = new ObjectStack(10);

        objStack.Push(43);
        objStack.Push("PUSH HELLO");

        var obj = objStack.Pop();
        var obj2 = objStack.Pop();
    }
    class ObjectStack(int stackSize)
    {
        private int _position;
        private object[] _stack = new object[stackSize];
        public void Push(object obj) => _stack[_position++] = obj;
        public object Pop() => _stack[--_position]; 
}*/
}
