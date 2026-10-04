// Assembly: mscorlib.dll
// Namespace: System.Threading
[ComVisible(True)]
public sealed class Mutex : WaitHandle // TypeDefIndex: 9931
{
	// Methods

	// RVA: 0x30560DC Offset: 0x30520DC VA: 0x30560DC
	private static IntPtr CreateMutex_icall(bool initiallyOwned, char* name, int name_length, out bool created) { }

	// RVA: 0x30560E4 Offset: 0x30520E4 VA: 0x30560E4
	private static bool ReleaseMutex_internal(IntPtr handle) { }

	// RVA: 0x30560E8 Offset: 0x30520E8 VA: 0x30560E8
	private static IntPtr CreateMutex_internal(bool initiallyOwned, string name, out bool created) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x305612C Offset: 0x305212C VA: 0x305612C
	public void .ctor(bool initiallyOwned) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x30561C8 Offset: 0x30521C8 VA: 0x30561C8
	public void ReleaseMutex() { }
}
