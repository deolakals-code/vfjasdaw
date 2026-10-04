// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
[IsReadOnly]
internal struct ForceAsyncAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 9957
{
	// Fields
	private readonly Task _task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x3059A50 Offset: 0x3055A50 VA: 0x3059A50
	internal void .ctor(Task task) { }

	// RVA: 0x3059A58 Offset: 0x3055A58 VA: 0x3059A58
	public ForceAsyncAwaiter GetAwaiter() { }

	// RVA: 0x3059A60 Offset: 0x3055A60 VA: 0x3059A60
	public bool get_IsCompleted() { }

	// RVA: 0x3059A68 Offset: 0x3055A68 VA: 0x3059A68
	public void GetResult() { }

	// RVA: 0x3059AA8 Offset: 0x3055AA8 VA: 0x3059AA8 Slot: 4
	public void UnsafeOnCompleted(Action action) { }
}
