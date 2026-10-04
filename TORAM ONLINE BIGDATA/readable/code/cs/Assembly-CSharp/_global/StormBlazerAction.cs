// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StormBlazerAction : PlayerAttackBase // TypeDefIndex: 2573
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int mpRecovery; // 0x128
	private Vector3 effectPos; // 0x12C
	private bool isGuard; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public bool IsGuard { get; }

	// Methods

	// RVA: 0x21FBD8C Offset: 0x21F7D8C VA: 0x21FBD8C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21FBD94 Offset: 0x21F7D94 VA: 0x21FBD94 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21FBD9C Offset: 0x21F7D9C VA: 0x21FBD9C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21FBDA4 Offset: 0x21F7DA4 VA: 0x21FBDA4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21FBDAC Offset: 0x21F7DAC VA: 0x21FBDAC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21FBDB4 Offset: 0x21F7DB4 VA: 0x21FBDB4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21FBDBC Offset: 0x21F7DBC VA: 0x21FBDBC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21FBDC4 Offset: 0x21F7DC4 VA: 0x21FBDC4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21FBDCC Offset: 0x21F7DCC VA: 0x21FBDCC
	public bool get_IsGuard() { }

	// RVA: 0x21FBDD4 Offset: 0x21F7DD4 VA: 0x21FBDD4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21FBFE4 Offset: 0x21F7FE4 VA: 0x21FBFE4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21FC2AC Offset: 0x21F82AC VA: 0x21FC2AC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21FC428 Offset: 0x21F8428 VA: 0x21FC428 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x21FC688 Offset: 0x21F8688 VA: 0x21FC688 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21FC900 Offset: 0x21F8900 VA: 0x21FC900 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21FC908 Offset: 0x21F8908 VA: 0x21FC908
	public void OnGuard() { }

	// RVA: 0x21FC91C Offset: 0x21F891C VA: 0x21FC91C
	public static void StackStormBlazer(PlayerActionManagerBase playerAction, int addCount = 1) { }

	// RVA: 0x21FCB48 Offset: 0x21F8B48 VA: 0x21FCB48 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21FCC0C Offset: 0x21F8C0C VA: 0x21FCC0C Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x21FCCB0 Offset: 0x21F8CB0 VA: 0x21FCCB0
	public void .ctor() { }
}
