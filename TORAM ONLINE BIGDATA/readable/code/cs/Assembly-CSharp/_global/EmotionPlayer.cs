// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EmotionPlayer : MonoBehaviour // TypeDefIndex: 1382
{
	// Fields
	protected Dictionary<EmotionPlayer.EmotionType, int> emotionList; // 0x20
	protected CharacterActionManagerBase charaActManager; // 0x28
	protected TakeController takeController; // 0x30
	private int playTakeId; // 0x38
	private int takePlayerUid; // 0x3C
	private EmotionPlayer.EmotionType playEmotion; // 0x40
	private EmotionPlayer.EmotionType pendingGameEffectEmotion; // 0x44
	protected CharacterMove charaMove; // 0x48
	private BattleManagerBase battleManagerBase; // 0x50
	private float behaviorTimer; // 0x58
	private bool moveEmotionStop; // 0x5C
	private bool moveEmotionSkip; // 0x5D
	private bool isEmotionMove; // 0x5E
	private bool isCancelEmotionMove; // 0x5F
	protected bool initFlag; // 0x60
	private int reservationId; // 0x64
	protected bool IsPlayer; // 0x68
	protected bool IsManaged; // 0x69
	private bool IsMan; // 0x6A
	protected AutoMemberManager autoMemberManager; // 0x70
	protected PlayerAnimation playerAnimation; // 0x78
	private Dictionary<ActionCode, int> emotionReconnection; // 0x80
	private bool isCanceling; // 0x88
	private int playFieldEmotionId; // 0x8C
	private bool childTakeStopFlg; // 0x90

	// Properties
	public bool IsMoveLock { get; }
	public bool IsShit { get; }
	public EmotionPlayer.EmotionType GetNowEmotionType { get; }
	private BattleManagerBase battleManager { get; }
	public bool MoveEmotionStop { get; }
	public bool InitFlag { get; }
	private bool stateCheck { get; }

	// Methods

	// RVA: 0x1FE3590 Offset: 0x1FDF590 VA: 0x1FE3590
	public static EmotionPlayer.EmotionType[] GetEmotionList() { }

	// RVA: 0x1FE3600 Offset: 0x1FDF600 VA: 0x1FE3600
	public static void AddUnlockUserEmotionList(AvatarVariableType type, int bit, List<EmotionPlayer.EmotionType> userUsedList) { }

	// RVA: 0x1FE377C Offset: 0x1FDF77C VA: 0x1FE377C
	public bool get_IsMoveLock() { }

	// RVA: 0x1FE37BC Offset: 0x1FDF7BC VA: 0x1FE37BC
	public bool get_IsShit() { }

	// RVA: 0x1FE39AC Offset: 0x1FDF9AC VA: 0x1FE39AC
	public EmotionPlayer.EmotionType get_GetNowEmotionType() { }

	// RVA: 0x1FE39B4 Offset: 0x1FDF9B4 VA: 0x1FE39B4
	private BattleManagerBase get_battleManager() { }

	// RVA: 0x1FE3A5C Offset: 0x1FDFA5C VA: 0x1FE3A5C
	public bool get_MoveEmotionStop() { }

	// RVA: 0x1FE3A64 Offset: 0x1FDFA64 VA: 0x1FE3A64
	public bool get_InitFlag() { }

	// RVA: 0x1FE3A6C Offset: 0x1FDFA6C VA: 0x1FE3A6C
	private bool get_stateCheck() { }

	// RVA: 0x1FE3B78 Offset: 0x1FDFB78 VA: 0x1FE3B78 Slot: 4
	protected virtual void Initialized() { }

	// RVA: 0x1FE4828 Offset: 0x1FE0828 VA: 0x1FE4828
	public void Initialize(bool man) { }

	// RVA: 0x1FE4AA0 Offset: 0x1FE0AA0 VA: 0x1FE4AA0
	private void AddUpdateEmotion(EmotionPlayer.EmotionType type, int id) { }

	// RVA: 0x1FE4B30 Offset: 0x1FE0B30 VA: 0x1FE4B30
	private void Update() { }

	// RVA: 0x1FE5608 Offset: 0x1FE1608 VA: 0x1FE5608
	public void PlayFieldEmotion(int id) { }

	// RVA: 0x1FE578C Offset: 0x1FE178C VA: 0x1FE578C
	public void CheckEmotionPlay(EmotionPlayer.EmotionType id) { }

	// RVA: 0x1FE57DC Offset: 0x1FE17DC VA: 0x1FE57DC
	public bool InterruptPlay(EmotionPlayer.EmotionType id) { }

	// RVA: 0x1FE506C Offset: 0x1FE106C VA: 0x1FE506C
	public void Play(EmotionPlayer.EmotionType id) { }

	// RVA: 0x1FE6450 Offset: 0x1FE2450 VA: 0x1FE6450
	public void Stop() { }

	// RVA: 0x1FE56B0 Offset: 0x1FE16B0 VA: 0x1FE56B0
	public void StopEvent() { }

	// RVA: 0x1FE63CC Offset: 0x1FE23CC VA: 0x1FE63CC
	private void SetPendingGameEffectEmotion(EmotionPlayer.EmotionType id) { }

	// RVA: 0x1FE63E8 Offset: 0x1FE23E8 VA: 0x1FE63E8
	private bool IsGameEffectTakeLost() { }

	// RVA: 0x1FE6518 Offset: 0x1FE2518 VA: 0x1FE6518
	private void OnTakeEmotionEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x1FE54C0 Offset: 0x1FE14C0 VA: 0x1FE54C0
	private void EndEmotion() { }

	// RVA: 0x1FE5AE4 Offset: 0x1FE1AE4 VA: 0x1FE5AE4
	private int PetRespawnEmotion() { }

	// RVA: 0x1FE6198 Offset: 0x1FE2198 VA: 0x1FE6198
	private bool OtherPlayerEmotionCancelCheck(EmotionPlayer.EmotionType id) { }

	// RVA: 0x1FE622C Offset: 0x1FE222C VA: 0x1FE622C
	private bool MoveSwitchEmoitonCheck(int id) { }

	// RVA: 0x1FE6788 Offset: 0x1FE2788 VA: 0x1FE6788
	public void MoveEmotionCancel() { }

	// RVA: 0x1FE6610 Offset: 0x1FE2610 VA: 0x1FE6610
	public void AddReconnectionEmotionCancel() { }

	// RVA: 0x1FE6838 Offset: 0x1FE2838 VA: 0x1FE6838
	public void RemoveReconnectionEmotionCancel() { }

	// RVA: 0x1FE6024 Offset: 0x1FE2024 VA: 0x1FE6024
	private Dictionary<TakeParameterType, int> SettingTakeParameter(EmotionPlayer.EmotionType type) { }

	// RVA: 0x1FE6928 Offset: 0x1FE2928 VA: 0x1FE6928
	public void .ctor() { }
}
