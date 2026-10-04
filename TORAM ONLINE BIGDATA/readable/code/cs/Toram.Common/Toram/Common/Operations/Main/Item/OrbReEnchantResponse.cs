// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class OrbReEnchantResponse : OperationResponseBase // TypeDefIndex: 12138
{
	// Fields
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private OrbEquipItemData <OrbEquipItemData>k__BackingField; // 0x28

	// Properties
	public GameStatusData GameStatus { get; set; }
	public OrbEquipItemData OrbEquipItemData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378F0CC Offset: 0x378B0CC VA: 0x378F0CC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378F0D4 Offset: 0x378B0D4 VA: 0x378F0D4
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x378F0DC Offset: 0x378B0DC VA: 0x378F0DC
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x378F0E4 Offset: 0x378B0E4 VA: 0x378F0E4
	public OrbEquipItemData get_OrbEquipItemData() { }

	[CompilerGenerated]
	// RVA: 0x378F0EC Offset: 0x378B0EC VA: 0x378F0EC
	public void set_OrbEquipItemData(OrbEquipItemData value) { }

	// RVA: 0x378F0F4 Offset: 0x378B0F4 VA: 0x378F0F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378F0FC Offset: 0x378B0FC VA: 0x378F0FC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378F104 Offset: 0x378B104 VA: 0x378F104 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378F1B8 Offset: 0x378B1B8 VA: 0x378F1B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
