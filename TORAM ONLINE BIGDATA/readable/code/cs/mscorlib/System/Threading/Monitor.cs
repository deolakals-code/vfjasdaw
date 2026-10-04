// Assembly: mscorlib.dll
// Namespace: System.Threading
public static class Monitor // TypeDefIndex: 9903
{
	// Methods

	// RVA: 0x304B9C0 Offset: 0x30479C0 VA: 0x304B9C0
	public static void Enter(object obj) { }

	// RVA: 0x3048D10 Offset: 0x3044D10 VA: 0x3048D10
	public static void Enter(object obj, ref bool lockTaken) { }

	// RVA: 0x304FFDC Offset: 0x304BFDC VA: 0x304FFDC
	private static void ThrowLockTakenException() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x304B9C4 Offset: 0x30479C4 VA: 0x304B9C4
	public static void Exit(object obj) { }

	// RVA: 0x3050054 Offset: 0x304C054 VA: 0x3050054
	public static void TryEnter(object obj, ref bool lockTaken) { }

	// RVA: 0x3050108 Offset: 0x304C108 VA: 0x3050108
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x30495D0 Offset: 0x30455D0 VA: 0x30495D0
	public static bool Wait(object obj, int millisecondsTimeout) { }

	// RVA: 0x304CBF8 Offset: 0x3048BF8 VA: 0x304CBF8
	public static void Pulse(object obj) { }

	// RVA: 0x3048F40 Offset: 0x3044F40 VA: 0x3048F40
	public static void PulseAll(object obj) { }

	// RVA: 0x30502D4 Offset: 0x304C2D4 VA: 0x30502D4
	private static bool Monitor_test_synchronised(object obj) { }

	// RVA: 0x30502D8 Offset: 0x304C2D8 VA: 0x30502D8
	private static void Monitor_pulse(object obj) { }

	// RVA: 0x3050214 Offset: 0x304C214 VA: 0x3050214
	private static void ObjPulse(object obj) { }

	// RVA: 0x30502DC Offset: 0x304C2DC VA: 0x30502DC
	private static void Monitor_pulse_all(object obj) { }

	// RVA: 0x3050274 Offset: 0x304C274 VA: 0x3050274
	private static void ObjPulseAll(object obj) { }

	// RVA: 0x30502E0 Offset: 0x304C2E0 VA: 0x30502E0
	private static bool Monitor_wait(object obj, int ms) { }

	// RVA: 0x3050164 Offset: 0x304C164 VA: 0x3050164
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	// RVA: 0x30502E4 Offset: 0x304C2E4 VA: 0x30502E4
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x3050074 Offset: 0x304C074 VA: 0x3050074
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	// RVA: 0x3050048 Offset: 0x304C048 VA: 0x3050048
	private static void ReliableEnter(object obj, ref bool lockTaken) { }
}
