// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Dungeon
public class DungeonMobHate : PacketBase // TypeDefIndex: 11770
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <MobUniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 88)]
	public int MobUniqueId { get; set; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3746D78 Offset: 0x3742D78 VA: 0x3746D78
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3746D80 Offset: 0x3742D80 VA: 0x3746D80
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3746D88 Offset: 0x3742D88 VA: 0x3746D88
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3746D90 Offset: 0x3742D90 VA: 0x3746D90
	public int get_MobUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3746D98 Offset: 0x3742D98 VA: 0x3746D98
	public void set_MobUniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3746DA0 Offset: 0x3742DA0 VA: 0x3746DA0
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3746DA8 Offset: 0x3742DA8 VA: 0x3746DA8
	public void set_Position(short[] value) { }

	// RVA: 0x3746DB0 Offset: 0x3742DB0 VA: 0x3746DB0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3746DB8 Offset: 0x3742DB8 VA: 0x3746DB8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3746FB4 Offset: 0x3742FB4 VA: 0x3746FB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
