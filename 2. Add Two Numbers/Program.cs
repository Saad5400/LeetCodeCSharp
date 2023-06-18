
class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

class Solution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {

        var lc = new ListNode();
        var lr = lc;

        int remainder = 0;

        while (true)
        {
            if (l1 is not null)
            {
                lc.val += l1.val;
                l1 = l1.next;
            }
            if (l2 is not null)
            {
                lc.val += l2.val;
                l2 = l2.next;
            }
            lc.val += remainder;
            remainder = 0;
            if (lc.val > 9)
            {
                remainder = lc.val / 10;
                lc.val = lc.val % 10;
            }
            if (l1 is null && l2 is null)
            {
                if (remainder > 0)
                {
                    lc.next = new ListNode(remainder);
                }
                break;
            }
            lc.next = new ListNode();
            lc = lc.next;
        }

        return lr;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // create a solution object
        Solution sol = new Solution();

        // create a linked list
        ListNode l1 = new ListNode(2);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(3);

        // create a linked list
        ListNode l2 = new ListNode(5);
        l2.next = new ListNode(6);
        l2.next.next = new ListNode(4);


        // call method and get result
        ListNode? result = sol.AddTwoNumbers(l1, l2);

        // print the result
        while (result != null)
        {
            Console.Write(result.val + " ");
            result = result.next;
        }
    }
}