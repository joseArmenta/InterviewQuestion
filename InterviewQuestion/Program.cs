// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        var s = new Solution();
        ReverseString2Test(s);
        ListNodeTest(s);
        Console.ReadKey();
    }

    private static void ListNodeTest(Solution s)
    {
        var head = s.Populate(new int[] { 1, 2, 3, 4, 5 });
        s.PrintListNodes(head);
        s.PrintListNodes(s.ReverseList(head));
    }

    private static void ReverseString2Test(Solution s)
    {
        Console.WriteLine(s.ReverseString2("1234".ToArray()));
        Console.WriteLine(s.ReverseString2("123".ToArray()));
        Console.WriteLine(s.ReverseString2("12".ToArray()));
        Console.WriteLine(s.ReverseString2("1".ToArray()));
    }
}

/*
Given the head of a singly linked list, reverse the list, and return the reversed list.
 
Example 1:
Input: head = [1, 2, 3, 4, 5]
Output: [5, 4, 3, 2, 1]


Example 2:
Input: head = [1, 2]
Output: [2, 1]


Example 3:
Input: head = []
Output: []

*/
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode Populate(int[] values)
    {
        ListNode head = null;
        ListNode tail = head;

        for (var i = 0; i < values.Length; i++)
        {
            var tmp = new ListNode(values[i]);

            if (head == null)
            {
                head = tmp;
                tail = head;
            }
            else
            {
                tail.next = tmp;
                tail = tmp;
            }
        }

        return head;
    }

    public void PrintListNodes(ListNode head)
    {
        var tail = head;
        while (tail != null)
        {
            Console.Write(tail.val);
            tail = tail.next;
        }
        Console.WriteLine();
    }

    public ListNode ReverseList(ListNode head)
    {
        var h = head;
        ListNode tmp = null;
        ListNode prev = null;

        while (h != null) 
        {
            tmp = h.next;
            h.next = prev;
            prev = h;
            h = tmp;
        }

        head = prev;

        return head;
    }


    public string ReverseString(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
            return string.Empty;

        //"hello"
        var sb = new StringBuilder();
        for(var i = word.Length-1; i>=0; i--)
        {
            sb.Append(word[i]);
        }

        return sb.ToString();

    }

    public char[] ReverseString2(char[] word)
    {
        //"hello"
        //olleh
        //01234
        char l = '\0';
        char r = '\0';
        var j = word.Length - 1;
        for (var i = 0; i < word.Length/2; i++)
        {
            l = word[i];
            r = word[j];
            word[i] = r;
            word[j] = l;
            j--;
            
        }

        return word;

    }
}

