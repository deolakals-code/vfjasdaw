// Assembly: System.dll
// Namespace: System.Net.Sockets
internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid // TypeDefIndex: 14588
{
	// Fields
	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0x3451F2C Offset: 0x344DF2C VA: 0x3451F2C
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x345ECAC Offset: 0x345ACAC VA: 0x345ECAC Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x34556A0 Offset: 0x34516A0 VA: 0x34556A0
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x345F250 Offset: 0x345B250 VA: 0x345F250
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x345F440 Offset: 0x345B440 VA: 0x345F440
	private static void .cctor() { }
}
