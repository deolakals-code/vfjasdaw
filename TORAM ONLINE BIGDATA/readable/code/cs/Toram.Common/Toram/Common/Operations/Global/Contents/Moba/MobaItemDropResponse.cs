// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaItemDropResponse : OperationResponseBase // TypeDefIndex: 11605
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <EquipNo>k__BackingField; // 0x22
	[CompilerGenerated]
	private short <ItemId>k__BackingField; // 0x24

	// Properties
	public short ReturnCode { get; set; }
	public byte EquipNo { get; set; }
	public short ItemId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3723490 Offset: 0x371F490 VA: 0x3723490
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3723498 Offset: 0x371F498 VA: 0x3723498
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x37234A0 Offset: 0x371F4A0 VA: 0x37234A0
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x37234A8 Offset: 0x371F4A8 VA: 0x37234A8
	public byte get_EquipNo() { }

	[CompilerGenerated]
	// RVA: 0x37234B0 Offset: 0x371F4B0 VA: 0x37234B0
	public void set_EquipNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37234B8 Offset: 0x371F4B8 VA: 0x37234B8
	public short get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x37234C0 Offset: 0x371F4C0 VA: 0x37234C0
	public void set_ItemId(short value) { }

	// RVA: 0x37234C8 Offset: 0x371F4C8 VA: 0x37234C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37234D0 Offset: 0x371F4D0 VA: 0x37234D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37234D8 Offset: 0x371F4D8 VA: 0x37234D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37235E4 Offset: 0x371F5E4 VA: 0x37235E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
