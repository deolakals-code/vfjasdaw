// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIE_SwitchLine : ActionStateBase // TypeDefIndex: 1607
{
	// Fields
	private AIEventActionStateBase eventCheck; // 0x18
	private List<IAIAction> trueActions; // 0x20
	private List<IAIAction> falseActions; // 0x28

	// Methods

	// RVA: 0x2093024 Offset: 0x208F024 VA: 0x2093024
	public void .ctor(IScriptAICentral _script_central, IAIAction cheker, List<IAIAction> trueActions, List<IAIAction> falseActions) { }

	// RVA: 0x209313C Offset: 0x208F13C VA: 0x209313C Slot: 9
	public override bool Action() { }
}
