// Assembly: Assembly-CSharp.dll
// Namespace: 
[Obsolete("徐々にAIEventActionStateBaseに移行します")]
public abstract class AIEventActionState : ActionStateBase // TypeDefIndex: 1580
{
	// Fields
	protected AIEventActionState.AIE_DoneState state; // 0x18
	protected int next_state; // 0x1C
	protected int next_motion_state; // 0x20
	protected int call_script_id; // 0x24
	protected bool need_call_script; // 0x28

	// Methods

	// RVA: 0x208EA98 Offset: 0x208AA98 VA: 0x208EA98
	public void .ctor(IScriptAICentral _central) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract AIEventActionState Clone();

	// RVA: 0x208EAC8 Offset: 0x208AAC8 VA: 0x208EAC8 Slot: 12
	public virtual void SetNextState(int _next_state) { }

	// RVA: 0x208EAD0 Offset: 0x208AAD0 VA: 0x208EAD0 Slot: 13
	public virtual void SetNextMotionState(int _next_motion_id) { }

	// RVA: 0x208EAD8 Offset: 0x208AAD8 VA: 0x208EAD8 Slot: 14
	public virtual void SetCallScriptID(int _call_script_id) { }

	// RVA: 0x208EAE8 Offset: 0x208AAE8 VA: 0x208EAE8 Slot: 15
	public virtual void SetActionState(AIEventActionState.AIE_DoneState _state) { }

	// RVA: 0x208EAF0 Offset: 0x208AAF0 VA: 0x208EAF0 Slot: 9
	public override bool Action() { }

	// RVA: 0x208EAF8 Offset: 0x208AAF8 VA: 0x208EAF8 Slot: 16
	protected virtual void change_state() { }
}
