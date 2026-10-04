// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global
public class GlobalChannelGetListResponse : OperationResponseBase // TypeDefIndex: 11571
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <WorldType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, short> <ChannelList>k__BackingField; // 0x30

	// Properties
	public int FieldId { get; set; }
	public byte WorldType { get; set; }
	public int WorldId { get; set; }
	public Dictionary<byte, short> ChannelList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371CD20 Offset: 0x3718D20 VA: 0x371CD20
	public void .ctor() { }

	// RVA: 0x371CD28 Offset: 0x3718D28 VA: 0x371CD28
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371CD30 Offset: 0x3718D30 VA: 0x371CD30
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x371CD38 Offset: 0x3718D38 VA: 0x371CD38
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371CD40 Offset: 0x3718D40 VA: 0x371CD40
	public byte get_WorldType() { }

	[CompilerGenerated]
	// RVA: 0x371CD48 Offset: 0x3718D48 VA: 0x371CD48
	public void set_WorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371CD50 Offset: 0x3718D50 VA: 0x371CD50
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x371CD58 Offset: 0x3718D58 VA: 0x371CD58
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371CD60 Offset: 0x3718D60 VA: 0x371CD60
	public Dictionary<byte, short> get_ChannelList() { }

	[CompilerGenerated]
	// RVA: 0x371CD68 Offset: 0x3718D68 VA: 0x371CD68
	public void set_ChannelList(Dictionary<byte, short> value) { }

	// RVA: 0x371CD70 Offset: 0x3718D70 VA: 0x371CD70 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371CD78 Offset: 0x3718D78 VA: 0x371CD78 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371CD80 Offset: 0x3718D80 VA: 0x371CD80 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371CFE4 Offset: 0x3718FE4 VA: 0x371CFE4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
