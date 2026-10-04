// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class RefiningEquipmentResponse : OperationResponseBase // TypeDefIndex: 11713
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private OrbItemData[] <OrbItem>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Cost>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <Result>k__BackingField; // 0x40
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x54

	// Properties
	public int ShopId { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public OrbItemData[] OrbItem { get; set; }
	public int Gold { get; set; }
	public int Cost { get; set; }
	public bool Result { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3738CD8 Offset: 0x3734CD8 VA: 0x3738CD8
	public void .ctor() { }

	// RVA: 0x3738CE0 Offset: 0x3734CE0 VA: 0x3738CE0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3738CE8 Offset: 0x3734CE8 VA: 0x3738CE8
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3738CF0 Offset: 0x3734CF0 VA: 0x3738CF0
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3738CF8 Offset: 0x3734CF8 VA: 0x3738CF8
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3738D00 Offset: 0x3734D00 VA: 0x3738D00
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3738D08 Offset: 0x3734D08 VA: 0x3738D08
	public OrbItemData[] get_OrbItem() { }

	[CompilerGenerated]
	// RVA: 0x3738D10 Offset: 0x3734D10 VA: 0x3738D10
	public void set_OrbItem(OrbItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3738D18 Offset: 0x3734D18 VA: 0x3738D18
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3738D20 Offset: 0x3734D20 VA: 0x3738D20
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3738D28 Offset: 0x3734D28 VA: 0x3738D28
	public int get_Cost() { }

	[CompilerGenerated]
	// RVA: 0x3738D30 Offset: 0x3734D30 VA: 0x3738D30
	public void set_Cost(int value) { }

	[CompilerGenerated]
	// RVA: 0x3738D38 Offset: 0x3734D38 VA: 0x3738D38
	public bool get_Result() { }

	[CompilerGenerated]
	// RVA: 0x3738D40 Offset: 0x3734D40 VA: 0x3738D40
	public void set_Result(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3738D4C Offset: 0x3734D4C VA: 0x3738D4C
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x3738D54 Offset: 0x3734D54 VA: 0x3738D54
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3738D5C Offset: 0x3734D5C VA: 0x3738D5C
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3738D64 Offset: 0x3734D64 VA: 0x3738D64
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3738D6C Offset: 0x3734D6C VA: 0x3738D6C
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x3738D74 Offset: 0x3734D74 VA: 0x3738D74
	public void set_PaidOrb(int value) { }

	// RVA: 0x3738D7C Offset: 0x3734D7C VA: 0x3738D7C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3738D84 Offset: 0x3734D84 VA: 0x3738D84 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3738D8C Offset: 0x3734D8C VA: 0x3738D8C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3738FD4 Offset: 0x3734FD4 VA: 0x3738FD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
