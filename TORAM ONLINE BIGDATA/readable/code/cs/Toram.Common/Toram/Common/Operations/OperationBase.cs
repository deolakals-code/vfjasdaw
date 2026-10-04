// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public abstract class OperationBase : PacketBase // TypeDefIndex: 11372
{
	// Fields
	private static int OperationRevision; // 0x0
	[CompilerGenerated]
	private byte <Revision>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 129)]
	public byte Revision { get; set; }

	// Methods

	// RVA: 0x36FB83C Offset: 0x36F783C VA: 0x36FB83C
	protected static byte GetNextOperationRevision() { }

	// RVA: 0x36FB888 Offset: 0x36F7888 VA: 0x36FB888
	public void .ctor() { }

	// RVA: 0x36FB8A8 Offset: 0x36F78A8 VA: 0x36FB8A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36FB8B0 Offset: 0x36F78B0 VA: 0x36FB8B0
	public byte get_Revision() { }

	[CompilerGenerated]
	// RVA: 0x36FB8B8 Offset: 0x36F78B8 VA: 0x36FB8B8
	private void set_Revision(byte value) { }

	// RVA: 0x36FB8C0 Offset: 0x36F78C0 VA: 0x36FB8C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FB9E0 Offset: 0x36F79E0 VA: 0x36FB9E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
