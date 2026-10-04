// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class KadarElexioAction : PlayerAttackBase // TypeDefIndex: 2767
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x225F3CC Offset: 0x225B3CC VA: 0x225F3CC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x225F3D4 Offset: 0x225B3D4 VA: 0x225F3D4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x225F3DC Offset: 0x225B3DC VA: 0x225F3DC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x225F3E4 Offset: 0x225B3E4 VA: 0x225F3E4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x225F3EC Offset: 0x225B3EC VA: 0x225F3EC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x225F3F4 Offset: 0x225B3F4 VA: 0x225F3F4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x225F3FC Offset: 0x225B3FC VA: 0x225F3FC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x225F404 Offset: 0x225B404 VA: 0x225F404 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x225F40C Offset: 0x225B40C VA: 0x225F40C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x225F414 Offset: 0x225B414 VA: 0x225F414 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x225F508 Offset: 0x225B508 VA: 0x225F508 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x225F588 Offset: 0x225B588 VA: 0x225F588
	public static void PlayRandomEffect(int type, byte lv, PlayerDataManager playerData, SupportResultData supportData) { }

	// RVA: 0x225FCA4 Offset: 0x225BCA4 VA: 0x225FCA4
	public void .ctor() { }
}
