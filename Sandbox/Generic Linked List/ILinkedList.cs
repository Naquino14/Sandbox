namespace GenericLinkedList
{
    public interface ILinkedList<T>
    {
        public void Append(Node<T> target, Node<T> node);
        public void Prepend(Node<T> target, Node<T> node);
    }
}