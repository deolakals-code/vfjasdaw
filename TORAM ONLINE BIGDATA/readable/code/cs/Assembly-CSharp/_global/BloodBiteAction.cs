// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BloodBiteAction : PlayerAttackBase // TypeDefIndex: 2600
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int hpRecovery; // 0x128
	private float recoveryRate; // 0x12C
	private int maxHpRecovery; // 0x130

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

	// RVA: 0x2208FB4 Offset: 0x2204FB4 VA: 0x2208FB4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2208FBC Offset: 0x2204FBC VA: 0x2208FBC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2208FC4 Offset: 0x2204FC4 VA: 0x2208FC4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2208FCC Offset: 0x2204FCC VA: 0x2208FCC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2208FD4 Offset: 0x2204FD4 VA: 0x2208FD4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2208FDC Offset: 0x2204FDC VA: 0x2208FDC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2208FE4 Offset: 0x2204FE4 VA: 0x2208FE4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2208FEC Offset: 0x2204FEC VA: 0x2208FEC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2208FF4 Offset: 0x2204FF4 VA: 0x2208FF4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2209308 Offset: 0x2205308 VA: 0x2209308 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2209554 Offset: 0x2205554 VA: 0x2209554 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2209628 Offset: 0x2205628 VA: 0x2209628 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2209930 Offset: 0x2205930 VA: 0x2209930 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22094B0 Offset: 0x22054B0 VA: 0x22094B0
	private int GetTake(int main, int sub) { }

	// RVA: 0x2209C08 Offset: 0x2205C08 VA: 0x2209C08
	public void .ctor() { }
}
