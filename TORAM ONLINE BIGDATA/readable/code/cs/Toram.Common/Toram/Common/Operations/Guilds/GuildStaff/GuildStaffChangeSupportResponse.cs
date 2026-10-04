// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class GuildStaffChangeSupportResponse : OperationResponseBase // TypeDefIndex: 12411
{
	// Fields
	[CompilerGenerated]
	private byte <Support>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 199)]
	public byte Support { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3603390 Offset: 0x35FF390 VA: 0x3603390
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3603398 Offset: 0x35FF398 VA: 0x3603398
	public byte get_Support() { }

	[CompilerGenerated]
	// RVA: 0x36033A0 Offset: 0x35FF3A0 VA: 0x36033A0
	public void set_Support(byte value) { }

	// RVA: 0x36033A8 Offset: 0x35FF3A8 VA: 0x36033A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36033B0 Offset: 0x35FF3B0 VA: 0x36033B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36033B8 Offset: 0x35FF3B8 VA: 0x36033B8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3603458 Offset: 0x35FF458 VA: 0x3603458 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
