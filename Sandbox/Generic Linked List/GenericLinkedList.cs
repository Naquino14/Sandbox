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

        public void Append(Node<T> node)
        {
            node.index = size;
            head.next = node;
            size++;
            
        }

        public void Append(Node<T> target, Node<T> node)
        {
            node.next = target.next;
            target.next = node;
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
            Node<T> ctx;

            try
            {
                // erro testing for getting the next node when it doesnt exist
                if (index > 0)
                {
                    ctx = head.next;
                    for (long i = 1; i <= index; i++)
                    {
                        if (index == ctx.index)
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
    }
}
