// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CallGolemBattleManager : PlayerBattleManager // TypeDefIndex: 535
{
	// Fields
	private CallGolemActionManager callGolemActionManager; // 0x110
	private PlayerDataManager playerDataManager; // 0x118
	private ArchetypeUid archetypeUid; // 0x120
	private IEnumerator battleEndCheckCoroutine; // 0x128

	// Methods

	// RVA: 0x1832CE0 Offset: 0x182ECE0 VA: 0x1832CE0
	private void Start() { }

	// RVA: 0x1832DB8 Offset: 0x182EDB8 VA: 0x1832DB8
	public void Initialize(ArchetypeUid archetypeUid) { }

	// RVA: 0x1832DC0 Offset: 0x182EDC0 VA: 0x1832DC0 Slot: 28
	protected override bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1833304 Offset: 0x182F304 VA: 0x1833304 Slot: 35
	protected override void OnSkillActionSupport(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1833308 Offset: 0x182F308 VA: 0x1833308 Slot: 29
	protected override void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x183384C Offset: 0x182F84C VA: 0x183384C Slot: 30
	protected override void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x1833C90 Offset: 0x182FC90 VA: 0x1833C90 Slot: 32
	protected override void OnSkillActionEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1833D28 Offset: 0x182FD28 VA: 0x1833D28 Slot: 33
	protected override void OnSkillActionAllEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1833E20 Offset: 0x182FE20 VA: 0x1833E20 Slot: 34
	protected override void OnSkillActionCancel(GameObject target, SkillActionBase action) { }

	// RVA: 0x1833ED0 Offset: 0x182FED0 VA: 0x1833ED0 Slot: 22
	protected override void OnBattleActive() { }

	// RVA: 0x1833F04 Offset: 0x182FF04 VA: 0x1833F04 Slot: 23
	protected override void OnBattleEnd() { }

	// RVA: 0x1833F44 Offset: 0x182FF44 VA: 0x1833F44 Slot: 18
	public override void CheckBattleEnd() { }

	// RVA: 0x1834070 Offset: 0x1830070 VA: 0x1834070 Slot: 15
	protected override void OnNextActionCancel() { }

	// RVA: 0x1833134 Offset: 0x182F134 VA: 0x1833134
	private void targetToEnemy(GameObject target) { }

	// RVA: 0x1833DD8 Offset: 0x182FDD8 VA: 0x1833DD8
	public void BattleEndCheck(float time) { }

	// RVA: 0x1834074 Offset: 0x1830074 VA: 0x1834074
	private void StopBattleEndCheck() { }

	[IteratorStateMachine(typeof(CallGolemBattleManager.<waitBattleEndCheck>d__20))]
	// RVA: 0x18340B8 Offset: 0x18300B8 VA: 0x18340B8
	private IEnumerator waitBattleEndCheck(float time) { }

	// RVA: 0x183415C Offset: 0x183015C VA: 0x183415C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1834164 Offset: 0x1830164 VA: 0x1834164
	private bool <CheckBattleEnd>b__15_0(MobActionManagerBase m) { }
}
