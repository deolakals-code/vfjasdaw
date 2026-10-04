// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Renovation
public class GuildOpenRenovation : OperationRequestBase // TypeDefIndex: 12421
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

	// RVA: 0x3604CF4 Offset: 0x3600CF4 VA: 0x3604CF4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3604CFC Offset: 0x3600CFC VA: 0x3604CFC
	public byte get_RenovationId() { }

	[CompilerGenerated]
	// RVA: 0x3604D04 Offset: 0x3600D04 VA: 0x3604D04
	public void set_RenovationId(byte value) { }

	// RVA: 0x3604D0C Offset: 0x3600D0C VA: 0x3604D0C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3604D14 Offset: 0x3600D14 VA: 0x3604D14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3604D1C Offset: 0x3600D1C VA: 0x3604D1C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3604DBC Offset: 0x3600DBC VA: 0x3604DBC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
