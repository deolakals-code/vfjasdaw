// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentListResponse : OperationResponseBase // TypeDefIndex: 11492
{
	// Fields
	[CompilerGenerated]
	private PartyRecruitmentData[] <List>k__BackingField; // 0x20

	// Properties
	public PartyRecruitmentData[] List { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3712C1C Offset: 0x370EC1C VA: 0x3712C1C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3712C24 Offset: 0x370EC24 VA: 0x3712C24
	public PartyRecruitmentData[] get_List() { }

	[CompilerGenerated]
	// RVA: 0x3712C2C Offset: 0x370EC2C VA: 0x3712C2C
	public void set_List(PartyRecruitmentData[] value) { }

	// RVA: 0x3712C34 Offset: 0x370EC34 VA: 0x3712C34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3712C3C Offset: 0x370EC3C VA: 0x3712C3C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3712C44 Offset: 0x370EC44 VA: 0x3712C44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3712CDC Offset: 0x370ECDC VA: 0x3712CDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
