// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceInviteCancelResponse : OperationResponseBase // TypeDefIndex: 12476
{
	// Fields
	[CompilerGenerated]
	private int <AllianceId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 0)]
	public int AllianceId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360D8AC Offset: 0x36098AC VA: 0x360D8AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360D8B4 Offset: 0x36098B4 VA: 0x360D8B4
	public int get_AllianceId() { }

	[CompilerGenerated]
	// RVA: 0x360D8BC Offset: 0x36098BC VA: 0x360D8BC
	public void set_AllianceId(int value) { }

	// RVA: 0x360D8C4 Offset: 0x36098C4 VA: 0x360D8C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360D8CC Offset: 0x36098CC VA: 0x360D8CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360D8D4 Offset: 0x36098D4 VA: 0x360D8D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360D974 Offset: 0x3609974 VA: 0x360D974 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
