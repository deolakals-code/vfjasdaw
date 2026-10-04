// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class SynthesizeEquipmentResponse : OperationResponseBase // TypeDefIndex: 11721
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Result>k__BackingField; // 0x34
	[CompilerGenerated]
	private OrbItemData[] <OrbItem>k__BackingField; // 0x38
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x4C

	// Properties
	public int ShopId { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public int Gold { get; set; }
	public byte Result { get; set; }
	public OrbItemData[] OrbItem { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373AF8C Offset: 0x3736F8C VA: 0x373AF8C
	public void .ctor() { }

	// RVA: 0x373AF94 Offset: 0x3736F94 VA: 0x373AF94
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373AF9C Offset: 0x3736F9C VA: 0x373AF9C
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x373AFA4 Offset: 0x3736FA4 VA: 0x373AFA4
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x373AFAC Offset: 0x3736FAC VA: 0x373AFAC
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x373AFB4 Offset: 0x3736FB4 VA: 0x373AFB4
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x373AFBC Offset: 0x3736FBC VA: 0x373AFBC
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x373AFC4 Offset: 0x3736FC4 VA: 0x373AFC4
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x373AFCC Offset: 0x3736FCC VA: 0x373AFCC
	public byte get_Result() { }

	[CompilerGenerated]
	// RVA: 0x373AFD4 Offset: 0x3736FD4 VA: 0x373AFD4
	public void set_Result(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373AFDC Offset: 0x3736FDC VA: 0x373AFDC
	public OrbItemData[] get_OrbItem() { }

	[CompilerGenerated]
	// RVA: 0x373AFE4 Offset: 0x3736FE4 VA: 0x373AFE4
	public void set_OrbItem(OrbItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x373AFEC Offset: 0x3736FEC VA: 0x373AFEC
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x373AFF4 Offset: 0x3736FF4 VA: 0x373AFF4
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x373AFFC Offset: 0x3736FFC VA: 0x373AFFC
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x373B004 Offset: 0x3737004 VA: 0x373B004
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x373B00C Offset: 0x373700C VA: 0x373B00C
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x373B014 Offset: 0x3737014 VA: 0x373B014
	public void set_PaidOrb(int value) { }

	// RVA: 0x373B01C Offset: 0x373701C VA: 0x373B01C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373B024 Offset: 0x3737024 VA: 0x373B024 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373B02C Offset: 0x373702C VA: 0x373B02C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373B254 Offset: 0x3737254 VA: 0x373B254 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
