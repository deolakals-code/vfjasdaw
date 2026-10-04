// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobAttackData : UnityHashBase // TypeDefIndex: 13161
{
	// Fields
	[CompilerGenerated]
	private MobSendData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ActionPatternId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <DamageId>k__BackingField; // 0x2A
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x2C
	[CompilerGenerated]
	private AbnormalData <AbnormalData>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsForceAddAbnormal>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <HitType>k__BackingField; // 0x39
	[CompilerGenerated]
	private MobDamageData[] <TargetList>k__BackingField; // 0x40
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x48
	[CompilerGenerated]
	private short <GuardSkillId>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte <AttackFlag>k__BackingField; // 0x52

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 20)]
	public MobSendData MobData { get; set; }
	[UnityHash(Code = 29)]
	public short ActionPatternId { get; set; }
	[UnityHash(Code = 23)]
	public byte DamageId { get; set; }
	[UnityHash(Code = 49)]
	public int Damage { get; set; }
	public AbnormalData AbnormalData { get; set; }
	public bool IsForceAddAbnormal { get; set; }
	public byte HitType { get; set; }
	[UnityHash(Code = 21, IsOptional = True)]
	public MobDamageData[] TargetList { get; set; }
	public ActionAppendData AppendData { get; set; }
	public short GuardSkillId { get; set; }
	public byte AttackFlag { get; set; }

	// Methods

	// RVA: 0x36B8C64 Offset: 0x36B4C64 VA: 0x36B8C64
	public void .ctor() { }

	// RVA: 0x36B8C6C Offset: 0x36B4C6C VA: 0x36B8C6C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36B8C74 Offset: 0x36B4C74 VA: 0x36B8C74
	public MobSendData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36B8C7C Offset: 0x36B4C7C VA: 0x36B8C7C
	public void set_MobData(MobSendData value) { }

	[CompilerGenerated]
	// RVA: 0x36B8C84 Offset: 0x36B4C84 VA: 0x36B8C84
	public short get_ActionPatternId() { }

	[CompilerGenerated]
	// RVA: 0x36B8C8C Offset: 0x36B4C8C VA: 0x36B8C8C
	public void set_ActionPatternId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36B8C94 Offset: 0x36B4C94 VA: 0x36B8C94
	public byte get_DamageId() { }

	[CompilerGenerated]
	// RVA: 0x36B8C9C Offset: 0x36B4C9C VA: 0x36B8C9C
	public void set_DamageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B8CA4 Offset: 0x36B4CA4 VA: 0x36B8CA4 Slot: 7
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x36B8CAC Offset: 0x36B4CAC VA: 0x36B8CAC Slot: 8
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B8CB4 Offset: 0x36B4CB4 VA: 0x36B8CB4 Slot: 9
	public AbnormalData get_AbnormalData() { }

	[CompilerGenerated]
	// RVA: 0x36B8CBC Offset: 0x36B4CBC VA: 0x36B8CBC Slot: 10
	public void set_AbnormalData(AbnormalData value) { }

	[CompilerGenerated]
	// RVA: 0x36B8CC4 Offset: 0x36B4CC4 VA: 0x36B8CC4 Slot: 11
	public bool get_IsForceAddAbnormal() { }

	[CompilerGenerated]
	// RVA: 0x36B8CCC Offset: 0x36B4CCC VA: 0x36B8CCC Slot: 12
	public void set_IsForceAddAbnormal(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36B8CD8 Offset: 0x36B4CD8 VA: 0x36B8CD8 Slot: 13
	public byte get_HitType() { }

	[CompilerGenerated]
	// RVA: 0x36B8CE0 Offset: 0x36B4CE0 VA: 0x36B8CE0 Slot: 14
	public void set_HitType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B8CE8 Offset: 0x36B4CE8 VA: 0x36B8CE8
	public MobDamageData[] get_TargetList() { }

	[CompilerGenerated]
	// RVA: 0x36B8CF0 Offset: 0x36B4CF0 VA: 0x36B8CF0
	public void set_TargetList(MobDamageData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B8CF8 Offset: 0x36B4CF8 VA: 0x36B8CF8 Slot: 15
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36B8D00 Offset: 0x36B4D00 VA: 0x36B8D00 Slot: 16
	public void set_AppendData(ActionAppendData value) { }

	[CompilerGenerated]
	// RVA: 0x36B8D08 Offset: 0x36B4D08 VA: 0x36B8D08 Slot: 17
	public short get_GuardSkillId() { }

	[CompilerGenerated]
	// RVA: 0x36B8D10 Offset: 0x36B4D10 VA: 0x36B8D10 Slot: 18
	public void set_GuardSkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36B8D18 Offset: 0x36B4D18 VA: 0x36B8D18 Slot: 19
	public byte get_AttackFlag() { }

	[CompilerGenerated]
	// RVA: 0x36B8D20 Offset: 0x36B4D20 VA: 0x36B8D20 Slot: 20
	public void set_AttackFlag(byte value) { }

	// RVA: 0x36B8D28 Offset: 0x36B4D28 VA: 0x36B8D28 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36B94F8 Offset: 0x36B54F8 VA: 0x36B94F8 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
