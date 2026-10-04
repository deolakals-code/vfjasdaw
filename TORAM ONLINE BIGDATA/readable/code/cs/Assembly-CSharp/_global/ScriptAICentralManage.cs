// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScriptAICentralManage : MonoBehaviour, IScriptAICentral // TypeDefIndex: 1624
{
	// Fields
	private GameObject player; // 0x20
	private Dictionary<int, List<ActionStateBase>> script_action; // 0x28
	private IMove chara_move; // 0x30
	private AnimationBase anime; // 0x38
	private int done_action_no; // 0x40
	private bool change_state_break; // 0x44
	private bool is_exist_script_componet_data; // 0x45
	[CompilerGenerated]
	private RouteDataManager <RouteManager>k__BackingField; // 0x48
	[CompilerGenerated]
	private MasteryScriptAI <MasteryScriptAi>k__BackingField; // 0x50

	// Properties
	public GameObject Target { get; }
	public IMove CharaMove { get; }
	public int ActionNo { get; }
	public RouteDataManager RouteManager { get; set; }
	public AnimationBase Animation { get; }
	public GameObject Mine { get; }
	public bool ExistMasteryComponent { get; }
	public MasteryScriptAI MasteryScriptAi { get; set; }

	// Methods

	// RVA: 0x2099148 Offset: 0x2095148 VA: 0x2099148 Slot: 5
	public GameObject get_Target() { }

	// RVA: 0x20991DC Offset: 0x20951DC VA: 0x20991DC Slot: 6
	public IMove get_CharaMove() { }

	// RVA: 0x2099248 Offset: 0x2095248 VA: 0x2099248
	public int get_ActionNo() { }

	[CompilerGenerated]
	// RVA: 0x2099250 Offset: 0x2095250 VA: 0x2099250 Slot: 8
	public RouteDataManager get_RouteManager() { }

	[CompilerGenerated]
	// RVA: 0x2099258 Offset: 0x2095258 VA: 0x2099258
	public void set_RouteManager(RouteDataManager value) { }

	// RVA: 0x2099260 Offset: 0x2095260 VA: 0x2099260 Slot: 7
	public AnimationBase get_Animation() { }

	// RVA: 0x2099308 Offset: 0x2095308 VA: 0x2099308 Slot: 4
	public GameObject get_Mine() { }

	// RVA: 0x2099310 Offset: 0x2095310 VA: 0x2099310 Slot: 9
	public bool get_ExistMasteryComponent() { }

	[CompilerGenerated]
	// RVA: 0x2099318 Offset: 0x2095318 VA: 0x2099318 Slot: 10
	public MasteryScriptAI get_MasteryScriptAi() { }

	[CompilerGenerated]
	// RVA: 0x2099320 Offset: 0x2095320 VA: 0x2099320
	private void set_MasteryScriptAi(MasteryScriptAI value) { }

	// RVA: 0x2099328 Offset: 0x2095328 VA: 0x2099328 Slot: 11
	public void ChangeStateAction(int _no) { }

	// RVA: 0x2099668 Offset: 0x2095668 VA: 0x2099668
	public void SetActionPattern(Dictionary<int, List<ActionStateBase>> _action_pattern_data) { }

	// RVA: 0x2099670 Offset: 0x2095670 VA: 0x2099670
	public void StartUpMastary() { }

	// RVA: 0x209971C Offset: 0x209571C VA: 0x209971C
	private void Awake() { }

	// RVA: 0x2099720 Offset: 0x2095720 VA: 0x2099720
	private void Start() { }

	// RVA: 0x2099724 Offset: 0x2095724 VA: 0x2099724
	private void Update() { }

	// RVA: 0x209993C Offset: 0x209593C VA: 0x209993C
	private void OnDestroy() { }

	// RVA: 0x20998D4 Offset: 0x20958D4 VA: 0x20998D4
	private bool ready_operation() { }

	// RVA: 0x2099940 Offset: 0x2095940 VA: 0x2099940 Slot: 12
	public int GetPropertyData(AIDataProperty _accesser) { }

	// RVA: 0x2099948 Offset: 0x2095948 VA: 0x2099948
	public void .ctor() { }
}
