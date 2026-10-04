// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Parties
public class PartyRecruitmentData : BinaryBase // TypeDefIndex: 13008
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <PartyLeaderId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <PartyName>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <RecruitmentType>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <PartyComments>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <MemberNum>k__BackingField; // 0x44
	[CompilerGenerated]
	private PartyMemberFrameData[] <MemberFrames>k__BackingField; // 0x48

	// Properties
	public int RecruitmentId { get; set; }
	public int PartyLeaderId { get; set; }
	public int PartyId { get; set; }
	public string PartyName { get; set; }
	public byte RecruitmentType { get; set; }
	public string PartyComments { get; set; }
	public int FieldId { get; set; }
	public byte MemberNum { get; set; }
	public PartyMemberFrameData[] MemberFrames { get; set; }

	// Methods

	// RVA: 0x368C40C Offset: 0x368840C VA: 0x368C40C
	public void .ctor() { }

	// RVA: 0x368C414 Offset: 0x3688414 VA: 0x368C414
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x368C41C Offset: 0x368841C VA: 0x368C41C
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x368C424 Offset: 0x3688424 VA: 0x368C424
	public void set_RecruitmentId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368C42C Offset: 0x368842C VA: 0x368C42C
	public int get_PartyLeaderId() { }

	[CompilerGenerated]
	// RVA: 0x368C434 Offset: 0x3688434 VA: 0x368C434
	public void set_PartyLeaderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368C43C Offset: 0x368843C VA: 0x368C43C
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x368C444 Offset: 0x3688444 VA: 0x368C444
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368C44C Offset: 0x368844C VA: 0x368C44C
	public string get_PartyName() { }

	[CompilerGenerated]
	// RVA: 0x368C454 Offset: 0x3688454 VA: 0x368C454
	public void set_PartyName(string value) { }

	[CompilerGenerated]
	// RVA: 0x368C45C Offset: 0x368845C VA: 0x368C45C
	public byte get_RecruitmentType() { }

	[CompilerGenerated]
	// RVA: 0x368C464 Offset: 0x3688464 VA: 0x368C464
	public void set_RecruitmentType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368C46C Offset: 0x368846C VA: 0x368C46C
	public string get_PartyComments() { }

	[CompilerGenerated]
	// RVA: 0x368C474 Offset: 0x3688474 VA: 0x368C474
	public void set_PartyComments(string value) { }

	[CompilerGenerated]
	// RVA: 0x368C47C Offset: 0x368847C VA: 0x368C47C
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x368C484 Offset: 0x3688484 VA: 0x368C484
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368C48C Offset: 0x368848C VA: 0x368C48C
	public byte get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x368C494 Offset: 0x3688494 VA: 0x368C494
	public void set_MemberNum(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368C49C Offset: 0x368849C VA: 0x368C49C
	public PartyMemberFrameData[] get_MemberFrames() { }

	[CompilerGenerated]
	// RVA: 0x368C4A4 Offset: 0x36884A4 VA: 0x368C4A4
	public void set_MemberFrames(PartyMemberFrameData[] value) { }

	// RVA: 0x368C4AC Offset: 0x36884AC VA: 0x368C4AC Slot: 3
	public override string ToString() { }

	// RVA: 0x368C838 Offset: 0x3688838 VA: 0x368C838 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368C91C Offset: 0x368891C VA: 0x368C91C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
