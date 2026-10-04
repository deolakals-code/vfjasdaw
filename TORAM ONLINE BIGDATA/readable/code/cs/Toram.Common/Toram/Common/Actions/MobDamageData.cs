// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobDamageData : UnityHashBase // TypeDefIndex: 13117
{
	// Fields
	[CompilerGenerated]
	private MobSendData <Target>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <HitType>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte[] <HitTypeList>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <PartsData>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <PrimaryStatusId>k__BackingField; // 0x3C
	[CompilerGenerated]
	private byte[] <AbnormalCondition>k__BackingField; // 0x40
	[CompilerGenerated]
	private AbnormalData <AbnormalData>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsForceAddAbnormal>k__BackingField; // 0x50
	[CompilerGenerated]
	private float[] <SkillCalc>k__BackingField; // 0x58
	[CompilerGenerated]
	private byte <AttackDamageFlag>k__BackingField; // 0x60
	[CompilerGenerated]
	private byte <AttackDamageIndividualFlag>k__BackingField; // 0x61
	[CompilerGenerated]
	private MobBuffData <MobBuffData>k__BackingField; // 0x68
	[CompilerGenerated]
	private byte <PartsAttackAbnormal>k__BackingField; // 0x70
	[CompilerGenerated]
	private short <MobLevel>k__BackingField; // 0x72
	[CompilerGenerated]
	private short <DamageLocalId>k__BackingField; // 0x74

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 20)]
	public MobSendData Target { get; set; }
	[UnityHash(Code = 49)]
	public int Damage { get; set; }
	[UnityHash(Code = 47, IsOptional = True)]
	public byte HitType { get; set; }
	[UnityHash(Code = 78, IsOptional = True)]
	public byte[] HitTypeList { get; set; }
	[UnityHash(Code = 79, IsOptional = True)]
	public byte PartsData { get; set; }
	[UnityHash(Code = 80, IsOptional = True)]
	public int PrimaryStatusId { get; set; }
	[UnityHash(Code = 6, IsOptional = True)]
	public byte[] AbnormalCondition { get; set; }
	public AbnormalData AbnormalData { get; set; }
	public bool IsForceAddAbnormal { get; set; }
	public float[] SkillCalc { get; set; }
	public byte AttackDamageFlag { get; set; }
	public byte AttackDamageIndividualFlag { get; set; }
	public MobBuffData MobBuffData { get; set; }
	public byte PartsAttackAbnormal { get; set; }
	[Obsolete("ログにしか使用しないのと、あまり有用性がなかったので削除予定")]
	public short MobLevel { get; set; }
	public short DamageLocalId { get; set; }

	// Methods

	// RVA: 0x36A916C Offset: 0x36A516C VA: 0x36A916C
	public void .ctor() { }

	// RVA: 0x36A9174 Offset: 0x36A5174 VA: 0x36A9174 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36A917C Offset: 0x36A517C VA: 0x36A917C
	public MobSendData get_Target() { }

	[CompilerGenerated]
	// RVA: 0x36A9184 Offset: 0x36A5184 VA: 0x36A9184
	public void set_Target(MobSendData value) { }

	[CompilerGenerated]
	// RVA: 0x36A918C Offset: 0x36A518C VA: 0x36A918C
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x36A9194 Offset: 0x36A5194 VA: 0x36A9194
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A919C Offset: 0x36A519C VA: 0x36A919C
	public byte get_HitType() { }

	[CompilerGenerated]
	// RVA: 0x36A91A4 Offset: 0x36A51A4 VA: 0x36A91A4
	public void set_HitType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A91AC Offset: 0x36A51AC VA: 0x36A91AC
	public byte[] get_HitTypeList() { }

	[CompilerGenerated]
	// RVA: 0x36A91B4 Offset: 0x36A51B4 VA: 0x36A91B4
	public void set_HitTypeList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A91BC Offset: 0x36A51BC VA: 0x36A91BC
	public byte get_PartsData() { }

	[CompilerGenerated]
	// RVA: 0x36A91C4 Offset: 0x36A51C4 VA: 0x36A91C4
	public void set_PartsData(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A91CC Offset: 0x36A51CC VA: 0x36A91CC
	public int get_PrimaryStatusId() { }

	[CompilerGenerated]
	// RVA: 0x36A91D4 Offset: 0x36A51D4 VA: 0x36A91D4
	public void set_PrimaryStatusId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A91DC Offset: 0x36A51DC VA: 0x36A91DC
	public byte[] get_AbnormalCondition() { }

	[CompilerGenerated]
	// RVA: 0x36A91E4 Offset: 0x36A51E4 VA: 0x36A91E4
	public void set_AbnormalCondition(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A91EC Offset: 0x36A51EC VA: 0x36A91EC
	public AbnormalData get_AbnormalData() { }

	[CompilerGenerated]
	// RVA: 0x36A91F4 Offset: 0x36A51F4 VA: 0x36A91F4
	public void set_AbnormalData(AbnormalData value) { }

	[CompilerGenerated]
	// RVA: 0x36A91FC Offset: 0x36A51FC VA: 0x36A91FC
	public bool get_IsForceAddAbnormal() { }

	[CompilerGenerated]
	// RVA: 0x36A9204 Offset: 0x36A5204 VA: 0x36A9204
	public void set_IsForceAddAbnormal(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36A9210 Offset: 0x36A5210 VA: 0x36A9210
	public float[] get_SkillCalc() { }

	[CompilerGenerated]
	// RVA: 0x36A9218 Offset: 0x36A5218 VA: 0x36A9218
	public void set_SkillCalc(float[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A9220 Offset: 0x36A5220 VA: 0x36A9220
	public byte get_AttackDamageFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A9228 Offset: 0x36A5228 VA: 0x36A9228
	public void set_AttackDamageFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A9230 Offset: 0x36A5230 VA: 0x36A9230
	public byte get_AttackDamageIndividualFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A9238 Offset: 0x36A5238 VA: 0x36A9238
	public void set_AttackDamageIndividualFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A9240 Offset: 0x36A5240 VA: 0x36A9240
	public MobBuffData get_MobBuffData() { }

	[CompilerGenerated]
	// RVA: 0x36A9248 Offset: 0x36A5248 VA: 0x36A9248
	public void set_MobBuffData(MobBuffData value) { }

	[CompilerGenerated]
	// RVA: 0x36A9250 Offset: 0x36A5250 VA: 0x36A9250
	public byte get_PartsAttackAbnormal() { }

	[CompilerGenerated]
	// RVA: 0x36A9258 Offset: 0x36A5258 VA: 0x36A9258
	public void set_PartsAttackAbnormal(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A9260 Offset: 0x36A5260 VA: 0x36A9260
	public short get_MobLevel() { }

	[CompilerGenerated]
	// RVA: 0x36A9268 Offset: 0x36A5268 VA: 0x36A9268
	public void set_MobLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A9270 Offset: 0x36A5270 VA: 0x36A9270
	public short get_DamageLocalId() { }

	[CompilerGenerated]
	// RVA: 0x36A9278 Offset: 0x36A5278 VA: 0x36A9278
	public void set_DamageLocalId(short value) { }

	// RVA: 0x36A9280 Offset: 0x36A5280 VA: 0x36A9280 Slot: 3
	public override string ToString() { }

	// RVA: 0x36A92E4 Offset: 0x36A52E4 VA: 0x36A92E4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36A9DEC Offset: 0x36A5DEC VA: 0x36A9DEC Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
