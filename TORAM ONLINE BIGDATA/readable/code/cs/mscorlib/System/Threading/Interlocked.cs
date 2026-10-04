// Assembly: mscorlib.dll
// Namespace: System.Threading
public static class Interlocked // TypeDefIndex: 9929
{
	// Methods

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055CF0 Offset: 0x3051CF0 VA: 0x3055CF0
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055CF4 Offset: 0x3051CF4 VA: 0x3055CF4
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055CF8 Offset: 0x3051CF8 VA: 0x3055CF8
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055CFC Offset: 0x3051CFC VA: 0x3055CFC
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	// RVA: 0x3055D28 Offset: 0x3051D28 VA: 0x3055D28
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055D2C Offset: 0x3051D2C VA: 0x3055D2C
	public static int Decrement(ref int location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055D30 Offset: 0x3051D30 VA: 0x3055D30
	public static int Increment(ref int location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055D34 Offset: 0x3051D34 VA: 0x3055D34
	public static long Increment(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055D38 Offset: 0x3051D38 VA: 0x3055D38
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055D3C Offset: 0x3051D3C VA: 0x3055D3C
	private static void Exchange(ref object location1, ref object value, ref object result) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055D40 Offset: 0x3051D40 VA: 0x3055D40
	public static object Exchange(ref object location1, object value) { }

	// RVA: 0x3055D64 Offset: 0x3051D64 VA: 0x3055D64
	public static float Exchange(ref float location1, float value) { }

	// RVA: 0x3055D68 Offset: 0x3051D68 VA: 0x3055D68
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055D6C Offset: 0x3051D6C VA: 0x3055D6C
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	// RVA: 0x3055D70 Offset: 0x3051D70 VA: 0x3055D70
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[Intrinsic]
	[ReliabilityContract(3, 2)]
	[ComVisible(False)]
	// RVA: -1 Offset: -1
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.CompareExchange<object>
	*/

	// RVA: 0x3055D74 Offset: 0x3051D74 VA: 0x3055D74
	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055D78 Offset: 0x3051D78 VA: 0x3055D78
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	// RVA: 0x3055D7C Offset: 0x3051D7C VA: 0x3055D7C
	public static double Exchange(ref double location1, double value) { }

	[ReliabilityContract(3, 2)]
	[Intrinsic]
	[ComVisible(False)]
	// RVA: -1 Offset: -1
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.Exchange<object>
	*/

	// RVA: 0x3055D80 Offset: 0x3051D80 VA: 0x3055D80
	public static long Read(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3055D84 Offset: 0x3051D84 VA: 0x3055D84
	public static int Add(ref int location1, int value) { }

	// RVA: 0x3055D88 Offset: 0x3051D88 VA: 0x3055D88
	public static void MemoryBarrier() { }
}
