// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class ImprovisationSongAction : PlayerAttackBase // TypeDefIndex: 9140
{
	// Fields
	private int add_cost_mp; // 0x120
	private bool failure; // 0x124

	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x1EB24B8 Offset: 0x1EAE4B8 VA: 0x1EB24B8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x1EB24C0 Offset: 0x1EAE4C0 VA: 0x1EB24C0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1EB24C8 Offset: 0x1EAE4C8 VA: 0x1EB24C8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1EB24D4 Offset: 0x1EAE4D4 VA: 0x1EB24D4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x1EB24DC Offset: 0x1EAE4DC VA: 0x1EB24DC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x1EB24E4 Offset: 0x1EAE4E4 VA: 0x1EB24E4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x1EB24EC Offset: 0x1EAE4EC VA: 0x1EB24EC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x1EB24F4 Offset: 0x1EAE4F4 VA: 0x1EB24F4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x1EB24FC Offset: 0x1EAE4FC VA: 0x1EB24FC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x1EB2504 Offset: 0x1EAE504 VA: 0x1EB2504 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x1EB2658 Offset: 0x1EAE658 VA: 0x1EB2658 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x1EB2838 Offset: 0x1EAE838 VA: 0x1EB2838 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x1EB2988 Offset: 0x1EAE988 VA: 0x1EB2988
	public void .ctor() { }
}
