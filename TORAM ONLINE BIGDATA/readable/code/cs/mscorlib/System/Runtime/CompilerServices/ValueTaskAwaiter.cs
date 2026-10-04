// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ValueTaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 10515
{
	// Fields
	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x2F204F0 Offset: 0x2F1C4F0 VA: 0x2F204F0
	internal void .ctor(ValueTask value) { }

	// RVA: 0x2F204FC Offset: 0x2F1C4FC VA: 0x2F204FC
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x2F20554 Offset: 0x2F1C554 VA: 0x2F20554
	public void GetResult() { }

	// RVA: 0x2F205AC Offset: 0x2F1C5AC VA: 0x2F205AC Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x2F20748 Offset: 0x2F1C748 VA: 0x2F20748
	private static void .cctor() { }
}
