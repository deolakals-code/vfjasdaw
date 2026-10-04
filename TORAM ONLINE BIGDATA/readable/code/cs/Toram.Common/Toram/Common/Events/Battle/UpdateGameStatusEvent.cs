// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class UpdateGameStatusEvent : PacketBase // TypeDefIndex: 12707
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <HealHp>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <HealMp>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 70)]
	public PlayerStatusData PlayerStatus { get; set; }
	[PacketParameter(Code = 41, IsOptional = True)]
	public int HealHp { get; set; }
	[PacketParameter(Code = 42, IsOptional = True)]
	public short HealMp { get; set; }
	[PacketParameter(Code = 199, IsOptional = True)]
	public int Damage { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3646004 Offset: 0x3642004 VA: 0x3646004
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364600C Offset: 0x364200C VA: 0x364600C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3646014 Offset: 0x3642014 VA: 0x3646014
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x364601C Offset: 0x364201C VA: 0x364601C
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3646024 Offset: 0x3642024 VA: 0x3646024
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x364602C Offset: 0x364202C VA: 0x364602C
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x3646034 Offset: 0x3642034 VA: 0x3646034
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x364603C Offset: 0x364203C VA: 0x364603C
	public int get_HealHp() { }

	[CompilerGenerated]
	// RVA: 0x3646044 Offset: 0x3642044 VA: 0x3646044
	public void set_HealHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x364604C Offset: 0x364204C VA: 0x364604C
	public short get_HealMp() { }

	[CompilerGenerated]
	// RVA: 0x3646054 Offset: 0x3642054 VA: 0x3646054
	public void set_HealMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x364605C Offset: 0x364205C VA: 0x364605C
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x3646064 Offset: 0x3642064 VA: 0x3646064
	public void set_Damage(int value) { }

	// RVA: 0x364606C Offset: 0x364206C VA: 0x364606C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3646074 Offset: 0x3642074 VA: 0x3646074 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3646244 Offset: 0x3642244 VA: 0x3646244 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
