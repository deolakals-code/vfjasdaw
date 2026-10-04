// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class TransferRandomPropertyResponse : OperationResponseBase // TypeDefIndex: 11723
{
	// Fields
	[CompilerGenerated]
	private bool <IsSuccess>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private OrbItemData[] <OrbItemList>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <UpdateGold>k__BackingField; // 0x38

	// Properties
	public bool IsSuccess { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public OrbItemData[] OrbItemList { get; set; }
	public int UpdateGold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373BB6C Offset: 0x3737B6C VA: 0x373BB6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373BB74 Offset: 0x3737B74 VA: 0x373BB74
	public bool get_IsSuccess() { }

	[CompilerGenerated]
	// RVA: 0x373BB7C Offset: 0x3737B7C VA: 0x373BB7C
	public void set_IsSuccess(bool value) { }

	[CompilerGenerated]
	// RVA: 0x373BB88 Offset: 0x3737B88 VA: 0x373BB88
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x373BB90 Offset: 0x3737B90 VA: 0x373BB90
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x373BB98 Offset: 0x3737B98 VA: 0x373BB98
	public OrbItemData[] get_OrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x373BBA0 Offset: 0x3737BA0 VA: 0x373BBA0
	public void set_OrbItemList(OrbItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x373BBA8 Offset: 0x3737BA8 VA: 0x373BBA8
	public int get_UpdateGold() { }

	[CompilerGenerated]
	// RVA: 0x373BBB0 Offset: 0x3737BB0 VA: 0x373BBB0
	public void set_UpdateGold(int value) { }

	// RVA: 0x373BBB8 Offset: 0x3737BB8 VA: 0x373BBB8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373BBC0 Offset: 0x3737BC0 VA: 0x373BBC0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373BBC8 Offset: 0x3737BC8 VA: 0x373BBC8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373BD28 Offset: 0x3737D28 VA: 0x373BD28 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
