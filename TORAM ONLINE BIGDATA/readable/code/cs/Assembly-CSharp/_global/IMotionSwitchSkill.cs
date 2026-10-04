// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IMotionSwitchSkill // TypeDefIndex: 3378
{
	// Properties
	public abstract MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MotionSwitchType get_MotionSwitchType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType);
}
