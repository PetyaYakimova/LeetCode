namespace AddTwoNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] firstListInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] secondListInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			ListNode firstList = GetListNodeFromArray(firstListInput);
			ListNode secondList = GetListNodeFromArray(secondListInput);

			ListNode result = CalculatingResultFromTwoListNodes.AddTwoNumbers(firstList, secondList);
			PrintListNode(result);
		}

		public static ListNode GetListNodeFromArray(int[] array)
		{
			ListNode node = new ListNode(array[0], null);
			ListNode currentNode = node;
			for (int i = 1; i < array.Length; i++)
			{
				currentNode.next = new ListNode(array[i], null);
				currentNode = currentNode.next;
			}

			return node;
		}

		public static void PrintListNode(ListNode node)
		{
			ListNode currentNode = node;
			while (currentNode != null)
			{
				Console.Write(currentNode.val + " ");
				currentNode = currentNode.next;
			}

			Console.WriteLine();
		}
	}

	public static class CalculatingResultFromTwoListNodes
	{
		public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			//Get the first digit of the result
			int total = l1.val + l2.val;
			int currentDigit = total % 10;
			int transferred = total / 10;
			ListNode result = new ListNode(currentDigit, null);
			l1 = l1.next;
			l2 = l2.next;

			ListNode currentResultNode = result;

			//While both list nodes still have digits
			while (l1 != null && l2 != null)
			{
				total = l1.val + l2.val + transferred;
				currentDigit = total % 10;
				transferred = total / 10;
				currentResultNode.next = new ListNode(currentDigit, null);
				currentResultNode = currentResultNode.next;

				l1 = l1.next;
				l2 = l2.next;
			}

			//There are still digits from the second list node
			if (l1 == null && l2 != null)
			{
				while (l2 != null)
				{
					total = l2.val + transferred;
					currentDigit = total % 10;
					transferred = total / 10;
					currentResultNode.next = new ListNode(currentDigit, null);
					currentResultNode = currentResultNode.next;

					l2 = l2.next;
				}
			}

			//There are still digits from the first list node
			if (l1 != null && l2 == null)
			{
				while (l1 != null)
				{
					total = l1.val + transferred;
					currentDigit = total % 10;
					transferred = total / 10;
					currentResultNode.next = new ListNode(currentDigit, null);
					currentResultNode = currentResultNode.next;

					l1 = l1.next;
				}
			}

			//If there is one last transferred value to be added to the result
			if (l1 == null && l2 == null && transferred != 0)
			{
				currentResultNode.next = new ListNode(transferred, null);
			}

			return result;
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


}