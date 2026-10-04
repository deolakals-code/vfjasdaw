// Assembly: mscorlib.dll
// Namespace: System.Threading
[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
[IsReadOnly]
public struct CancellationToken // TypeDefIndex: 9871
{
	// Fields
	private readonly CancellationTokenSource _source; // 0x0
	private static readonly Action<object> s_actionToActionObjShunt; // 0x0

	// Properties
	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }

	// Methods

	// RVA: 0x304799C Offset: 0x304399C VA: 0x304799C
	public static CancellationToken get_None() { }

	// RVA: 0x30479A4 Offset: 0x30439A4 VA: 0x30479A4
	public bool get_IsCancellationRequested() { }

	// RVA: 0x30479EC Offset: 0x30439EC VA: 0x30479EC
	public bool get_CanBeCanceled() { }

	// RVA: 0x30479FC Offset: 0x30439FC VA: 0x30479FC
	internal void .ctor(CancellationTokenSource source) { }

	// RVA: 0x3047A04 Offset: 0x3043A04 VA: 0x3047A04
	public void .ctor(bool canceled) { }

	// RVA: 0x3047AA0 Offset: 0x3043AA0 VA: 0x3047AA0
	public CancellationTokenRegistration Register(Action callback) { }

	// RVA: 0x3047CC4 Offset: 0x3043CC4 VA: 0x3047CC4
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	// RVA: 0x3047B98 Offset: 0x3043B98 VA: 0x3047B98
	public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	// RVA: 0x30480E0 Offset: 0x30440E0 VA: 0x30480E0
	public bool Equals(CancellationToken other) { }

	// RVA: 0x30480F0 Offset: 0x30440F0 VA: 0x30480F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3048198 Offset: 0x3044198 VA: 0x3048198 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x304820C Offset: 0x304420C VA: 0x304820C
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x3048270 Offset: 0x3044270 VA: 0x3048270
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x30482D4 Offset: 0x30442D4 VA: 0x30482D4
	public void ThrowIfCancellationRequested() { }

	// RVA: 0x304834C Offset: 0x304434C VA: 0x304834C
	private void ThrowOperationCanceledException() { }

	// RVA: 0x30483A4 Offset: 0x30443A4 VA: 0x30483A4
	private static void .cctor() { }
}
