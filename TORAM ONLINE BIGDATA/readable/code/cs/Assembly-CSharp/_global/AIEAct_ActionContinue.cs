// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIEAct_ActionContinue : AIEventActionStateBase // TypeDefIndex: 1582
{
	// Fields
	private AIEventActionStateBase[] events; // 0x28
	private int event_count; // 0x30
	private bool continue_action; // 0x34

	// Properties
	public override bool ContinueAction { get; }

	// Methods

	// RVA: 0x208EE44 Offset: 0x208AE44 VA: 0x208EE44 Slot: 6
	public override bool get_ContinueAction() { }

	// RVA: 0x208EE4C Offset: 0x208AE4C VA: 0x208EE4C
	public void .ctor(IScriptAICentral _script_central, IAIAction _action, AIEventActionStateBase[] _events) { }

	// RVA: 0x208EFB0 Offset: 0x208AFB0 VA: 0x208EFB0 Slot: 11
	public override AIEventActionStateBase Clone() { }

	// RVA: 0x208F020 Offset: 0x208B020 VA: 0x208F020 Slot: 8
	public override void Init() { }

	// RVA: 0x208F02C Offset: 0x208B02C VA: 0x208F02C Slot: 12
	protected override bool cheak_term() { }
}
