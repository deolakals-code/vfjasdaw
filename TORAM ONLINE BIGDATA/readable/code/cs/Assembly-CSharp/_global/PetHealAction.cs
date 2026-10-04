// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetHealAction : PlayerAttackBase // TypeDefIndex: 3721
{
	// Fields
	private int hpRecovery; // 0x120
	private float hpHealRate; // 0x124

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23D38F4 Offset: 0x23CF8F4 VA: 0x23D38F4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D38FC Offset: 0x23CF8FC VA: 0x23D38FC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D3904 Offset: 0x23CF904 VA: 0x23D3904 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D390C Offset: 0x23CF90C VA: 0x23D390C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D3914 Offset: 0x23CF914 VA: 0x23D3914 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D391C Offset: 0x23CF91C VA: 0x23D391C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D3924 Offset: 0x23CF924 VA: 0x23D3924 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D392C Offset: 0x23CF92C VA: 0x23D392C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D3934 Offset: 0x23CF934 VA: 0x23D3934 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D393C Offset: 0x23CF93C VA: 0x23D393C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D3B44 Offset: 0x23CFB44 VA: 0x23D3B44 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D3C14 Offset: 0x23CFC14 VA: 0x23D3C14 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D3DE0 Offset: 0x23CFDE0 VA: 0x23D3DE0
	public void .ctor() { }
}
