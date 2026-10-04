// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobaMobResponseData : UnityHashBase // TypeDefIndex: 13131
{
	// Fields
	[CompilerGenerated]
	private byte <ReturnCode>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <HpRate>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x32
	[CompilerGenerated]
	private int <State>k__BackingField; // 0x34
	[CompilerGenerated]
	private MobHateData[] <MobHateList>k__BackingField; // 0x38
	[CompilerGenerated]
	private AbnormalData[] <AbnormalStateList>k__BackingField; // 0x40
	[CompilerGenerated]
	private AbnormalData <AddAbnormalState>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <AbnormalDamage>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x54
	[CompilerGenerated]
	private short <HitType>k__BackingField; // 0x58
	[CompilerGenerated]
	private byte <AttackType>k__BackingField; // 0x5A
	[CompilerGenerated]
	private byte <DamageResultFlag>k__BackingField; // 0x5B
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x60
	[CompilerGenerated]
	private MobBuffData[] <MobBuffList>k__BackingField; // 0x68
	[CompilerGenerated]
	private MobBuffData <AddMobBufferData>k__BackingField; // 0x70

	// Properties
	[UnityHash(Code = 58)]
	public byte ReturnCode { get; set; }
	[UnityHash(Code = 3)]
	public byte ArchetypeType { get; set; }
	[UnityHash(Code = 4)]
	public int ArchetypeId { get; set; }
	[UnityHash(Code = 10)]
	public short[] Position { get; set; }
	[UnityHash(Code = 11)]
	public short Rotation { get; set; }
	[UnityHash(Code = 12)]
	public int Hp { get; set; }
	[UnityHash(Code = 102, IsOptional = True)]
	public byte HpRate { get; set; }
	public short Mp { get; set; }
	[UnityHash(Code = 18)]
	public int State { get; set; }
	[UnityHash(Code = 30, IsOptional = True)]
	public MobHateData[] MobHateList { get; set; }
	[UnityHash(Code = 52)]
	public AbnormalData[] AbnormalStateList { get; set; }
	[UnityHash(Code = 51)]
	public AbnormalData AddAbnormalState { get; set; }
	[UnityHash(Code = 101)]
	public int AbnormalDamage { get; set; }
	[UnityHash(Code = 49)]
	public int Damage { get; set; }
	public short HitType { get; set; }
	public byte AttackType { get; set; }
	[UnityHash(Code = 59)]
	public byte DamageResultFlag { get; set; }
	public ActionAppendData AppendData { get; set; }
	[UnityHash(Code = 86, IsOptional = True)]
	public MobBuffData[] MobBuffList { get; set; }
	public MobBuffData AddMobBufferData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36AD794 Offset: 0x36A9794 VA: 0x36AD794
	public void .ctor() { }

	// RVA: 0x36AD78C Offset: 0x36A978C VA: 0x36AD78C
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36AD79C Offset: 0x36A979C VA: 0x36AD79C
	public byte get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x36AD7A4 Offset: 0x36A97A4 VA: 0x36AD7A4
	public void set_ReturnCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AD7AC Offset: 0x36A97AC VA: 0x36AD7AC
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36AD7B4 Offset: 0x36A97B4 VA: 0x36AD7B4
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AD7BC Offset: 0x36A97BC VA: 0x36AD7BC
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36AD7C4 Offset: 0x36A97C4 VA: 0x36AD7C4
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36AD7CC Offset: 0x36A97CC VA: 0x36AD7CC
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36AD7D4 Offset: 0x36A97D4 VA: 0x36AD7D4
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36AD7DC Offset: 0x36A97DC VA: 0x36AD7DC
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36AD7E4 Offset: 0x36A97E4 VA: 0x36AD7E4
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36AD7EC Offset: 0x36A97EC VA: 0x36AD7EC
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x36AD7F4 Offset: 0x36A97F4 VA: 0x36AD7F4
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36AD7FC Offset: 0x36A97FC VA: 0x36AD7FC
	public byte get_HpRate() { }

	[CompilerGenerated]
	// RVA: 0x36AD804 Offset: 0x36A9804 VA: 0x36AD804
	public void set_HpRate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AD80C Offset: 0x36A980C VA: 0x36AD80C
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x36AD814 Offset: 0x36A9814 VA: 0x36AD814
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x36AD81C Offset: 0x36A981C VA: 0x36AD81C
	public int get_State() { }

	[CompilerGenerated]
	// RVA: 0x36AD824 Offset: 0x36A9824 VA: 0x36AD824
	public void set_State(int value) { }

	[CompilerGenerated]
	// RVA: 0x36AD82C Offset: 0x36A982C VA: 0x36AD82C
	public MobHateData[] get_MobHateList() { }

	[CompilerGenerated]
	// RVA: 0x36AD834 Offset: 0x36A9834 VA: 0x36AD834
	public void set_MobHateList(MobHateData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36AD83C Offset: 0x36A983C VA: 0x36AD83C
	public AbnormalData[] get_AbnormalStateList() { }

	[CompilerGenerated]
	// RVA: 0x36AD844 Offset: 0x36A9844 VA: 0x36AD844
	public void set_AbnormalStateList(AbnormalData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36AD84C Offset: 0x36A984C VA: 0x36AD84C
	public AbnormalData get_AddAbnormalState() { }

	[CompilerGenerated]
	// RVA: 0x36AD854 Offset: 0x36A9854 VA: 0x36AD854
	public void set_AddAbnormalState(AbnormalData value) { }

	[CompilerGenerated]
	// RVA: 0x36AD85C Offset: 0x36A985C VA: 0x36AD85C
	public int get_AbnormalDamage() { }

	[CompilerGenerated]
	// RVA: 0x36AD864 Offset: 0x36A9864 VA: 0x36AD864
	public void set_AbnormalDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36AD86C Offset: 0x36A986C VA: 0x36AD86C
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x36AD874 Offset: 0x36A9874 VA: 0x36AD874
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36AD87C Offset: 0x36A987C VA: 0x36AD87C
	public short get_HitType() { }

	[CompilerGenerated]
	// RVA: 0x36AD884 Offset: 0x36A9884 VA: 0x36AD884
	public void set_HitType(short value) { }

	[CompilerGenerated]
	// RVA: 0x36AD88C Offset: 0x36A988C VA: 0x36AD88C
	public byte get_AttackType() { }

	[CompilerGenerated]
	// RVA: 0x36AD894 Offset: 0x36A9894 VA: 0x36AD894
	public void set_AttackType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AD89C Offset: 0x36A989C VA: 0x36AD89C
	public byte get_DamageResultFlag() { }

	[CompilerGenerated]
	// RVA: 0x36AD8A4 Offset: 0x36A98A4 VA: 0x36AD8A4
	public void set_DamageResultFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AD8AC Offset: 0x36A98AC VA: 0x36AD8AC
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36AD8B4 Offset: 0x36A98B4 VA: 0x36AD8B4
	public void set_AppendData(ActionAppendData value) { }

	[CompilerGenerated]
	// RVA: 0x36AD8BC Offset: 0x36A98BC VA: 0x36AD8BC
	public MobBuffData[] get_MobBuffList() { }

	[CompilerGenerated]
	// RVA: 0x36AD8C4 Offset: 0x36A98C4 VA: 0x36AD8C4
	public void set_MobBuffList(MobBuffData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36AD8CC Offset: 0x36A98CC VA: 0x36AD8CC
	public MobBuffData get_AddMobBufferData() { }

	[CompilerGenerated]
	// RVA: 0x36AD8D4 Offset: 0x36A98D4 VA: 0x36AD8D4
	public void set_AddMobBufferData(MobBuffData value) { }

	// RVA: 0x36AD8DC Offset: 0x36A98DC VA: 0x36AD8DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AD8E4 Offset: 0x36A98E4 VA: 0x36AD8E4 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36ADFD0 Offset: 0x36A9FD0 VA: 0x36ADFD0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
