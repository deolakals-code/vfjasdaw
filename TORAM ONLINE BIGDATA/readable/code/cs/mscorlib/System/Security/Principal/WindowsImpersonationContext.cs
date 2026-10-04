// Assembly: mscorlib.dll
// Namespace: System.Security.Principal
[ComVisible(True)]
public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 10182
{
	// Fields
	private IntPtr _token; // 0x10
	private bool undo; // 0x18

	// Methods

	// RVA: 0x2EC8164 Offset: 0x2EC4164 VA: 0x2EC8164
	internal void .ctor(IntPtr token) { }

	[ComVisible(False)]
	// RVA: 0x2EC8734 Offset: 0x2EC4734 VA: 0x2EC8734 Slot: 4
	public void Dispose() { }

	// RVA: 0x2EC8744 Offset: 0x2EC4744 VA: 0x2EC8744
	public void Undo() { }

	// RVA: 0x2EC8808 Offset: 0x2EC4808 VA: 0x2EC8808
	private static bool CloseToken(IntPtr token) { }

	// RVA: 0x2EC872C Offset: 0x2EC472C VA: 0x2EC872C
	private static IntPtr DuplicateToken(IntPtr token) { }

	// RVA: 0x2EC8730 Offset: 0x2EC4730 VA: 0x2EC8730
	private static bool SetCurrentToken(IntPtr token) { }

	// RVA: 0x2EC8804 Offset: 0x2EC4804 VA: 0x2EC8804
	private static bool RevertToSelf() { }
}
