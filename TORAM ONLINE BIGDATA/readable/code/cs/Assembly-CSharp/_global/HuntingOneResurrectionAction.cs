// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HuntingOneResurrectionAction : HuntingOneSkillBase // TypeDefIndex: 3367
{
	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x235441C Offset: 0x235041C VA: 0x235441C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2354424 Offset: 0x2350424 VA: 0x2354424 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x235442C Offset: 0x235042C VA: 0x235442C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2354434 Offset: 0x2350434 VA: 0x2354434 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x235443C Offset: 0x235043C VA: 0x235443C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2354444 Offset: 0x2350444 VA: 0x2354444 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x235444C Offset: 0x235044C VA: 0x235444C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2354454 Offset: 0x2350454 VA: 0x2354454 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x235445C Offset: 0x235045C VA: 0x235445C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2354464 Offset: 0x2350464 VA: 0x2354464 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x235446C Offset: 0x235046C VA: 0x235446C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2354474 Offset: 0x2350474 VA: 0x2354474 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23544EC Offset: 0x23504EC VA: 0x23544EC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23544F0 Offset: 0x23504F0 VA: 0x23544F0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23544F4 Offset: 0x23504F4 VA: 0x23544F4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x235456C Offset: 0x235056C VA: 0x235456C
	public void .ctor() { }
}
