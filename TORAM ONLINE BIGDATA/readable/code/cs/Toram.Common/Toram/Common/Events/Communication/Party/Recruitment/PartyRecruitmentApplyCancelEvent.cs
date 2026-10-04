// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party.Recruitment
public class PartyRecruitmentApplyCancelEvent : EventSubBase // TypeDefIndex: 12881
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsTimeout>k__BackingField; // 0x24

	// Properties
	public int RecruitmentId { get; set; }
	public bool IsTimeout { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x366ECE4 Offset: 0x366ACE4 VA: 0x366ECE4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366ECEC Offset: 0x366ACEC VA: 0x366ECEC
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x366ECF4 Offset: 0x366ACF4 VA: 0x366ECF4
	public void set_RecruitmentId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366ECFC Offset: 0x366ACFC VA: 0x366ECFC
	public bool get_IsTimeout() { }

	[CompilerGenerated]
	// RVA: 0x366ED04 Offset: 0x366AD04 VA: 0x366ED04
	public void set_IsTimeout(bool value) { }

	// RVA: 0x366ED10 Offset: 0x366AD10 VA: 0x366ED10 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366ED18 Offset: 0x366AD18 VA: 0x366ED18 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366ED20 Offset: 0x366AD20 VA: 0x366ED20 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366EDFC Offset: 0x366ADFC VA: 0x366EDFC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
