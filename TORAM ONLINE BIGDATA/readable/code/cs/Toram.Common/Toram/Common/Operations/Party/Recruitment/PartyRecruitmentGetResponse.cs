// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentGetResponse : OperationResponseBase // TypeDefIndex: 11489
{
	// Fields
	[CompilerGenerated]
	private PartyRecruitmentData[] <Recruitments>k__BackingField; // 0x20
	[CompilerGenerated]
	private PartyCandidateData[] <Candidates>k__BackingField; // 0x28
	[CompilerGenerated]
	private TimeSpan[] <LeftTimes>k__BackingField; // 0x30

	// Properties
	public PartyRecruitmentData[] Recruitments { get; set; }
	public PartyCandidateData[] Candidates { get; set; }
	public TimeSpan[] LeftTimes { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371232C Offset: 0x370E32C VA: 0x371232C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3712334 Offset: 0x370E334 VA: 0x3712334
	public PartyRecruitmentData[] get_Recruitments() { }

	[CompilerGenerated]
	// RVA: 0x371233C Offset: 0x370E33C VA: 0x371233C
	public void set_Recruitments(PartyRecruitmentData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3712344 Offset: 0x370E344 VA: 0x3712344
	public PartyCandidateData[] get_Candidates() { }

	[CompilerGenerated]
	// RVA: 0x371234C Offset: 0x370E34C VA: 0x371234C
	public void set_Candidates(PartyCandidateData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3712354 Offset: 0x370E354 VA: 0x3712354
	public TimeSpan[] get_LeftTimes() { }

	[CompilerGenerated]
	// RVA: 0x371235C Offset: 0x370E35C VA: 0x371235C
	public void set_LeftTimes(TimeSpan[] value) { }

	// RVA: 0x3712364 Offset: 0x370E364 VA: 0x3712364 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371236C Offset: 0x370E36C VA: 0x371236C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3712374 Offset: 0x370E374 VA: 0x3712374 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3712554 Offset: 0x370E554 VA: 0x3712554 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
