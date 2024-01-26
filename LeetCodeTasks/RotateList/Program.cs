namespace RotateList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            ListNode head = new ListNode(inputNums[0]);
            ListNode currentNode = head;
            for (int i = 1; i < inputNums.Length; i++)
            {
                currentNode.next = new ListNode(inputNums[i]);
                currentNode = currentNode.next;
            }

            ListNode result = Solution.RotateRight(head, k);
            currentNode = result;
            while (currentNode != null)
            {
                Console.Write(currentNode.val + ",");
                currentNode = currentNode.next;
            }
            Console.WriteLine();
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class Solution
    {
        public static ListNode RotateRight(ListNode head, int k)
        {
            ListNode currentNode = head;
            int numberOfNodes = 0;
            while (currentNode != null)
            {
                numberOfNodes++;
                currentNode = currentNode.next;
            }

            ListNode firstList = head;
            for (int i = 0; i < numberOfNodes - k; i++)
            {
                firstList = firstList.next;
            }


            ListNode secondList = head;
            ListNode curentNodeFromSecondList = secondList;
            for (int i = 0; i < numberOfNodes - k - 1; i++)
            {
                curentNodeFromSecondList = curentNodeFromSecondList.next;
            }
            curentNodeFromSecondList.next = null;

            currentNode = firstList;
            for (int i = 0; i < k - 1; i++)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = secondList;

            return firstList;
        }
    }
}