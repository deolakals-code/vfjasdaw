// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruiting : OperationRequestBase // TypeDefIndex: 11479
{
	// Fields
	[CompilerGenerated]
	private string <PartyName>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RecruitmentType>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <PartyComments>k__BackingField; // 0x30
	[CompilerGenerated]
	private PartyMemberFrameData[] <MemberFrames>k__BackingField; // 0x38

	// Properties
	public string PartyName { get; set; }
	public byte RecruitmentType { get; set; }
	public string PartyComments { get; set; }
	public PartyMemberFrameData[] MemberFrames { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3710CB0 Offset: 0x370CCB0 VA: 0x3710CB0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3710CB8 Offset: 0x370CCB8 VA: 0x3710CB8
	public string get_PartyName() { }

	[CompilerGenerated]
	// RVA: 0x3710CC0 Offset: 0x370CCC0 VA: 0x3710CC0
	public void set_PartyName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3710CC8 Offset: 0x370CCC8 VA: 0x3710CC8
	public byte get_RecruitmentType() { }

	[CompilerGenerated]
	// RVA: 0x3710CD0 Offset: 0x370CCD0 VA: 0x3710CD0
	public void set_RecruitmentType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3710CD8 Offset: 0x370CCD8 VA: 0x3710CD8
	public string get_PartyComments() { }

	[CompilerGenerated]
	// RVA: 0x3710CE0 Offset: 0x370CCE0 VA: 0x3710CE0
	public void set_PartyComments(string value) { }

	[CompilerGenerated]
	// RVA: 0x3710CE8 Offset: 0x370CCE8 VA: 0x3710CE8
	public PartyMemberFrameData[] get_MemberFrames() { }

	[CompilerGenerated]
	// RVA: 0x3710CF0 Offset: 0x370CCF0 VA: 0x3710CF0
	public void set_MemberFrames(PartyMemberFrameData[] value) { }

	// RVA: 0x3710CF8 Offset: 0x370CCF8 VA: 0x3710CF8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3710D00 Offset: 0x370CD00 VA: 0x3710D00 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3710D08 Offset: 0x370CD08 VA: 0x3710D08 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3710E08 Offset: 0x370CE08 VA: 0x3710E08 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
