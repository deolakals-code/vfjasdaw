// Assembly: mscorlib.dll
// Namespace: System.Threading
public struct SpinWait // TypeDefIndex: 9874
{
	// Fields
	internal static readonly int SpinCountforSpinBeforeWait; // 0x0
	private int _count; // 0x0

	// Properties
	public int Count { get; }
	public bool NextSpinWillYield { get; }

	// Methods

	// RVA: 0x3049954 Offset: 0x3045954 VA: 0x3049954
	public int get_Count() { }

	// RVA: 0x304995C Offset: 0x304595C VA: 0x304995C
	public bool get_NextSpinWillYield() { }

	// RVA: 0x304985C Offset: 0x304585C VA: 0x304985C
	public void SpinOnce() { }

	// RVA: 0x304949C Offset: 0x304549C VA: 0x304949C
	public void SpinOnce(int sleep1Threshold) { }

	// RVA: 0x30499D4 Offset: 0x30459D4 VA: 0x30499D4
	private void SpinOnceCore(int sleep1Threshold) { }

	// RVA: 0x3049B80 Offset: 0x3045B80 VA: 0x3049B80
	private static void .cctor() { }
}
