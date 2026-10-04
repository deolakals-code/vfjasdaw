// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HuntingOneBattleManager : PlayerBattleManager // TypeDefIndex: 591
{
	// Fields
	private HuntingOneActionManager huntingOneActionManager; // 0x110
	private ClonePlayerAnimation cloneAnimation; // 0x118
	private PlayerStatusBase huntingOneStatus; // 0x120
	private ArchetypeUid archetypeUid; // 0x128
	private PlayerDataManager playerDataManager; // 0x130
	private UISkillPopupLabel skillPopup; // 0x138
	private IEnumerator battleEndCheckCoroutine; // 0x140

	// Methods

	// RVA: 0x190A93C Offset: 0x190693C VA: 0x190A93C
	private void Start() { }

	// RVA: 0x1907ADC Offset: 0x1903ADC VA: 0x1907ADC
	public void Initialize(ArchetypeUid archetypeUid, PlayerStatusBase status) { }

	// RVA: 0x190AAAC Offset: 0x1906AAC VA: 0x190AAAC Slot: 28
	protected override bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x190AF8C Offset: 0x1906F8C VA: 0x190AF8C Slot: 35
	protected override void OnSkillActionSupport(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x190B52C Offset: 0x190752C VA: 0x190B52C Slot: 29
	protected override void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x190C074 Offset: 0x1908074 VA: 0x190C074 Slot: 30
	protected override void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x190C4C0 Offset: 0x19084C0 VA: 0x190C4C0 Slot: 32
	protected override void OnSkillActionEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x190C568 Offset: 0x1908568 VA: 0x190C568 Slot: 33
	protected override void OnSkillActionAllEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x190ADBC Offset: 0x1906DBC VA: 0x190ADBC
	protected void targetToEnemy(GameObject target) { }

	// RVA: 0x190C660 Offset: 0x1908660 VA: 0x190C660 Slot: 22
	protected override void OnBattleActive() { }

	// RVA: 0x190C694 Offset: 0x1908694 VA: 0x190C694 Slot: 23
	protected override void OnBattleEnd() { }

	// RVA: 0x190C618 Offset: 0x1908618 VA: 0x190C618
	public void BattleEndCheck(float time) { }

	// RVA: 0x190C6D4 Offset: 0x19086D4 VA: 0x190C6D4
	public void StopBattleEndCheck() { }

	[IteratorStateMachine(typeof(HuntingOneBattleManager.<waitBattleEndCheck>d__20))]
	// RVA: 0x190C718 Offset: 0x1908718 VA: 0x190C718
	private IEnumerator waitBattleEndCheck(float time) { }

	// RVA: 0x190C79C Offset: 0x190879C VA: 0x190C79C Slot: 15
	protected override void OnNextActionCancel() { }

	// RVA: 0x190C7A0 Offset: 0x19087A0 VA: 0x190C7A0 Slot: 18
	public override void CheckBattleEnd() { }

	// RVA: 0x190C8CC Offset: 0x19088CC VA: 0x190C8CC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x190C8D4 Offset: 0x19088D4 VA: 0x190C8D4
	private bool <CheckBattleEnd>b__22_0(MobActionManagerBase m) { }
}
