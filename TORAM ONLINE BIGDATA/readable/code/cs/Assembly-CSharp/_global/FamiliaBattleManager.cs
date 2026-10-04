// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FamiliaBattleManager : PlayerBattleManager // TypeDefIndex: 578
{
	// Fields
	private FamiliaActionManager familiaActionManager; // 0x110
	private ClonePlayerAnimation cloneAnimation; // 0x118
	private PlayerStatusBase familiaStatus; // 0x120
	private ArchetypeUid archetypeUid; // 0x128
	private PlayerDataManager playerDataManager; // 0x130
	private UISkillPopupLabel skillPopup; // 0x138
	private IEnumerator battleEndCheckCoroutine; // 0x140

	// Methods

	// RVA: 0x19040A0 Offset: 0x19000A0 VA: 0x19040A0
	private void Start() { }

	// RVA: 0x1900D80 Offset: 0x18FCD80 VA: 0x1900D80
	public void Initialize(ArchetypeUid archetypeUid, PlayerStatusBase status) { }

	// RVA: 0x1904210 Offset: 0x1900210 VA: 0x1904210 Slot: 32
	protected override void OnSkillActionEnd(GameObject target, CharacterActionManagerBase actManager, SkillActionBase action) { }

	// RVA: 0x1904330 Offset: 0x1900330 VA: 0x1904330 Slot: 28
	protected override bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1904978 Offset: 0x1900978 VA: 0x1904978 Slot: 19
	protected override bool OnActionRange(GameObject target, SkillActionBase action) { }

	// RVA: 0x19049B8 Offset: 0x19009B8 VA: 0x19049B8 Slot: 20
	protected override bool OnActionOutOfRange(GameObject target, SkillActionBase action) { }

	// RVA: 0x19047A8 Offset: 0x19007A8 VA: 0x19047A8
	protected void targetToEnemy(GameObject target) { }

	// RVA: 0x19049C0 Offset: 0x19009C0 VA: 0x19049C0 Slot: 22
	protected override void OnBattleActive() { }

	// RVA: 0x19049F4 Offset: 0x19009F4 VA: 0x19049F4 Slot: 23
	protected override void OnBattleEnd() { }

	// RVA: 0x1904A34 Offset: 0x1900A34 VA: 0x1904A34
	public void BattleEndCheck(float time) { }

	// RVA: 0x1904AA4 Offset: 0x1900AA4 VA: 0x1904AA4
	public void StopBattleEndCheck() { }

	[IteratorStateMachine(typeof(FamiliaBattleManager.<waitBattleEndCheck>d__18))]
	// RVA: 0x1904AE8 Offset: 0x1900AE8 VA: 0x1904AE8
	private IEnumerator waitBattleEndCheck(float time) { }

	// RVA: 0x1904B8C Offset: 0x1900B8C VA: 0x1904B8C Slot: 30
	protected override void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x1904F20 Offset: 0x1900F20 VA: 0x1904F20 Slot: 31
	protected override void OnSkillActionRangeDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x19054A8 Offset: 0x19014A8 VA: 0x19054A8 Slot: 35
	protected override void OnSkillActionSupport(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1905A74 Offset: 0x1901A74 VA: 0x1905A74 Slot: 34
	protected override void OnSkillActionCancel(GameObject target, SkillActionBase action) { }

	// RVA: 0x1905B50 Offset: 0x1901B50 VA: 0x1905B50 Slot: 29
	protected override void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x190676C Offset: 0x190276C VA: 0x190676C Slot: 33
	protected override void OnSkillActionAllEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x190681C Offset: 0x190281C VA: 0x190681C Slot: 15
	protected override void OnNextActionCancel() { }

	// RVA: 0x1906820 Offset: 0x1902820 VA: 0x1906820 Slot: 18
	public override void CheckBattleEnd() { }

	// RVA: 0x190694C Offset: 0x190294C VA: 0x190694C Slot: 27
	public override void OnAvoid(GameObject actor) { }

	// RVA: 0x1906950 Offset: 0x1902950 VA: 0x1906950 Slot: 25
	public override void OnGuard(GameObject actor, SkillDamageData damageData) { }

	// RVA: 0x1906954 Offset: 0x1902954 VA: 0x1906954
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x190695C Offset: 0x190295C VA: 0x190695C
	private bool <CheckBattleEnd>b__26_0(MobActionManagerBase m) { }
}
