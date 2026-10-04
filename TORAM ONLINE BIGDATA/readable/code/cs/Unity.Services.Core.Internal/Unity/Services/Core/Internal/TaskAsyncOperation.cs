// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal class TaskAsyncOperation : AsyncOperationBase // TypeDefIndex: 17552
{
	// Fields
	internal static TaskScheduler Scheduler; // 0x0
	private Task m_Task; // 0x10

	// Properties
	public override bool IsCompleted { get; }

	// Methods

	// RVA: 0x37AACB4 Offset: 0x37A6CB4 VA: 0x37AACB4 Slot: 9
	public override bool get_IsCompleted() { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x37AACD0 Offset: 0x37A6CD0 VA: 0x37AACD0
	internal static void SetScheduler() { }
}
