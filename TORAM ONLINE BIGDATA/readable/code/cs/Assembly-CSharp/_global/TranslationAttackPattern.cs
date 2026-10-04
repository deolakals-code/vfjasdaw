// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TranslationAttackPattern : MobPatternBase // TypeDefIndex: 833
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private float attackRangeRed; // 0x78
	private int fristRot; // 0x7C
	private int nextRot; // 0x80
	private int fireNum; // 0x84
	private Vector3 oldForward; // 0x88
	private List<AttackArea> attackAreaList; // 0x98
	private float hitEffectTiming; // 0xA0
	private bool isAttack; // 0xA4
	private bool isAttackable; // 0xA5
	private ElementType element; // 0xA8
	private List<Vector3> attackPosList; // 0xB0
	private float warningFloorReducedTime; // 0xB8
	private bool isCurrving; // 0xBC

	// Properties
	public override KnockBackResistType KnockBackResist { get; }
	public override bool IsTargetDirection { get; }
	public override bool VisibleAttackArea { get; }
	private bool IsFixedDirectionPattern { get; }

	// Methods

	// RVA: 0x1E21964 Offset: 0x1E1D964 VA: 0x1E21964 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E2196C Offset: 0x1E1D96C VA: 0x1E2196C Slot: 6
	public override bool get_IsTargetDirection() { }

	// RVA: 0x1E21974 Offset: 0x1E1D974 VA: 0x1E21974 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E21A98 Offset: 0x1E1DA98 VA: 0x1E21A98
	private bool get_IsFixedDirectionPattern() { }

	// RVA: 0x1E21ABC Offset: 0x1E1DABC VA: 0x1E21ABC
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E21F30 Offset: 0x1E1DF30 VA: 0x1E21F30
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, List<MobActionTargetData> targetList, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E22100 Offset: 0x1E1E100 VA: 0x1E22100 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E2286C Offset: 0x1E1E86C VA: 0x1E2286C Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E2297C Offset: 0x1E1E97C VA: 0x1E2297C Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E22BF0 Offset: 0x1E1EBF0 VA: 0x1E22BF0 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E231DC Offset: 0x1E1F1DC VA: 0x1E231DC Slot: 29
	public override bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1E23230 Offset: 0x1E1F230 VA: 0x1E23230 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1E22CF8 Offset: 0x1E1ECF8 VA: 0x1E22CF8
	private void Attack() { }

	// RVA: 0x1E22374 Offset: 0x1E1E374 VA: 0x1E22374
	private void CreateAttackArea() { }

	// RVA: 0x1E21E44 Offset: 0x1E1DE44 VA: 0x1E21E44
	private void CreateTargetList(Vector3 targetPos) { }

	// RVA: 0x1E23704 Offset: 0x1E1F704 VA: 0x1E23704
	private void CreateTargetToHateManager(Vector3 targetPos) { }

	// RVA: 0x1E237E0 Offset: 0x1E1F7E0 VA: 0x1E237E0
	private void CreateTargetToNonHateManager(Vector3 targetPos) { }

	// RVA: 0x1E23DF8 Offset: 0x1E1FDF8 VA: 0x1E23DF8
	private void CreateTargetToRandom(Vector3 targetPos) { }

	// RVA: 0x1E24A0C Offset: 0x1E20A0C VA: 0x1E24A0C
	private void CreateTargetToCloseNonHateManager() { }

	// RVA: 0x1E250BC Offset: 0x1E210BC VA: 0x1E250BC
	private void CreateTargetToDistantNonHateManager() { }

	// RVA: 0x1E243EC Offset: 0x1E203EC VA: 0x1E243EC
	private void CreateTargetToNonHateManagerAll() { }

	// RVA: 0x1E246FC Offset: 0x1E206FC VA: 0x1E246FC
	private void CreateTargetToAll() { }
}
