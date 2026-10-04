// Assembly: System.dll
// Namespace: 
private class ServicePointScheduler.ConnectionGroup // TypeDefIndex: 14502
{
	// Fields
	[CompilerGenerated]
	private readonly ServicePointScheduler <Scheduler>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	private static int nextId; // 0x0
	public readonly int ID; // 0x20
	private LinkedList<WebConnection> connections; // 0x28
	private LinkedList<WebOperation> queue; // 0x30

	// Properties
	public ServicePointScheduler Scheduler { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3518300 Offset: 0x3514300 VA: 0x3518300
	public ServicePointScheduler get_Scheduler() { }

	// RVA: 0x3516A9C Offset: 0x3512A9C VA: 0x3516A9C
	public void .ctor(ServicePointScheduler scheduler, string name) { }

	// RVA: 0x3517194 Offset: 0x3513194 VA: 0x3517194
	public bool IsEmpty() { }

	// RVA: 0x35178C4 Offset: 0x35138C4 VA: 0x35178C4
	public void RemoveConnection(WebConnection connection) { }

	// RVA: 0x3517A18 Offset: 0x3513A18 VA: 0x3517A18
	public void Cleanup() { }

	// RVA: 0x351815C Offset: 0x351415C VA: 0x351815C
	public void EnqueueOperation(WebOperation operation) { }

	// RVA: 0x3517CE0 Offset: 0x3513CE0 VA: 0x3517CE0
	public WebOperation GetNextOperation() { }

	// RVA: 0x3518370 Offset: 0x3514370 VA: 0x3518370
	public WebConnection FindIdleConnection(WebOperation operation) { }

	// RVA: 0x3517B04 Offset: 0x3513B04 VA: 0x3517B04
	public ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force) { }
}
