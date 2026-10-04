// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentUpdate : OperationRequestBase // TypeDefIndex: 11494
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <PartyName>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <RecruitmentType>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <PartyComments>k__BackingField; // 0x38
	[CompilerGenerated]
	private PartyMemberFrameData[] <MemberFrames>k__BackingField; // 0x40

	// Properties
	public int RecruitmentId { get; set; }
	public string PartyName { get; set; }
	public byte RecruitmentType { get; set; }
	public string PartyComments { get; set; }
	public PartyMemberFrameData[] MemberFrames { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371303C Offset: 0x370F03C VA: 0x371303C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3713044 Offset: 0x370F044 VA: 0x3713044
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x371304C Offset: 0x370F04C VA: 0x371304C
	public void set_RecruitmentId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3713054 Offset: 0x370F054 VA: 0x3713054
	public string get_PartyName() { }

	[CompilerGenerated]
	// RVA: 0x371305C Offset: 0x370F05C VA: 0x371305C
	public void set_PartyName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3713064 Offset: 0x370F064 VA: 0x3713064
	public byte get_RecruitmentType() { }

	[CompilerGenerated]
	// RVA: 0x371306C Offset: 0x370F06C VA: 0x371306C
	public void set_RecruitmentType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3713074 Offset: 0x370F074 VA: 0x3713074
	public string get_PartyComments() { }

	[CompilerGenerated]
	// RVA: 0x371307C Offset: 0x370F07C VA: 0x371307C
	public void set_PartyComments(string value) { }

	[CompilerGenerated]
	// RVA: 0x3713084 Offset: 0x370F084 VA: 0x3713084
	public PartyMemberFrameData[] get_MemberFrames() { }

	[CompilerGenerated]
	// RVA: 0x371308C Offset: 0x370F08C VA: 0x371308C
	public void set_MemberFrames(PartyMemberFrameData[] value) { }

	// RVA: 0x3713094 Offset: 0x370F094 VA: 0x3713094 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371309C Offset: 0x370F09C VA: 0x371309C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37130A4 Offset: 0x370F0A4 VA: 0x37130A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37131E4 Offset: 0x370F1E4 VA: 0x37131E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
