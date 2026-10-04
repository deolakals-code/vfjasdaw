// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class BlackKnightMobSkillBase : BlackKnightSkillActionBase // TypeDefIndex: 4188
{
	// Fields
	[CompilerGenerated]
	private MobActionPattern <MasterActionPattern>k__BackingField; // 0x50

	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public MobActionPattern MasterActionPattern { get; set; }

	// Methods

	// RVA: 0x24A2D0C Offset: 0x249ED0C VA: 0x24A2D0C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24A2D28 Offset: 0x249ED28 VA: 0x24A2D28 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24A2D30 Offset: 0x249ED30 VA: 0x24A2D30 Slot: 7
	public override bool get_IsPlace() { }

	[CompilerGenerated]
	// RVA: 0x24A2D38 Offset: 0x249ED38 VA: 0x24A2D38
	public MobActionPattern get_MasterActionPattern() { }

	[CompilerGenerated]
	// RVA: 0x24A2D40 Offset: 0x249ED40 VA: 0x24A2D40
	private void set_MasterActionPattern(MobActionPattern value) { }

	// RVA: 0x24A2B1C Offset: 0x249EB1C VA: 0x24A2B1C Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24A2D48 Offset: 0x249ED48 VA: 0x24A2D48 Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24A2D68 Offset: 0x249ED68 VA: 0x24A2D68 Slot: 14
	public override void ActionHit(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24A2D6C Offset: 0x249ED6C VA: 0x24A2D6C
	public void SetHitArea(List<BlackKnightHitAreaData> hitArea) { }

	// RVA: 0x24A2DC4 Offset: 0x249EDC4 VA: 0x24A2DC4
	public void SetPattern(MobActionPattern pattern) { }

	// RVA: 0x24A2DCC Offset: 0x249EDCC VA: 0x24A2DCC Slot: 21
	protected override BlackKnightSkillActionBase.DamageData templateToDamageData(BlackKnightSkillActionBase.DamageData damageData, BlackKnightCharacterManagerBase charaMng, int damage, bool isCritical) { }

	// RVA: 0x24A2D08 Offset: 0x249ED08 VA: 0x24A2D08
	protected void .ctor() { }
}
