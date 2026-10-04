// Assembly: mscorlib.dll
// Namespace: System.Runtime.InteropServices
public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 10465
{
	// Fields
	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x2F1D9B8 Offset: 0x2F199B8 VA: 0x2F1D9B8
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0x2F1DA58 Offset: 0x2F19A58 VA: 0x2F1DA58
	protected void .ctor() { }

	// RVA: 0x2F1DA94 Offset: 0x2F19A94 VA: 0x2F1DA94 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2F1DB34 Offset: 0x2F19B34 VA: 0x2F1DB34
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2F1DB3C Offset: 0x2F19B3C VA: 0x2F1DB3C
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2F1DB44 Offset: 0x2F19B44 VA: 0x2F1DB44
	public bool get_IsClosed() { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContract(3, 2)]
	// RVA: 0x2F1DB50 Offset: 0x2F19B50 VA: 0x2F1DB50
	public void Close() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2F1DB60 Offset: 0x2F19B60 VA: 0x2F1DB60 Slot: 4
	public void Dispose() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2F1DB70 Offset: 0x2F19B70 VA: 0x2F1DB70 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

	[ReliabilityContract(3, 2)]
	// RVA: 0x2F1DC40 Offset: 0x2F19C40 VA: 0x2F1DC40
	public void SetHandleAsInvalid() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x2F1D180 Offset: 0x2F19180 VA: 0x2F1D180
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2F1D2EC Offset: 0x2F192EC VA: 0x2F1D2EC
	public void DangerousRelease() { }

	// RVA: 0x2F1DB8C Offset: 0x2F19B8C VA: 0x2F1DB8C
	private void InternalDispose() { }

	// RVA: 0x2F1DC2C Offset: 0x2F19C2C VA: 0x2F1DC2C
	private void InternalFinalize() { }

	// RVA: 0x2F1DCC4 Offset: 0x2F19CC4 VA: 0x2F1DCC4
	private void DangerousReleaseInternal(bool dispose) { }
}
