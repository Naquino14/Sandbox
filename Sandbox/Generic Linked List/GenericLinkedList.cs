namespace GenericLinkedList
{
#pragma warning disable CS0168
    public class LinkedList<T> : ILinkedList<T> where T : notnull
    {
        public Node<T> head { get; private set; }
        public long size { get; private set; }

        public LinkedList(Node<T> head)
        {
            this.head = head;
            head.index = 0;
            size++;
        }

        public LinkedList(T data)
        {
            head = new Node<T>(data);
            head.index = 0;
            size++;
        }

        public void Append(Node<T> node) => Append(size, node);

        public void Append(long target, Node<T> node)
        {
            node.index = size;
            Node<T> ctx = head;
            for (int i = 1; i < target; i++)
                ctx = ctx.next ?? throw new NullReferenceException();
            ctx.next = node;
            size++;
        }

        public void Prepend(Node<T> target, Node<T> node)
        {
            node.previous = target.previous;
            target.previous = node;
            size++;
        }

        #pragma warning disable CS8600
        public bool TryGetNodeAt(long index, out Node<T>? target)
        {
            // start at base node
            if (index == 0)
            {
                target = head;
                return true;
            }

            Node<T> ctx;

            try
            {
                // erro testing for getting the next node when it doesnt exist
                if (index > 0)
                {
                    ctx = head.next;
                    for (long i = 1; i <= index; i++)
                    {
                        if (index == (ReferenceEquals(ctx, null) ? throw new ArgumentNullException() : ctx.index))
                        {
                            target = ctx;
                            return true;
                        }
                        ctx = ctx.next;
                    } // fallout breakpoint
                    target = null;
                    return false;
                }
            }
            catch (NullReferenceException u)
            {

            }
            target = null;
            return false;
        }
        #pragma warning restore CS8600

        #pragma warning disable CS8600, CS8602
        public bool TryGetNodeAt(string id, out Node<T>? target)
        {
            Node<T> ctx;

            try
            {
                if (head.id != null && head.id == id)
                {
                    target = head;
                    return true;
                }
                ctx = head.next;
                for (long i = 1; i <= size; i++)
                {
                    if (!ReferenceEquals(ctx.id, null))
                        if (ctx.id == id)
                        {
                            target = ctx;
                            return true;
                        }
                    ctx = ctx.next;

                } // fallout

                target = null;
                return false;
            }
            catch (NullReferenceException u)
            { }
            target = null;
            return false;
        }
#pragma warning restore CS8600, CS8602

        public override string ToString()
        {
            string res = $"Size: {size}, Data type: {typeof(T)}, Head Node ID: {head.id ?? "null"}, {{ ";
            Node<T>? context;
            for (int i = 0; i < size; i++) // loop thru every node
            {
                if (!TryGetNodeAt(i, out context))
                    res += $"Node at {i} is undefined. ";
                else
                    res += $"{(!ReferenceEquals(context, null) ? context.ToString() : $"Node at {i} is null. ")}";
            }
            return res += " }";
        }
    }
}
