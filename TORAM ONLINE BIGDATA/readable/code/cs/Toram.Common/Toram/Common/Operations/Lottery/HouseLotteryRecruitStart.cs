// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Lottery
public class HouseLotteryRecruitStart : OperationRequestBase // TypeDefIndex: 11539
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

	// RVA: 0x37171DC Offset: 0x37131DC VA: 0x37171DC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37171E4 Offset: 0x37131E4 VA: 0x37171E4
	public short get_ExclusionLanguages() { }

	[CompilerGenerated]
	// RVA: 0x37171EC Offset: 0x37131EC VA: 0x37171EC
	public void set_ExclusionLanguages(short value) { }

	// RVA: 0x37171F4 Offset: 0x37131F4 VA: 0x37171F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37171FC Offset: 0x37131FC VA: 0x37171FC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3717204 Offset: 0x3713204 VA: 0x3717204 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3717324 Offset: 0x3713324 VA: 0x3717324 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
