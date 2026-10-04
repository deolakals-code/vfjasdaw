// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class AIEventActionStateBase : ActionStateBase // TypeDefIndex: 1581
{
	// Fields
	protected IAIAction action; // 0x18
	protected bool is_reverse; // 0x20
	private bool not_action; // 0x21

	// Properties
	public IAIAction ActionReference { get; }

	// Methods

	// RVA: 0x208EC6C Offset: 0x208AC6C VA: 0x208EC6C
	public IAIAction get_ActionReference() { }

	// RVA: 0x208E670 Offset: 0x208A670 VA: 0x208E670
	public void .ctor(IScriptAICentral _script_central, IAIAction _action) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract AIEventActionStateBase Clone();

	// RVA: 0x208EC74 Offset: 0x208AC74 VA: 0x208EC74
	public void ReSet(IAIAction _action) { }

	// RVA: 0x208ECAC Offset: 0x208ACAC VA: 0x208ECAC Slot: 8
	public override void Init() { }

	// RVA: 0x208ED4C Offset: 0x208AD4C VA: 0x208ED4C
	public void SetIsReverseRange(bool _reverse_state) { }

	// RVA: 0x208ED58 Offset: 0x208AD58 VA: 0x208ED58
	public void SetActionHandle(bool _action_handle) { }

	// RVA: 0x208ED64 Offset: 0x208AD64 VA: 0x208ED64 Slot: 9
	public override bool Action() { }

	// RVA: 0x208EE3C Offset: 0x208AE3C VA: 0x208EE3C Slot: 12
	protected virtual bool cheak_term() { }
}
