// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Renovation
public class GuildChangeRenovation : OperationRequestBase // TypeDefIndex: 12422
{
	// Fields
	[CompilerGenerated]
	private byte <RenovationId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 0)]
	public byte RenovationId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3604EDC Offset: 0x3600EDC VA: 0x3604EDC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3604EE4 Offset: 0x3600EE4 VA: 0x3604EE4
	public byte get_RenovationId() { }

	[CompilerGenerated]
	// RVA: 0x3604EEC Offset: 0x3600EEC VA: 0x3604EEC
	public void set_RenovationId(byte value) { }

	// RVA: 0x3604EF4 Offset: 0x3600EF4 VA: 0x3604EF4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3604EFC Offset: 0x3600EFC VA: 0x3604EFC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3604F04 Offset: 0x3600F04 VA: 0x3604F04 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3604FA4 Offset: 0x3600FA4 VA: 0x3604FA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
