using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_dom
{
    internal class List
    {
        public Node head;
        public Node tail;
        public int count = 0;
        public void AddLast(int liczba)
        {
            Node add = new Node(liczba);
            if (this.tail == null)
            {
                this.head = add;
                this.tail = add;
            }
            else
            {
                this.tail.next = add;
                add.prev = this.tail;
                this.tail = add;
            }
            this.count++;
        }
        public void AddFirst(int liczba)
        {
            Node add = new Node(liczba);
            if (this.head == null)
            {
                this.head = add;
                this.tail = add;
            }
            else
            {
                add.next = this.head;
                this.head.prev = add;
                this.head = add;
            }
            this.count++;
        }

        public void RemoveFirst()
        {
            if (this.head == null)
            {
                return;
            }
            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                this.head = this.head.next;
                tail.prev = null;
            }
            this.count--;
        }

        public void RemoveLast()
        {
           if(this.tail == null)
            {
                return;
            }
           if(this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                this.tail = this.tail.prev;
                tail.next = null;
            }
           this.count--;
        }
    }
}
