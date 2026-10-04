// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonDemonicBattleManager : PlayerBattleManager // TypeDefIndex: 1634
{
	// Fields
	private SummonDemonicActionManager summonDemonicActionManager; // 0x110
	private PlayerStatusBase summonDemonicStatus; // 0x118
	private ArchetypeUid archetypeUid; // 0x120
	private PlayerDataManager playerDataManager; // 0x128
	private IEnumerator battleEndCheckCoroutine; // 0x130

	// Methods

	// RVA: 0x209CA9C Offset: 0x2098A9C VA: 0x209CA9C
	private void Start() { }

	// RVA: 0x209CB74 Offset: 0x2098B74 VA: 0x209CB74
	public void Initialize(ArchetypeUid archetypeUid, PlayerStatusBase status) { }

	// RVA: 0x209CBA4 Offset: 0x2098BA4 VA: 0x209CBA4 Slot: 28
	protected override bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x209D084 Offset: 0x2099084 VA: 0x209D084 Slot: 35
	protected override void OnSkillActionSupport(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x209D624 Offset: 0x2099624 VA: 0x209D624 Slot: 29
	protected override void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x209E16C Offset: 0x209A16C VA: 0x209E16C Slot: 30
	protected override void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x209E5B0 Offset: 0x209A5B0 VA: 0x209E5B0 Slot: 32
	protected override void OnSkillActionEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x209E648 Offset: 0x209A648 VA: 0x209E648 Slot: 33
	protected override void OnSkillActionAllEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x209E740 Offset: 0x209A740 VA: 0x209E740 Slot: 34
	protected override void OnSkillActionCancel(GameObject target, SkillActionBase action) { }

	// RVA: 0x209E7F0 Offset: 0x209A7F0 VA: 0x209E7F0 Slot: 22
	protected override void OnBattleActive() { }

	// RVA: 0x209E824 Offset: 0x209A824 VA: 0x209E824 Slot: 23
	protected override void OnBattleEnd() { }

	// RVA: 0x209E864 Offset: 0x209A864 VA: 0x209E864 Slot: 18
	public override void CheckBattleEnd() { }

	// RVA: 0x209E990 Offset: 0x209A990 VA: 0x209E990 Slot: 15
	protected override void OnNextActionCancel() { }

	// RVA: 0x209CEB4 Offset: 0x2098EB4 VA: 0x209CEB4
	protected void targetToEnemy(GameObject target) { }

	// RVA: 0x209E6F8 Offset: 0x209A6F8 VA: 0x209E6F8
	public void BattleEndCheck(float time) { }

	// RVA: 0x209E994 Offset: 0x209A994 VA: 0x209E994
	public void StopBattleEndCheck() { }

	[IteratorStateMachine(typeof(SummonDemonicBattleManager.<waitBattleEndCheck>d__21))]
	// RVA: 0x209E9D8 Offset: 0x209A9D8 VA: 0x209E9D8
	private IEnumerator waitBattleEndCheck(float time) { }

	// RVA: 0x209EA7C Offset: 0x209AA7C VA: 0x209EA7C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x209EA84 Offset: 0x209AA84 VA: 0x209EA84
	private bool <CheckBattleEnd>b__16_0(MobActionManagerBase m) { }
}
