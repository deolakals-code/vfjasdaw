// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicEgelAction : PlayerAttackBase, IEnchantSkill, IChronosShift // TypeDefIndex: 3705
{
	// Fields
	private MagicEgelAction lastUsedSkill; // 0x120

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x23CC3D0 Offset: 0x23C83D0 VA: 0x23CC3D0 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23CC3D8 Offset: 0x23C83D8 VA: 0x23CC3D8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23CC3E0 Offset: 0x23C83E0 VA: 0x23CC3E0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23CC3E8 Offset: 0x23C83E8 VA: 0x23CC3E8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23CC3F0 Offset: 0x23C83F0 VA: 0x23CC3F0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23CC3F8 Offset: 0x23C83F8 VA: 0x23CC3F8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23CC400 Offset: 0x23C8400 VA: 0x23CC400 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23CC408 Offset: 0x23C8408 VA: 0x23CC408 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23CC410 Offset: 0x23C8410 VA: 0x23CC410 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23CC418 Offset: 0x23C8418 VA: 0x23CC418 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23CC420 Offset: 0x23C8420 VA: 0x23CC420 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x23CC428 Offset: 0x23C8428 VA: 0x23CC428 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x23CC430 Offset: 0x23C8430 VA: 0x23CC430 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x23CC438 Offset: 0x23C8438 VA: 0x23CC438 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23CC560 Offset: 0x23C8560 VA: 0x23CC560 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23CC618 Offset: 0x23C8618 VA: 0x23CC618 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x23CC6F0 Offset: 0x23C86F0 VA: 0x23CC6F0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CC7C0 Offset: 0x23C87C0 VA: 0x23CC7C0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CC8F0 Offset: 0x23C88F0 VA: 0x23CC8F0
	public static bool CheckSkill(PlayerAttackBase skill) { }

	// RVA: 0x23CC96C Offset: 0x23C896C VA: 0x23CC96C Slot: 96
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x23CC728 Offset: 0x23C8728 VA: 0x23CC728 Slot: 97
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x23CCA2C Offset: 0x23C8A2C VA: 0x23CCA2C Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23CCB00 Offset: 0x23C8B00 VA: 0x23CCB00 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23CCBD4 Offset: 0x23C8BD4 VA: 0x23CCBD4
	public void .ctor() { }
}
