// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild.Alliance
public class GuildAllianceConsentEvent : EventSubBase // TypeDefIndex: 12937
{
	// Fields
	[CompilerGenerated]
	private GuildInfoData[] <InfoList>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <StartDate>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 2)]
	public GuildInfoData[] InfoList { get; set; }
	[PacketParameter(Code = 10)]
	public DateTime StartDate { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367C668 Offset: 0x3678668 VA: 0x367C668
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367C670 Offset: 0x3678670 VA: 0x367C670
	public GuildInfoData[] get_InfoList() { }

	[CompilerGenerated]
	// RVA: 0x367C678 Offset: 0x3678678 VA: 0x367C678
	public void set_InfoList(GuildInfoData[] value) { }

	[CompilerGenerated]
	// RVA: 0x367C680 Offset: 0x3678680 VA: 0x367C680
	public DateTime get_StartDate() { }

	[CompilerGenerated]
	// RVA: 0x367C688 Offset: 0x3678688 VA: 0x367C688
	public void set_StartDate(DateTime value) { }

	// RVA: 0x367C690 Offset: 0x3678690 VA: 0x367C690 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367C698 Offset: 0x3678698 VA: 0x367C698 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x367C6A0 Offset: 0x36786A0 VA: 0x367C6A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x367C7B8 Offset: 0x36787B8 VA: 0x367C7B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
