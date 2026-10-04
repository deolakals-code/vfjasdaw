// Assembly: mscorlib.dll
// Namespace: System
public class Random // TypeDefIndex: 9654
{
	// Fields
	private const int MBIG = 2147483647;
	private const int MSEED = 161803398;
	private const int MZ = 0;
	private int _inext; // 0x10
	private int _inextp; // 0x14
	private int[] _seedArray; // 0x18
	[ThreadStatic]
	private static Random t_threadRandom; // 0x80000000
	private static readonly Random s_globalRandom; // 0x0

	// Methods

	// RVA: 0x2FF6224 Offset: 0x2FF2224 VA: 0x2FF6224
	public void .ctor() { }

	// RVA: 0x2FF6448 Offset: 0x2FF2448 VA: 0x2FF6448
	public void .ctor(int Seed) { }

	// RVA: 0x2FF6608 Offset: 0x2FF2608 VA: 0x2FF6608 Slot: 4
	protected virtual double Sample() { }

	// RVA: 0x2FF6628 Offset: 0x2FF2628 VA: 0x2FF6628
	private int InternalSample() { }

	// RVA: 0x2FF6280 Offset: 0x2FF2280 VA: 0x2FF6280
	private static int GenerateSeed() { }

	// RVA: 0x2FF66B4 Offset: 0x2FF26B4 VA: 0x2FF66B4
	private static int GenerateGlobalSeed() { }

	// RVA: 0x2FF66D8 Offset: 0x2FF26D8 VA: 0x2FF66D8 Slot: 5
	public virtual int Next() { }

	// RVA: 0x2FF66DC Offset: 0x2FF26DC VA: 0x2FF66DC
	private double GetSampleForLargeRange() { }

	// RVA: 0x2FF6728 Offset: 0x2FF2728 VA: 0x2FF6728 Slot: 6
	public virtual int Next(int minValue, int maxValue) { }

	// RVA: 0x2FF6840 Offset: 0x2FF2840 VA: 0x2FF6840 Slot: 7
	public virtual int Next(int maxValue) { }

	// RVA: 0x2FF6904 Offset: 0x2FF2904 VA: 0x2FF6904 Slot: 8
	public virtual double NextDouble() { }

	// RVA: 0x2FF6910 Offset: 0x2FF2910 VA: 0x2FF6910
	private static void .cctor() { }
}
