// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentJoin : OperationRequestBase // TypeDefIndex: 11490
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

	// RVA: 0x3712988 Offset: 0x370E988 VA: 0x3712988
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3712990 Offset: 0x370E990 VA: 0x3712990
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x3712998 Offset: 0x370E998 VA: 0x3712998
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37129A0 Offset: 0x370E9A0 VA: 0x37129A0
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x37129A8 Offset: 0x370E9A8 VA: 0x37129A8
	public void set_RecruitmentId(int value) { }

	// RVA: 0x37129B0 Offset: 0x370E9B0 VA: 0x37129B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37129B8 Offset: 0x370E9B8 VA: 0x37129B8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37129C0 Offset: 0x370E9C0 VA: 0x37129C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3712A88 Offset: 0x370EA88 VA: 0x3712A88 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
