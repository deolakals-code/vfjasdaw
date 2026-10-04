// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Dungeon
public class CheckDungeonRoom : PacketBase // TypeDefIndex: 11763
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 106)]
	public byte RoomId { get; set; }
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3744E34 Offset: 0x3740E34 VA: 0x3744E34
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3744E3C Offset: 0x3740E3C VA: 0x3744E3C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3744E44 Offset: 0x3740E44 VA: 0x3744E44
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3744E4C Offset: 0x3740E4C VA: 0x3744E4C
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3744E54 Offset: 0x3740E54 VA: 0x3744E54
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3744E5C Offset: 0x3740E5C VA: 0x3744E5C
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3744E64 Offset: 0x3740E64 VA: 0x3744E64
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3744E6C Offset: 0x3740E6C VA: 0x3744E6C
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x3744E74 Offset: 0x3740E74 VA: 0x3744E74
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3744E7C Offset: 0x3740E7C VA: 0x3744E7C
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3744E84 Offset: 0x3740E84 VA: 0x3744E84
	public void set_GuildId(int value) { }

	// RVA: 0x3744E8C Offset: 0x3740E8C VA: 0x3744E8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3744E94 Offset: 0x3740E94 VA: 0x3744E94 Slot: 3
	public override string ToString() { }

	// RVA: 0x3744F34 Offset: 0x3740F34 VA: 0x3744F34 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3745180 Offset: 0x3741180 VA: 0x3745180 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
