// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Dungeon
public class DungeonTrapActiveResponse : PacketBase // TypeDefIndex: 12756
{
	// Fields
	[CompilerGenerated]
	private byte <ResponseId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <SenderType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 153)]
	public byte ResponseId { get; set; }
	[PacketParameter(Code = 165)]
	public byte SenderType { get; set; }
	[PacketParameter(Code = 99)]
	public int SenderId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3651D54 Offset: 0x364DD54 VA: 0x3651D54
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3651D5C Offset: 0x364DD5C VA: 0x3651D5C
	public byte get_ResponseId() { }

	[CompilerGenerated]
	// RVA: 0x3651D64 Offset: 0x364DD64 VA: 0x3651D64
	public void set_ResponseId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3651D6C Offset: 0x364DD6C VA: 0x3651D6C
	public byte get_SenderType() { }

	[CompilerGenerated]
	// RVA: 0x3651D74 Offset: 0x364DD74 VA: 0x3651D74
	public void set_SenderType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3651D7C Offset: 0x364DD7C VA: 0x3651D7C
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x3651D84 Offset: 0x364DD84 VA: 0x3651D84
	public void set_SenderId(int value) { }

	// RVA: 0x3651D8C Offset: 0x364DD8C VA: 0x3651D8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3651D94 Offset: 0x364DD94 VA: 0x3651D94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3651F58 Offset: 0x364DF58 VA: 0x3651F58 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
