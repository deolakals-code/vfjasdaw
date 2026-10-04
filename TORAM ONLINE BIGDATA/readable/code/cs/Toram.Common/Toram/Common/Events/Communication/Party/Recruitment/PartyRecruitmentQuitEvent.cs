// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party.Recruitment
public class PartyRecruitmentQuitEvent : EventSubBase // TypeDefIndex: 12887
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x20

	// Properties
	public int RecruitmentId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3670018 Offset: 0x366C018 VA: 0x3670018
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3670020 Offset: 0x366C020 VA: 0x3670020
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x3670028 Offset: 0x366C028 VA: 0x3670028
	public void set_RecruitmentId(int value) { }

	// RVA: 0x3670030 Offset: 0x366C030 VA: 0x3670030 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3670038 Offset: 0x366C038 VA: 0x3670038 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3670040 Offset: 0x366C040 VA: 0x3670040 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36700E0 Offset: 0x366C0E0 VA: 0x36700E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
