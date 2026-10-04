// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaSellEquipResponse : OperationResponseBase // TypeDefIndex: 11616
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <SellEquipType>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, object> <EquipProperties>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x38

	// Properties
	public short ReturnCode { get; set; }
	public int Gold { get; set; }
	public byte SellEquipType { get; set; }
	public Dictionary<byte, object> EquipProperties { get; set; }
	public int PropertiesRevision { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3725B70 Offset: 0x3721B70 VA: 0x3725B70
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3725B78 Offset: 0x3721B78 VA: 0x3725B78
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3725B80 Offset: 0x3721B80 VA: 0x3725B80
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3725B88 Offset: 0x3721B88 VA: 0x3725B88
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3725B90 Offset: 0x3721B90 VA: 0x3725B90
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3725B98 Offset: 0x3721B98 VA: 0x3725B98
	public byte get_SellEquipType() { }

	[CompilerGenerated]
	// RVA: 0x3725BA0 Offset: 0x3721BA0 VA: 0x3725BA0
	public void set_SellEquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3725BA8 Offset: 0x3721BA8 VA: 0x3725BA8
	public Dictionary<byte, object> get_EquipProperties() { }

	[CompilerGenerated]
	// RVA: 0x3725BB0 Offset: 0x3721BB0 VA: 0x3725BB0
	public void set_EquipProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x3725BB8 Offset: 0x3721BB8 VA: 0x3725BB8
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x3725BC0 Offset: 0x3721BC0 VA: 0x3725BC0
	public void set_PropertiesRevision(int value) { }

	// RVA: 0x3725BC8 Offset: 0x3721BC8 VA: 0x3725BC8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3725BD0 Offset: 0x3721BD0 VA: 0x3725BD0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3725BD8 Offset: 0x3721BD8 VA: 0x3725BD8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3725D38 Offset: 0x3721D38 VA: 0x3725D38 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
