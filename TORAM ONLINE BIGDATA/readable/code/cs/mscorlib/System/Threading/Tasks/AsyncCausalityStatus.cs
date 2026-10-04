// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal enum AsyncCausalityStatus // TypeDefIndex: 10004
{
	// Fields
	public int value__; // 0x0
	public const AsyncCausalityStatus Started = 0;
	public const AsyncCausalityStatus Completed = 1;
	public const AsyncCausalityStatus Canceled = 2;
	public const AsyncCausalityStatus Error = 3;
}
