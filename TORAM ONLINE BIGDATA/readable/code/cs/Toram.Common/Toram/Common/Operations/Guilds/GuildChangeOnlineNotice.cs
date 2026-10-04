// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildChangeOnlineNotice : OperationRequestBase // TypeDefIndex: 12354
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 245)]
	public byte Type { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F99A4 Offset: 0x35F59A4 VA: 0x35F99A4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F99AC Offset: 0x35F59AC VA: 0x35F99AC
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35F99B4 Offset: 0x35F59B4 VA: 0x35F99B4
	public void set_Type(byte value) { }

	// RVA: 0x35F99BC Offset: 0x35F59BC VA: 0x35F99BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F99C4 Offset: 0x35F59C4 VA: 0x35F99C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F99CC Offset: 0x35F59CC VA: 0x35F99CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F9AEC Offset: 0x35F5AEC VA: 0x35F9AEC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
