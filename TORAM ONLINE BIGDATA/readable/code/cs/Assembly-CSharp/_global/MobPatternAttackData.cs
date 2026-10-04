// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class MobPatternAttackData // TypeDefIndex: 790
{
	// Fields
	[CompilerGenerated]
	private MobPatternTargetData <TargetData>k__BackingField; // 0x10
	[CompilerGenerated]
	private Vector3 <AttackPos>k__BackingField; // 0x18
	private AttackArea attackArea; // 0x28

	// Properties
	public MobPatternTargetData TargetData { get; set; }
	public Vector3 AttackPos { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D4E3C8 Offset: 0x1D4A3C8 VA: 0x1D4E3C8
	public MobPatternTargetData get_TargetData() { }

	[CompilerGenerated]
	// RVA: 0x1D4E3D0 Offset: 0x1D4A3D0 VA: 0x1D4E3D0
	private void set_TargetData(MobPatternTargetData value) { }

	[CompilerGenerated]
	// RVA: 0x1D4E3D8 Offset: 0x1D4A3D8 VA: 0x1D4E3D8
	public Vector3 get_AttackPos() { }

	[CompilerGenerated]
	// RVA: 0x1D4E3E4 Offset: 0x1D4A3E4 VA: 0x1D4E3E4
	private void set_AttackPos(Vector3 value) { }

	// RVA: 0x1D4E3F0 Offset: 0x1D4A3F0 VA: 0x1D4E3F0
	public void .ctor(MobPatternTargetData target, Vector3 pos, float attackRange) { }

	// RVA: 0x1D4E540 Offset: 0x1D4A540 VA: 0x1D4E540
	public void ActiveAttackArea() { }

	// RVA: 0x1D4E560 Offset: 0x1D4A560 VA: 0x1D4E560
	public void UpdateAttackPos() { }

	// RVA: 0x1D4E624 Offset: 0x1D4A624 VA: 0x1D4E624
	public void End() { }
}
