// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 16379
{
	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x37F08A8 Offset: 0x37EC8A8 VA: 0x37F08A8
	private void .ctor(int mainThreadID) { }

	// RVA: 0x37F096C Offset: 0x37EC96C VA: 0x37F096C
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x37F0A24 Offset: 0x37ECA24 VA: 0x37F0A24 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x37F0DCC Offset: 0x37ECDCC VA: 0x37F0DCC Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x37F0DD8 Offset: 0x37ECDD8 VA: 0x37F0DD8 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x37F0DE4 Offset: 0x37ECDE4 VA: 0x37F0DE4 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x37F0F90 Offset: 0x37ECF90 VA: 0x37F0F90 Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x37F0FF4 Offset: 0x37ECFF4 VA: 0x37F0FF4
	public void Exec() { }

	// RVA: 0x37F1280 Offset: 0x37ED280 VA: 0x37F1280
	private bool HasPendingTasks() { }

	[RequiredByNativeCode]
	// RVA: 0x37F12E0 Offset: 0x37ED2E0 VA: 0x37F12E0
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCode]
	// RVA: 0x37F1358 Offset: 0x37ED358 VA: 0x37F1358
	private static void ExecuteTasks() { }

	[RequiredByNativeCode]
	// RVA: 0x37F13B0 Offset: 0x37ED3B0 VA: 0x37F13B0
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }
}
