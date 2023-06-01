using BenchmarkDotNet.Attributes;

public class BenchmarkTest
{
	private readonly Solution solution = new Solution();
	private readonly ListNode n1 = Utility.MakeNumberList(new int[] { 0 });
	private readonly ListNode n2 = Utility.MakeNumberList(new int[] { 0 });
	private readonly ListNode n3 = Utility.MakeNumberList(new int[] { 2, 4, 3 });
	private readonly ListNode n4 = Utility.MakeNumberList(new int[] { 5, 6, 4 });
	private readonly ListNode n5 = Utility.MakeNumberList(new int[] { 9, 9, 9, 9, 9, 9, 9 });
	private readonly ListNode n6 = Utility.MakeNumberList(new int[] { 9, 9, 9, 9 });

	private const int Iterations = 10_000;
	[Benchmark]
	public void Conditional()
	{
		for (int x = 0; x < Iterations; x++)
		{
			var s1 = solution.AddTwoNumbers(n1, n2);
			var s2 = solution.AddTwoNumbers(n3, n4);
			var s3 = solution.AddTwoNumbers(n5, n6);
		}
	}

	[Benchmark]
	public void NoConditional()
	{
		for (int x = 0; x < Iterations; x++)
		{
			var s1 = solution.IsThisFaster(n1, n2);
			var s2 = solution.IsThisFaster(n3, n4);
			var s3 = solution.IsThisFaster(n5, n6);
		}
	}
}
