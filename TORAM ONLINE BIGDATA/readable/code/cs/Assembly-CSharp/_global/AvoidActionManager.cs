// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AvoidActionManager : MonoBehaviour // TypeDefIndex: 312
{
	// Fields
	public const float MirageStepMoveDist = 4;
	private PlayerDataManager playerManager; // 0x20
	private PlayerActionManagerBase actionManager; // 0x28
	private BattleManagerBase battleManager; // 0x30
	private CharacterMove charaMove; // 0x38
	private bool isFloor; // 0x40
	private AvoidActionManager.TempData tempData; // 0x44
	private float emergencyTimer; // 0x4C
	[CompilerGenerated]
	private bool <IsAvoid>k__BackingField; // 0x50
	[CompilerGenerated]
	private float <AvoidStack>k__BackingField; // 0x54
	[CompilerGenerated]
	private int <AvoidDelay>k__BackingField; // 0x58

	// Properties
	public bool IsAvoid { get; set; }
	public float AvoidStack { get; set; }
	public int AvoidDelay { get; set; }
	public int AvoidSpeed { get; }
	public int AvoidCount { get; }
	public AvoidType AvoidType { get; }
	public float AvoidRate { get; }
	public int MaxAvoidCount { get; }
	private SkillActionManagerBase SkillActionManager { get; }
	public bool IsAbnormal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2384380 Offset: 0x2380380 VA: 0x2384380
	public bool get_IsAvoid() { }

	[CompilerGenerated]
	// RVA: 0x2384388 Offset: 0x2380388 VA: 0x2384388
	private void set_IsAvoid(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2384394 Offset: 0x2380394 VA: 0x2384394
	public float get_AvoidStack() { }

	[CompilerGenerated]
	// RVA: 0x238439C Offset: 0x238039C VA: 0x238439C
	private void set_AvoidStack(float value) { }

	[CompilerGenerated]
	// RVA: 0x23843A4 Offset: 0x23803A4 VA: 0x23843A4
	public int get_AvoidDelay() { }

	[CompilerGenerated]
	// RVA: 0x23843AC Offset: 0x23803AC VA: 0x23843AC
	private void set_AvoidDelay(int value) { }

	// RVA: 0x23843B4 Offset: 0x23803B4 VA: 0x23843B4
	public int get_AvoidSpeed() { }

	// RVA: 0x23844AC Offset: 0x23804AC VA: 0x23844AC
	public int get_AvoidCount() { }

	// RVA: 0x2384524 Offset: 0x2380524 VA: 0x2384524
	public AvoidType get_AvoidType() { }

	// RVA: 0x23845B0 Offset: 0x23805B0 VA: 0x23845B0
	public float get_AvoidRate() { }

	// RVA: 0x2384698 Offset: 0x2380698 VA: 0x2384698
	public int get_MaxAvoidCount() { }

	// RVA: 0x2384780 Offset: 0x2380780 VA: 0x2384780
	private SkillActionManagerBase get_SkillActionManager() { }

	// RVA: 0x2384800 Offset: 0x2380800 VA: 0x2384800
	public bool get_IsAbnormal() { }

	// RVA: 0x2384E4C Offset: 0x2380E4C VA: 0x2384E4C
	private void Awake() { }

	// RVA: 0x2384F24 Offset: 0x2380F24 VA: 0x2384F24
	private void Start() { }

	// RVA: 0x2384F28 Offset: 0x2380F28 VA: 0x2384F28
	private void Update() { }

	// RVA: 0x23850A0 Offset: 0x23810A0 VA: 0x23850A0
	public void InitializeAvoid() { }

	// RVA: 0x23850AC Offset: 0x23810AC VA: 0x23850AC
	public void ChangeField() { }

	// RVA: 0x2385190 Offset: 0x2381190 VA: 0x2385190
	public void ChangeStatus() { }

	// RVA: 0x2385274 Offset: 0x2381274 VA: 0x2385274
	public void ChangeAvoidOption() { }

	// RVA: 0x2385358 Offset: 0x2381358 VA: 0x2385358
	public void OnDead() { }

	// RVA: 0x2385360 Offset: 0x2381360 VA: 0x2385360
	public void OnRespawn(bool orbRespawn) { }

	// RVA: 0x2385444 Offset: 0x2381444 VA: 0x2385444
	public bool CheckAvoidEquip() { }

	// RVA: 0x2385694 Offset: 0x2381694 VA: 0x2385694
	public bool CheckAvoidStart() { }

	// RVA: 0x23865BC Offset: 0x23825BC VA: 0x23865BC
	public bool CheckAvoid(MobActionManagerBase mobAction, MobAttackBase mobAttack) { }

	// RVA: 0x2387308 Offset: 0x2383308 VA: 0x2387308
	public void AvoidStart() { }

	// RVA: 0x238794C Offset: 0x238394C VA: 0x238794C
	private void CheckInvokeShadowWalkAttack(GameObject target) { }

	// RVA: 0x238805C Offset: 0x238405C VA: 0x238805C
	private void DoubleThrowAvoid() { }

	// RVA: 0x2388178 Offset: 0x2384178 VA: 0x2388178
	private void InvalidAshuraAuraAttack() { }

	// RVA: 0x23890D8 Offset: 0x23850D8 VA: 0x23890D8
	public void AvoidEnd(bool forceEnd) { }

	// RVA: 0x238944C Offset: 0x238544C VA: 0x238944C
	public void OnAvoid(GameObject actor) { }

	// RVA: 0x2389588 Offset: 0x2385588 VA: 0x2389588
	public void StartSkill(SkillActionBase skill) { }

	// RVA: 0x23895E0 Offset: 0x23855E0 VA: 0x23895E0
	public void Damage(int damage) { }

	// RVA: 0x2389600 Offset: 0x2385600 VA: 0x2389600
	public void Heal(int heal) { }

	// RVA: 0x23896FC Offset: 0x23856FC VA: 0x23896FC
	public void Receive(int avoidStack) { }

	// RVA: 0x2389760 Offset: 0x2385760 VA: 0x2389760
	public void TemporaryEvacuationAvoidData() { }

	// RVA: 0x2389774 Offset: 0x2385774 VA: 0x2389774
	public void UndoAvoidData() { }

	// RVA: 0x2384F2C Offset: 0x2380F2C VA: 0x2384F2C
	private void UpdateAvoidStack() { }

	// RVA: 0x2388240 Offset: 0x2384240 VA: 0x2388240
	private void AvoidMove() { }

	// RVA: 0x2388CA0 Offset: 0x2384CA0 VA: 0x2388CA0
	private bool CheckActivatePhiloEclair(out Vector3 movePos) { }

	// RVA: 0x2385D4C Offset: 0x2381D4C VA: 0x2385D4C
	private bool CheckActivateMirageStep() { }

	// RVA: 0x2385EC8 Offset: 0x2381EC8 VA: 0x2385EC8
	private bool CheckMindimageSenju() { }

	// RVA: 0x2389788 Offset: 0x2385788 VA: 0x2389788
	private void MoveMirageStep(out float moveAngle) { }

	// RVA: 0x2385C18 Offset: 0x2381C18 VA: 0x2385C18
	private bool CheckPenetrator() { }

	// RVA: 0x2389A8C Offset: 0x2385A8C VA: 0x2389A8C
	private void MovePenetrator(out float moveAngle) { }

	// RVA: 0x238635C Offset: 0x238235C VA: 0x238635C
	private bool CheckSkullShakerAvoidCancel() { }

	// RVA: 0x238648C Offset: 0x238248C VA: 0x238648C
	private bool CheckBladeStingerAvoidCancel() { }

	[IteratorStateMachine(typeof(AvoidActionManager.<LockLook>d__71))]
	// RVA: 0x2389C10 Offset: 0x2385C10 VA: 0x2389C10
	private IEnumerator LockLook(bool defaultAutoLook) { }

	// RVA: 0x2386C9C Offset: 0x2382C9C VA: 0x2386C9C
	private bool CheckMobAttackArea(Transform transform) { }

	// RVA: 0x23848F4 Offset: 0x23808F4 VA: 0x23848F4
	private bool CheckInBlackHole(Transform transform) { }

	// RVA: 0x2389CB8 Offset: 0x2385CB8 VA: 0x2389CB8
	public void .ctor() { }
}
