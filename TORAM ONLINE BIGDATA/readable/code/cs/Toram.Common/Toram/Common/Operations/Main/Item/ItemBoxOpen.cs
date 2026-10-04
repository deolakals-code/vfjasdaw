// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class ItemBoxOpen : OperationRequestBase // TypeDefIndex: 12130
{
	// Fields
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ItemNum>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <CurrentNum>k__BackingField; // 0x26

	// Properties
	public int ItemUuid { get; set; }
	public short ItemNum { get; set; }
	public short CurrentNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378DA84 Offset: 0x3789A84 VA: 0x378DA84
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378DA8C Offset: 0x3789A8C VA: 0x378DA8C
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x378DA94 Offset: 0x3789A94 VA: 0x378DA94
	public void set_ItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378DA9C Offset: 0x3789A9C VA: 0x378DA9C
	public short get_ItemNum() { }

	[CompilerGenerated]
	// RVA: 0x378DAA4 Offset: 0x3789AA4 VA: 0x378DAA4
	public void set_ItemNum(short value) { }

	[CompilerGenerated]
	// RVA: 0x378DAAC Offset: 0x3789AAC VA: 0x378DAAC
	public short get_CurrentNum() { }

	[CompilerGenerated]
	// RVA: 0x378DAB4 Offset: 0x3789AB4 VA: 0x378DAB4
	public void set_CurrentNum(short value) { }

	// RVA: 0x378DABC Offset: 0x3789ABC VA: 0x378DABC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378DAC4 Offset: 0x3789AC4 VA: 0x378DAC4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378DACC Offset: 0x3789ACC VA: 0x378DACC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378DBD8 Offset: 0x3789BD8 VA: 0x378DBD8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
