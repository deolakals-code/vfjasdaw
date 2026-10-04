// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
[CLSCompliant(False)]
public class _ItemUserFlagChange : OperationRequestBase // TypeDefIndex: 12143
{
	// Fields
	[CompilerGenerated]
	private byte <ItemDataType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <ItemUserFlag>k__BackingField; // 0x28

	// Properties
	public byte ItemDataType { get; set; }
	public int ItemUuid { get; set; }
	public byte ItemUserFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378FEAC Offset: 0x378BEAC VA: 0x378FEAC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378FEB4 Offset: 0x378BEB4 VA: 0x378FEB4
	public byte get_ItemDataType() { }

	[CompilerGenerated]
	// RVA: 0x378FEBC Offset: 0x378BEBC VA: 0x378FEBC
	public void set_ItemDataType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378FEC4 Offset: 0x378BEC4 VA: 0x378FEC4
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x378FECC Offset: 0x378BECC VA: 0x378FECC
	public void set_ItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378FED4 Offset: 0x378BED4 VA: 0x378FED4
	public byte get_ItemUserFlag() { }

	[CompilerGenerated]
	// RVA: 0x378FEDC Offset: 0x378BEDC VA: 0x378FEDC
	public void set_ItemUserFlag(byte value) { }

	// RVA: 0x378FEE4 Offset: 0x378BEE4 VA: 0x378FEE4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378FEEC Offset: 0x378BEEC VA: 0x378FEEC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378FEF4 Offset: 0x378BEF4 VA: 0x378FEF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3790000 Offset: 0x378C000 VA: 0x3790000 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
