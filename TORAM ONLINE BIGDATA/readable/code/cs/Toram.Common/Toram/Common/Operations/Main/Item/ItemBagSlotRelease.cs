// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class ItemBagSlotRelease : OperationRequestBase // TypeDefIndex: 12128
{
	// Fields
	[CompilerGenerated]
	private byte <ItemDataType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RecipeId>k__BackingField; // 0x24

	// Properties
	public byte ItemDataType { get; set; }
	public int RecipeId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378D238 Offset: 0x3789238 VA: 0x378D238
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378D240 Offset: 0x3789240 VA: 0x378D240
	public byte get_ItemDataType() { }

	[CompilerGenerated]
	// RVA: 0x378D248 Offset: 0x3789248 VA: 0x378D248
	public void set_ItemDataType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378D250 Offset: 0x3789250 VA: 0x378D250
	public int get_RecipeId() { }

	[CompilerGenerated]
	// RVA: 0x378D258 Offset: 0x3789258 VA: 0x378D258
	public void set_RecipeId(int value) { }

	// RVA: 0x378D260 Offset: 0x3789260 VA: 0x378D260 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378D268 Offset: 0x3789268 VA: 0x378D268 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378D270 Offset: 0x3789270 VA: 0x378D270 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378D34C Offset: 0x378934C VA: 0x378D34C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
