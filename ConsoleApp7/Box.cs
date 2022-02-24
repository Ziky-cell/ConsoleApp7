namespace ConsoleApp7
{
    internal class Box<T>
    {

        public Box(T item)
        {
            Item = item;
        }

        public T Item { get; set; }
    }
}
