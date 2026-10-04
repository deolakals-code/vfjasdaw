// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitingResponse : OperationResponseBase // TypeDefIndex: 11480
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x20

	// Properties
	public int RecruitmentId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3711050 Offset: 0x370D050 VA: 0x3711050
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3711058 Offset: 0x370D058 VA: 0x3711058
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x3711060 Offset: 0x370D060 VA: 0x3711060
	public void set_RecruitmentId(int value) { }

	// RVA: 0x3711068 Offset: 0x370D068 VA: 0x3711068 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3711070 Offset: 0x370D070 VA: 0x3711070 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3711078 Offset: 0x370D078 VA: 0x3711078 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3711118 Offset: 0x370D118 VA: 0x3711118 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
