// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StoneSkinAction : PlayerAttackBase // TypeDefIndex: 3755
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23DDD80 Offset: 0x23D9D80 VA: 0x23DDD80 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DDD88 Offset: 0x23D9D88 VA: 0x23DDD88 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DDD90 Offset: 0x23D9D90 VA: 0x23DDD90 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DDD98 Offset: 0x23D9D98 VA: 0x23DDD98 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DDDA0 Offset: 0x23D9DA0 VA: 0x23DDDA0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DDDA8 Offset: 0x23D9DA8 VA: 0x23DDDA8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DDDB0 Offset: 0x23D9DB0 VA: 0x23DDDB0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DDDB8 Offset: 0x23D9DB8 VA: 0x23DDDB8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DDDC0 Offset: 0x23D9DC0 VA: 0x23DDDC0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DDDC8 Offset: 0x23D9DC8 VA: 0x23DDDC8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DDEF0 Offset: 0x23D9EF0 VA: 0x23DDEF0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DDFA8 Offset: 0x23D9FA8 VA: 0x23DDFA8 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23DE108 Offset: 0x23DA108 VA: 0x23DE108 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23DE1F0 Offset: 0x23DA1F0 VA: 0x23DE1F0
	public void .ctor() { }
}
