// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party.Recruitment
public class PartyRecruitmentApproveEvent : EventSubBase // TypeDefIndex: 12884
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x24

	// Properties
	public int PartyId { get; set; }
	public int RecruitmentId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x366F4DC Offset: 0x366B4DC VA: 0x366F4DC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366F4E4 Offset: 0x366B4E4 VA: 0x366F4E4
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366F4EC Offset: 0x366B4EC VA: 0x366F4EC
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366F4F4 Offset: 0x366B4F4 VA: 0x366F4F4
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x366F4FC Offset: 0x366B4FC VA: 0x366F4FC
	public void set_RecruitmentId(int value) { }

	// RVA: 0x366F504 Offset: 0x366B504 VA: 0x366F504 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366F50C Offset: 0x366B50C VA: 0x366F50C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366F514 Offset: 0x366B514 VA: 0x366F514 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366F5DC Offset: 0x366B5DC VA: 0x366F5DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
