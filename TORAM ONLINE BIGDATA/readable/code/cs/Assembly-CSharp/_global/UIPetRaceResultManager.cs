// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetRaceResultManager : UIBasePanel, PetRaceRoomData.IPetRaceMemberData // TypeDefIndex: 5996
{
	// Fields
	[SerializeField]
	private GameObject[] panels; // 0x30
	[SerializeField]
	private GameObject[] goalResult; // 0x38
	[SerializeField]
	private UILabel[] goalResultLabel; // 0x40
	[SerializeField]
	private GameObject newRecordLabel; // 0x48
	[SerializeField]
	private GameObject multiPanel; // 0x50
	[SerializeField]
	private GameObject[] rankingTimePanel; // 0x58
	[SerializeField]
	private UIPetRaceResultUserPanel[] userRankPanel; // 0x60
	[SerializeField]
	private GameObject[] nextPanels; // 0x68
	[SerializeField]
	private UILabel nextActionWaitLabel; // 0x70
	[SerializeField]
	private GameObject nextTimerPanel; // 0x78
	[SerializeField]
	private GameObject popTelop; // 0x80
	[SerializeField]
	private TweenScale popTelopAnimation; // 0x88
	[SerializeField]
	private UILabel popTelopLabel; // 0x90
	[SerializeField]
	private GameObject newrecordTelop; // 0x98
	[SerializeField]
	private GameObject resultButton; // 0xA0
	private PetRaceRoomData roomData; // 0xA8
	private int mineId; // 0xB0
	private bool isLeader; // 0xB4
	private UIPetRaceResultManager.State acitveState; // 0xB8
	private List<UIPetRaceResultManager.RankData> rankDatas; // 0xC0
	private Dictionary<GameObject, Vector3> resultModel; // 0xC8
	private UIPetRaceResultManager.ReceiveFlag receiveState; // 0xD0
	private float timer; // 0xD4
	private bool isNewrecord; // 0xD8
	private byte goalUserNum; // 0xD9
	private CameraManager cameraManager; // 0xE0
	private PetModelLoader petModelLoader; // 0xE8
	private GameObject shortcutManager; // 0xF0
	private bool openShortcut; // 0xF8
	private int fixedPointCameraActive; // 0xFC

	// Methods

	// RVA: 0x185F65C Offset: 0x185B65C VA: 0x185F65C
	protected void Start() { }

	// RVA: 0x185F928 Offset: 0x185B928 VA: 0x185F928
	private void OnDestroy() { }

	// RVA: 0x185FBFC Offset: 0x185BBFC VA: 0x185FBFC
	protected void Update() { }

	// RVA: 0x18600F0 Offset: 0x185C0F0 VA: 0x18600F0
	private void CheckShortcutPanel() { }

	// RVA: 0x1861114 Offset: 0x185D114 VA: 0x1861114
	private void ActiveChatCommandPanel() { }

	// RVA: 0x1860AC0 Offset: 0x185CAC0 VA: 0x1860AC0
	private void SoroResultPanelActive() { }

	// RVA: 0x186138C Offset: 0x185D38C VA: 0x186138C
	private void ResultPanelFixedPointCameraActive(int activeCamera) { }

	// RVA: 0x1860328 Offset: 0x185C328 VA: 0x1860328
	private void ResultPanlActive() { }

	// RVA: 0x1861058 Offset: 0x185D058 VA: 0x1861058
	private void NextPanlActive() { }

	// RVA: 0x1860220 Offset: 0x185C220 VA: 0x1860220
	private void ActivePanel(UIPetRaceResultManager.State panelType) { }

	// RVA: 0x1861668 Offset: 0x185D668 VA: 0x1861668
	private UIPetRaceResultManager.RankData GetData(int id) { }

	// RVA: 0x1861878 Offset: 0x185D878 VA: 0x1861878
	public void OnClick_ResultEnd() { }

	// RVA: 0x18618DC Offset: 0x185D8DC VA: 0x18618DC
	public void OnClick_NextAction(int type) { }

	// RVA: 0x186199C Offset: 0x185D99C VA: 0x186199C
	public void OnClick_ChangeFixedPointCamera(int add) { }

	// RVA: 0x18619FC Offset: 0x185D9FC VA: 0x18619FC
	public void ReceiveResultPanelData(Dictionary<int, int> ranks, bool newrecord = False) { }

	// RVA: 0x18620AC Offset: 0x185E0AC VA: 0x18620AC Slot: 7
	public void ReceiveRoomData(PetRaceMemberData[] members) { }

	// RVA: 0x186238C Offset: 0x185E38C VA: 0x186238C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1862484 Offset: 0x185E484 VA: 0x1862484
	private void TopReturnButton() { }

	// RVA: 0x186251C Offset: 0x185E51C VA: 0x186251C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18623FC Offset: 0x185E3FC VA: 0x18623FC
	private void TopChatButton() { }

	// RVA: 0x186258C Offset: 0x185E58C VA: 0x186258C Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18626B4 Offset: 0x185E6B4 VA: 0x18626B4
	public void .ctor() { }
}
