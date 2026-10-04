// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIAct_TraceTarget : ActionStateBase // TypeDefIndex: 1573
{
	// Fields
	private float trace_move_speed; // 0x18
	private IValiableData data; // 0x20
	private bool is_use_variable_data; // 0x28

	// Properties
	private float MoveSpeed { get; }

	// Methods

	// RVA: 0x208D410 Offset: 0x2089410 VA: 0x208D410
	private float get_MoveSpeed() { }

	// RVA: 0x208D4C8 Offset: 0x20894C8 VA: 0x208D4C8
	public void .ctor(IScriptAICentral _ai_manager, float _trace_move_speed) { }

	// RVA: 0x208D5E8 Offset: 0x20895E8 VA: 0x208D5E8
	public void .ctor(IScriptAICentral _ai_manager, IValiableData _data) { }

	// RVA: 0x208D638 Offset: 0x2089638 VA: 0x208D638 Slot: 9
	public override bool Action() { }
}
