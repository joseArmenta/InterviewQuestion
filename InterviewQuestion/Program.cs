// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        /*var s = new Solution();
        var arr = new int[1, 2, 3, 4, 5];
        ListNode head = new ListNode();
        foreach (var x in arr)
        {
            
        }
        //s.ReverseList();
        */
        var s = new Solution();
        Console.Write(s.ReverseString2("1234".ToArray()));
        Console.ReadKey();
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
    public ListNode ReverseList(ListNode head)
    {
        var h = head;
        var t = head; //1
        ListNode tmp=null;
        //[1, 2, 3, 4, 5]
        // t   tm  
        while (h != null)
        {
            /*if (tmp == null)
            {
                tmp = t.next;//2
                tmp.next = t;//1
                t.next = null;
                t = tmp;
            }
            else*/
            {
                //
                var l = t;//1
                var r = t.next; //2
                //r.next = l;//
                //l.next = null;
                
            }

            h = head.next;

        }
        head = t;

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
        /*if (string.IsNullOrWhiteSpace(word))
            return string.Empty;*/

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

