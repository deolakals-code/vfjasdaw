// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillActionBase.TargetData // TypeDefIndex: 345
{
	// Fields
	[CompilerGenerated]
	private bool <MainTarget>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsHit>k__BackingField; // 0x11
	[CompilerGenerated]
	private CharacterActionManagerBase <ActionManager>k__BackingField; // 0x18
	private int instanceId; // 0x20

	// Properties
	public bool MainTarget { get; set; }
	public bool IsHit { get; set; }
	public CharacterActionManagerBase ActionManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x248B290 Offset: 0x2487290 VA: 0x248B290
	public bool get_MainTarget() { }

	[CompilerGenerated]
	// RVA: 0x248B298 Offset: 0x2487298 VA: 0x248B298
	private void set_MainTarget(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248B2A4 Offset: 0x24872A4 VA: 0x248B2A4
	public bool get_IsHit() { }

	[CompilerGenerated]
	// RVA: 0x248B2AC Offset: 0x24872AC VA: 0x248B2AC
	private void set_IsHit(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248B2B8 Offset: 0x24872B8 VA: 0x248B2B8
	public CharacterActionManagerBase get_ActionManager() { }

	[CompilerGenerated]
	// RVA: 0x248B2C0 Offset: 0x24872C0 VA: 0x248B2C0
	private void set_ActionManager(CharacterActionManagerBase value) { }

	// RVA: 0x248997C Offset: 0x248597C VA: 0x248997C
	public void .ctor(CharacterActionManagerBase actionManager, bool mainTarget) { }

	// RVA: 0x248B2C8 Offset: 0x24872C8 VA: 0x248B2C8
	public bool Match(CharacterActionManagerBase target) { }

	// RVA: 0x248A350 Offset: 0x2486350 VA: 0x248A350
	public void Hit() { }
}
