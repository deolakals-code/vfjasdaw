// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetMember : AutoMember // TypeDefIndex: 1311
{
	// Fields
	private PetMemberSettingBase setting; // 0xB8
	[CompilerGenerated]
	private bool <IsGroggyKickout>k__BackingField; // 0xC0

	// Properties
	private PetMemberActionManager petActionManager { get; }
	public PetMemberSettingBase PetSetting { get; }
	public override NPCPartySettingBase Setting { get; }
	public override bool IsPartyMember { get; }
	public bool IsGroggyKickout { get; set; }
	public bool IsMine { get; }

	// Methods

	// RVA: 0x1FB7C28 Offset: 0x1FB3C28 VA: 0x1FB7C28
	public static PetMember CreatePet(Archetype archetype, GameObject obj, PetMemberSettingBase setting, ref MobRangeAttackCollection mobRangeAttackList) { }

	// RVA: 0x1FB80D4 Offset: 0x1FB40D4 VA: 0x1FB80D4
	private PetMemberActionManager get_petActionManager() { }

	// RVA: 0x1FB8150 Offset: 0x1FB4150 VA: 0x1FB8150
	public PetMemberSettingBase get_PetSetting() { }

	// RVA: 0x1FB8158 Offset: 0x1FB4158 VA: 0x1FB8158 Slot: 51
	public override NPCPartySettingBase get_Setting() { }

	// RVA: 0x1FB8160 Offset: 0x1FB4160 VA: 0x1FB8160 Slot: 12
	public override bool get_IsPartyMember() { }

	[CompilerGenerated]
	// RVA: 0x1FB8168 Offset: 0x1FB4168 VA: 0x1FB8168
	public bool get_IsGroggyKickout() { }

	[CompilerGenerated]
	// RVA: 0x1FB8170 Offset: 0x1FB4170 VA: 0x1FB8170
	private void set_IsGroggyKickout(bool value) { }

	// RVA: 0x1FB817C Offset: 0x1FB417C VA: 0x1FB817C
	public bool get_IsMine() { }

	// RVA: 0x1FB819C Offset: 0x1FB419C VA: 0x1FB819C Slot: 52
	public override void Initialize(Archetype archetype) { }

	// RVA: 0x1FB7D44 Offset: 0x1FB3D44 VA: 0x1FB7D44
	public void Initialize(Archetype archetype, PetMemberSettingBase settingData, ref MobRangeAttackCollection rangeList) { }

	[IteratorStateMachine(typeof(PetMember.<ModelFadein>d__18))]
	// RVA: 0x1FB9770 Offset: 0x1FB5770 VA: 0x1FB9770
	private IEnumerator ModelFadein() { }

	// RVA: 0x1FB9834 Offset: 0x1FB5834 VA: 0x1FB9834
	private void initializeSkill() { }

	// RVA: 0x1FB9AD0 Offset: 0x1FB5AD0 VA: 0x1FB9AD0
	private void initializeAIPattern(bool isUsedFirstSkill) { }

	// RVA: 0x1FBA3F8 Offset: 0x1FB63F8 VA: 0x1FBA3F8
	private void LateUpdate() { }

	// RVA: 0x1FBA558 Offset: 0x1FB6558 VA: 0x1FBA558
	public void OnUpdateEvent(PetUpdateEvent updateEvent) { }

	// RVA: 0x1FBA798 Offset: 0x1FB6798 VA: 0x1FBA798
	public void LevelUp(short lv) { }

	// RVA: 0x1FBA9E8 Offset: 0x1FB69E8 VA: 0x1FBA9E8
	public void WeaponAtkUp(short atk) { }

	// RVA: 0x1FBABA8 Offset: 0x1FB6BA8 VA: 0x1FBABA8
	public void SkillLvUp(SkillId skillId, byte skillLv, SkillTextManager skillTextManager) { }

	// RVA: 0x1FBAE84 Offset: 0x1FB6E84 VA: 0x1FBAE84
	public void SkillLvUpCommoit() { }

	// RVA: 0x1FBB0F0 Offset: 0x1FB70F0 VA: 0x1FBB0F0
	public void StatusUp(PetStatusData status) { }

	// RVA: 0x1FB8268 Offset: 0x1FB4268 VA: 0x1FB8268
	protected IArchetypeListener CreateCommonListener() { }

	// RVA: 0x1FB870C Offset: 0x1FB470C VA: 0x1FB870C
	protected IArchetypeListener CreateDummyListener() { }

	// RVA: 0x1FBB15C Offset: 0x1FB715C VA: 0x1FBB15C
	public void OnActionHousePetMove(PetMoveEventData eventData) { }

	// RVA: 0x1FBB194 Offset: 0x1FB7194 VA: 0x1FBB194
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1FBB19C Offset: 0x1FB719C VA: 0x1FBB19C
	private void <CreateCommonListener>b__29_0(Game game, AbnormalStateEndEvent eventData) { }

	[CompilerGenerated]
	// RVA: 0x1FBB1A8 Offset: 0x1FB71A8 VA: 0x1FBB1A8
	private void <CreateCommonListener>b__29_1(Game game, AbnormalDamageEvent eventData) { }

	[CompilerGenerated]
	// RVA: 0x1FBB1B4 Offset: 0x1FB71B4 VA: 0x1FBB1B4
	private void <CreateCommonListener>b__29_2(Game game, ArchetypeChangeState eventData) { }

	[CompilerGenerated]
	// RVA: 0x1FBB1CC Offset: 0x1FB71CC VA: 0x1FBB1CC
	private void <CreateCommonListener>b__29_3(Game game, NaturalRecoveryEvent eventData) { }

	[CompilerGenerated]
	// RVA: 0x1FBB270 Offset: 0x1FB7270 VA: 0x1FBB270
	private void <CreateCommonListener>b__29_4(Game game, MonsterFollowersPop eventData) { }

	[CompilerGenerated]
	// RVA: 0x1FBB27C Offset: 0x1FB727C VA: 0x1FBB27C
	private void <CreateCommonListener>b__29_5(Game game, SkillBuffEndEvent eventData) { }

	[CompilerGenerated]
	// RVA: 0x1FBB288 Offset: 0x1FB7288 VA: 0x1FBB288
	private void <CreateCommonListener>b__29_6(Game game, LevelupEvent eventData) { }
}
