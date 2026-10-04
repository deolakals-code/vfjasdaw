// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildPresent : OperationRequestBase // TypeDefIndex: 12400
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20

	// Properties
	public byte Type { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3601D04 Offset: 0x35FDD04 VA: 0x3601D04
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3601D0C Offset: 0x35FDD0C VA: 0x3601D0C
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3601D14 Offset: 0x35FDD14 VA: 0x3601D14
	public void set_Type(byte value) { }

	// RVA: 0x3601D1C Offset: 0x35FDD1C VA: 0x3601D1C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3601D24 Offset: 0x35FDD24 VA: 0x3601D24 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3601D2C Offset: 0x35FDD2C VA: 0x3601D2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3601E4C Offset: 0x35FDE4C VA: 0x3601E4C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
