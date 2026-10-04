// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global
public class ChannelGetGlobalResponse : OperationResponseBase // TypeDefIndex: 11567
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

	// RVA: 0x371BD4C Offset: 0x3717D4C VA: 0x371BD4C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371BD54 Offset: 0x3717D54 VA: 0x371BD54
	public byte get_WorldType() { }

	[CompilerGenerated]
	// RVA: 0x371BD5C Offset: 0x3717D5C VA: 0x371BD5C
	public void set_WorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371BD64 Offset: 0x3717D64 VA: 0x371BD64
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x371BD6C Offset: 0x3717D6C VA: 0x371BD6C
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371BD74 Offset: 0x3717D74 VA: 0x371BD74
	public WorldLoginData[] get_WorldList() { }

	[CompilerGenerated]
	// RVA: 0x371BD7C Offset: 0x3717D7C VA: 0x371BD7C
	public void set_WorldList(WorldLoginData[] value) { }

	// RVA: 0x371BD84 Offset: 0x3717D84 VA: 0x371BD84 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371BD8C Offset: 0x3717D8C VA: 0x371BD8C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371BD94 Offset: 0x3717D94 VA: 0x371BD94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371BFBC Offset: 0x3717FBC VA: 0x371BFBC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
