// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScriptAIActionGroupCreator // TypeDefIndex: 1623
{
	// Fields
	private Dictionary<int, ActionStateBase> dic_action; // 0x10
	private Dictionary<int, List<ActionStateBase>> groupdic_action; // 0x18
	private int group_uniqe_id; // 0x20

	// Methods

	// RVA: 0x2097DE8 Offset: 0x2093DE8 VA: 0x2097DE8
	public void .ctor() { }

	// RVA: 0x2097EC8 Offset: 0x2093EC8 VA: 0x2097EC8
	public bool EntryAction(int _entry_action_no, ActionStateBase _act) { }

	[Obsolete("EntryActionで統一しています。")]
	// RVA: 0x2097F90 Offset: 0x2093F90 VA: 0x2097F90
	public bool EntryEventAction(int _entry_action_no, AIEventActionStateBase _event) { }

	[Obsolete("それぞれのアクションでのCloneを行ってください")]
	// RVA: 0x2098058 Offset: 0x2094058 VA: 0x2098058
	public bool EntryCloneEventChangeAction(int _entry_no, int _event_no, IAIAction _action, bool _is_reverse = False) { }

	[Obsolete("EntryAction の形式で、作成してください。")]
	// RVA: 0x20982A8 Offset: 0x20942A8 VA: 0x20982A8
	public bool EntryActionEvent(int _entry_action_no, AIEventActionState _act, int _next_state, int _motion_id) { }

	[Obsolete("EntryAction の形式で、作成してください。")]
	// RVA: 0x209838C Offset: 0x209438C VA: 0x209838C
	public bool EntryActionEventAddScriptEvent(int _entry_action_no, AIEventActionState _act, int _next_state, int _motion_id, int _call_scirpt_id) { }

	[Obsolete("EntryAction の形式で、作成してください。")]
	// RVA: 0x209848C Offset: 0x209448C VA: 0x209848C
	public bool EntryActionEventScriptContinue(int _entry_action_no, IScriptAICentral _manager, int[] _action_types) { }

	// RVA: 0x2098830 Offset: 0x2094830 VA: 0x2098830
	public void EntryActionSummarize(int _entry_action_no, IScriptAICentral _manager, int[] _action_nos) { }

	// RVA: 0x2098B7C Offset: 0x2094B7C VA: 0x2098B7C
	public IAIAction GettingAction(int _action_no) { }

	// RVA: 0x2098C10 Offset: 0x2094C10 VA: 0x2098C10
	public IAIAction[] GettingActions(int[] _action_nos) { }

	// RVA: 0x2098D74 Offset: 0x2094D74 VA: 0x2098D74
	public void CreateActionGroup(int[] _action_types) { }

	// RVA: 0x2098F74 Offset: 0x2094F74 VA: 0x2098F74
	public List<IAIAction> SelectPickUpActionGroup(int[] _action_types) { }

	// RVA: 0x2099140 Offset: 0x2095140 VA: 0x2099140
	public Dictionary<int, List<ActionStateBase>> GetActionGroup() { }
}
