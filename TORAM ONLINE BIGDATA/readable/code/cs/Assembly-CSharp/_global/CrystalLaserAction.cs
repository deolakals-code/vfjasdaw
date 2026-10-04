// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CrystalLaserAction : PlayerAttackBase // TypeDefIndex: 3051
{
	// Fields
	private bool failure; // 0x120
	private int skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private float attackRange; // 0x12C
	private float mpHealRange; // 0x130
	private float length; // 0x134
	private Vector3 crystalPos; // 0x138
	private GameObject target; // 0x148
	private Vector3 attackDir; // 0x150
	private PlayerActionManagerBase playerAction; // 0x160

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public Vector3 CrystalPos { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x231761C Offset: 0x231361C VA: 0x231761C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2317624 Offset: 0x2313624 VA: 0x2317624 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x231762C Offset: 0x231362C VA: 0x231762C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2317634 Offset: 0x2313634 VA: 0x2317634 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x231763C Offset: 0x231363C VA: 0x231763C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2317644 Offset: 0x2313644 VA: 0x2317644 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x231764C Offset: 0x231364C VA: 0x231764C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2317654 Offset: 0x2313654 VA: 0x2317654 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x231765C Offset: 0x231365C VA: 0x231765C
	public Vector3 get_CrystalPos() { }

	// RVA: 0x231766C Offset: 0x231366C VA: 0x231766C Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x2317674 Offset: 0x2313674 VA: 0x2317674 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x231767C Offset: 0x231367C VA: 0x231767C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23177A8 Offset: 0x23137A8 VA: 0x23177A8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2317844 Offset: 0x2313844 VA: 0x2317844 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2317C6C Offset: 0x2313C6C VA: 0x2317C6C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2317D18 Offset: 0x2313D18 VA: 0x2317D18 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x2317DB0 Offset: 0x2313DB0 VA: 0x2317DB0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2317FB0 Offset: 0x2313FB0 VA: 0x2317FB0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2318B4C Offset: 0x2314B4C VA: 0x2318B4C Slot: 53
	protected override void OnEnd(bool cancel) { }

	// RVA: 0x2318C6C Offset: 0x2314C6C VA: 0x2318C6C
	public void .ctor() { }
}
