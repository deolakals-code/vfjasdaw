// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class GuildStaffChangeSupport : OperationRequestBase // TypeDefIndex: 12410
{
	// Fields
	[CompilerGenerated]
	private byte <Support>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 245)]
	public byte Support { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36031A8 Offset: 0x35FF1A8 VA: 0x36031A8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36031B0 Offset: 0x35FF1B0 VA: 0x36031B0
	public byte get_Support() { }

	[CompilerGenerated]
	// RVA: 0x36031B8 Offset: 0x35FF1B8 VA: 0x36031B8
	public void set_Support(byte value) { }

	// RVA: 0x36031C0 Offset: 0x35FF1C0 VA: 0x36031C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36031C8 Offset: 0x35FF1C8 VA: 0x36031C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36031D0 Offset: 0x35FF1D0 VA: 0x36031D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3603270 Offset: 0x35FF270 VA: 0x3603270 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
