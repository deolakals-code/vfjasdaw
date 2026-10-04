// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendChangeOnlineNotice : PacketBase // TypeDefIndex: 11635
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 245)]
	public byte Type { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3729350 Offset: 0x3725350 VA: 0x3729350
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3729358 Offset: 0x3725358 VA: 0x3729358
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3729360 Offset: 0x3725360 VA: 0x3729360
	public void set_Type(byte value) { }

	// RVA: 0x3729368 Offset: 0x3725368 VA: 0x3729368 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3729370 Offset: 0x3725370 VA: 0x3729370 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3729490 Offset: 0x3725490 VA: 0x3729490 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
