// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentCheck : OperationRequestBase // TypeDefIndex: 11485
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x20

	// Properties
	public int RecruitmentId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3711BC4 Offset: 0x370DBC4 VA: 0x3711BC4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3711BCC Offset: 0x370DBCC VA: 0x3711BCC
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x3711BD4 Offset: 0x370DBD4 VA: 0x3711BD4
	public void set_RecruitmentId(int value) { }

	// RVA: 0x3711BDC Offset: 0x370DBDC VA: 0x3711BDC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3711BE4 Offset: 0x370DBE4 VA: 0x3711BE4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3711BEC Offset: 0x370DBEC VA: 0x3711BEC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3711C8C Offset: 0x370DC8C VA: 0x3711C8C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
