// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaChestOpen : OperationRequestBase // TypeDefIndex: 11598
{
	// Fields
	[CompilerGenerated]
	private int <ChestUniqueId>k__BackingField; // 0x20

	// Properties
	public int ChestUniqueId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3721E5C Offset: 0x371DE5C VA: 0x3721E5C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3721E64 Offset: 0x371DE64 VA: 0x3721E64
	public int get_ChestUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3721E6C Offset: 0x371DE6C VA: 0x3721E6C
	public void set_ChestUniqueId(int value) { }

	// RVA: 0x3721E74 Offset: 0x371DE74 VA: 0x3721E74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3721E7C Offset: 0x371DE7C VA: 0x3721E7C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3721E84 Offset: 0x371DE84 VA: 0x3721E84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3721F24 Offset: 0x371DF24 VA: 0x3721F24 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
