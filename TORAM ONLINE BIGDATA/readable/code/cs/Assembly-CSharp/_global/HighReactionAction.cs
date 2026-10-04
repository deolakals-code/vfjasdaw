// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HighReactionAction : PlayerAttackBase // TypeDefIndex: 3679
{
	// Fields
	private int range; // 0x120
	private Vector3 checkPos; // 0x124

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

	// RVA: 0x23C36AC Offset: 0x23BF6AC VA: 0x23C36AC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C36B4 Offset: 0x23BF6B4 VA: 0x23C36B4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C36BC Offset: 0x23BF6BC VA: 0x23C36BC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C36C4 Offset: 0x23BF6C4 VA: 0x23C36C4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C36CC Offset: 0x23BF6CC VA: 0x23C36CC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C36D4 Offset: 0x23BF6D4 VA: 0x23C36D4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C36DC Offset: 0x23BF6DC VA: 0x23C36DC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C36E4 Offset: 0x23BF6E4 VA: 0x23C36E4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C36EC Offset: 0x23BF6EC VA: 0x23C36EC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C36F4 Offset: 0x23BF6F4 VA: 0x23C36F4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C38BC Offset: 0x23BF8BC VA: 0x23C38BC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C398C Offset: 0x23BF98C VA: 0x23C398C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C3A60 Offset: 0x23BFA60 VA: 0x23C3A60 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23C3ADC Offset: 0x23BFADC VA: 0x23C3ADC
	public void .ctor() { }
}
