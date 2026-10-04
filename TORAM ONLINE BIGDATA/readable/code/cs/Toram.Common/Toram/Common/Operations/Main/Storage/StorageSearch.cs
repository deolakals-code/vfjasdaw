// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageSearch : OperationRequestBase // TypeDefIndex: 12049
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Parts>k__BackingField; // 0x29
	[CompilerGenerated]
	private byte <Color>k__BackingField; // 0x2A
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <UseType>k__BackingField; // 0x30

	// Properties
	public byte Type { get; set; }
	public int Id { get; set; }
	public byte Slot { get; set; }
	public byte Parts { get; set; }
	public byte Color { get; set; }
	public int ModelId { get; set; }
	public byte UseType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377D6E4 Offset: 0x37796E4 VA: 0x377D6E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377D6FC Offset: 0x37796FC VA: 0x377D6FC
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x377D704 Offset: 0x3779704 VA: 0x377D704
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377D70C Offset: 0x377970C VA: 0x377D70C
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x377D714 Offset: 0x3779714 VA: 0x377D714
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x377D71C Offset: 0x377971C VA: 0x377D71C
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x377D724 Offset: 0x3779724 VA: 0x377D724
	public void set_Slot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377D72C Offset: 0x377972C VA: 0x377D72C
	public byte get_Parts() { }

	[CompilerGenerated]
	// RVA: 0x377D734 Offset: 0x3779734 VA: 0x377D734
	public void set_Parts(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377D73C Offset: 0x377973C VA: 0x377D73C
	public byte get_Color() { }

	[CompilerGenerated]
	// RVA: 0x377D744 Offset: 0x3779744 VA: 0x377D744
	public void set_Color(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377D74C Offset: 0x377974C VA: 0x377D74C
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x377D754 Offset: 0x3779754 VA: 0x377D754
	public void set_ModelId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377D75C Offset: 0x377975C VA: 0x377D75C
	public byte get_UseType() { }

	[CompilerGenerated]
	// RVA: 0x377D764 Offset: 0x3779764 VA: 0x377D764
	public void set_UseType(byte value) { }

	// RVA: 0x377D76C Offset: 0x377976C VA: 0x377D76C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377D774 Offset: 0x3779774 VA: 0x377D774 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377D77C Offset: 0x377977C VA: 0x377D77C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x377D928 Offset: 0x3779928 VA: 0x377D928 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
