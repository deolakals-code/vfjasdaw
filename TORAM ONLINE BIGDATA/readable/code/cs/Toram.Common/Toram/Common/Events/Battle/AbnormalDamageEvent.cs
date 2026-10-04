// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class AbnormalDamageEvent : PacketBase // TypeDefIndex: 12711
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <AbnormalState>k__BackingField; // 0x25
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x28
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <MpHeal>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 204)]
	public byte AbnormalState { get; set; }
	[PacketParameter(Code = 195)]
	public int Damage { get; set; }
	[PacketClass(Code = 181)]
	public PlayerStatusData PlayerStatus { get; set; }
	[PacketClass(Code = 26, IsOptional = True)]
	public short MpHeal { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3647294 Offset: 0x3643294 VA: 0x3647294
	public void .ctor() { }

	// RVA: 0x364729C Offset: 0x364329C VA: 0x364729C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36472A4 Offset: 0x36432A4 VA: 0x36472A4
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36472AC Offset: 0x36432AC VA: 0x36472AC
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36472B4 Offset: 0x36432B4 VA: 0x36472B4
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36472BC Offset: 0x36432BC VA: 0x36472BC
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36472C4 Offset: 0x36432C4 VA: 0x36472C4
	public byte get_AbnormalState() { }

	[CompilerGenerated]
	// RVA: 0x36472CC Offset: 0x36432CC VA: 0x36472CC
	public void set_AbnormalState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36472D4 Offset: 0x36432D4 VA: 0x36472D4
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x36472DC Offset: 0x36432DC VA: 0x36472DC
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36472E4 Offset: 0x36432E4 VA: 0x36472E4
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36472EC Offset: 0x36432EC VA: 0x36472EC
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36472F4 Offset: 0x36432F4 VA: 0x36472F4
	public short get_MpHeal() { }

	[CompilerGenerated]
	// RVA: 0x36472FC Offset: 0x36432FC VA: 0x36472FC
	public void set_MpHeal(short value) { }

	// RVA: 0x3647304 Offset: 0x3643304 VA: 0x3647304 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364730C Offset: 0x364330C VA: 0x364730C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3647640 Offset: 0x3643640 VA: 0x3647640 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
