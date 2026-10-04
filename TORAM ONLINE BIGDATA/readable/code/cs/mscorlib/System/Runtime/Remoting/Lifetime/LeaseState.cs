// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
[Serializable]
public enum LeaseState // TypeDefIndex: 10232
{
	// Fields
	public int value__; // 0x0
	public const LeaseState Null = 0;
	public const LeaseState Initial = 1;
	public const LeaseState Active = 2;
	public const LeaseState Renewing = 3;
	public const LeaseState Expired = 4;
}
