// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class EnhanceEquipmentResponse : OperationResponseBase // TypeDefIndex: 11707
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <Result>k__BackingField; // 0x30
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x38

	// Properties
	public ItemDatav2[] ItemList { get; set; }
	public MaterialData[] MaterialList { get; set; }
	public bool Result { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3736E2C Offset: 0x3732E2C VA: 0x3736E2C
	public void .ctor() { }

	// RVA: 0x3736E34 Offset: 0x3732E34 VA: 0x3736E34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3736E3C Offset: 0x3732E3C VA: 0x3736E3C
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3736E44 Offset: 0x3732E44 VA: 0x3736E44
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3736E4C Offset: 0x3732E4C VA: 0x3736E4C
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x3736E54 Offset: 0x3732E54 VA: 0x3736E54
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3736E5C Offset: 0x3732E5C VA: 0x3736E5C
	public bool get_Result() { }

	[CompilerGenerated]
	// RVA: 0x3736E64 Offset: 0x3732E64 VA: 0x3736E64
	public void set_Result(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3736E70 Offset: 0x3732E70 VA: 0x3736E70
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x3736E78 Offset: 0x3732E78 VA: 0x3736E78
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x3736E80 Offset: 0x3732E80 VA: 0x3736E80 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3736E88 Offset: 0x3732E88 VA: 0x3736E88 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3736E90 Offset: 0x3732E90 VA: 0x3736E90 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3736FDC Offset: 0x3732FDC VA: 0x3736FDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
