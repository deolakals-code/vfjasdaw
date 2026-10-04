// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaReadyOkResponse : OperationResponseBase // TypeDefIndex: 11608
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20

	// Properties
	public short ReturnCode { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3723CC0 Offset: 0x371FCC0 VA: 0x3723CC0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3723CC8 Offset: 0x371FCC8 VA: 0x3723CC8
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3723CD0 Offset: 0x371FCD0 VA: 0x3723CD0
	public void set_ReturnCode(short value) { }

	// RVA: 0x3723CD8 Offset: 0x371FCD8 VA: 0x3723CD8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3723CE0 Offset: 0x371FCE0 VA: 0x3723CE0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3723CE8 Offset: 0x371FCE8 VA: 0x3723CE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3723D84 Offset: 0x371FD84 VA: 0x3723D84 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
