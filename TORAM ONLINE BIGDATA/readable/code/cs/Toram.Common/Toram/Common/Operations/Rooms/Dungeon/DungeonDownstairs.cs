// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Dungeon
public class DungeonDownstairs : PacketBase // TypeDefIndex: 11768
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3746898 Offset: 0x3742898 VA: 0x3746898
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37468A0 Offset: 0x37428A0 VA: 0x37468A0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37468A8 Offset: 0x37428A8 VA: 0x37468A8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37468B0 Offset: 0x37428B0 VA: 0x37468B0
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x37468B8 Offset: 0x37428B8 VA: 0x37468B8
	public void set_Position(short[] value) { }

	// RVA: 0x37468C0 Offset: 0x37428C0 VA: 0x37468C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37468C8 Offset: 0x37428C8 VA: 0x37468C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3746A78 Offset: 0x3742A78 VA: 0x3746A78 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
