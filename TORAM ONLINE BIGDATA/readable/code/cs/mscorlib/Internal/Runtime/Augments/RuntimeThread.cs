// Assembly: mscorlib.dll
// Namespace: Internal.Runtime.Augments
internal sealed class RuntimeThread // TypeDefIndex: 9505
{
	// Fields
	internal static readonly int OptimalMaxSpinWaitsPerSpinIteration; // 0x0
	private readonly Thread thread; // 0x10

	// Properties
	public bool IsBackground { set; }

	// Methods

	// RVA: 0x2E80178 Offset: 0x2E7C178 VA: 0x2E80178
	private void .ctor(Thread t) { }

	// RVA: 0x2E801A8 Offset: 0x2E7C1A8 VA: 0x2E801A8
	public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize) { }

	// RVA: 0x2E8024C Offset: 0x2E7C24C VA: 0x2E8024C
	public void set_IsBackground(bool value) { }

	// RVA: 0x2E8026C Offset: 0x2E7C26C VA: 0x2E8026C
	public void Start(object state) { }

	// RVA: 0x2E80288 Offset: 0x2E7C288 VA: 0x2E80288
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x2E80290 Offset: 0x2E7C290 VA: 0x2E80290
	public static bool Yield() { }

	// RVA: 0x2E80298 Offset: 0x2E7C298 VA: 0x2E80298
	public static bool SpinWait(int iterations) { }

	// RVA: 0x2E802B0 Offset: 0x2E7C2B0 VA: 0x2E802B0
	public static int GetCurrentProcessorId() { }

	// RVA: 0x2E802B8 Offset: 0x2E7C2B8 VA: 0x2E802B8
	private static void .cctor() { }
}
