// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentCheckResponse : OperationResponseBase // TypeDefIndex: 11487
{
	// Fields
	[CompilerGenerated]
	private PartyRecruitmentData <Data>k__BackingField; // 0x20

	// Properties
	public PartyRecruitmentData Data { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37120E8 Offset: 0x370E0E8 VA: 0x37120E8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37120F0 Offset: 0x370E0F0 VA: 0x37120F0
	public PartyRecruitmentData get_Data() { }

	[CompilerGenerated]
	// RVA: 0x37120F8 Offset: 0x370E0F8 VA: 0x37120F8
	public void set_Data(PartyRecruitmentData value) { }

	// RVA: 0x3712100 Offset: 0x370E100 VA: 0x3712100 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3712108 Offset: 0x370E108 VA: 0x3712108 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3712110 Offset: 0x370E110 VA: 0x3712110 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3712198 Offset: 0x370E198 VA: 0x3712198 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
