using BenchmarkDotNet.Running;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#if RELEASE
var summary = BenchmarkRunner.Run<BenchmarkTest>();
#else
TestCase(new int[] { 0 }, new int[] { 0 });
TestCase(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 });
TestCase(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 });
#endif

void TestCase(int[] x1, int[] x2)
{
	var n1 = Utility.MakeNumberList(x1);
	var n2 = Utility.MakeNumberList(x2);

	var solution = new Solution().AddTwoNumbers(n1, n2);

	printAnswer(solution);
}

void printAnswer(ListNode x)
{
	Console.Write("[");
	while (x != null)
	{
		Console.Write(x.val + ",");
		x = x.next;
	}
	Console.WriteLine("]");
}
