// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlackKnightMainManager : UIBasePanel // TypeDefIndex: 5846
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor[] panelAnchor; // 0x30
	[SerializeField]
	private UIBlackKnightActionButtonPanel buttonPanel; // 0x38
	[SerializeField]
	protected UIBlackKnightPopWindowPanel popWindowPanel; // 0x40
	[SerializeField]
	private GameObject reinforcePanel; // 0x48
	[SerializeField]
	private UILabel spinaLabel; // 0x50
	[SerializeField]
	private UILabel subSpinaLabel; // 0x58
	[SerializeField]
	private UILabel timeLabel; // 0x60
	[SerializeField]
	private UILabel bestTimeLabel; // 0x68
	[SerializeField]
	private GameObject arrowIconObj; // 0x70
	[SerializeField]
	private GameObject hpPanel; // 0x78
	[SerializeField]
	private UISprite hpIcon; // 0x80
	[SerializeField]
	private GameObject timerPanel; // 0x88
	[SerializeField]
	private GameObject bossHpPanel; // 0x90
	[SerializeField]
	private UISprite bossHpColorBar; // 0x98
	[SerializeField]
	private UISprite bossHpBaseBar; // 0xA0
	[SerializeField]
	private GameObject endWindowObj; // 0xA8
	protected BlackKnightRoomData roomData; // 0xB0
	private GameObject shortcutManager; // 0xB8
	private bool isOpenShortcut; // 0xC0
	private int gold; // 0xC4
	private readonly float[] arrowDirList; // 0xC8
	private int nowHp; // 0xD0
	private List<UISprite> hpIconList; // 0xD8
	private const string timerFormat = "{0:00}:{1:00}:{2:00}";
	private bool isTelop; // 0xE0
	private const float maxHpBarWidth = 430;
	private float damageValue; // 0xE4
	private PlayerDataManager playerDataMangaer; // 0xE8
	private const float barMinWidth = 18;
	private GameObject emotionBarObj; // 0xF0

	// Properties
	private UIMainManager.UIElicitFlag NormalFlag { get; }

	// Methods

	// RVA: 0x180698C Offset: 0x180298C VA: 0x180698C
	private UIMainManager.UIElicitFlag get_NormalFlag() { }

	// RVA: 0x1806994 Offset: 0x1802994 VA: 0x1806994
	private void Awake() { }

	[IteratorStateMachine(typeof(UIBlackKnightMainManager.<Start>d__35))]
	// RVA: 0x1806A5C Offset: 0x1802A5C VA: 0x1806A5C Slot: 7
	protected virtual IEnumerator Start() { }

	// RVA: 0x1806AD0 Offset: 0x1802AD0 VA: 0x1806AD0
	private void Update() { }

	// RVA: 0x1807038 Offset: 0x1803038 VA: 0x1807038
	private void OnDestroy() { }

	// RVA: 0x1807150 Offset: 0x1803150 VA: 0x1807150
	public void SetTimer(float seconds) { }

	// RVA: 0x18072B4 Offset: 0x18032B4 VA: 0x18072B4
	public void ChangeArrowDir(UIBlackKnightMainManager.ArrowType type) { }

	// RVA: 0x1807330 Offset: 0x1803330 VA: 0x1807330
	public void ChangeTopPanelEnable(bool isEnable) { }

	// RVA: 0x1807378 Offset: 0x1803378 VA: 0x1807378
	public void UpdateGoldAction() { }

	// RVA: 0x1806E9C Offset: 0x1802E9C VA: 0x1806E9C
	private void CloseShortcutPanel() { }

	// RVA: 0x1807488 Offset: 0x1803488 VA: 0x1807488 Slot: 8
	protected virtual bool ClosePopWindow() { }

	[IteratorStateMachine(typeof(UIBlackKnightMainManager.<UpdateHp>d__44))]
	// RVA: 0x1806FC4 Offset: 0x1802FC4 VA: 0x1806FC4
	private IEnumerator UpdateHp() { }

	// RVA: 0x18075E8 Offset: 0x18035E8 VA: 0x18075E8 Slot: 9
	public virtual void OnReinforce(int param) { }

	// RVA: 0x18077A0 Offset: 0x18037A0 VA: 0x18077A0
	public void OnGameOver(int param) { }

	// RVA: 0x180785C Offset: 0x180385C VA: 0x180785C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1807A54 Offset: 0x1803A54 VA: 0x1807A54 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1807CF4 Offset: 0x1803CF4 VA: 0x1807CF4 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1807E38 Offset: 0x1803E38 VA: 0x1807E38
	public void .ctor() { }
}
