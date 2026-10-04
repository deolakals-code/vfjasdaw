// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AshuraAuraBuf : CountBufferBase // TypeDefIndex: 3066
{
	// Fields
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsAttack>k__BackingField; // 0x29
	private const short BaseLastDamageUpValue = 10;
	private const float Interval = 0.25;
	private int lastDamageRate; // 0x2C
	private int lastDamageRateOffVer; // 0x30
	private int constantDamage; // 0x34
	private int critical; // 0x38
	private float loopTimer; // 0x3C
	private PlayerActionManagerBase actionManager; // 0x40
	private MobActionManagerBase mobAction; // 0x48
	private Func<MobActionManagerBase, bool> StartAshuraAuraAttack; // 0x50
	private int attackCount; // 0x58
	private int takeUid; // 0x5C
	private bool right; // 0x60
	private float attackRange; // 0x64
	private bool isMainKnucle; // 0x68

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public bool IsActive { get; set; }
	public bool IsAttack { get; set; }

	// Methods

	// RVA: 0x231D380 Offset: 0x2319380 VA: 0x231D380 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x231D388 Offset: 0x2319388 VA: 0x231D388 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x231D3A0 Offset: 0x23193A0 VA: 0x231D3A0 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	[CompilerGenerated]
	// RVA: 0x231D3A8 Offset: 0x23193A8 VA: 0x231D3A8
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x231D3B0 Offset: 0x23193B0 VA: 0x231D3B0
	private void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x231D3BC Offset: 0x23193BC VA: 0x231D3BC
	public bool get_IsAttack() { }

	[CompilerGenerated]
	// RVA: 0x231D3C4 Offset: 0x23193C4 VA: 0x231D3C4
	private void set_IsAttack(bool value) { }

	// RVA: 0x231D3D0 Offset: 0x23193D0 VA: 0x231D3D0
	public void .ctor(byte lv, int takeUid, PlayerActionManagerBase playerAction) { }

	// RVA: 0x231D634 Offset: 0x2319634 VA: 0x231D634 Slot: 17
	public override void OnLeave() { }

	// RVA: 0x231D6B8 Offset: 0x23196B8 VA: 0x231D6B8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x231D718 Offset: 0x2319718 VA: 0x231D718 Slot: 11
	public override void Updata() { }

	// RVA: 0x231D71C Offset: 0x231971C VA: 0x231D71C
	private void UpdateAshuraAuraAttack() { }

	// RVA: 0x231D99C Offset: 0x231999C VA: 0x231D99C Slot: 23
	public override void Next() { }

	// RVA: 0x231D9F8 Offset: 0x23199F8 VA: 0x231D9F8
	public bool CheckRightAttack() { }

	// RVA: 0x231DA00 Offset: 0x2319A00 VA: 0x231DA00
	public void StartSkill(SkillActionBase skill) { }

	// RVA: 0x231DB0C Offset: 0x2319B0C VA: 0x231DB0C
	public void PayMp(int mp) { }

	// RVA: 0x231D638 Offset: 0x2319638 VA: 0x231D638
	public void SwitchOff() { }

	// RVA: 0x231DB60 Offset: 0x2319B60 VA: 0x231DB60
	public void AttackStart(MobActionManagerBase mobAction) { }

	// RVA: 0x231D944 Offset: 0x2319944 VA: 0x231D944
	public void AttackStop() { }

	// RVA: 0x231D970 Offset: 0x2319970 VA: 0x231D970
	private void Attacked() { }

	// RVA: 0x231D814 Offset: 0x2319814 VA: 0x231D814
	private bool CheckAttackStop() { }

	// RVA: 0x231DC58 Offset: 0x2319C58 VA: 0x231DC58
	public static bool CheckMpIncrease(PlayerAttackBase skill) { }

	// RVA: 0x231DD30 Offset: 0x2319D30 VA: 0x231DD30
	public void ValidDamageUp() { }

	// RVA: 0x231DD44 Offset: 0x2319D44 VA: 0x231DD44
	public void InvalidDamageUp() { }

	[CompilerGenerated]
	// RVA: 0x231DD58 Offset: 0x2319D58 VA: 0x231DD58
	private bool <.ctor>b__29_0(MobActionManagerBase mobAction) { }

	[CompilerGenerated]
	// RVA: 0x231DDE8 Offset: 0x2319DE8 VA: 0x231DDE8
	private bool <.ctor>b__29_1(MobActionManagerBase mobAction) { }
}
