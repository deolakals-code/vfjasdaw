// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIEAct_EventTriggerBox : AIEventActionStateBase // TypeDefIndex: 1576
{
	// Fields
	private IAIAction[] events; // 0x28
	private AIEventEnumOperator enumOperator; // 0x30

	// Methods

	// RVA: 0x208E548 Offset: 0x208A548 VA: 0x208E548
	public void .ctor(IScriptAICentral _script_central, IAIAction _action, AIEventEnumOperator _operator, IAIAction[] _event) { }

	// RVA: 0x208E6B4 Offset: 0x208A6B4 VA: 0x208E6B4
	public void .ctor(IScriptAICentral _script_central, IAIAction _action, AIEventEnumOperator _operator, bool _limit_action, IAIAction[] _event) { }

	// RVA: 0x208E7E4 Offset: 0x208A7E4 VA: 0x208E7E4 Slot: 11
	public override AIEventActionStateBase Clone() { }

	// RVA: 0x208E85C Offset: 0x208A85C VA: 0x208E85C Slot: 12
	protected override bool cheak_term() { }

	// RVA: 0x208E984 Offset: 0x208A984 VA: 0x208E984
	private bool andOperatorCheck() { }

	// RVA: 0x208E87C Offset: 0x208A87C VA: 0x208E87C
	private bool orOperatorCheck() { }
}
