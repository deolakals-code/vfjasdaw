// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class BlackKnightSkillActionManagerBase // TypeDefIndex: 4228
{
	// Fields
	[CompilerGenerated]
	private readonly BlackKnightSkillActionBase <CurrentSkill>k__BackingField; // 0x10

	// Properties
	public virtual BlackKnightSkillActionBase CurrentSkill { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24AF344 Offset: 0x24AB344 VA: 0x24AF344 Slot: 4
	public virtual BlackKnightSkillActionBase get_CurrentSkill() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void End();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void UseSkill(GameObject actor, GameObject target, BlackKnightSkillActionBase action);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void ActionCancel();

	// RVA: 0x24AF34C Offset: 0x24AB34C VA: 0x24AF34C
	protected int ConversionMotionSpeed(int speed) { }

	// RVA: 0x24AB9A8 Offset: 0x24A79A8 VA: 0x24AB9A8
	protected void .ctor() { }
}
