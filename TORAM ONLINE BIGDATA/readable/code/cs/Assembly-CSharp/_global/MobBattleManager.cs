// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(MobSkillActionManager))]
public class MobBattleManager : BattleManagerBase // TypeDefIndex: 726
{
	// Fields
	private float actionDelay; // 0x74
	private PlayerDataManager playerDataManager; // 0x78
	private EnemyMobActionManagerBase mobActManager; // 0x80
	private MobAnimation mobAnimation; // 0x88
	private MobSkillActionManager mobSkillActionManager; // 0x90
	private Vector3 correctionPos; // 0x98
	private const float CorrectionRange = 10;
	[CompilerGenerated]
	private bool <IsComboAttack>k__BackingField; // 0xA4

	// Properties
	public MobSkillActionManager MobSkillActionManager { get; }
	public bool IsComboAttack { get; set; }
	public override GuardType GuardType { get; }
	public override AvoidType AvoidType { get; }

	// Methods

	// RVA: 0x1B8F490 Offset: 0x1B8B490 VA: 0x1B8F490
	public MobSkillActionManager get_MobSkillActionManager() { }

	[CompilerGenerated]
	// RVA: 0x1B8F498 Offset: 0x1B8B498 VA: 0x1B8F498
	public bool get_IsComboAttack() { }

	[CompilerGenerated]
	// RVA: 0x1B8F4A0 Offset: 0x1B8B4A0 VA: 0x1B8F4A0
	private void set_IsComboAttack(bool value) { }

	// RVA: 0x1B8F4AC Offset: 0x1B8B4AC VA: 0x1B8F4AC Slot: 4
	public override GuardType get_GuardType() { }

	// RVA: 0x1B8F4B4 Offset: 0x1B8B4B4 VA: 0x1B8F4B4 Slot: 5
	public override AvoidType get_AvoidType() { }

	// RVA: 0x1B8F4BC Offset: 0x1B8B4BC VA: 0x1B8F4BC Slot: 6
	protected override void Awake() { }

	// RVA: 0x1B8F574 Offset: 0x1B8B574 VA: 0x1B8F574
	private void Start() { }

	// RVA: 0x1B8F64C Offset: 0x1B8B64C VA: 0x1B8F64C Slot: 8
	public override void ActionUpdate() { }

	// RVA: 0x1B8F6DC Offset: 0x1B8B6DC VA: 0x1B8F6DC Slot: 20
	protected override bool OnActionOutOfRange(GameObject target, SkillActionBase action) { }

	// RVA: 0x1B8F940 Offset: 0x1B8B940 VA: 0x1B8F940 Slot: 21
	protected override bool OnEndAssistMove(GameObject target) { }

	// RVA: 0x1B8FBE4 Offset: 0x1B8BBE4 VA: 0x1B8FBE4
	public void UnmagedMobAssistMoveStart() { }

	// RVA: 0x1B8FC68 Offset: 0x1B8BC68 VA: 0x1B8FC68
	public void UnmagedMobAssistMoveEnd() { }

	// RVA: 0x1B8FCE8 Offset: 0x1B8BCE8 VA: 0x1B8FCE8 Slot: 28
	protected override bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1B90998 Offset: 0x1B8C998 VA: 0x1B90998 Slot: 29
	protected override void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1B9149C Offset: 0x1B8D49C VA: 0x1B9149C Slot: 30
	protected override void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x1B915F4 Offset: 0x1B8D5F4 VA: 0x1B915F4
	private void OnSkillActionDamagedExecute(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x1B91C68 Offset: 0x1B8DC68 VA: 0x1B91C68 Slot: 31
	protected override void OnSkillActionRangeDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1B927BC Offset: 0x1B8E7BC VA: 0x1B927BC Slot: 32
	protected override void OnSkillActionEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1B903EC Offset: 0x1B8C3EC VA: 0x1B903EC
	private bool ActionStartFloorCorrection(GameObject target) { }

	// RVA: 0x1B92E4C Offset: 0x1B8EE4C VA: 0x1B92E4C
	private bool ActionEndFloorCorrection(GameObject target) { }

	// RVA: 0x1B93170 Offset: 0x1B8F170 VA: 0x1B93170 Slot: 34
	protected override void OnSkillActionCancel(GameObject target, SkillActionBase action) { }

	// RVA: 0x1B9326C Offset: 0x1B8F26C VA: 0x1B9326C Slot: 16
	public override void ClearDelay() { }

	// RVA: 0x1B93288 Offset: 0x1B8F288 VA: 0x1B93288 Slot: 17
	protected override bool CheckActionRange() { }

	// RVA: 0x1B9311C Offset: 0x1B8F11C VA: 0x1B9311C
	private float calcFleezDelayTime(float orgDelayTime, bool isBoss) { }

	// RVA: 0x1B93158 Offset: 0x1B8F158 VA: 0x1B93158
	private float calcParalysisDelayTime(float orgDelayTime, bool isBoss) { }

	// RVA: 0x1B93404 Offset: 0x1B8F404 VA: 0x1B93404 Slot: 15
	protected override void OnNextActionCancel() { }

	// RVA: 0x1B934E0 Offset: 0x1B8F4E0 VA: 0x1B934E0 Slot: 35
	protected override void OnSkillActionSupport(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1B93DFC Offset: 0x1B8FDFC VA: 0x1B93DFC
	public void AddDelay(float time) { }

	// RVA: 0x1B93E1C Offset: 0x1B8FE1C VA: 0x1B93E1C
	public void .ctor() { }
}
