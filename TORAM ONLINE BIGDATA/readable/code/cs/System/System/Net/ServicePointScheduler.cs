// Assembly: System.dll
// Namespace: System.Net
internal class ServicePointScheduler // TypeDefIndex: 14507
{
	// Fields
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; // 0x10
	private int running; // 0x18
	private int maxIdleTime; // 0x1C
	private ServicePointScheduler.AsyncManualResetEvent schedulerEvent; // 0x20
	private ServicePointScheduler.ConnectionGroup defaultGroup; // 0x28
	private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups; // 0x30
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations; // 0x38
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections; // 0x40
	private int currentConnections; // 0x48
	private int connectionLimit; // 0x4C
	private DateTime idleSince; // 0x50
	private static int nextId; // 0x0
	public readonly int ID; // 0x58

	// Properties
	private ServicePoint ServicePoint { get; set; }
	public int MaxIdleTime { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x35169D8 Offset: 0x35129D8 VA: 0x35169D8
	private ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	// RVA: 0x35169E0 Offset: 0x35129E0 VA: 0x35169E0
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x35169E8 Offset: 0x35129E8 VA: 0x35169E8
	public int get_MaxIdleTime() { }

	// RVA: 0x3514EC8 Offset: 0x3510EC8 VA: 0x3514EC8
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x3516BD4 Offset: 0x3512BD4 VA: 0x3516BD4
	public void Run() { }

	[AsyncStateMachine(typeof(ServicePointScheduler.<RunScheduler>d__32))]
	// RVA: 0x3516ECC Offset: 0x3512ECC VA: 0x3516ECC
	private Task RunScheduler() { }

	// RVA: 0x3516FB4 Offset: 0x3512FB4 VA: 0x3516FB4
	private void Cleanup() { }

	// RVA: 0x3517208 Offset: 0x3513208 VA: 0x3517208
	private void RunSchedulerIteration() { }

	// RVA: 0x3517534 Offset: 0x3513534 VA: 0x3517534
	private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x3517CA8 Offset: 0x3513CA8 VA: 0x3517CA8
	private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x3517454 Offset: 0x3513454 VA: 0x3517454
	private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group) { }

	// RVA: 0x3517DC8 Offset: 0x3513DC8 VA: 0x3517DC8
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x351794C Offset: 0x351394C VA: 0x351794C
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x3517E94 Offset: 0x3513E94 VA: 0x3517E94
	private void FinalCleanup() { }

	// RVA: 0x3515A40 Offset: 0x3511A40 VA: 0x3515A40
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x3517F5C Offset: 0x3513F5C VA: 0x3517F5C
	private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x35181B4 Offset: 0x35141B4 VA: 0x35181B4
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x35181C0 Offset: 0x35141C0 VA: 0x35181C0
	private void OnConnectionClosed(WebConnection connection) { }

	[AsyncStateMachine(typeof(ServicePointScheduler.<WaitAsync>d__46))]
	// RVA: 0x35181DC Offset: 0x35141DC VA: 0x35181DC
	public static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout) { }

	[CompilerGenerated]
	// RVA: 0x35182FC Offset: 0x35142FC VA: 0x35182FC
	private Task <Run>b__31_0() { }
}
