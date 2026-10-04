// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FamiliaMovingAI : IScriptAICentral // TypeDefIndex: 581
{
	// Fields
	private int action_state; // 0x10
	private GameObject mine; // 0x18
	private GameObject target; // 0x20
	private AnimationBase animation; // 0x28
	private TakeController takeController; // 0x30
	private IMove move; // 0x38
	private PlayerDataManager playerDataManager; // 0x40
	private Dictionary<int, List<ActionStateBase>> actions; // 0x48

	// Properties
	public int ActionNo { get; }
	public AnimationBase Animation { get; }
	public IMove CharaMove { get; }
	public bool ExistMasteryComponent { get; }
	public MasteryScriptAI MasteryScriptAi { get; }
	public GameObject Mine { get; }
	public RouteDataManager RouteManager { get; }
	public GameObject Target { get; }

	// Methods

	// RVA: 0x19070DC Offset: 0x19030DC VA: 0x19070DC
	public int get_ActionNo() { }

	// RVA: 0x19070E4 Offset: 0x19030E4 VA: 0x19070E4 Slot: 7
	public AnimationBase get_Animation() { }

	// RVA: 0x19070EC Offset: 0x19030EC VA: 0x19070EC Slot: 6
	public IMove get_CharaMove() { }

	// RVA: 0x19070F4 Offset: 0x19030F4 VA: 0x19070F4 Slot: 9
	public bool get_ExistMasteryComponent() { }

	// RVA: 0x19070FC Offset: 0x19030FC VA: 0x19070FC Slot: 10
	public MasteryScriptAI get_MasteryScriptAi() { }

	// RVA: 0x1907104 Offset: 0x1903104 VA: 0x1907104 Slot: 4
	public GameObject get_Mine() { }

	// RVA: 0x190710C Offset: 0x190310C VA: 0x190710C Slot: 8
	public RouteDataManager get_RouteManager() { }

	// RVA: 0x1907114 Offset: 0x1903114 VA: 0x1907114 Slot: 5
	public GameObject get_Target() { }

	// RVA: 0x1900DB0 Offset: 0x18FCDB0 VA: 0x1900DB0
	public void .ctor(GameObject _mine, GameObject _target, AnimationBase _animation, TakeController _takeController, IMove _move) { }

	// RVA: 0x1907170 Offset: 0x1903170 VA: 0x1907170 Slot: 11
	public void ChangeStateAction(int _no) { }

	// RVA: 0x19072EC Offset: 0x19032EC VA: 0x19072EC
	public void CallBackChangeMotion(int _animation_id, bool sendEmotion) { }

	// RVA: 0x1903800 Offset: 0x18FF800 VA: 0x1903800
	public void Update() { }

	// RVA: 0x1907434 Offset: 0x1903434 VA: 0x1907434 Slot: 12
	public int GetPropertyData(AIDataProperty _accesser) { }

	// RVA: 0x1902C4C Offset: 0x18FEC4C VA: 0x1902C4C
	public void ReserveSkill() { }

	// RVA: 0x190711C Offset: 0x190311C VA: 0x190711C
	private static bool IsWarp(FieldRoomType type) { }
}
