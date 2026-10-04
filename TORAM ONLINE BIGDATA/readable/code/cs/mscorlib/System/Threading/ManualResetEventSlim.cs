// Assembly: mscorlib.dll
// Namespace: System.Threading
[DebuggerDisplay("Set = {IsSet}")]
public class ManualResetEventSlim : IDisposable // TypeDefIndex: 9872
{
	// Fields
	private const int DEFAULT_SPIN_SP = 1;
	private object m_lock; // 0x10
	private ManualResetEvent m_eventObj; // 0x18
	private int m_combinedState; // 0x20
	private const int SignalledState_BitMask = -2147483648;
	private const int SignalledState_ShiftCount = 31;
	private const int Dispose_BitMask = 1073741824;
	private const int SpinCountState_BitMask = 1073217536;
	private const int SpinCountState_ShiftCount = 19;
	private const int SpinCountState_MaxValue = 2047;
	private const int NumWaitersState_BitMask = 524287;
	private const int NumWaitersState_ShiftCount = 0;
	private const int NumWaitersState_MaxValue = 524287;
	private static Action<object> s_cancellationTokenCallback; // 0x0

	// Properties
	public WaitHandle WaitHandle { get; }
	public bool IsSet { get; set; }
	public int SpinCount { get; set; }
	private int Waiters { get; set; }

	// Methods

	// RVA: 0x3048550 Offset: 0x3044550 VA: 0x3048550
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x3048764 Offset: 0x3044764 VA: 0x3048764
	public bool get_IsSet() { }

	// RVA: 0x30487C8 Offset: 0x30447C8 VA: 0x30487C8
	private void set_IsSet(bool value) { }

	// RVA: 0x30488C0 Offset: 0x30448C0 VA: 0x30488C0
	public int get_SpinCount() { }

	// RVA: 0x3048928 Offset: 0x3044928 VA: 0x3048928
	private void set_SpinCount(int value) { }

	// RVA: 0x304895C Offset: 0x304495C VA: 0x304895C
	private int get_Waiters() { }

	// RVA: 0x30489B8 Offset: 0x30449B8 VA: 0x30489B8
	private void set_Waiters(int value) { }

	// RVA: 0x3048A44 Offset: 0x3044A44 VA: 0x3048A44
	public void .ctor() { }

	// RVA: 0x3048A4C Offset: 0x3044A4C VA: 0x3048A4C
	public void .ctor(bool initialState) { }

	// RVA: 0x3048B78 Offset: 0x3044B78 VA: 0x3048B78
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x3048AC8 Offset: 0x3044AC8 VA: 0x3048AC8
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x3048C90 Offset: 0x3044C90 VA: 0x3048C90
	private void EnsureLockObjectCreated() { }

	// RVA: 0x30485EC Offset: 0x30445EC VA: 0x30485EC
	private bool LazyInitializeEvent() { }

	// RVA: 0x3048D8C Offset: 0x3044D8C VA: 0x3048D8C
	public void Set() { }

	// RVA: 0x3048D94 Offset: 0x3044D94 VA: 0x3048D94
	private void Set(bool duringCancellation) { }

	// RVA: 0x3048F94 Offset: 0x3044F94 VA: 0x3048F94
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x30495D8 Offset: 0x30455D8 VA: 0x30495D8 Slot: 4
	public void Dispose() { }

	// RVA: 0x3049644 Offset: 0x3045644 VA: 0x3049644 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x304858C Offset: 0x304458C VA: 0x304858C
	private void ThrowIfDisposed() { }

	// RVA: 0x3049740 Offset: 0x3045740 VA: 0x3049740
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x30487E8 Offset: 0x30447E8 VA: 0x30487E8
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x304891C Offset: 0x304491C VA: 0x304891C
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0x30487C0 Offset: 0x30447C0 VA: 0x30487C0
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x30498B4 Offset: 0x30458B4 VA: 0x30498B4
	private static void .cctor() { }
}
