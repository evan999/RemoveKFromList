using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveKFromList
{
    // Definition for singly-linked list:
     class ListNode<T> {
       public T value { get; set; }
       public ListNode<T> next { get; set; }
     }

    ListNode<int> RemoveFromList(ListNode<int> l, int k)
    {
        // l.value;
        // l.next;
        // l is head node of list
        // 
        // Find k from List
        // Remove k

        // Empty list
        if (l == null)
        {
            // null 
            return l;
        }

        ListNode<int> trav = l;
        // Console.WriteLine(trav.value);

        while (trav.next != null)
        {
            /*
            if (k == trav.value)
            {
                l.value = k.value;
                break;
            }
            */

            Console.WriteLine(trav.value);
            trav = trav.next;
        }

        // if (trav.next == null)
        // {
        //      Console.WriteLine(trav.value);
        // }
        Console.WriteLine(trav.value);

        return l;

    }
}
