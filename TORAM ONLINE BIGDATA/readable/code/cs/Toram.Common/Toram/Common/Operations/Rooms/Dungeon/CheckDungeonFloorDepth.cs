// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Dungeon
public class CheckDungeonFloorDepth : PacketBase // TypeDefIndex: 11767
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <FloorDepth>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 240)]
	public short FloorDepth { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37465E0 Offset: 0x37425E0 VA: 0x37465E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37465E8 Offset: 0x37425E8 VA: 0x37465E8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37465F0 Offset: 0x37425F0 VA: 0x37465F0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37465F8 Offset: 0x37425F8 VA: 0x37465F8
	public short get_FloorDepth() { }

	[CompilerGenerated]
	// RVA: 0x3746600 Offset: 0x3742600 VA: 0x3746600
	public void set_FloorDepth(short value) { }

	// RVA: 0x3746608 Offset: 0x3742608 VA: 0x3746608 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3746610 Offset: 0x3742610 VA: 0x3746610 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3746788 Offset: 0x3742788 VA: 0x3746788 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
