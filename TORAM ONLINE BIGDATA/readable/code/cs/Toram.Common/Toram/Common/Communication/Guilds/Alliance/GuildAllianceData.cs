// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds.Alliance
public class GuildAllianceData : PacketBase // TypeDefIndex: 13039
{
	// Fields
	[CompilerGenerated]
	private int <AllianceId>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <StartDate>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <EndDate>k__BackingField; // 0x30
	[CompilerGenerated]
	private GuildAllianceInvitationData[] <InvitationList>k__BackingField; // 0x38
	[CompilerGenerated]
	private GuildInfoData[] <InfoList>k__BackingField; // 0x40

	// Properties
	public int AllianceId { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public GuildAllianceInvitationData[] InvitationList { get; set; }
	public GuildInfoData[] InfoList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x368F550 Offset: 0x368B550 VA: 0x368F550
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36943E0 Offset: 0x36903E0 VA: 0x36943E0
	public int get_AllianceId() { }

	[CompilerGenerated]
	// RVA: 0x36943E8 Offset: 0x36903E8 VA: 0x36943E8
	public void set_AllianceId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36943F0 Offset: 0x36903F0 VA: 0x36943F0
	public DateTime get_StartDate() { }

	[CompilerGenerated]
	// RVA: 0x36943F8 Offset: 0x36903F8 VA: 0x36943F8
	public void set_StartDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3694400 Offset: 0x3690400 VA: 0x3694400
	public DateTime get_EndDate() { }

	[CompilerGenerated]
	// RVA: 0x3694408 Offset: 0x3690408 VA: 0x3694408
	public void set_EndDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3694410 Offset: 0x3690410 VA: 0x3694410
	public GuildAllianceInvitationData[] get_InvitationList() { }

	[CompilerGenerated]
	// RVA: 0x3694418 Offset: 0x3690418 VA: 0x3694418
	public void set_InvitationList(GuildAllianceInvitationData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3694420 Offset: 0x3690420 VA: 0x3694420
	public GuildInfoData[] get_InfoList() { }

	[CompilerGenerated]
	// RVA: 0x3694428 Offset: 0x3690428 VA: 0x3694428
	public void set_InfoList(GuildInfoData[] value) { }

	// RVA: 0x3694430 Offset: 0x3690430 VA: 0x3694430 Slot: 3
	public override string ToString() { }

	// RVA: 0x3694508 Offset: 0x3690508 VA: 0x3694508 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3694510 Offset: 0x3690510 VA: 0x3694510 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3694708 Offset: 0x3690708 VA: 0x3694708 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
