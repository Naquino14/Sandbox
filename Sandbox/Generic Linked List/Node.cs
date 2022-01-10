namespace GenericLinkedList
{
    public abstract class BaseNode
    {
        public long index { get; set; }
        public string? id { get; set; }
    }

    public sealed class Node<T> : BaseNode where T : notnull
    {
        public T data;
        public Node(T data) => this.data = data;

        public Node(T data, Node<T>? next, Node<T>? previous) : this(data)
        {
            this.next = next;
            this.previous = previous;
        }

        public Node(T data, long index) : this(data) => this.index = index;

        public Node(T data, string id) : this(data) => this.id = id;

        public Node(T data, long index, string id) : this(data)
        {
            this.index = index;
            this.id = id;
        }

        public Node<T>? next;
        public Node<T>? previous;
    }

    public sealed class Node : BaseNode
    {
        public object data;

        public Node(object data) => this.data = data;
    }
}
