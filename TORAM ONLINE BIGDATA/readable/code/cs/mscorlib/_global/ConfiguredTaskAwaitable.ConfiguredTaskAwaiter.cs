// Assembly: mscorlib.dll
// Namespace: 
[IsReadOnly]
public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 10520
{
	// Fields
	internal readonly Task m_task; // 0x0
	internal readonly bool m_continueOnCapturedContext; // 0x8

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x2F20F8C Offset: 0x2F1CF8C VA: 0x2F20F8C
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0x2F20FC0 Offset: 0x2F1CFC0 VA: 0x2F20FC0
	public bool get_IsCompleted() { }

	// RVA: 0x2F20FDC Offset: 0x2F1CFDC VA: 0x2F20FDC Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x2F20FF0 Offset: 0x2F1CFF0 VA: 0x2F20FF0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	[StackTraceHidden]
	// RVA: 0x2F21004 Offset: 0x2F1D004 VA: 0x2F21004
	public void GetResult() { }
}
