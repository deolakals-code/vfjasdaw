// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class RegistletExtensionSlotResponse : OperationResponseBase // TypeDefIndex: 12417
{
	// Fields
	[CompilerGenerated]
	private int <GemPowder>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 10)]
	public int GemPowder { get; set; }
	[PacketParameter(Code = 11)]
	public byte Slot { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3604194 Offset: 0x3600194 VA: 0x3604194
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360419C Offset: 0x360019C VA: 0x360419C
	public int get_GemPowder() { }

	[CompilerGenerated]
	// RVA: 0x36041A4 Offset: 0x36001A4 VA: 0x36041A4
	public void set_GemPowder(int value) { }

	[CompilerGenerated]
	// RVA: 0x36041AC Offset: 0x36001AC VA: 0x36041AC
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x36041B4 Offset: 0x36001B4 VA: 0x36041B4
	public void set_Slot(byte value) { }

	// RVA: 0x36041BC Offset: 0x36001BC VA: 0x36041BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36041C4 Offset: 0x36001C4 VA: 0x36041C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36041CC Offset: 0x36001CC VA: 0x36041CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36042A8 Offset: 0x36002A8 VA: 0x36042A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
