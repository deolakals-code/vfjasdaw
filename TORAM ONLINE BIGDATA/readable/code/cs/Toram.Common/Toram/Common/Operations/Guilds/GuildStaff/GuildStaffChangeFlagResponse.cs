// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class GuildStaffChangeFlagResponse : OperationResponseBase // TypeDefIndex: 12413
{
	// Fields
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 43)]
	public byte Flag { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36037E4 Offset: 0x35FF7E4 VA: 0x36037E4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36037EC Offset: 0x35FF7EC VA: 0x36037EC
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36037F4 Offset: 0x35FF7F4 VA: 0x36037F4
	public void set_Flag(byte value) { }

	// RVA: 0x36037FC Offset: 0x35FF7FC VA: 0x36037FC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3603804 Offset: 0x35FF804 VA: 0x3603804 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360380C Offset: 0x35FF80C VA: 0x360380C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36038AC Offset: 0x35FF8AC VA: 0x36038AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
