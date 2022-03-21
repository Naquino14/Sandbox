namespace GenericLinkedList
{
    public interface ILinkedList<T> where T : notnull
    {
        public void Append(long target, Node<T> node);
        public void Prepend(Node<T> target, Node<T> node);
    }
}