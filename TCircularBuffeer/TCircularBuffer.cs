using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCircularBuffeer
{
    class TCircularBuffer
    {
        private Element head;
        private Element tail;

        public TCircularBuffer()
        {
            head = null;
            tail = null;
        }

        public void Insert(object data)
        {
            Element element = new Element(data);
            if (head == null)
            {
                head = element;
                tail = element;
            }
            else
            {
                element.Previous = tail;
                tail.Next = element;
                tail = element;
                element.Next = head;
                head.Previous = element;
            }
        }
        public void Remove()
        {
            tail.Next = head.Next;
            head.Next.Previous = tail;
            head = head.Next;
        }
    }
}
