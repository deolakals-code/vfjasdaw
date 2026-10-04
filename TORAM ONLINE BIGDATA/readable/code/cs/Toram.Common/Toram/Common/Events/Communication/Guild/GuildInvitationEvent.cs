// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildInvitationEvent : PacketBase // TypeDefIndex: 12915
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildReserveData <ReserveData>k__BackingField; // 0x28

	// Properties
	public int TargetId { get; set; }
	public GuildReserveData ReserveData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x367755C Offset: 0x367355C VA: 0x367755C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3677564 Offset: 0x3673564 VA: 0x3677564
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x367756C Offset: 0x367356C VA: 0x367756C
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3677574 Offset: 0x3673574 VA: 0x3677574
	public GuildReserveData get_ReserveData() { }

	[CompilerGenerated]
	// RVA: 0x367757C Offset: 0x367357C VA: 0x367757C
	public void set_ReserveData(GuildReserveData value) { }

	// RVA: 0x3677584 Offset: 0x3673584 VA: 0x3677584 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367758C Offset: 0x367358C VA: 0x367758C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3677754 Offset: 0x3673754 VA: 0x3677754 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
