// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Channel
public class ChannelChange : PacketBase // TypeDefIndex: 12039
{
	// Fields
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <AccountWorldType>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <CustomerPlatform>k__BackingField; // 0x26
	[CompilerGenerated]
	private byte <ChannelId>k__BackingField; // 0x28

	// Properties
	public int WorldId { get; set; }
	public byte AccountWorldType { get; set; }
	public short CustomerPlatform { get; set; }
	public byte ChannelId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x377BD10 Offset: 0x3777D10 VA: 0x377BD10
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377BD18 Offset: 0x3777D18 VA: 0x377BD18
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x377BD20 Offset: 0x3777D20 VA: 0x377BD20
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377BD28 Offset: 0x3777D28 VA: 0x377BD28
	public byte get_AccountWorldType() { }

	[CompilerGenerated]
	// RVA: 0x377BD30 Offset: 0x3777D30 VA: 0x377BD30
	public void set_AccountWorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377BD38 Offset: 0x3777D38 VA: 0x377BD38
	public short get_CustomerPlatform() { }

	[CompilerGenerated]
	// RVA: 0x377BD40 Offset: 0x3777D40 VA: 0x377BD40
	public void set_CustomerPlatform(short value) { }

	[CompilerGenerated]
	// RVA: 0x377BD48 Offset: 0x3777D48 VA: 0x377BD48
	public byte get_ChannelId() { }

	[CompilerGenerated]
	// RVA: 0x377BD50 Offset: 0x3777D50 VA: 0x377BD50
	public void set_ChannelId(byte value) { }

	// RVA: 0x377BD58 Offset: 0x3777D58 VA: 0x377BD58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377BD60 Offset: 0x3777D60 VA: 0x377BD60 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377BFC0 Offset: 0x3777FC0 VA: 0x377BFC0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
