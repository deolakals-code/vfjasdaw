// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class SkillBuffEndEvent : PacketBase // TypeDefIndex: 12708
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x26
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsSelf>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 90)]
	public short SkillId { get; set; }
	[PacketParameter(Code = 70)]
	public PlayerStatusData PlayerStatus { get; set; }
	public bool IsSelf { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36465B0 Offset: 0x36425B0 VA: 0x36465B0
	public void .ctor() { }

	// RVA: 0x36465B8 Offset: 0x36425B8 VA: 0x36465B8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36465C0 Offset: 0x36425C0 VA: 0x36465C0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36465C8 Offset: 0x36425C8 VA: 0x36465C8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36465D0 Offset: 0x36425D0 VA: 0x36465D0
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36465D8 Offset: 0x36425D8 VA: 0x36465D8
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36465E0 Offset: 0x36425E0 VA: 0x36465E0
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36465E8 Offset: 0x36425E8 VA: 0x36465E8
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36465F0 Offset: 0x36425F0 VA: 0x36465F0
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36465F8 Offset: 0x36425F8 VA: 0x36465F8
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3646600 Offset: 0x3642600 VA: 0x3646600
	public bool get_IsSelf() { }

	[CompilerGenerated]
	// RVA: 0x3646608 Offset: 0x3642608 VA: 0x3646608
	public void set_IsSelf(bool value) { }

	// RVA: 0x3646614 Offset: 0x3642614 VA: 0x3646614 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364661C Offset: 0x364261C VA: 0x364661C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36467CC Offset: 0x36427CC VA: 0x36467CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
