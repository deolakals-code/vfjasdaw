// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class MonsterFollowersPop : PacketBase // TypeDefIndex: 12720
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketClass(Code = 76)]
	public MobResponseData MobData { get; set; }

	// Methods

	// RVA: 0x3649C88 Offset: 0x3645C88 VA: 0x3649C88
	public void .ctor() { }

	// RVA: 0x3649C90 Offset: 0x3645C90 VA: 0x3649C90
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3649C98 Offset: 0x3645C98 VA: 0x3649C98 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3649CA0 Offset: 0x3645CA0 VA: 0x3649CA0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3649CA8 Offset: 0x3645CA8 VA: 0x3649CA8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3649CB0 Offset: 0x3645CB0 VA: 0x3649CB0
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3649CB8 Offset: 0x3645CB8 VA: 0x3649CB8
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3649CC0 Offset: 0x3645CC0 VA: 0x3649CC0
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x3649CC8 Offset: 0x3645CC8 VA: 0x3649CC8
	public void set_MobData(MobResponseData value) { }

	// RVA: 0x3649CD0 Offset: 0x3645CD0 VA: 0x3649CD0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3649EF0 Offset: 0x3645EF0 VA: 0x3649EF0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
