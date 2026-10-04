// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRhythmGameEnterManager : UIBasePanel // TypeDefIndex: 6198
{
	// Fields
	[SerializeField]
	private GameObject inRoomPanel; // 0x30
	[SerializeField]
	private GameObject outRoomPanel; // 0x38
	[SerializeField]
	private GameObject[] partyMemberObj; // 0x40
	[SerializeField]
	protected UIRhythmGameSelectMusic selectMusicPanel; // 0x48
	[SerializeField]
	private UIRhythmGameSelectMode selectModePanel; // 0x50
	[SerializeField]
	private UIRhythmGameSettingPanel settingPanel; // 0x58
	[SerializeField]
	private GameObject settingButton; // 0x60
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x69
	private UIRhythmGameBasePanel rhythmGamePanel; // 0x70
	private bool isInitUI; // 0x78
	private GameObject shortcutManager; // 0x80
	protected bool isOpenShortcut; // 0x88
	private float connectTimer; // 0x8C
	private GameObject emotionBarObj; // 0x90
	private PlayerDataManager playerDataManager; // 0x98
	private RhythmGameManager rhythmGameManager; // 0xA0

	// Properties
	public bool IsCancel { get; set; }
	public bool IsClose { get; set; }
	public UIRhythmGameSelectMusic SelectMusicPanel { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18B563C Offset: 0x18B163C VA: 0x18B563C
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x18B5644 Offset: 0x18B1644 VA: 0x18B5644
	private void set_IsCancel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x18B5650 Offset: 0x18B1650 VA: 0x18B5650
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x18B5658 Offset: 0x18B1658 VA: 0x18B5658
	private void set_IsClose(bool value) { }

	// RVA: 0x18B5664 Offset: 0x18B1664 VA: 0x18B5664
	public UIRhythmGameSelectMusic get_SelectMusicPanel() { }

	// RVA: 0x18B566C Offset: 0x18B166C VA: 0x18B566C Slot: 7
	public virtual void UpdateSelectMusicPanel(RhythmSettingData data) { }

	// RVA: 0x18B5734 Offset: 0x18B1734 VA: 0x18B5734
	public void OnSetting() { }

	// RVA: 0x18B58B4 Offset: 0x18B18B4 VA: 0x18B58B4 Slot: 8
	protected virtual void Awake() { }

	// RVA: 0x18B5A34 Offset: 0x18B1A34 VA: 0x18B5A34
	private void Start() { }

	// RVA: 0x18B5F50 Offset: 0x18B1F50 VA: 0x18B5F50
	private void Update() { }

	// RVA: 0x18B6358 Offset: 0x18B2358 VA: 0x18B6358
	private void OnDestroy() { }

	// RVA: 0x18B6474 Offset: 0x18B2474 VA: 0x18B6474
	private void BattleReady() { }

	// RVA: 0x18B6574 Offset: 0x18B2574 VA: 0x18B6574
	private void BattleReadyCancel() { }

	// RVA: 0x18B6238 Offset: 0x18B2238 VA: 0x18B6238
	private void CloseShortcutPanel() { }

	// RVA: 0x18B5EBC Offset: 0x18B1EBC VA: 0x18B5EBC
	private void Leave() { }

	[IteratorStateMachine(typeof(UIRhythmGameEnterManager.<LeaveWait>d__35))]
	// RVA: 0x18B6600 Offset: 0x18B2600 VA: 0x18B6600
	private IEnumerator LeaveWait() { }

	[IteratorStateMachine(typeof(UIRhythmGameEnterManager.<WaitLoadNotes>d__36))]
	// RVA: 0x18B5EE4 Offset: 0x18B1EE4 VA: 0x18B5EE4
	private IEnumerator WaitLoadNotes() { }

	// RVA: 0x18B573C Offset: 0x18B173C VA: 0x18B573C
	private void ChangeActiveSettingPanel(bool isActive) { }

	// RVA: 0x18B66BC Offset: 0x18B26BC VA: 0x18B66BC
	private bool TryCloseSettingPanel() { }

	// RVA: 0x18B6774 Offset: 0x18B2774 VA: 0x18B6774 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18B6A38 Offset: 0x18B2A38 VA: 0x18B6A38 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18B6BA0 Offset: 0x18B2BA0 VA: 0x18B6BA0 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18B6C40 Offset: 0x18B2C40 VA: 0x18B6C40
	public void .ctor() { }
}
