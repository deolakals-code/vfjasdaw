// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class SpecificCristaRemoveResponse : OperationResponseBase // TypeDefIndex: 12140
{
	// Fields
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28

	// Properties
	public GameStatusData GameStatus { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378F6A0 Offset: 0x378B6A0 VA: 0x378F6A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378F6A8 Offset: 0x378B6A8 VA: 0x378F6A8
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x378F6B0 Offset: 0x378B6B0 VA: 0x378F6B0
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x378F6B8 Offset: 0x378B6B8 VA: 0x378F6B8
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x378F6C0 Offset: 0x378B6C0 VA: 0x378F6C0
	public void set_ItemList(ItemDatav2[] value) { }

	// RVA: 0x378F6C8 Offset: 0x378B6C8 VA: 0x378F6C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378F6D0 Offset: 0x378B6D0 VA: 0x378F6D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378F6D8 Offset: 0x378B6D8 VA: 0x378F6D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378F7B0 Offset: 0x378B7B0 VA: 0x378F7B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
