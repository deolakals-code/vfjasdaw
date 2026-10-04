// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillDamageData // TypeDefIndex: 360
{
	// Fields
	[CompilerGenerated]
	private int <ViewDamage>k__BackingField; // 0x10
	[CompilerGenerated]
	private SkillHitType <HitType>k__BackingField; // 0x14
	[CompilerGenerated]
	private SkillHitReactionType <HitReactionType>k__BackingField; // 0x18
	[CompilerGenerated]
	private SkillFreeType <FreeType>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsScratch>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsMinDamage>k__BackingField; // 0x21
	[CompilerGenerated]
	private bool <IsMaxDamage>k__BackingField; // 0x22
	[CompilerGenerated]
	private SkillDamageData <NextDamage>k__BackingField; // 0x28
	[CompilerGenerated]
	private SkillDamageData <ExtensionDamage>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <InvisibleDamage>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <InvisibleDamageLog>k__BackingField; // 0x39
	[CompilerGenerated]
	private bool <InvisibleMissLabel>k__BackingField; // 0x3A
	[CompilerGenerated]
	private bool <IsGuardBreak>k__BackingField; // 0x3B
	[CompilerGenerated]
	private bool <IsAvoidBreak>k__BackingField; // 0x3C
	[CompilerGenerated]
	private DamageStatus <DamageStatus>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <StoneSkinCutValue>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <GeoImpactUseBarrier>k__BackingField; // 0x4C
	[CompilerGenerated]
	private int <ArkSaberMpDamage>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <GuardPowerDamage>k__BackingField; // 0x54
	[CompilerGenerated]
	private short <GuardSkillId>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <IsJustGuard>k__BackingField; // 0x5A
	[CompilerGenerated]
	private int <KnightHealValue>k__BackingField; // 0x5C
	[CompilerGenerated]
	private bool <IllusionarySceneDamageCut>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <RevivalDamage>k__BackingField; // 0x61
	[CompilerGenerated]
	private int <MagicProtectionDamage>k__BackingField; // 0x64
	[CompilerGenerated]
	private int <AfterShieldTransferredDamage>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <KnightPladgeArchetypeId>k__BackingField; // 0x6C
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x70
	[CompilerGenerated]
	private byte <DamageIndividualFlag>k__BackingField; // 0x74
	[CompilerGenerated]
	private List<SkillCalcTemplate> <CalcTemplateList>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <ElementWeak>k__BackingField; // 0x80
	[CompilerGenerated]
	private short <DamageLocalId>k__BackingField; // 0x82
	private int _damage; // 0x84
	private bool isExtension; // 0x88
	[CompilerGenerated]
	private AbnormalType <AbnormalType>k__BackingField; // 0x8C
	[CompilerGenerated]
	private AbnormalType <GuardResistAbnormalType>k__BackingField; // 0x90
	[CompilerGenerated]
	private float <AbnormalEffectTime>k__BackingField; // 0x94
	[CompilerGenerated]
	private float <AbnormalResistTime>k__BackingField; // 0x98
	[CompilerGenerated]
	private float <AddAbnormalResistTime>k__BackingField; // 0x9C
	[CompilerGenerated]
	private byte <AbnormalLocalId>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <IsForceAddAbnormal>k__BackingField; // 0xA1
	[CompilerGenerated]
	private AbnormalType <PartsAttackPermissionAbnormal>k__BackingField; // 0xA4
	[CompilerGenerated]
	private int <AbnormalValue>k__BackingField; // 0xA8
	[CompilerGenerated]
	private MobBuffBase <AddMobBuffer>k__BackingField; // 0xB0

	// Properties
	public int Damage { get; set; }
	public int ViewDamage { get; set; }
	public SkillHitType HitType { get; set; }
	public SkillHitReactionType HitReactionType { get; set; }
	public SkillFreeType FreeType { get; set; }
	public bool IsScratch { get; set; }
	public bool IsMinDamage { get; set; }
	public bool IsMaxDamage { get; set; }
	public SkillDamageData NextDamage { get; set; }
	public SkillDamageData ExtensionDamage { get; set; }
	public bool InvisibleDamage { get; set; }
	public bool InvisibleDamageLog { get; set; }
	public bool InvisibleMissLabel { get; set; }
	public bool IsGuardBreak { get; set; }
	public bool IsAvoidBreak { get; set; }
	public DamageStatus DamageStatus { get; set; }
	public int StoneSkinCutValue { get; set; }
	public int GeoImpactUseBarrier { get; set; }
	public int ArkSaberMpDamage { get; set; }
	public int GuardPowerDamage { get; set; }
	public short GuardSkillId { get; set; }
	public bool IsJustGuard { get; set; }
	public int KnightHealValue { get; set; }
	public bool IllusionarySceneDamageCut { get; set; }
	public bool RevivalDamage { get; set; }
	public int MagicProtectionDamage { get; set; }
	public int AfterShieldTransferredDamage { get; set; }
	public int KnightPladgeArchetypeId { get; set; }
	public int Flag { get; set; }
	public byte DamageIndividualFlag { get; set; }
	public List<SkillCalcTemplate> CalcTemplateList { get; set; }
	public bool ElementWeak { get; set; }
	public short DamageLocalId { get; set; }
	public AbnormalType AbnormalType { get; set; }
	public AbnormalType GuardResistAbnormalType { get; set; }
	public float AbnormalEffectTime { get; set; }
	public float AbnormalResistTime { get; set; }
	public float AddAbnormalResistTime { get; set; }
	public byte AbnormalLocalId { get; set; }
	public bool IsForceAddAbnormal { get; set; }
	public AbnormalType PartsAttackPermissionAbnormal { get; set; }
	public int AbnormalValue { get; set; }
	public MobBuffBase AddMobBuffer { get; set; }

	// Methods

	// RVA: 0x248BBC8 Offset: 0x2487BC8 VA: 0x248BBC8
	public int get_Damage() { }

	// RVA: 0x2486BE0 Offset: 0x2482BE0 VA: 0x2486BE0
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BBD0 Offset: 0x2487BD0 VA: 0x248BBD0
	public int get_ViewDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BBD8 Offset: 0x2487BD8 VA: 0x248BBD8
	public void set_ViewDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BBE0 Offset: 0x2487BE0 VA: 0x248BBE0
	public SkillHitType get_HitType() { }

	[CompilerGenerated]
	// RVA: 0x248BBE8 Offset: 0x2487BE8 VA: 0x248BBE8
	public void set_HitType(SkillHitType value) { }

	[CompilerGenerated]
	// RVA: 0x248BBF0 Offset: 0x2487BF0 VA: 0x248BBF0
	public SkillHitReactionType get_HitReactionType() { }

	[CompilerGenerated]
	// RVA: 0x248BBF8 Offset: 0x2487BF8 VA: 0x248BBF8
	public void set_HitReactionType(SkillHitReactionType value) { }

	[CompilerGenerated]
	// RVA: 0x248BC00 Offset: 0x2487C00 VA: 0x248BC00
	public SkillFreeType get_FreeType() { }

	[CompilerGenerated]
	// RVA: 0x248BC08 Offset: 0x2487C08 VA: 0x248BC08
	public void set_FreeType(SkillFreeType value) { }

	[CompilerGenerated]
	// RVA: 0x248BC10 Offset: 0x2487C10 VA: 0x248BC10
	public bool get_IsScratch() { }

	[CompilerGenerated]
	// RVA: 0x248BC18 Offset: 0x2487C18 VA: 0x248BC18
	public void set_IsScratch(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BC24 Offset: 0x2487C24 VA: 0x248BC24
	public bool get_IsMinDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BC2C Offset: 0x2487C2C VA: 0x248BC2C
	public void set_IsMinDamage(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BC38 Offset: 0x2487C38 VA: 0x248BC38
	public bool get_IsMaxDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BC40 Offset: 0x2487C40 VA: 0x248BC40
	public void set_IsMaxDamage(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BC4C Offset: 0x2487C4C VA: 0x248BC4C
	public SkillDamageData get_NextDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BC54 Offset: 0x2487C54 VA: 0x248BC54
	public void set_NextDamage(SkillDamageData value) { }

	[CompilerGenerated]
	// RVA: 0x248BC5C Offset: 0x2487C5C VA: 0x248BC5C
	public SkillDamageData get_ExtensionDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BC64 Offset: 0x2487C64 VA: 0x248BC64
	public void set_ExtensionDamage(SkillDamageData value) { }

	[CompilerGenerated]
	// RVA: 0x248BC6C Offset: 0x2487C6C VA: 0x248BC6C
	public bool get_InvisibleDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BC74 Offset: 0x2487C74 VA: 0x248BC74
	public void set_InvisibleDamage(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BC80 Offset: 0x2487C80 VA: 0x248BC80
	public bool get_InvisibleDamageLog() { }

	[CompilerGenerated]
	// RVA: 0x248BC88 Offset: 0x2487C88 VA: 0x248BC88
	public void set_InvisibleDamageLog(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BC94 Offset: 0x2487C94 VA: 0x248BC94
	public bool get_InvisibleMissLabel() { }

	[CompilerGenerated]
	// RVA: 0x248BC9C Offset: 0x2487C9C VA: 0x248BC9C
	public void set_InvisibleMissLabel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BCA8 Offset: 0x2487CA8 VA: 0x248BCA8
	public bool get_IsGuardBreak() { }

	[CompilerGenerated]
	// RVA: 0x248BCB0 Offset: 0x2487CB0 VA: 0x248BCB0
	public void set_IsGuardBreak(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BCBC Offset: 0x2487CBC VA: 0x248BCBC
	public bool get_IsAvoidBreak() { }

	[CompilerGenerated]
	// RVA: 0x248BCC4 Offset: 0x2487CC4 VA: 0x248BCC4
	public void set_IsAvoidBreak(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BCD0 Offset: 0x2487CD0 VA: 0x248BCD0
	public DamageStatus get_DamageStatus() { }

	[CompilerGenerated]
	// RVA: 0x248BCD8 Offset: 0x2487CD8 VA: 0x248BCD8
	public void set_DamageStatus(DamageStatus value) { }

	[CompilerGenerated]
	// RVA: 0x248BCE0 Offset: 0x2487CE0 VA: 0x248BCE0
	public int get_StoneSkinCutValue() { }

	[CompilerGenerated]
	// RVA: 0x248BCE8 Offset: 0x2487CE8 VA: 0x248BCE8
	public void set_StoneSkinCutValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BCF0 Offset: 0x2487CF0 VA: 0x248BCF0
	public int get_GeoImpactUseBarrier() { }

	[CompilerGenerated]
	// RVA: 0x248BCF8 Offset: 0x2487CF8 VA: 0x248BCF8
	public void set_GeoImpactUseBarrier(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BD00 Offset: 0x2487D00 VA: 0x248BD00
	public int get_ArkSaberMpDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BD08 Offset: 0x2487D08 VA: 0x248BD08
	public void set_ArkSaberMpDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BD10 Offset: 0x2487D10 VA: 0x248BD10
	public int get_GuardPowerDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BD18 Offset: 0x2487D18 VA: 0x248BD18
	public void set_GuardPowerDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BD20 Offset: 0x2487D20 VA: 0x248BD20
	public short get_GuardSkillId() { }

	[CompilerGenerated]
	// RVA: 0x248BD28 Offset: 0x2487D28 VA: 0x248BD28
	public void set_GuardSkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x248BD30 Offset: 0x2487D30 VA: 0x248BD30
	public bool get_IsJustGuard() { }

	[CompilerGenerated]
	// RVA: 0x248BD38 Offset: 0x2487D38 VA: 0x248BD38
	public void set_IsJustGuard(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BD44 Offset: 0x2487D44 VA: 0x248BD44
	public int get_KnightHealValue() { }

	[CompilerGenerated]
	// RVA: 0x248BD4C Offset: 0x2487D4C VA: 0x248BD4C
	public void set_KnightHealValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BD54 Offset: 0x2487D54 VA: 0x248BD54
	public bool get_IllusionarySceneDamageCut() { }

	[CompilerGenerated]
	// RVA: 0x248BD5C Offset: 0x2487D5C VA: 0x248BD5C
	public void set_IllusionarySceneDamageCut(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BD68 Offset: 0x2487D68 VA: 0x248BD68
	public bool get_RevivalDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BD70 Offset: 0x2487D70 VA: 0x248BD70
	public void set_RevivalDamage(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BD7C Offset: 0x2487D7C VA: 0x248BD7C
	public int get_MagicProtectionDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BD84 Offset: 0x2487D84 VA: 0x248BD84
	public void set_MagicProtectionDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BD8C Offset: 0x2487D8C VA: 0x248BD8C
	public int get_AfterShieldTransferredDamage() { }

	[CompilerGenerated]
	// RVA: 0x248BD94 Offset: 0x2487D94 VA: 0x248BD94
	public void set_AfterShieldTransferredDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BD9C Offset: 0x2487D9C VA: 0x248BD9C
	public int get_KnightPladgeArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x248BDA4 Offset: 0x2487DA4 VA: 0x248BDA4
	public void set_KnightPladgeArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BDAC Offset: 0x2487DAC VA: 0x248BDAC
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x248BDB4 Offset: 0x2487DB4 VA: 0x248BDB4
	public void set_Flag(int value) { }

	[CompilerGenerated]
	// RVA: 0x248BDBC Offset: 0x2487DBC VA: 0x248BDBC
	public byte get_DamageIndividualFlag() { }

	[CompilerGenerated]
	// RVA: 0x248BDC4 Offset: 0x2487DC4 VA: 0x248BDC4
	public void set_DamageIndividualFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x248BDCC Offset: 0x2487DCC VA: 0x248BDCC
	public List<SkillCalcTemplate> get_CalcTemplateList() { }

	[CompilerGenerated]
	// RVA: 0x248BDD4 Offset: 0x2487DD4 VA: 0x248BDD4
	public void set_CalcTemplateList(List<SkillCalcTemplate> value) { }

	[CompilerGenerated]
	// RVA: 0x248BDDC Offset: 0x2487DDC VA: 0x248BDDC
	public bool get_ElementWeak() { }

	[CompilerGenerated]
	// RVA: 0x248BDE4 Offset: 0x2487DE4 VA: 0x248BDE4
	public void set_ElementWeak(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BDF0 Offset: 0x2487DF0 VA: 0x248BDF0
	public short get_DamageLocalId() { }

	[CompilerGenerated]
	// RVA: 0x248BDF8 Offset: 0x2487DF8 VA: 0x248BDF8
	private void set_DamageLocalId(short value) { }

	[CompilerGenerated]
	// RVA: 0x248BE00 Offset: 0x2487E00 VA: 0x248BE00
	public AbnormalType get_AbnormalType() { }

	[CompilerGenerated]
	// RVA: 0x248BE08 Offset: 0x2487E08 VA: 0x248BE08
	public void set_AbnormalType(AbnormalType value) { }

	[CompilerGenerated]
	// RVA: 0x248BE10 Offset: 0x2487E10 VA: 0x248BE10
	public AbnormalType get_GuardResistAbnormalType() { }

	[CompilerGenerated]
	// RVA: 0x248BE18 Offset: 0x2487E18 VA: 0x248BE18
	public void set_GuardResistAbnormalType(AbnormalType value) { }

	[CompilerGenerated]
	// RVA: 0x248BE20 Offset: 0x2487E20 VA: 0x248BE20
	public float get_AbnormalEffectTime() { }

	[CompilerGenerated]
	// RVA: 0x248BE28 Offset: 0x2487E28 VA: 0x248BE28
	public void set_AbnormalEffectTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x248BE30 Offset: 0x2487E30 VA: 0x248BE30
	public float get_AbnormalResistTime() { }

	[CompilerGenerated]
	// RVA: 0x248BE38 Offset: 0x2487E38 VA: 0x248BE38
	public void set_AbnormalResistTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x248BE40 Offset: 0x2487E40 VA: 0x248BE40
	public float get_AddAbnormalResistTime() { }

	[CompilerGenerated]
	// RVA: 0x248BE48 Offset: 0x2487E48 VA: 0x248BE48
	public void set_AddAbnormalResistTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x248BE50 Offset: 0x2487E50 VA: 0x248BE50
	public byte get_AbnormalLocalId() { }

	[CompilerGenerated]
	// RVA: 0x248BE58 Offset: 0x2487E58 VA: 0x248BE58
	public void set_AbnormalLocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x248BE60 Offset: 0x2487E60 VA: 0x248BE60
	public bool get_IsForceAddAbnormal() { }

	[CompilerGenerated]
	// RVA: 0x248BE68 Offset: 0x2487E68 VA: 0x248BE68
	public void set_IsForceAddAbnormal(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248BE74 Offset: 0x2487E74 VA: 0x248BE74
	public AbnormalType get_PartsAttackPermissionAbnormal() { }

	[CompilerGenerated]
	// RVA: 0x248BE7C Offset: 0x2487E7C VA: 0x248BE7C
	public void set_PartsAttackPermissionAbnormal(AbnormalType value) { }

	[CompilerGenerated]
	// RVA: 0x248BE84 Offset: 0x2487E84 VA: 0x248BE84
	public int get_AbnormalValue() { }

	[CompilerGenerated]
	// RVA: 0x248BE8C Offset: 0x2487E8C VA: 0x248BE8C
	public void set_AbnormalValue(int value) { }

	// RVA: 0x248BE94 Offset: 0x2487E94 VA: 0x248BE94
	public void SetAbnormalType(AbnormalType type, float addResistTime) { }

	// RVA: 0x248BF34 Offset: 0x2487F34 VA: 0x248BF34
	public void SetAbnormalType(AbnormalType type, float addResistTime, bool force) { }

	[CompilerGenerated]
	// RVA: 0x248BFCC Offset: 0x2487FCC VA: 0x248BFCC
	public MobBuffBase get_AddMobBuffer() { }

	[CompilerGenerated]
	// RVA: 0x248BFD4 Offset: 0x2487FD4 VA: 0x248BFD4
	public void set_AddMobBuffer(MobBuffBase value) { }

	// RVA: 0x2486B44 Offset: 0x2482B44 VA: 0x2486B44
	public void .ctor(DamageStatus status) { }

	// RVA: 0x248B1FC Offset: 0x24871FC VA: 0x248B1FC
	public void SetDamageLocalId(short localId) { }

	// RVA: 0x248BFDC Offset: 0x2487FDC VA: 0x248BFDC
	public bool NextExtensionDamage() { }

	// RVA: 0x248B204 Offset: 0x2487204 VA: 0x248B204
	public SkillDamageData CreateNextDamage() { }

	// RVA: 0x248C030 Offset: 0x2488030 VA: 0x248C030
	public SkillDamageData CreateExtensionDamage() { }

	// RVA: 0x248C09C Offset: 0x248809C VA: 0x248C09C
	public bool IsInactivityAbnormal() { }

	// RVA: 0x248C0B0 Offset: 0x24880B0 VA: 0x248C0B0
	public ActionAppendData GetMobAttackAppendData() { }

	// RVA: 0x248C3F4 Offset: 0x24883F4 VA: 0x248C3F4
	public void Invincibility() { }
}
