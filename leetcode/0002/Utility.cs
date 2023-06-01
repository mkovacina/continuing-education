public static class Utility
{
	public static ListNode MakeNumberList(int[] digits)
	{
		var number = new ListNode(0);
		var head = number;
		foreach (var digit in digits)
		{
			head.next = new ListNode(digit);
			head = head.next;
		}

		return number.next;
	}
}