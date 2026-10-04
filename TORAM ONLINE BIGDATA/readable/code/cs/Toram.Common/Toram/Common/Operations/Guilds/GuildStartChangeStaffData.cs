// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildStartChangeStaffData : OperationRequestBase // TypeDefIndex: 12365
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 245)]
	public byte Type { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FB9A4 Offset: 0x35F79A4 VA: 0x35FB9A4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35FB9AC Offset: 0x35F79AC VA: 0x35FB9AC
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35FB9B4 Offset: 0x35F79B4 VA: 0x35FB9B4
	public void set_Type(byte value) { }

	// RVA: 0x35FB9BC Offset: 0x35F79BC VA: 0x35FB9BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FB9C4 Offset: 0x35F79C4 VA: 0x35FB9C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FB9CC Offset: 0x35F79CC VA: 0x35FB9CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35FBA6C Offset: 0x35F7A6C VA: 0x35FBA6C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
