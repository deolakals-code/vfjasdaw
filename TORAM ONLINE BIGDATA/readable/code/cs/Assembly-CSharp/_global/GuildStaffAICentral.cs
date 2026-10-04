// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(CharacterMove))]
public class GuildStaffAICentral : MonoBehaviour, IScriptAICentral // TypeDefIndex: 1194
{
	// Fields
	protected int doneActionNo; // 0x20
	protected bool changeStateFlg; // 0x24
	protected IMove charaMove; // 0x28
	protected Dictionary<int, List<ActionStateBase>> aiActionDic; // 0x30
	protected AnimationBase animation; // 0x38
	protected RouteDataManager routeData; // 0x40
	protected GameObject player; // 0x48
	protected bool isMyGuild; // 0x50
	[CompilerGenerated]
	private bool <IsMan>k__BackingField; // 0x51

	// Properties
	public int ActionNo { get; }
	public AnimationBase Animation { get; }
	public IMove CharaMove { get; }
	public bool ExistMasteryComponent { get; }
	public MasteryScriptAI MasteryScriptAi { get; }
	public GameObject Mine { get; }
	public RouteDataManager RouteManager { get; }
	public virtual GameObject Target { get; }
	public bool IsMan { get; set; }
	public virtual bool IsWaiting { get; }

	// Methods

	// RVA: 0x1F7EED0 Offset: 0x1F7AED0 VA: 0x1F7EED0
	public int get_ActionNo() { }

	// RVA: 0x1F7EED8 Offset: 0x1F7AED8 VA: 0x1F7EED8 Slot: 7
	public AnimationBase get_Animation() { }

	// RVA: 0x1F7EEE0 Offset: 0x1F7AEE0 VA: 0x1F7EEE0 Slot: 6
	public IMove get_CharaMove() { }

	// RVA: 0x1F7EF4C Offset: 0x1F7AF4C VA: 0x1F7EF4C Slot: 9
	public bool get_ExistMasteryComponent() { }

	// RVA: 0x1F7EF54 Offset: 0x1F7AF54 VA: 0x1F7EF54 Slot: 10
	public MasteryScriptAI get_MasteryScriptAi() { }

	// RVA: 0x1F7EF5C Offset: 0x1F7AF5C VA: 0x1F7EF5C Slot: 4
	public GameObject get_Mine() { }

	// RVA: 0x1F7EF64 Offset: 0x1F7AF64 VA: 0x1F7EF64 Slot: 8
	public RouteDataManager get_RouteManager() { }

	// RVA: 0x1F7EF6C Offset: 0x1F7AF6C VA: 0x1F7EF6C Slot: 13
	public virtual GameObject get_Target() { }

	[CompilerGenerated]
	// RVA: 0x1F7EFF0 Offset: 0x1F7AFF0 VA: 0x1F7EFF0
	private void set_IsMan(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F7EFFC Offset: 0x1F7AFFC VA: 0x1F7EFFC
	public bool get_IsMan() { }

	// RVA: 0x1F7F004 Offset: 0x1F7B004 VA: 0x1F7F004 Slot: 14
	public virtual bool get_IsWaiting() { }

	// RVA: 0x1F7F00C Offset: 0x1F7B00C VA: 0x1F7F00C
	private void Awake() { }

	// RVA: 0x1F7F074 Offset: 0x1F7B074 VA: 0x1F7F074 Slot: 11
	public void ChangeStateAction(int _no) { }

	// RVA: 0x1F7F204 Offset: 0x1F7B204 VA: 0x1F7F204
	public bool CheckActionNo(int _no) { }

	// RVA: 0x1F7F214 Offset: 0x1F7B214 VA: 0x1F7F214 Slot: 15
	public virtual void Initialize(bool isMan, Vector3 pos, float rot) { }

	// RVA: 0x1F7F344 Offset: 0x1F7B344 VA: 0x1F7F344 Slot: 16
	protected virtual void Update() { }

	// RVA: 0x1F7F508 Offset: 0x1F7B508 VA: 0x1F7F508 Slot: 17
	protected virtual void CreateAction(bool isMan) { }

	// RVA: 0x1F7F59C Offset: 0x1F7B59C VA: 0x1F7F59C Slot: 18
	public virtual void ChangeWaitingAction(bool isStop) { }

	// RVA: 0x1F7F5A0 Offset: 0x1F7B5A0 VA: 0x1F7F5A0 Slot: 19
	public virtual void EnterField() { }

	// RVA: 0x1F7F728 Offset: 0x1F7B728 VA: 0x1F7F728
	public void LeaveField() { }

	// RVA: 0x1F7F72C Offset: 0x1F7B72C VA: 0x1F7F72C Slot: 12
	public int GetPropertyData(AIDataProperty _accesser) { }

	// RVA: 0x1F7F764 Offset: 0x1F7B764 VA: 0x1F7F764
	public void .ctor() { }
}
