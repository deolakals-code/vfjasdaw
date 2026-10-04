// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaSellEquip : OperationRequestBase // TypeDefIndex: 11615
{
	// Fields
	[CompilerGenerated]
	private byte <SellEquipType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <SellItemType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x24

	// Properties
	public byte SellEquipType { get; set; }
	public byte SellItemType { get; set; }
	public int Price { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3725764 Offset: 0x3721764 VA: 0x3725764
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372576C Offset: 0x372176C VA: 0x372576C
	public byte get_SellEquipType() { }

	[CompilerGenerated]
	// RVA: 0x3725774 Offset: 0x3721774 VA: 0x3725774
	public void set_SellEquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372577C Offset: 0x372177C VA: 0x372577C
	public byte get_SellItemType() { }

	[CompilerGenerated]
	// RVA: 0x3725784 Offset: 0x3721784 VA: 0x3725784
	public void set_SellItemType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372578C Offset: 0x372178C VA: 0x372578C
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x3725794 Offset: 0x3721794 VA: 0x3725794
	public void set_Price(int value) { }

	// RVA: 0x372579C Offset: 0x372179C VA: 0x372579C Slot: 3
	public override string ToString() { }

	// RVA: 0x3725890 Offset: 0x3721890 VA: 0x3725890 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3725898 Offset: 0x3721898 VA: 0x3725898 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37258A0 Offset: 0x37218A0 VA: 0x37258A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37259AC Offset: 0x37219AC VA: 0x37259AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
