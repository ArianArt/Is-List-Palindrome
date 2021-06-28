// Singly-linked lists are already defined with this interface:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
bool isListPalindrome(ListNode<int> l) {
            if(l==null)
                return true;
            ListNode<int> a = l;
            ListNode<int> b = l;
            ListNode<int> h = l;
            while (b.next != null)
            {
                if (b.next != null)
                {
                    if (b.next.next != null)
                    {
                        b = b.next.next;
                       
                    }
                    else
                    {
                        b = b.next;
                        a = a.next;
                        break;
                    }
                }
                a = a.next;
            }

            ListNode<int> prev = null;

            while (a != null)
            {
                ListNode<int> next = a.next;
                a.next = prev;
                prev = a;
                a = next;
            }

            while(prev != null)
            {
                if (prev.value != h.value)
                    return false;
                
                prev = prev.next;
                h = h.next;
            }

                return true;
}
