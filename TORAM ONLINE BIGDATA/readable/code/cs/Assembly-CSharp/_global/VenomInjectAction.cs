// Assembly: Assembly-CSharp.dll
// Namespace: 
public class VenomInjectAction : PlayerAttackBase // TypeDefIndex: 3763
{
	// Fields
	private const float BaseDamageRate = 5;

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsPayHp { get; }

	// Methods

	// RVA: 0x23E1D04 Offset: 0x23DDD04 VA: 0x23E1D04 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23E1D0C Offset: 0x23DDD0C VA: 0x23E1D0C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23E1D14 Offset: 0x23DDD14 VA: 0x23E1D14 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23E1D1C Offset: 0x23DDD1C VA: 0x23E1D1C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23E1D24 Offset: 0x23DDD24 VA: 0x23E1D24 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23E1D2C Offset: 0x23DDD2C VA: 0x23E1D2C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23E1D34 Offset: 0x23DDD34 VA: 0x23E1D34 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23E1D3C Offset: 0x23DDD3C VA: 0x23E1D3C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23E1D44 Offset: 0x23DDD44 VA: 0x23E1D44 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23E1D4C Offset: 0x23DDD4C VA: 0x23E1D4C Slot: 26
	public override bool get_IsPayHp() { }

	// RVA: 0x23E1D54 Offset: 0x23DDD54 VA: 0x23E1D54 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23E1E98 Offset: 0x23DDE98 VA: 0x23E1E98 Slot: 61
	public override bool CheckPayHp(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23E214C Offset: 0x23DE14C VA: 0x23E214C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23E2354 Offset: 0x23DE354 VA: 0x23E2354 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23E1FE8 Offset: 0x23DDFE8 VA: 0x23E1FE8
	private int CalcPayHpValue(PlayerStatusBase status) { }

	// RVA: 0x23E23D8 Offset: 0x23DE3D8 VA: 0x23E23D8
	public static int CalcPercent(PlayerStatusBase status, bool critical, bool glaze) { }

	// RVA: 0x23E2574 Offset: 0x23DE574 VA: 0x23E2574 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23E263C Offset: 0x23DE63C VA: 0x23E263C
	public void .ctor() { }
}
