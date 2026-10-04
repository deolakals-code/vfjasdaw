// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(MobSkillActionPlayer))]
public class MobBattlePlayer : MonoBehaviour // TypeDefIndex: 732
{
	// Fields
	private Transform charaTransform; // 0x20
	private EnemyMobActionManagerBase mobActManager; // 0x28
	private MobAnimation mobAnimation; // 0x30
	private MobSkillActionPlayer skillPlayer; // 0x38
	private MobBattlePlayer.MobPlayActionDataBase currentPlayAction; // 0x40
	private List<MobBattlePlayer.MobPlayActionDataBase> mobPlayActionList; // 0x48
	private bool isDelay; // 0x50
	private float actionDelay; // 0x54
	private PlayerDataManager playerDataManager; // 0x58
	[CompilerGenerated]
	private bool <IsBattleActionLock>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <IsComboAttack>k__BackingField; // 0x61

	// Properties
	public bool IsBattleActionLock { get; set; }
	public MobSkillActionPlayer SkillActionPlayer { get; }
	public bool IsComboAttack { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B940C8 Offset: 0x1B900C8 VA: 0x1B940C8
	public bool get_IsBattleActionLock() { }

	[CompilerGenerated]
	// RVA: 0x1B940D0 Offset: 0x1B900D0 VA: 0x1B940D0
	protected void set_IsBattleActionLock(bool value) { }

	// RVA: 0x1B940DC Offset: 0x1B900DC VA: 0x1B940DC
	public MobSkillActionPlayer get_SkillActionPlayer() { }

	[CompilerGenerated]
	// RVA: 0x1B940E4 Offset: 0x1B900E4 VA: 0x1B940E4
	public bool get_IsComboAttack() { }

	[CompilerGenerated]
	// RVA: 0x1B940EC Offset: 0x1B900EC VA: 0x1B940EC
	private void set_IsComboAttack(bool value) { }

	// RVA: 0x1B940F8 Offset: 0x1B900F8 VA: 0x1B940F8
	private void Awake() { }

	// RVA: 0x1B94470 Offset: 0x1B90470 VA: 0x1B94470
	public void ApparentDeath() { }

	// RVA: 0x1B9449C Offset: 0x1B9049C VA: 0x1B9449C
	public void ReviveFromApparentDeath() { }

	// RVA: 0x1B946F4 Offset: 0x1B906F4 VA: 0x1B946F4
	public void End() { }

	// RVA: 0x1B9476C Offset: 0x1B9076C VA: 0x1B9476C
	public void Skip() { }

	// RVA: 0x1B94924 Offset: 0x1B90924 VA: 0x1B94924
	public void ActionCancel() { }

	// RVA: 0x1B94ABC Offset: 0x1B90ABC VA: 0x1B94ABC
	public void ActionCancel(short patternId) { }

	// RVA: 0x1B94D24 Offset: 0x1B90D24 VA: 0x1B94D24
	public void ReserveActionMove(GameObject target, Vector3 targetPos) { }

	// RVA: 0x1B94FE0 Offset: 0x1B90FE0 VA: 0x1B94FE0
	public void ReserveAction(GameObject target, Vector3 pos, Quaternion rot, MobActionPattern pattern, byte attackStartFlag, List<MobActionTargetData> targetPosList, long personaTarget) { }

	// RVA: 0x1B944A4 Offset: 0x1B904A4 VA: 0x1B944A4
	public void NextAction2() { }

	// RVA: 0x1B9556C Offset: 0x1B9156C VA: 0x1B9556C
	private void Update() { }

	// RVA: 0x1B956B4 Offset: 0x1B916B4 VA: 0x1B956B4
	protected bool OnSkillActionStart(GameObject target, SkillActionBase action) { }

	// RVA: 0x1B956BC Offset: 0x1B916BC VA: 0x1B956BC
	protected void OnSkillActionHit(GameObject target, SkillActionBase action) { }

	// RVA: 0x1B95D38 Offset: 0x1B91D38 VA: 0x1B95D38
	protected void OnSkillActionDamaged(GameObject target, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x1B95F10 Offset: 0x1B91F10 VA: 0x1B95F10
	private void OnSkillActionDamagedExecute(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x1B9653C Offset: 0x1B9253C VA: 0x1B9653C
	protected void OnSkillActionRangeDamaged(GameObject target, SkillActionBase action) { }

	// RVA: 0x1B96C28 Offset: 0x1B92C28 VA: 0x1B96C28
	protected void OnSkillActionEnd(GameObject target, SkillActionBase action) { }

	// RVA: 0x1B96D64 Offset: 0x1B92D64 VA: 0x1B96D64
	protected void OnSkillActionSupport(GameObject target, SkillActionBase action) { }

	// RVA: 0x1B97198 Offset: 0x1B93198 VA: 0x1B97198
	public void ClearDelay() { }

	// RVA: 0x1B971A4 Offset: 0x1B931A4 VA: 0x1B971A4
	public void SetCurrentSkillHateChange() { }

	// RVA: 0x1B973AC Offset: 0x1B933AC VA: 0x1B973AC
	public void .ctor() { }
}
