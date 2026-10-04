// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaChestStart : OperationRequestBase // TypeDefIndex: 11600
{
	// Fields
	[CompilerGenerated]
	private int <ChestUniqueId>k__BackingField; // 0x20

	// Properties
	public int ChestUniqueId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3722514 Offset: 0x371E514 VA: 0x3722514
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372251C Offset: 0x371E51C VA: 0x372251C
	public int get_ChestUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3722524 Offset: 0x371E524 VA: 0x3722524
	public void set_ChestUniqueId(int value) { }

	// RVA: 0x372252C Offset: 0x371E52C VA: 0x372252C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3722534 Offset: 0x371E534 VA: 0x3722534 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372253C Offset: 0x371E53C VA: 0x372253C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37225DC Offset: 0x371E5DC VA: 0x37225DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
