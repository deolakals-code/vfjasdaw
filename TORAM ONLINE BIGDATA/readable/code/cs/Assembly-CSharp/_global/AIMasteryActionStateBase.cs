// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class AIMasteryActionStateBase : IAIAction // TypeDefIndex: 1609
{
	// Fields
	protected MasteryScriptAI mastery_ai; // 0x10

	// Methods

	// RVA: 0x209344C Offset: 0x208F44C VA: 0x209344C
	public void .ctor(MasteryScriptAI _mastery_script_ai) { }

	// RVA: 0x2093454 Offset: 0x208F454 VA: 0x2093454 Slot: 6
	public virtual void OnDrawGizmo() { }

	// RVA: 0x2093458 Offset: 0x208F458 VA: 0x2093458 Slot: 7
	public virtual void Init() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Action();
}
