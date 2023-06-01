/**
 * Definition for singly-linked list.
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode x1, ListNode x2)
    {
        var zero = new ListNode(0);
        var ans = new ListNode(0);
        var head = ans;
        var carry = 0;
       while(x1 != null || x2 != null)
       {
            x1 = x1 ?? zero;
            x2 = x2 ?? zero;

            var sum =x1.val+x2.val+carry; 
            carry = 0;
            if (sum>=10)
            {
                // sum = sum % 10;
                // We know these are digits, so the value will 
                // never be greater than 18, so we can ditch the
                // slow `mod` for a fast subtraction
                sum = sum - 10;
                carry = 1;
            }
            ans.next = new ListNode(sum);
            ans = ans.next;

            x1 = x1.next;
            x2 = x2.next;
       }

       if ( carry == 1 )
       {
            ans.next = new ListNode(1);
       }
       return head.next; 
    }

    public ListNode IsThisFaster(ListNode x1, ListNode x2)
    {
        var zero = new ListNode(0);
        var ans = new ListNode(0);
        var head = ans;
        var carry = 0;
       while(x1 != null || x2 != null)
       {
            var x = x1?.val ?? 0;
            var y = x2?.val ?? 0;

            var sum = x + y + carry; 
            carry = sum / 10;
            sum = sum % 10;
            
            ans.next = new ListNode(sum);
            ans = ans.next;

            x1 = x1?.next;
            x2 = x2?.next;
       }

       if ( carry == 1 )
       {
            ans.next = new ListNode(1);
       }
       return head.next; 
    }
}