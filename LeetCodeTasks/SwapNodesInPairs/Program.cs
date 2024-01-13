namespace SwapNodesInPairs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] inputNums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			ListNode head = new ListNode(inputNums[0]);
			ListNode currentNode = head;
			for (int i = 1; i < inputNums.Length; i++)
			{
				currentNode.next = new ListNode(inputNums[i]);
				currentNode = currentNode.next;
			}

			ListNode result = Solution.SwapPairs(head);
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
		public static ListNode SwapPairs(ListNode head)
		{
			if (head == null || head.next == null)
			{
				return head;
			}

			ListNode result = head;
			ListNode currentNode = result;
			ListNode curr = currentNode;
			ListNode next = currentNode.next;
			curr.next = next.next;
			next.next = curr;

			ListNode prev = currentNode;
			currentNode = currentNode.next;
			result = next;

			while (currentNode!=null && currentNode.next != null)
			{
				curr = currentNode;
				next = currentNode.next;
				curr.next = next.next;
				next.next = curr;
				prev.next = next;

				prev = currentNode;
				currentNode = currentNode.next;
			}

			return result;
		}
	}
}