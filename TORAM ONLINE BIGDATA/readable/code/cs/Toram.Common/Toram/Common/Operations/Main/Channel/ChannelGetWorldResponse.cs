// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Channel
public class ChannelGetWorldResponse : PacketBase // TypeDefIndex: 12044
{
	// Fields
	[CompilerGenerated]
	private byte <WorldType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x24
	[CompilerGenerated]
	private WorldLoginData[] <WorldList>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 10)]
	public byte WorldType { get; set; }
	[PacketParameter(Code = 11)]
	public int WorldId { get; set; }
	[PacketParameter(Code = 167, IsOptional = True)]
	public WorldLoginData[] WorldList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x377CB0C Offset: 0x3778B0C VA: 0x377CB0C
	public void .ctor() { }

	// RVA: 0x377CB14 Offset: 0x3778B14 VA: 0x377CB14
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377CB1C Offset: 0x3778B1C VA: 0x377CB1C
	public byte get_WorldType() { }

	[CompilerGenerated]
	// RVA: 0x377CB24 Offset: 0x3778B24 VA: 0x377CB24
	public void set_WorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377CB2C Offset: 0x3778B2C VA: 0x377CB2C
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x377CB34 Offset: 0x3778B34 VA: 0x377CB34
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377CB3C Offset: 0x3778B3C VA: 0x377CB3C
	public WorldLoginData[] get_WorldList() { }

	[CompilerGenerated]
	// RVA: 0x377CB44 Offset: 0x3778B44 VA: 0x377CB44
	public void set_WorldList(WorldLoginData[] value) { }

	// RVA: 0x377CB4C Offset: 0x3778B4C VA: 0x377CB4C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377CB54 Offset: 0x3778B54 VA: 0x377CB54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377CD7C Offset: 0x3778D7C VA: 0x377CD7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
