// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Dungeon
public class DungeonGuildHomeEscape : PacketBase // TypeDefIndex: 11769
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3746B64 Offset: 0x3742B64 VA: 0x3746B64
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3746B6C Offset: 0x3742B6C VA: 0x3746B6C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3746B74 Offset: 0x3742B74 VA: 0x3746B74
	public void set_AvatarUuid(int value) { }

	// RVA: 0x3746B7C Offset: 0x3742B7C VA: 0x3746B7C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3746B84 Offset: 0x3742B84 VA: 0x3746B84 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3746CA4 Offset: 0x3742CA4 VA: 0x3746CA4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
