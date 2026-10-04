// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HandlingerOfGodspeedAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3669
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	public static readonly int[] AuraMainColors; // 0x0
	public static readonly int[] AuraSubColors; // 0x8

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
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x23BF30C Offset: 0x23BB30C VA: 0x23BF30C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BF314 Offset: 0x23BB314 VA: 0x23BF314 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BF31C Offset: 0x23BB31C VA: 0x23BF31C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BF324 Offset: 0x23BB324 VA: 0x23BF324 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BF32C Offset: 0x23BB32C VA: 0x23BF32C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BF334 Offset: 0x23BB334 VA: 0x23BF334 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BF33C Offset: 0x23BB33C VA: 0x23BF33C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BF344 Offset: 0x23BB344 VA: 0x23BF344 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BF34C Offset: 0x23BB34C VA: 0x23BF34C Slot: 15
	public override bool get_IsSupport() { }

	[CompilerGenerated]
	// RVA: 0x23BF354 Offset: 0x23BB354 VA: 0x23BF354 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23BF35C Offset: 0x23BB35C VA: 0x23BF35C
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23BF368 Offset: 0x23BB368 VA: 0x23BF368 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BF4DC Offset: 0x23BB4DC VA: 0x23BF4DC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BD784 Offset: 0x23B9784 VA: 0x23BD784 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BF674 Offset: 0x23BB674 VA: 0x23BF674 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BF8F4 Offset: 0x23BB8F4 VA: 0x23BF8F4 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23BDE9C Offset: 0x23B9E9C VA: 0x23BDE9C
	public void .ctor() { }

	// RVA: 0x23BF900 Offset: 0x23BB900 VA: 0x23BF900
	private static void .cctor() { }
}
