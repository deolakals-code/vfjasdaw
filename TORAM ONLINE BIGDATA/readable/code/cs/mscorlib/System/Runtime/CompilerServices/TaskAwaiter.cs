// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct TaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 10518
{
	// Fields
	internal readonly Task m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x2F208FC Offset: 0x2F1C8FC VA: 0x2F208FC
	internal void .ctor(Task task) { }

	// RVA: 0x2F20904 Offset: 0x2F1C904 VA: 0x2F20904
	public bool get_IsCompleted() { }

	// RVA: 0x2F20738 Offset: 0x2F1C738 VA: 0x2F20738 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	[StackTraceHidden]
	// RVA: 0x2F209D0 Offset: 0x2F1C9D0 VA: 0x2F209D0
	public void GetResult() { }

	[StackTraceHidden]
	// RVA: 0x2F209D8 Offset: 0x2F1C9D8 VA: 0x2F209D8
	internal static void ValidateEnd(Task task) { }

	[StackTraceHidden]
	// RVA: 0x2F20A24 Offset: 0x2F1CA24 VA: 0x2F20A24
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	[StackTraceHidden]
	// RVA: 0x2F20A84 Offset: 0x2F1CA84 VA: 0x2F20A84
	private static void ThrowForNonSuccess(Task task) { }

	// RVA: 0x2F20920 Offset: 0x2F1C920 VA: 0x2F20920
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

	// RVA: 0x2F20BD0 Offset: 0x2F1CBD0 VA: 0x2F20BD0
	private static Action OutputWaitEtwEvents(Task task, Action continuation) { }
}
