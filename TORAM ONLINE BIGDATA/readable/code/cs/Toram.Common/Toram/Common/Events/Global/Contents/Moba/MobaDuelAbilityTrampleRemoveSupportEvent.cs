// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaDuelAbilityTrampleRemoveSupportEvent : EventSubBase // TypeDefIndex: 12660
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <TargetArchetypeType>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <TargetArchetypeId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short[] <RemoveSkillId>k__BackingField; // 0x30
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x38

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public byte TargetArchetypeType { get; set; }
	public int TargetArchetypeId { get; set; }
	public short[] RemoveSkillId { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x363BEA8 Offset: 0x3637EA8 VA: 0x363BEA8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363BEB0 Offset: 0x3637EB0 VA: 0x363BEB0
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x363BEB8 Offset: 0x3637EB8 VA: 0x363BEB8
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363BEC0 Offset: 0x3637EC0 VA: 0x363BEC0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x363BEC8 Offset: 0x3637EC8 VA: 0x363BEC8
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x363BED0 Offset: 0x3637ED0 VA: 0x363BED0
	public byte get_TargetArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x363BED8 Offset: 0x3637ED8 VA: 0x363BED8
	public void set_TargetArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363BEE0 Offset: 0x3637EE0 VA: 0x363BEE0
	public int get_TargetArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x363BEE8 Offset: 0x3637EE8 VA: 0x363BEE8
	public void set_TargetArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x363BEF0 Offset: 0x3637EF0 VA: 0x363BEF0
	public short[] get_RemoveSkillId() { }

	[CompilerGenerated]
	// RVA: 0x363BEF8 Offset: 0x3637EF8 VA: 0x363BEF8
	public void set_RemoveSkillId(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x363BF00 Offset: 0x3637F00 VA: 0x363BF00
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x363BF08 Offset: 0x3637F08 VA: 0x363BF08
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x363BF10 Offset: 0x3637F10 VA: 0x363BF10 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363BF18 Offset: 0x3637F18 VA: 0x363BF18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363BF20 Offset: 0x3637F20 VA: 0x363BF20 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363C098 Offset: 0x3638098 VA: 0x363C098 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
