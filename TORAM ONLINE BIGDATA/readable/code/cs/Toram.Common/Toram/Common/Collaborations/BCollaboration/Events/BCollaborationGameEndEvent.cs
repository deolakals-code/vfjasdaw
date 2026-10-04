// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Events
public class BCollaborationGameEndEvent : EventSubBase // TypeDefIndex: 13076
{
	// Fields
	[CompilerGenerated]
	private int <EventPoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <RankingPoint>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <PartyMaxDamage>k__BackingField; // 0x30
	[CompilerGenerated]
	private long <Damage>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <AvatarBonus>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <TargetDamage>k__BackingField; // 0x44
	[CompilerGenerated]
	private byte[] <WeeklyChallengeClearList>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte[] <WeeklyChallengeGetPointList>k__BackingField; // 0x50
	[CompilerGenerated]
	private Dictionary<byte, object> <BossResultData>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <WeeklySealed>k__BackingField; // 0x60

	// Properties
	[PacketClass(Code = 10)]
	public int EventPoint { get; set; }
	[PacketClass(Code = 11)]
	public long RankingPoint { get; set; }
	public long PartyMaxDamage { get; set; }
	public long Damage { get; set; }
	public int AvatarBonus { get; set; }
	public int TargetDamage { get; set; }
	public byte[] WeeklyChallengeClearList { get; set; }
	public byte[] WeeklyChallengeGetPointList { get; set; }
	public Dictionary<byte, object> BossResultData { get; set; }
	public bool WeeklySealed { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x369DB0C Offset: 0x3699B0C VA: 0x369DB0C
	public void .ctor() { }

	// RVA: 0x369DB14 Offset: 0x3699B14 VA: 0x369DB14
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x369DB1C Offset: 0x3699B1C VA: 0x369DB1C
	public int get_EventPoint() { }

	[CompilerGenerated]
	// RVA: 0x369DB24 Offset: 0x3699B24 VA: 0x369DB24
	public void set_EventPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x369DB2C Offset: 0x3699B2C VA: 0x369DB2C
	public long get_RankingPoint() { }

	[CompilerGenerated]
	// RVA: 0x369DB34 Offset: 0x3699B34 VA: 0x369DB34
	public void set_RankingPoint(long value) { }

	[CompilerGenerated]
	// RVA: 0x369DB3C Offset: 0x3699B3C VA: 0x369DB3C
	public long get_PartyMaxDamage() { }

	[CompilerGenerated]
	// RVA: 0x369DB44 Offset: 0x3699B44 VA: 0x369DB44
	public void set_PartyMaxDamage(long value) { }

	[CompilerGenerated]
	// RVA: 0x369DB4C Offset: 0x3699B4C VA: 0x369DB4C
	public long get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x369DB54 Offset: 0x3699B54 VA: 0x369DB54
	public void set_Damage(long value) { }

	[CompilerGenerated]
	// RVA: 0x369DB5C Offset: 0x3699B5C VA: 0x369DB5C
	public int get_AvatarBonus() { }

	[CompilerGenerated]
	// RVA: 0x369DB64 Offset: 0x3699B64 VA: 0x369DB64
	public void set_AvatarBonus(int value) { }

	[CompilerGenerated]
	// RVA: 0x369DB6C Offset: 0x3699B6C VA: 0x369DB6C
	public int get_TargetDamage() { }

	[CompilerGenerated]
	// RVA: 0x369DB74 Offset: 0x3699B74 VA: 0x369DB74
	public void set_TargetDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x369DB7C Offset: 0x3699B7C VA: 0x369DB7C
	public byte[] get_WeeklyChallengeClearList() { }

	[CompilerGenerated]
	// RVA: 0x369DB84 Offset: 0x3699B84 VA: 0x369DB84
	public void set_WeeklyChallengeClearList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x369DB8C Offset: 0x3699B8C VA: 0x369DB8C
	public byte[] get_WeeklyChallengeGetPointList() { }

	[CompilerGenerated]
	// RVA: 0x369DB94 Offset: 0x3699B94 VA: 0x369DB94
	public void set_WeeklyChallengeGetPointList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x369DB9C Offset: 0x3699B9C VA: 0x369DB9C
	public Dictionary<byte, object> get_BossResultData() { }

	[CompilerGenerated]
	// RVA: 0x369DBA4 Offset: 0x3699BA4 VA: 0x369DBA4
	public void set_BossResultData(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x369DBAC Offset: 0x3699BAC VA: 0x369DBAC
	public bool get_WeeklySealed() { }

	[CompilerGenerated]
	// RVA: 0x369DBB4 Offset: 0x3699BB4 VA: 0x369DBB4
	public void set_WeeklySealed(bool value) { }

	// RVA: 0x369DBC0 Offset: 0x3699BC0 VA: 0x369DBC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369DBC8 Offset: 0x3699BC8 VA: 0x369DBC8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369DBD0 Offset: 0x3699BD0 VA: 0x369DBD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x369DDD8 Offset: 0x3699DD8 VA: 0x369DDD8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
