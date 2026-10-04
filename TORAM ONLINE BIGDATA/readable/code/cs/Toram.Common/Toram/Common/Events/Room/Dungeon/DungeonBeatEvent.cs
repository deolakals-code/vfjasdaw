// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Dungeon
public class DungeonBeatEvent : PacketBase // TypeDefIndex: 12755
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <FloorDepth>k__BackingField; // 0x24

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 99)]
	public int SenderId { get; set; }
	[PacketParameter(Code = 240)]
	public short FloorDepth { get; set; }

	// Methods

	// RVA: 0x3651A9C Offset: 0x364DA9C VA: 0x3651A9C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3651AA4 Offset: 0x364DAA4 VA: 0x3651AA4 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3651AAC Offset: 0x364DAAC VA: 0x3651AAC
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x3651AB4 Offset: 0x364DAB4 VA: 0x3651AB4
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3651ABC Offset: 0x364DABC VA: 0x3651ABC
	public short get_FloorDepth() { }

	[CompilerGenerated]
	// RVA: 0x3651AC4 Offset: 0x364DAC4 VA: 0x3651AC4
	public void set_FloorDepth(short value) { }

	// RVA: 0x3651ACC Offset: 0x364DACC VA: 0x3651ACC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3651C44 Offset: 0x364DC44 VA: 0x3651C44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
