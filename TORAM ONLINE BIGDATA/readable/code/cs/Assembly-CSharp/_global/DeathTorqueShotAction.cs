// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DeathTorqueShotAction : PlayerAttackBase // TypeDefIndex: 2976
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x22F0208 Offset: 0x22EC208 VA: 0x22F0208 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22F0210 Offset: 0x22EC210 VA: 0x22F0210 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22F0218 Offset: 0x22EC218 VA: 0x22F0218 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22F0220 Offset: 0x22EC220 VA: 0x22F0220 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22F0228 Offset: 0x22EC228 VA: 0x22F0228 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22F0230 Offset: 0x22EC230 VA: 0x22F0230 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22F0238 Offset: 0x22EC238 VA: 0x22F0238 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22F0240 Offset: 0x22EC240 VA: 0x22F0240 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22F0248 Offset: 0x22EC248 VA: 0x22F0248 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22F0590 Offset: 0x22EC590 VA: 0x22F0590 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22F06DC Offset: 0x22EC6DC VA: 0x22F06DC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22F0760 Offset: 0x22EC760 VA: 0x22F0760 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22F0AE4 Offset: 0x22ECAE4 VA: 0x22F0AE4
	public void .ctor() { }
}
