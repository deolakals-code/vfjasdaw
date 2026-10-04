// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public class AIBlackKnightCentralManager : IBlackBoardMemory // TypeDefIndex: 9110
{
	// Fields
	private bool isActionEndWailFlg; // 0x10
	private Action<MobBlackKnightAIActionType, float[]> callback; // 0x18
	private int stateId; // 0x20
	private int nextResurveStateId; // 0x24
	private MobBlackKnightStateBase[] states; // 0x28
	private int stateNum; // 0x30
	private Stack<IMobBlackKnightTask> task; // 0x38
	private GuideRail guideRail; // 0x40
	private MobStatusMaster mobStatusMaster; // 0x48
	private BlackKnightPlayerManager player; // 0x50
	private BlackKnightMobManagerBase character; // 0x58
	private Vector2 moveRange; // 0x60
	private AIIndicationMaterial material; // 0x68
	[CompilerGenerated]
	private bool <IsInjured>k__BackingField; // 0x70

	// Properties
	public bool IsExistTask { get; }
	public Stack<IMobBlackKnightTask> StackTask { get; }
	public GuideRail Rail { get; }
	public MobStatusMaster Master { get; }
	public float Position { get; }
	public float PlayerPosition { get; }
	public float SearchStartDistance { get; }
	public bool Is3DSetPositon { get; }
	public Vector2 MoveRange { get; }
	public AIIndicationMaterial Material { get; }
	private bool IsBoss { get; }
	public bool IsInjured { get; set; }

	// Methods

	// RVA: 0x1EADABC Offset: 0x1EA9ABC VA: 0x1EADABC Slot: 5
	public bool get_IsExistTask() { }

	// RVA: 0x1EADB10 Offset: 0x1EA9B10 VA: 0x1EADB10 Slot: 6
	public Stack<IMobBlackKnightTask> get_StackTask() { }

	// RVA: 0x1EADB18 Offset: 0x1EA9B18 VA: 0x1EADB18 Slot: 7
	public GuideRail get_Rail() { }

	// RVA: 0x1EADB20 Offset: 0x1EA9B20 VA: 0x1EADB20 Slot: 8
	public MobStatusMaster get_Master() { }

	// RVA: 0x1EADB28 Offset: 0x1EA9B28 VA: 0x1EADB28 Slot: 9
	public float get_Position() { }

	// RVA: 0x1EADB44 Offset: 0x1EA9B44 VA: 0x1EADB44 Slot: 10
	public float get_PlayerPosition() { }

	// RVA: 0x1EADB60 Offset: 0x1EA9B60 VA: 0x1EADB60 Slot: 4
	public float get_SearchStartDistance() { }

	// RVA: 0x1EADB7C Offset: 0x1EA9B7C VA: 0x1EADB7C Slot: 12
	public bool get_Is3DSetPositon() { }

	// RVA: 0x1EADB98 Offset: 0x1EA9B98 VA: 0x1EADB98 Slot: 11
	public Vector2 get_MoveRange() { }

	// RVA: 0x1EADBA0 Offset: 0x1EA9BA0 VA: 0x1EADBA0 Slot: 14
	public AIIndicationMaterial get_Material() { }

	// RVA: 0x1EADBA8 Offset: 0x1EA9BA8 VA: 0x1EADBA8
	private bool get_IsBoss() { }

	[CompilerGenerated]
	// RVA: 0x1EADBC8 Offset: 0x1EA9BC8 VA: 0x1EADBC8 Slot: 13
	public bool get_IsInjured() { }

	[CompilerGenerated]
	// RVA: 0x1EADBD0 Offset: 0x1EA9BD0 VA: 0x1EADBD0
	private void set_IsInjured(bool value) { }

	// RVA: 0x1EADBDC Offset: 0x1EA9BDC VA: 0x1EADBDC
	public void .ctor(BlackKnightPlayerManager playerManager, BlackKnightMobManagerBase characterBase, GuideRail guideRail, MobStatusMaster statusMaster, AIIndicationMaterial material, Action<MobBlackKnightAIActionType, float[]> actionCallBack) { }

	// RVA: 0x1EADE64 Offset: 0x1EA9E64 VA: 0x1EADE64
	public void Update() { }

	// RVA: 0x1EADFC8 Offset: 0x1EA9FC8 VA: 0x1EADFC8
	public void AIUpdatPause() { }

	// RVA: 0x1EAE03C Offset: 0x1EAA03C VA: 0x1EAE03C
	public void ActionEnd() { }

	// RVA: 0x1EAE044 Offset: 0x1EAA044 VA: 0x1EAE044 Slot: 16
	public void CallBackActionMove(MobBlackKnightAIActionType type, float[] moveParam) { }

	// RVA: 0x1EAE0EC Offset: 0x1EAA0EC VA: 0x1EAE0EC Slot: 17
	public void CallBackActionSkill(int skillId) { }

	// RVA: 0x1EAE178 Offset: 0x1EAA178 VA: 0x1EAE178 Slot: 18
	public void SetChangeState(int nextId) { }

	// RVA: 0x1EAE2C8 Offset: 0x1EAA2C8 VA: 0x1EAE2C8
	public void SetDamageFlg() { }

	// RVA: 0x1EAE2D4 Offset: 0x1EAA2D4 VA: 0x1EAE2D4 Slot: 15
	public void SettingTask(IMobBlackKnightTask[] tasks) { }

	// RVA: 0x1EAE048 Offset: 0x1EAA048 VA: 0x1EAE048
	private void EventAction(MobBlackKnightAIActionType type, float[] vals) { }
}
