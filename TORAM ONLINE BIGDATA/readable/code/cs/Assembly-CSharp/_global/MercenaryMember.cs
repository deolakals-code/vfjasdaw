// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryMember : AutoMember // TypeDefIndex: 692
{
	// Fields
	private MercenarySetting setting; // 0xB8
	private MobRangeAttackCollection rangeList; // 0xC0
	private EmotionPlayer EmotionPlayer; // 0xC8
	private MercenarySkillDelayManager delayManager; // 0xD0

	// Properties
	private MercenaryActionManager actionManager { get; }
	public override bool IsPartyMember { get; }
	public override bool IsGhost { get; }
	public override NPCPartySettingBase Setting { get; }

	// Methods

	// RVA: 0x1AC2AB0 Offset: 0x1ABEAB0 VA: 0x1AC2AB0
	private MercenaryActionManager get_actionManager() { }

	// RVA: 0x1AC2B28 Offset: 0x1ABEB28 VA: 0x1AC2B28
	protected void Awake() { }

	// RVA: 0x1AC2B90 Offset: 0x1ABEB90 VA: 0x1AC2B90 Slot: 58
	protected virtual void LateUpdate() { }

	// RVA: 0x1AC2D40 Offset: 0x1ABED40 VA: 0x1AC2D40
	private void OnDestroy() { }

	// RVA: 0x1AC2E44 Offset: 0x1ABEE44 VA: 0x1AC2E44 Slot: 12
	public override bool get_IsPartyMember() { }

	// RVA: 0x1AC2E4C Offset: 0x1ABEE4C VA: 0x1AC2E4C Slot: 38
	public override bool get_IsGhost() { }

	// RVA: 0x1AC2EEC Offset: 0x1ABEEEC VA: 0x1AC2EEC Slot: 51
	public override NPCPartySettingBase get_Setting() { }

	// RVA: 0x1AC2EF4 Offset: 0x1ABEEF4 VA: 0x1AC2EF4 Slot: 52
	public override void Initialize(Archetype archetype) { }

	// RVA: 0x1AC3010 Offset: 0x1ABF010 VA: 0x1AC3010
	public void Initialize(Archetype archetype, MercenarySetting settingData, ClonePlayerAnimation cloneAnimation, ref MobRangeAttackCollection rangeList) { }

	// RVA: 0x1AC2FF8 Offset: 0x1ABEFF8 VA: 0x1AC2FF8
	private IArchetypeListener CreateArcheTypeListener(ArchetypeType type) { }

	// RVA: 0x1AC3AF0 Offset: 0x1ABFAF0 VA: 0x1AC3AF0
	private IArchetypeListener CreateMercenaryListener() { }

	// RVA: 0x1AC3AEC Offset: 0x1ABFAEC VA: 0x1AC3AEC
	private IArchetypeListener CreatePartnerListener() { }

	// RVA: 0x1AC3AF4 Offset: 0x1ABFAF4 VA: 0x1AC3AF4
	protected IArchetypeListener CreateCommonListener() { }

	// RVA: 0x1AC3FA4 Offset: 0x1ABFFA4 VA: 0x1AC3FA4 Slot: 35
	protected override void UpdateModelProperty(NewArchetypeProperties property) { }

	// RVA: 0x1AC3FAC Offset: 0x1ABFFAC VA: 0x1AC3FAC Slot: 36
	protected override void OnPropertyUpdateEnd() { }

	[IteratorStateMachine(typeof(MercenaryMember.<ModelFadein>d__23))]
	// RVA: 0x1AC42D0 Offset: 0x1AC02D0 VA: 0x1AC42D0
	private IEnumerator ModelFadein() { }

	// RVA: 0x1AC4364 Offset: 0x1AC0364 VA: 0x1AC4364 Slot: 57
	public override void OnSkillDelayStandbyOk(SkillReusePermissioneEvent response) { }

	// RVA: 0x1AC43B4 Offset: 0x1AC03B4 VA: 0x1AC43B4
	public void ChangeActionSkillSetting(Dictionary<short, byte> chageSkils) { }

	// RVA: 0x1AC4758 Offset: 0x1AC0758 VA: 0x1AC4758
	public void ChangeWalkingAnimtion(bool isWalk) { }

	// RVA: 0x1AC3244 Offset: 0x1ABF244 VA: 0x1AC3244
	private void initializeSkill() { }

	// RVA: 0x1AC3478 Offset: 0x1ABF478 VA: 0x1AC3478
	private void initializeAIPattern(bool isUsedFirstSkill) { }

	// RVA: 0x1AC4730 Offset: 0x1AC0730 VA: 0x1AC4730
	private AIActionCondition GetTransFarConditon(byte target) { }

	// RVA: 0x1AC47B0 Offset: 0x1AC07B0 VA: 0x1AC47B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1AC47B8 Offset: 0x1AC07B8 VA: 0x1AC47B8
	private void <CreateCommonListener>b__20_0(Game game, AbnormalStateEndEvent eventData) { }

	[CompilerGenerated]
	// RVA: 0x1AC47C4 Offset: 0x1AC07C4 VA: 0x1AC47C4
	private void <CreateCommonListener>b__20_1(Game game, AbnormalDamageEvent eventData) { }

	[CompilerGenerated]
	// RVA: 0x1AC47D0 Offset: 0x1AC07D0 VA: 0x1AC47D0
	private void <CreateCommonListener>b__20_2(Game game, ArchetypeChangeState eventData) { }

	[CompilerGenerated]
	// RVA: 0x1AC47E8 Offset: 0x1AC07E8 VA: 0x1AC47E8
	private void <CreateCommonListener>b__20_3(Game game, NaturalRecoveryEvent eventData) { }

	[CompilerGenerated]
	// RVA: 0x1AC483C Offset: 0x1AC083C VA: 0x1AC483C
	private void <CreateCommonListener>b__20_4(Game game, MonsterFollowersPop eventData) { }

	[CompilerGenerated]
	// RVA: 0x1AC4848 Offset: 0x1AC0848 VA: 0x1AC4848
	private void <CreateCommonListener>b__20_5(Game game, SkillReusePermissioneEvent eventData) { }

	[CompilerGenerated]
	// RVA: 0x1AC4860 Offset: 0x1AC0860 VA: 0x1AC4860
	private void <CreateCommonListener>b__20_6(Game game, SkillBuffEndEvent eventData) { }
}
