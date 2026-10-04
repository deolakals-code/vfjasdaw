// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ConquesterAction : PlayerAttackBase // TypeDefIndex: 2972
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private bool isIgnition; // 0x128
	private int split; // 0x12C
	private bool isRange; // 0x130
	private bool isPowerUp; // 0x131

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x22ED1CC Offset: 0x22E91CC VA: 0x22ED1CC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22ED1D4 Offset: 0x22E91D4 VA: 0x22ED1D4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22ED1DC Offset: 0x22E91DC VA: 0x22ED1DC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22ED1E4 Offset: 0x22E91E4 VA: 0x22ED1E4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22ED1EC Offset: 0x22E91EC VA: 0x22ED1EC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22ED1F4 Offset: 0x22E91F4 VA: 0x22ED1F4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22ED1FC Offset: 0x22E91FC VA: 0x22ED1FC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22ED204 Offset: 0x22E9204 VA: 0x22ED204 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22ED20C Offset: 0x22E920C VA: 0x22ED20C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22ED464 Offset: 0x22E9464 VA: 0x22ED464 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22ED610 Offset: 0x22E9610 VA: 0x22ED610 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22ED7DC Offset: 0x22E97DC VA: 0x22ED7DC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22EDAD8 Offset: 0x22E9AD8 VA: 0x22EDAD8 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22EDD74 Offset: 0x22E9D74 VA: 0x22EDD74 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22EDE68 Offset: 0x22E9E68 VA: 0x22EDE68 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22EE550 Offset: 0x22EA550 VA: 0x22EE550
	public void .ctor() { }
}
