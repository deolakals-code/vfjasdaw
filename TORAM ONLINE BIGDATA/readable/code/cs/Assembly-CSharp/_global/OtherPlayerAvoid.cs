// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OtherPlayerAvoid : OtherPlayerPlayActionDataBase, IOtherPlayerSkillAction // TypeDefIndex: 1212
{
	// Fields
	private float angle; // 0x4C
	[CompilerGenerated]
	private SkillActionBase <SkillAction>k__BackingField; // 0x50

	// Properties
	public SkillActionBase SkillAction { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F8890C Offset: 0x1F8490C VA: 0x1F8890C Slot: 8
	public SkillActionBase get_SkillAction() { }

	[CompilerGenerated]
	// RVA: 0x1F88914 Offset: 0x1F84914 VA: 0x1F88914
	private void set_SkillAction(SkillActionBase value) { }

	// RVA: 0x1F8891C Offset: 0x1F8491C VA: 0x1F8891C
	public void .ctor(CharacterActionManagerBase actor, GameObject target, Vector3 targetPos, float angle) { }

	// RVA: 0x1F88940 Offset: 0x1F84940 VA: 0x1F88940 Slot: 6
	protected override void OnCancel() { }

	// RVA: 0x1F88944 Offset: 0x1F84944 VA: 0x1F88944 Slot: 4
	protected override void OnStart() { }

	// RVA: 0x1F88B30 Offset: 0x1F84B30 VA: 0x1F88B30 Slot: 5
	protected override void OnUpdate() { }

	// RVA: 0x1F88B34 Offset: 0x1F84B34 VA: 0x1F88B34 Slot: 7
	protected override void OnEnd() { }
}
