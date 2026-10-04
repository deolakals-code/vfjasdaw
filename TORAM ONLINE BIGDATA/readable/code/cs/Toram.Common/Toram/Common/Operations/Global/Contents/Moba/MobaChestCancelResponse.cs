// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaChestCancelResponse : OperationResponseBase // TypeDefIndex: 11597
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ChestUniqueId>k__BackingField; // 0x24

	// Properties
	public short ReturnCode { get; set; }
	public int ChestUniqueId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3721BD0 Offset: 0x371DBD0 VA: 0x3721BD0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3721BD8 Offset: 0x371DBD8 VA: 0x3721BD8
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3721BE0 Offset: 0x371DBE0 VA: 0x3721BE0
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3721BE8 Offset: 0x371DBE8 VA: 0x3721BE8
	public int get_ChestUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3721BF0 Offset: 0x371DBF0 VA: 0x3721BF0
	public void set_ChestUniqueId(int value) { }

	// RVA: 0x3721BF8 Offset: 0x371DBF8 VA: 0x3721BF8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3721C00 Offset: 0x371DC00 VA: 0x3721C00 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3721C08 Offset: 0x371DC08 VA: 0x3721C08 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3721CE4 Offset: 0x371DCE4 VA: 0x3721CE4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
