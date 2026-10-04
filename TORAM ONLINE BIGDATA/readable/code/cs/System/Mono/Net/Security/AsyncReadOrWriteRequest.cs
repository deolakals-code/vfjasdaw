// Assembly: System.dll
// Namespace: Mono.Net.Security
internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest // TypeDefIndex: 13991
{
	// Fields
	[CompilerGenerated]
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <CurrentSize>k__BackingField; // 0x40

	// Properties
	protected BufferOffsetSize UserBuffer { get; }
	protected int CurrentSize { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3199450 Offset: 0x3195450 VA: 0x3199450
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGenerated]
	// RVA: 0x3199458 Offset: 0x3195458 VA: 0x3199458
	protected int get_CurrentSize() { }

	[CompilerGenerated]
	// RVA: 0x3199460 Offset: 0x3195460 VA: 0x3199460
	protected void set_CurrentSize(int value) { }

	// RVA: 0x3199468 Offset: 0x3195468 VA: 0x3199468
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x319950C Offset: 0x319550C VA: 0x319950C Slot: 3
	public override string ToString() { }
}
