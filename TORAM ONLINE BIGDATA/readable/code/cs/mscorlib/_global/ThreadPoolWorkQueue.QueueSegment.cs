// Assembly: mscorlib.dll
// Namespace: 
internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 9921
{
	// Fields
	internal readonly IThreadPoolWorkItem[] nodes; // 0x10
	private int indexes; // 0x18
	public ThreadPoolWorkQueue.QueueSegment Next; // 0x20

	// Methods

	// RVA: 0x3053B54 Offset: 0x304FB54 VA: 0x3053B54
	private void GetIndexes(out int upper, out int lower) { }

	// RVA: 0x3053B88 Offset: 0x304FB88 VA: 0x3053B88
	private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x3051FFC Offset: 0x304DFFC VA: 0x3051FFC
	public void .ctor() { }

	// RVA: 0x3053298 Offset: 0x304F298 VA: 0x3053298
	public bool IsUsedUp() { }

	// RVA: 0x30527EC Offset: 0x304E7EC VA: 0x30527EC
	public bool TryEnqueue(IThreadPoolWorkItem node) { }

	// RVA: 0x3053140 Offset: 0x304F140 VA: 0x3053140
	public bool TryDequeue(out IThreadPoolWorkItem node) { }
}
