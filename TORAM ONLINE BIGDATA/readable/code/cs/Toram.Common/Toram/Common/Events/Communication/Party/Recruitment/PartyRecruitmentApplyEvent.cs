// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party.Recruitment
public class PartyRecruitmentApplyEvent : EventSubBase // TypeDefIndex: 12882
{
	// Fields
	[CompilerGenerated]
	private PartyCandidateData <Candidate>k__BackingField; // 0x20
	[CompilerGenerated]
	private TimeSpan <LeftTime>k__BackingField; // 0x28

	// Properties
	public PartyCandidateData Candidate { get; set; }
	public TimeSpan LeftTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x366EF74 Offset: 0x366AF74 VA: 0x366EF74
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366EF7C Offset: 0x366AF7C VA: 0x366EF7C
	public PartyCandidateData get_Candidate() { }

	[CompilerGenerated]
	// RVA: 0x366EF84 Offset: 0x366AF84 VA: 0x366EF84
	public void set_Candidate(PartyCandidateData value) { }

	[CompilerGenerated]
	// RVA: 0x366EF8C Offset: 0x366AF8C VA: 0x366EF8C
	public TimeSpan get_LeftTime() { }

	[CompilerGenerated]
	// RVA: 0x366EF94 Offset: 0x366AF94 VA: 0x366EF94
	public void set_LeftTime(TimeSpan value) { }

	// RVA: 0x366EF9C Offset: 0x366AF9C VA: 0x366EF9C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366EFA4 Offset: 0x366AFA4 VA: 0x366EFA4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366EFAC Offset: 0x366AFAC VA: 0x366EFAC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366F0A0 Offset: 0x366B0A0 VA: 0x366F0A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
