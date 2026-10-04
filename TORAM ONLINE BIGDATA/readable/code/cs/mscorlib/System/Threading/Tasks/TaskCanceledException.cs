// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
[Serializable]
public class TaskCanceledException : OperationCanceledException // TypeDefIndex: 9944
{
	// Fields
	private readonly Task _canceledTask; // 0x98

	// Methods

	// RVA: 0x3058398 Offset: 0x3054398 VA: 0x3058398
	public void .ctor() { }

	// RVA: 0x30583E4 Offset: 0x30543E4 VA: 0x30583E4
	public void .ctor(Task task) { }

	// RVA: 0x3058490 Offset: 0x3054490 VA: 0x3058490
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}
