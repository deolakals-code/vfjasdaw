// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaRefineEquipResponse : OperationResponseBase // TypeDefIndex: 11610
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <RefineEquipType>k__BackingField; // 0x28
	[CompilerGenerated]
	private ItemDatav2 <RefineWeapon>k__BackingField; // 0x30

	// Properties
	public short ReturnCode { get; set; }
	public int Gold { get; set; }
	public byte RefineEquipType { get; set; }
	public ItemDatav2 RefineWeapon { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372447C Offset: 0x372047C VA: 0x372447C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3724484 Offset: 0x3720484 VA: 0x3724484
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x372448C Offset: 0x372048C VA: 0x372448C
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3724494 Offset: 0x3720494 VA: 0x3724494
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x372449C Offset: 0x372049C VA: 0x372449C
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x37244A4 Offset: 0x37204A4 VA: 0x37244A4
	public byte get_RefineEquipType() { }

	[CompilerGenerated]
	// RVA: 0x37244AC Offset: 0x37204AC VA: 0x37244AC
	public void set_RefineEquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37244B4 Offset: 0x37204B4 VA: 0x37244B4
	public ItemDatav2 get_RefineWeapon() { }

	[CompilerGenerated]
	// RVA: 0x37244BC Offset: 0x37204BC VA: 0x37244BC
	public void set_RefineWeapon(ItemDatav2 value) { }

	// RVA: 0x37244C4 Offset: 0x37204C4 VA: 0x37244C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37244CC Offset: 0x37204CC VA: 0x37244CC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37244D4 Offset: 0x37204D4 VA: 0x37244D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372461C Offset: 0x372061C VA: 0x372461C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
