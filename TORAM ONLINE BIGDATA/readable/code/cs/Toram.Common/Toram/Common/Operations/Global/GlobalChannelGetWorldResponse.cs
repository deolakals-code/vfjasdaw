// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global
public class GlobalChannelGetWorldResponse : OperationResponseBase // TypeDefIndex: 11572
{
	// Fields
	[CompilerGenerated]
	private byte <WorldType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x24
	[CompilerGenerated]
	private WorldLoginData[] <WorldList>k__BackingField; // 0x28

	// Properties
	public byte WorldType { get; set; }
	public int WorldId { get; set; }
	public WorldLoginData[] WorldList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371D108 Offset: 0x3719108 VA: 0x371D108
	public void .ctor() { }

	// RVA: 0x371D110 Offset: 0x3719110 VA: 0x371D110
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371D118 Offset: 0x3719118 VA: 0x371D118
	public byte get_WorldType() { }

	[CompilerGenerated]
	// RVA: 0x371D120 Offset: 0x3719120 VA: 0x371D120
	public void set_WorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371D128 Offset: 0x3719128 VA: 0x371D128
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x371D130 Offset: 0x3719130 VA: 0x371D130
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371D138 Offset: 0x3719138 VA: 0x371D138
	public WorldLoginData[] get_WorldList() { }

	[CompilerGenerated]
	// RVA: 0x371D140 Offset: 0x3719140 VA: 0x371D140
	public void set_WorldList(WorldLoginData[] value) { }

	// RVA: 0x371D148 Offset: 0x3719148 VA: 0x371D148 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371D150 Offset: 0x3719150 VA: 0x371D150 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371D158 Offset: 0x3719158 VA: 0x371D158 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371D380 Offset: 0x3719380 VA: 0x371D380 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
