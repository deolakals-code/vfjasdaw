// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentQuitResponse : OperationResponseBase // TypeDefIndex: 11493
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x20

	// Properties
	public int RecruitmentId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3712E54 Offset: 0x370EE54 VA: 0x3712E54
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3712E5C Offset: 0x370EE5C VA: 0x3712E5C
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x3712E64 Offset: 0x370EE64 VA: 0x3712E64
	public void set_RecruitmentId(int value) { }

	// RVA: 0x3712E6C Offset: 0x370EE6C VA: 0x3712E6C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3712E74 Offset: 0x370EE74 VA: 0x3712E74 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3712E7C Offset: 0x370EE7C VA: 0x3712E7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3712F1C Offset: 0x370EF1C VA: 0x3712F1C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
