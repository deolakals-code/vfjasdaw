// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaItemPickup : OperationRequestBase // TypeDefIndex: 11606
{
	// Fields
	[CompilerGenerated]
	private byte <EquipNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ItemUniqueId>k__BackingField; // 0x24

	// Properties
	public byte EquipNo { get; set; }
	public int ItemUniqueId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37237A8 Offset: 0x371F7A8 VA: 0x37237A8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37237B0 Offset: 0x371F7B0 VA: 0x37237B0
	public byte get_EquipNo() { }

	[CompilerGenerated]
	// RVA: 0x37237B8 Offset: 0x371F7B8 VA: 0x37237B8
	public void set_EquipNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37237C0 Offset: 0x371F7C0 VA: 0x37237C0
	public int get_ItemUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x37237C8 Offset: 0x371F7C8 VA: 0x37237C8
	public void set_ItemUniqueId(int value) { }

	// RVA: 0x37237D0 Offset: 0x371F7D0 VA: 0x37237D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37237D8 Offset: 0x371F7D8 VA: 0x37237D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37237E0 Offset: 0x371F7E0 VA: 0x37237E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37238BC Offset: 0x371F8BC VA: 0x37238BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
