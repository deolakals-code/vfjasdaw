// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentCandidateCancelResponse : OperationResponseBase // TypeDefIndex: 11484
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20

	// Properties
	public short ReturnCode { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37119DC Offset: 0x370D9DC VA: 0x37119DC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37119E4 Offset: 0x370D9E4 VA: 0x37119E4
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x37119EC Offset: 0x370D9EC VA: 0x37119EC
	public void set_ReturnCode(short value) { }

	// RVA: 0x37119F4 Offset: 0x370D9F4 VA: 0x37119F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37119FC Offset: 0x370D9FC VA: 0x37119FC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3711A04 Offset: 0x370DA04 VA: 0x3711A04 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3711AA4 Offset: 0x370DAA4 VA: 0x3711AA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
