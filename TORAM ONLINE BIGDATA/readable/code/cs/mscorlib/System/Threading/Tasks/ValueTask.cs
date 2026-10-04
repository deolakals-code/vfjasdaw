// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
[IsReadOnly]
public struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 9952
{
	// Fields
	private static readonly Task s_canceledTask; // 0x0
	internal readonly object _obj; // 0x0
	internal readonly short _token; // 0x8
	internal readonly bool _continueOnCapturedContext; // 0xA

	// Properties
	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x3058B14 Offset: 0x3054B14 VA: 0x3058B14
	internal static Task get_CompletedTask() { }

	// RVA: 0x3058B9C Offset: 0x3054B9C VA: 0x3058B9C
	public void .ctor(Task task) { }

	// RVA: 0x3058BE0 Offset: 0x3054BE0 VA: 0x3058BE0
	public void .ctor(IValueTaskSource source, short token) { }

	// RVA: 0x3058C28 Offset: 0x3054C28 VA: 0x3058C28 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3058C40 Offset: 0x3054C40 VA: 0x3058C40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3058CF8 Offset: 0x3054CF8 VA: 0x3058CF8 Slot: 4
	public bool Equals(ValueTask other) { }

	// RVA: 0x3058D1C Offset: 0x3054D1C VA: 0x3058D1C
	public Task AsTask() { }

	// RVA: 0x3058DE8 Offset: 0x3054DE8 VA: 0x3058DE8
	private Task GetTaskForValueTaskSource(IValueTaskSource t) { }

	// RVA: 0x30592AC Offset: 0x30552AC VA: 0x30592AC
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x30593B0 Offset: 0x30553B0 VA: 0x30593B0
	internal void ThrowIfCompletedUnsuccessfully() { }

	// RVA: 0x30594B4 Offset: 0x30554B4 VA: 0x30594B4
	public ValueTaskAwaiter GetAwaiter() { }

	// RVA: 0x30594E0 Offset: 0x30554E0 VA: 0x30594E0
	private static void .cctor() { }
}
