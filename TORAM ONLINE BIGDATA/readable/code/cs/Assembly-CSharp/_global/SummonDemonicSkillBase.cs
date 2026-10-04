// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class SummonDemonicSkillBase : PlayerAttackBase // TypeDefIndex: 3605
{
	// Fields
	protected ExSkillSummonDemonic exSkillData; // 0x120
	[CompilerGenerated]
	private float <assistMoveTargetDistance>k__BackingField; // 0x128

	// Properties
	public override bool IsSupport { get; }
	public override SkillTreeType TreeType { get; }
	public override bool IsMoveAssistContinue { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	protected override bool CheckBlank { get; }
	protected float assistMoveTargetDistance { get; set; }

	// Methods

	// RVA: 0x23A9324 Offset: 0x23A5324 VA: 0x23A9324 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23A932C Offset: 0x23A532C VA: 0x23A932C Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x23A9334 Offset: 0x23A5334 VA: 0x23A9334 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x23A933C Offset: 0x23A533C VA: 0x23A933C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23A9344 Offset: 0x23A5344 VA: 0x23A9344 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x23A934C Offset: 0x23A534C VA: 0x23A934C Slot: 73
	protected override bool get_CheckBlank() { }

	[CompilerGenerated]
	// RVA: 0x23A9354 Offset: 0x23A5354 VA: 0x23A9354
	protected float get_assistMoveTargetDistance() { }

	[CompilerGenerated]
	// RVA: 0x23A935C Offset: 0x23A535C VA: 0x23A935C
	private void set_assistMoveTargetDistance(float value) { }

	// RVA: 0x23A9364 Offset: 0x23A5364 VA: 0x23A9364
	public void UpdateAssistMoveTargetDistance(float assistMoveTargetDistance) { }

	// RVA: 0x23A931C Offset: 0x23A531C VA: 0x23A931C
	protected void .ctor() { }
}
