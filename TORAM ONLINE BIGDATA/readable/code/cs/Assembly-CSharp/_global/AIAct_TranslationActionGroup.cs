// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIAct_TranslationActionGroup : ActionStateBase // TypeDefIndex: 1612
{
	// Fields
	private int next_state_action_group; // 0x18
	private int next_motion_id; // 0x1C
	private int call_script_id; // 0x20
	private bool need_call_script; // 0x24

	// Methods

	// RVA: 0x2093694 Offset: 0x208F694 VA: 0x2093694
	public void .ctor(IScriptAICentral _script_central, int _next_group_no, int _next_motion_id, int _call_script) { }

	// RVA: 0x2093714 Offset: 0x208F714 VA: 0x2093714
	public void SetNextState(int _next_group_state) { }

	// RVA: 0x209371C Offset: 0x208F71C VA: 0x209371C
	public void SetNextMotionState(int _next_motion_id) { }

	// RVA: 0x2093724 Offset: 0x208F724 VA: 0x2093724 Slot: 11
	public virtual void SetCallScriptID(int _call_script_id) { }

	// RVA: 0x2093734 Offset: 0x208F734 VA: 0x2093734 Slot: 9
	public override bool Action() { }

	// RVA: 0x2093748 Offset: 0x208F748 VA: 0x2093748
	private void change_state() { }
}
