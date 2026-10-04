// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRhythmGameManager : UIBasePanel // TypeDefIndex: 6209
{
	// Fields
	[SerializeField]
	protected UIRhythmNotesManager notesManager; // 0x30
	[SerializeField]
	private RhythmButtonManager buttonManager; // 0x38
	[SerializeField]
	private GameObject centerPanel; // 0x40
	[SerializeField]
	private UIGLLabel rankLabel; // 0x48
	[SerializeField]
	private UIGLLabel comboLabel; // 0x50
	[SerializeField]
	private UIRhythmGameTimer rhythmTimer; // 0x58
	[SerializeField]
	private UIRhythmGameBossHp rhythmBossHpBar; // 0x60
	[SerializeField]
	private UIGLLabel waitLabel; // 0x68
	[SerializeField]
	protected UIImageButton giveUpButton; // 0x70
	[SerializeField]
	private UILabel countDownLabel; // 0x78
	[SerializeField]
	private GameObject fullComboObj; // 0x80
	protected RhythmGameManager manager; // 0x88
	private Camera uiCamera; // 0x90
	protected Camera worldCamera; // 0x98
	private List<RhythmButtonManager> buttonManagerList; // 0xA0
	private bool isInitUI; // 0xA8
	private float textTime; // 0xAC
	private short nowCombo; // 0xB0
	private short maxCombo; // 0xB2
	protected Dictionary<int, short> attackList; // 0xB8
	protected Dictionary<int, short> resultList; // 0xC0
	private float connectTimer; // 0xC8
	private const int comboNum = 4;
	private bool isCountDown; // 0xCC
	private float countDownTimer; // 0xD0

	// Properties
	public UIRhythmGameBossHp BossHpPanel { get; }

	// Methods

	// RVA: 0x18B79EC Offset: 0x18B39EC VA: 0x18B79EC
	public UIRhythmGameBossHp get_BossHpPanel() { }

	// RVA: 0x18B79F4 Offset: 0x18B39F4 VA: 0x18B79F4 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0x18B79F8 Offset: 0x18B39F8 VA: 0x18B79F8
	private void Update() { }

	// RVA: 0x18B7E4C Offset: 0x18B3E4C VA: 0x18B7E4C
	public void Initialize() { }

	// RVA: 0x18B84F4 Offset: 0x18B44F4 VA: 0x18B84F4
	protected void TouchEvent(int buttonId, int type) { }

	// RVA: 0x18B85C0 Offset: 0x18B45C0 VA: 0x18B85C0
	private void Tap(int buttonId) { }

	// RVA: 0x18B8884 Offset: 0x18B4884 VA: 0x18B8884
	private void Flick(int buttonId, RhythmNotesData.NotesType type) { }

	// RVA: 0x18B87E0 Offset: 0x18B47E0 VA: 0x18B87E0
	private void PressKeep(int buttonId) { }

	// RVA: 0x18B8834 Offset: 0x18B4834 VA: 0x18B8834
	private void PressOut(int buttonId) { }

	// RVA: 0x18B8DB8 Offset: 0x18B4DB8 VA: 0x18B8DB8
	private void MissEvent() { }

	[IteratorStateMachine(typeof(UIRhythmGameManager.<CreateButton>d__36))]
	// RVA: 0x18B9000 Offset: 0x18B5000 VA: 0x18B9000 Slot: 8
	protected virtual IEnumerator CreateButton() { }

	[IteratorStateMachine(typeof(UIRhythmGameManager.<InitButtonNotes>d__37))]
	// RVA: 0x18B8488 Offset: 0x18B4488 VA: 0x18B8488
	private IEnumerator InitButtonNotes() { }

	// RVA: 0x18B7D98 Offset: 0x18B3D98 VA: 0x18B7D98
	private void UpdateRankLabel() { }

	// RVA: 0x18B8C88 Offset: 0x18B4C88 VA: 0x18B8C88
	protected void UpdateEffects(int buttonId, Color color, RhythmNotesData.RankType rankType, RhythmNotesData.NotesType notesType) { }

	// RVA: 0x18B8EC4 Offset: 0x18B4EC4 VA: 0x18B8EC4
	private void LabelEffect(RhythmNotesData.RankType rankType) { }

	// RVA: 0x18B8A5C Offset: 0x18B4A5C VA: 0x18B8A5C
	protected void UpdateComboLabel(short add) { }

	// RVA: 0x18B90BC Offset: 0x18B50BC VA: 0x18B90BC
	private Color GetEffectColor(RhythmNotesData.RankType rankType) { }

	// RVA: 0x18B8444 Offset: 0x18B4444 VA: 0x18B8444
	private void SetEnableWaitLabel(bool isEnable, string text) { }

	// RVA: 0x18B7C40 Offset: 0x18B3C40 VA: 0x18B7C40
	private void UpdateCountDownTimer() { }

	// RVA: 0x18B90FC Offset: 0x18B50FC VA: 0x18B90FC
	private void ReadyEvent() { }

	// RVA: 0x18B91F4 Offset: 0x18B51F4 VA: 0x18B91F4
	private void PlayEvent() { }

	// RVA: 0x18B92E0 Offset: 0x18B52E0 VA: 0x18B92E0
	private void StartEvent() { }

	// RVA: 0x18B9314 Offset: 0x18B5314 VA: 0x18B9314
	private void ResultEvent() { }

	[IteratorStateMachine(typeof(UIRhythmGameManager.<StartWait>d__49))]
	// RVA: 0x18B9188 Offset: 0x18B5188 VA: 0x18B9188
	private IEnumerator StartWait() { }

	[IteratorStateMachine(typeof(UIRhythmGameManager.<FinishWait>d__50))]
	// RVA: 0x18B9578 Offset: 0x18B5578 VA: 0x18B9578
	private IEnumerator FinishWait() { }

	[IteratorStateMachine(typeof(UIRhythmGameManager.<EnableFullCombo>d__51))]
	// RVA: 0x18B94F0 Offset: 0x18B54F0 VA: 0x18B94F0
	private IEnumerator EnableFullCombo(Action callBack) { }

	// RVA: 0x18B965C Offset: 0x18B565C VA: 0x18B965C
	private void OnPause() { }

	// RVA: 0x18B9678 Offset: 0x18B5678 VA: 0x18B9678 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18B967C Offset: 0x18B567C VA: 0x18B967C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18B9680 Offset: 0x18B5680 VA: 0x18B9680
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18B9780 Offset: 0x18B5780 VA: 0x18B9780
	private void <ResultEvent>b__48_0() { }
}
