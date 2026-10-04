// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class MobAbnormalDamageEvent : PacketBase // TypeDefIndex: 12716
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
	private MobResponseData <MobData>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 204)]
	public byte AbnormalState { get; set; }
	[PacketParameter(Code = 195)]
	public int Damage { get; set; }
	[PacketClass(Code = 76)]
	public MobResponseData MobData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3648B98 Offset: 0x3644B98 VA: 0x3648B98
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3648BA0 Offset: 0x3644BA0 VA: 0x3648BA0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3648BA8 Offset: 0x3644BA8 VA: 0x3648BA8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3648BB0 Offset: 0x3644BB0 VA: 0x3648BB0
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3648BB8 Offset: 0x3644BB8 VA: 0x3648BB8
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3648BC0 Offset: 0x3644BC0 VA: 0x3648BC0
	public byte get_AbnormalState() { }

	[CompilerGenerated]
	// RVA: 0x3648BC8 Offset: 0x3644BC8 VA: 0x3648BC8
	public void set_AbnormalState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3648BD0 Offset: 0x3644BD0 VA: 0x3648BD0
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x3648BD8 Offset: 0x3644BD8 VA: 0x3648BD8
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x3648BE0 Offset: 0x3644BE0 VA: 0x3648BE0
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x3648BE8 Offset: 0x3644BE8 VA: 0x3648BE8
	public void set_MobData(MobResponseData value) { }

	// RVA: 0x3648BF0 Offset: 0x3644BF0 VA: 0x3648BF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3648BF8 Offset: 0x3644BF8 VA: 0x3648BF8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3648EA8 Offset: 0x3644EA8 VA: 0x3648EA8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
