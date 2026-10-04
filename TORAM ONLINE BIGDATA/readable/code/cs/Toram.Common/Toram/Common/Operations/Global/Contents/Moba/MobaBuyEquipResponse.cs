// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaBuyEquipResponse : OperationResponseBase // TypeDefIndex: 11590
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <UpdateEquipType>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Update>k__BackingField; // 0x29
	[CompilerGenerated]
	private ItemDatav2 <UpdateWeapon>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<byte, object> <EquipProperties>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x40

	// Properties
	public short ReturnCode { get; set; }
	public int Gold { get; set; }
	public byte UpdateEquipType { get; set; }
	public byte Update { get; set; }
	public ItemDatav2 UpdateWeapon { get; set; }
	public Dictionary<byte, object> EquipProperties { get; set; }
	public int PropertiesRevision { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3720458 Offset: 0x371C458 VA: 0x3720458
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3720460 Offset: 0x371C460 VA: 0x3720460
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3720468 Offset: 0x371C468 VA: 0x3720468
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3720470 Offset: 0x371C470 VA: 0x3720470
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3720478 Offset: 0x371C478 VA: 0x3720478
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3720480 Offset: 0x371C480 VA: 0x3720480
	public byte get_UpdateEquipType() { }

	[CompilerGenerated]
	// RVA: 0x3720488 Offset: 0x371C488 VA: 0x3720488
	public void set_UpdateEquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3720490 Offset: 0x371C490 VA: 0x3720490
	public byte get_Update() { }

	[CompilerGenerated]
	// RVA: 0x3720498 Offset: 0x371C498 VA: 0x3720498
	public void set_Update(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37204A0 Offset: 0x371C4A0 VA: 0x37204A0
	public ItemDatav2 get_UpdateWeapon() { }

	[CompilerGenerated]
	// RVA: 0x37204A8 Offset: 0x371C4A8 VA: 0x37204A8
	public void set_UpdateWeapon(ItemDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x37204B0 Offset: 0x371C4B0 VA: 0x37204B0
	public Dictionary<byte, object> get_EquipProperties() { }

	[CompilerGenerated]
	// RVA: 0x37204B8 Offset: 0x371C4B8 VA: 0x37204B8
	public void set_EquipProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x37204C0 Offset: 0x371C4C0 VA: 0x37204C0
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x37204C8 Offset: 0x371C4C8 VA: 0x37204C8
	public void set_PropertiesRevision(int value) { }

	// RVA: 0x37204D0 Offset: 0x371C4D0 VA: 0x37204D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37204D8 Offset: 0x371C4D8 VA: 0x37204D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37204E0 Offset: 0x371C4E0 VA: 0x37204E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3720690 Offset: 0x371C690 VA: 0x3720690 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
