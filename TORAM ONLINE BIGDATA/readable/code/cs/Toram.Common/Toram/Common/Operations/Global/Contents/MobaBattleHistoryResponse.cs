// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaBattleHistoryResponse : OperationResponseBase // TypeDefIndex: 11573
{
	// Fields
	[CompilerGenerated]
	private MobaHistoryData[] <Histories>k__BackingField; // 0x20

	// Properties
	public MobaHistoryData[] Histories { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371D494 Offset: 0x3719494 VA: 0x371D494
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371D49C Offset: 0x371949C VA: 0x371D49C
	public MobaHistoryData[] get_Histories() { }

	[CompilerGenerated]
	// RVA: 0x371D4A4 Offset: 0x37194A4 VA: 0x371D4A4
	public void set_Histories(MobaHistoryData[] value) { }

	// RVA: 0x371D4AC Offset: 0x37194AC VA: 0x371D4AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371D4B4 Offset: 0x37194B4 VA: 0x371D4B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371D4BC Offset: 0x37194BC VA: 0x371D4BC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371D554 Offset: 0x3719554 VA: 0x371D554 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
