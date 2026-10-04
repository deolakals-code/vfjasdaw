// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AutoMember : PlayerObjectBase, INpcListener // TypeDefIndex: 421
{
	// Fields
	private AutoMemberSettingBase setting; // 0x90
	private FadeAnimationManager fadeAnimation; // 0x98
	protected float routineConnectTime; // 0xA0
	private float respawnTime; // 0xA4
	protected Archetype archetype; // 0xA8
	[CompilerGenerated]
	private int <NpcId>k__BackingField; // 0xB0
	[CompilerGenerated]
	private bool <IsDead>k__BackingField; // 0xB4

	// Properties
	public override Archetype Archetype { get; }
	public int NpcId { get; set; }
	public bool IsDead { get; set; }
	public override bool IsGhost { get; }
	public virtual NPCPartySettingBase Setting { get; }
	private AutoMemberActionManager AutoMemberActionManager { get; }

	// Methods

	// RVA: 0x173CBFC Offset: 0x1738BFC VA: 0x173CBFC
	public static AutoMember SettingPlayer(GameObject obj, ref MobRangeAttackCollection rangeList) { }

	// RVA: 0x173CDC0 Offset: 0x1738DC0 VA: 0x173CDC0
	public static AutoMember SettingPlayer(Archetype archetype, GameObject obj, AutoMemberSettingBase setting, ref MobRangeAttackCollection mobRangeAttackList) { }

	// RVA: 0x173D1E4 Offset: 0x17391E4 VA: 0x173D1E4 Slot: 11
	public override Archetype get_Archetype() { }

	[CompilerGenerated]
	// RVA: 0x173D1EC Offset: 0x17391EC VA: 0x173D1EC
	public int get_NpcId() { }

	[CompilerGenerated]
	// RVA: 0x173D1F4 Offset: 0x17391F4 VA: 0x173D1F4
	protected void set_NpcId(int value) { }

	[CompilerGenerated]
	// RVA: 0x173D1FC Offset: 0x17391FC VA: 0x173D1FC
	public bool get_IsDead() { }

	[CompilerGenerated]
	// RVA: 0x173D204 Offset: 0x1739204 VA: 0x173D204
	protected void set_IsDead(bool value) { }

	// RVA: 0x173D210 Offset: 0x1739210 VA: 0x173D210 Slot: 38
	public override bool get_IsGhost() { }

	// RVA: 0x173D2B8 Offset: 0x17392B8 VA: 0x173D2B8 Slot: 51
	public virtual NPCPartySettingBase get_Setting() { }

	// RVA: 0x173D2C0 Offset: 0x17392C0 VA: 0x173D2C0
	private AutoMemberActionManager get_AutoMemberActionManager() { }

	// RVA: 0x173D338 Offset: 0x1739338 VA: 0x173D338 Slot: 52
	public virtual void Initialize(Archetype archetype) { }

	// RVA: 0x173CF20 Offset: 0x1738F20 VA: 0x173CF20
	public void Initialize(Archetype archetype, AutoMemberSettingBase settingData, ref MobRangeAttackCollection rangeList) { }

	// RVA: 0x173DEDC Offset: 0x1739EDC VA: 0x173DEDC Slot: 53
	public virtual bool CheckHitType(MobPatternBase pattern) { }

	// RVA: 0x173DFE4 Offset: 0x1739FE4 VA: 0x173DFE4
	public void SetTacticalValue(int val) { }

	// RVA: 0x173E09C Offset: 0x173A09C VA: 0x173E09C
	public void Rejoin(Game engine) { }

	// RVA: 0x173E1D0 Offset: 0x173A1D0 VA: 0x173E1D0 Slot: 29
	public override GameObject CloneModelObject() { }

	// RVA: 0x173E988 Offset: 0x173A988 VA: 0x173E988 Slot: 27
	public override void StartActionFieldEvent(bool isColl, int actionId) { }

	// RVA: 0x173EA14 Offset: 0x173AA14 VA: 0x173EA14 Slot: 33
	protected override bool OnPropertyUpdateStart() { }

	// RVA: 0x173D58C Offset: 0x173958C VA: 0x173D58C
	private void initializeSkill() { }

	// RVA: 0x173D7CC Offset: 0x17397CC VA: 0x173D7CC
	private void initializeAIPattern(bool isUsedFirstSkill) { }

	// RVA: 0x173EB78 Offset: 0x173AB78 VA: 0x173EB78
	private void Update() { }

	// RVA: 0x173ECA0 Offset: 0x173ACA0 VA: 0x173ECA0
	private void LateUpdate() { }

	// RVA: 0x173EDC4 Offset: 0x173ADC4 VA: 0x173EDC4 Slot: 54
	public virtual void UpdateStatus(PlayerStatusData status) { }

	// RVA: 0x173EE74 Offset: 0x173AE74 VA: 0x173EE74
	public void UpdateStatus(int hp, short mp) { }

	// RVA: 0x173EF98 Offset: 0x173AF98 VA: 0x173EF98
	protected void OnDead() { }

	// RVA: 0x173F084 Offset: 0x173B084 VA: 0x173F084
	public void OnRespawn(NpcRespawnResponse response) { }

	// RVA: 0x173D3FC Offset: 0x17393FC VA: 0x173D3FC
	public void SetRespawnTime(short time) { }

	// RVA: 0x173EBBC Offset: 0x173ABBC VA: 0x173EBBC
	private bool checkRespawn() { }

	// RVA: 0x173EBF4 Offset: 0x173ABF4 VA: 0x173EBF4
	private void respawn() { }

	// RVA: 0x173F10C Offset: 0x173B10C VA: 0x173F10C Slot: 45
	public void OnAbnormalDamage(AbnormalDamageEvent response) { }

	// RVA: 0x173F180 Offset: 0x173B180 VA: 0x173F180 Slot: 46
	public void OnAbnormalStateEnd(AbnormalStateEndEvent response) { }

	// RVA: 0x173F248 Offset: 0x173B248 VA: 0x173F248 Slot: 55
	public virtual void OnChangeState(ArchetypeChangeState response) { }

	// RVA: 0x173F368 Offset: 0x173B368 VA: 0x173F368 Slot: 56
	public virtual void OnNaturalRecovery(NaturalRecoveryEvent response) { }

	// RVA: 0x173F36C Offset: 0x173B36C VA: 0x173F36C Slot: 44
	public void OnMonsterFollowersPop(MonsterFollowersPop response) { }

	// RVA: 0x173F3EC Offset: 0x173B3EC VA: 0x173F3EC Slot: 57
	public virtual void OnSkillDelayStandbyOk(SkillReusePermissioneEvent response) { }

	// RVA: 0x173F3F0 Offset: 0x173B3F0 VA: 0x173F3F0 Slot: 48
	public void OnSkillBuffEndEvent(SkillBuffEndEvent endEvent) { }

	// RVA: 0x173F414 Offset: 0x173B414 VA: 0x173F414 Slot: 50
	public void OnUpdateGameStatus(UpdateGameStatusEvent updateEvent) { }

	// RVA: 0x173F4A0 Offset: 0x173B4A0 VA: 0x173F4A0 Slot: 47
	public void OnAddAbnormalState(AddAbnormalStateEvent response) { }

	// RVA: 0x173F4A4 Offset: 0x173B4A4 VA: 0x173F4A4
	public void .ctor() { }
}
