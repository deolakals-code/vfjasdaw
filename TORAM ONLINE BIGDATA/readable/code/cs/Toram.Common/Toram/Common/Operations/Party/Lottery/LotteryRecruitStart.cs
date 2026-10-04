// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Lottery
public class LotteryRecruitStart : OperationRequestBase // TypeDefIndex: 11521
{
	// Fields
	[CompilerGenerated]
	private short <ExclusionLanguages>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 213)]
	public short ExclusionLanguages { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3715AD0 Offset: 0x3711AD0 VA: 0x3715AD0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3715AD8 Offset: 0x3711AD8 VA: 0x3715AD8
	public short get_ExclusionLanguages() { }

	[CompilerGenerated]
	// RVA: 0x3715AE0 Offset: 0x3711AE0 VA: 0x3715AE0
	public void set_ExclusionLanguages(short value) { }

	// RVA: 0x3715AE8 Offset: 0x3711AE8 VA: 0x3715AE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3715AF0 Offset: 0x3711AF0 VA: 0x3715AF0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3715AF8 Offset: 0x3711AF8 VA: 0x3715AF8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3715C18 Offset: 0x3711C18 VA: 0x3715C18 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
