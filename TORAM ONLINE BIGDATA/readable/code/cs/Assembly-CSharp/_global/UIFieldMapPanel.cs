// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFieldMapPanel : UIMapBasePanel // TypeDefIndex: 7374
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor fieldNameAnchor; // 0x20
	[SerializeField]
	private UILabel fieldNameLabel; // 0x28
	[SerializeField]
	private UISprite fieldNameBackground; // 0x30
	private GameObject playerModel; // 0x38
	private Vector3 stick; // 0x40
	private GameObject stage; // 0x50
	private MeshRenderer floorRender; // 0x58
	private MeshFilter floorFilter; // 0x60
	[SerializeField]
	private Material miniMapMaterial; // 0x68
	[SerializeField]
	private Camera controlCamera; // 0x70
	[SerializeField]
	private Transform controlCameraView; // 0x78
	private float miniMapScale; // 0x80
	private List<GameObject> modelList; // 0x88
	[SerializeField]
	private UIIruna2Anchor powerGaugeAnchor; // 0x90
	[SerializeField]
	private GameObject powerGaugePopUpButton; // 0x98
	[SerializeField]
	private UISprite enemyPowerGauge; // 0xA0
	[SerializeField]
	private UISprite playerPowerGauge; // 0xA8
	[SerializeField]
	private UISprite powerGauge; // 0xB0
	[SerializeField]
	private TweenPosition enemyPowerGaugeTween; // 0xB8
	[SerializeField]
	private TweenPosition playerPowerGaugeTween; // 0xC0
	[SerializeField]
	private Transform powerGaugeIcon; // 0xC8
	[SerializeField]
	private GameObject popIcon; // 0xD0
	[SerializeField]
	private GameObject areaBonusOption; // 0xD8
	[SerializeField]
	private UIToggle areaBonusOptionCheckBox; // 0xE0
	[SerializeField]
	private UILabel areaBonusOptionLabel; // 0xE8
	private readonly int ChangeAreaBonusAccountProgress; // 0xF0
	private bool isEnabledChangeAreaBonus; // 0xF4
	private bool isAreaBonusLockOption; // 0xF5
	[SerializeField]
	private GameObject popEventLabel; // 0xF8
	[SerializeField]
	private UILabel eventLabel; // 0x100
	[SerializeField]
	private UISprite iconEventObj; // 0x108
	[SerializeField]
	private GameObject popMobLabel; // 0x110
	[SerializeField]
	private UILabel mobLabel; // 0x118
	[SerializeField]
	private GameObject tapPopIcon; // 0x120
	[SerializeField]
	private GameObject tapPopLabel; // 0x128
	[SerializeField]
	private GameObject tapDropWindowChild; // 0x130
	private List<UIFieldMapPanel.PopData> popDataList; // 0x138
	private float resetTimer; // 0x140
	private UIFieldMapPanel.PopData popSelected; // 0x148
	private List<int> questItemList; // 0x168
	private SystemTextManager systemTextManager; // 0x170
	private bool initCheck; // 0x178
	private bool isClose; // 0x179
	private bool popUpWindowActive; // 0x17A
	private Mesh floorMesh; // 0x180
	private int meshLayer; // 0x188

	// Properties
	public override bool IsTapLock { get; }

	// Methods

	// RVA: 0x1B2BFB0 Offset: 0x1B27FB0 VA: 0x1B2BFB0 Slot: 4
	public override bool get_IsTapLock() { }

	[IteratorStateMachine(typeof(UIFieldMapPanel.<Initialize>d__50))]
	// RVA: 0x1B2BFB8 Offset: 0x1B27FB8 VA: 0x1B2BFB8 Slot: 5
	public override IEnumerator Initialize(UIMapMainPanelManager manager, PlayerDataManager playerDataManager, GameObject model, int fieldId, FieldTextManager fieldTextManager) { }

	// RVA: 0x1B2C06C Offset: 0x1B2806C VA: 0x1B2C06C
	private GameObject SetCopyModel(GameObject model, Vector3 position) { }

	// RVA: 0x1B2C420 Offset: 0x1B28420 VA: 0x1B2C420
	private void CheckFieldName(bool fadeOut) { }

	// RVA: 0x1B2C538 Offset: 0x1B28538 VA: 0x1B2C538
	private void OnDestroy() { }

	// RVA: 0x1B2C900 Offset: 0x1B28900 VA: 0x1B2C900
	private void PopLabelClose() { }

	// RVA: 0x1B2CA58 Offset: 0x1B28A58 VA: 0x1B2CA58 Slot: 6
	public override void Open() { }

	// RVA: 0x1B2CDE4 Offset: 0x1B28DE4 VA: 0x1B2CDE4 Slot: 7
	public override void Close() { }

	// RVA: 0x1B2C95C Offset: 0x1B2895C VA: 0x1B2C95C
	private void TapReset() { }

	// RVA: 0x1B2CEE8 Offset: 0x1B28EE8 VA: 0x1B2CEE8
	private void Update() { }

	// RVA: 0x1B2D034 Offset: 0x1B29034 VA: 0x1B2D034 Slot: 8
	public override Vector3 Control(Vector3 drag) { }

	// RVA: 0x1B2D364 Offset: 0x1B29364 VA: 0x1B2D364 Slot: 9
	public override bool PushLeftTopButton() { }

	// RVA: 0x1B2D37C Offset: 0x1B2937C VA: 0x1B2D37C Slot: 10
	public override void OnPress(bool pressed) { }

	// RVA: 0x1B2D390 Offset: 0x1B29390 VA: 0x1B2D390 Slot: 11
	public override void OnClick() { }

	// RVA: 0x1B2D77C Offset: 0x1B2977C VA: 0x1B2D77C Slot: 12
	public override void OnDrag(Vector2 delta) { }

	// RVA: 0x1B2D78C Offset: 0x1B2978C VA: 0x1B2D78C
	private void OnPopMessage() { }

	// RVA: 0x1B2DD50 Offset: 0x1B29D50 VA: 0x1B2DD50
	public void OnChangeAreaBonusOption() { }

	// RVA: 0x1B2DDA0 Offset: 0x1B29DA0 VA: 0x1B2DDA0
	private void OnPopDropData() { }

	[IteratorStateMachine(typeof(UIFieldMapPanel.<PopUpWrapWindow>d__67))]
	// RVA: 0x1B2DCAC Offset: 0x1B29CAC VA: 0x1B2DCAC
	private IEnumerator PopUpWrapWindow(UIPopBaseWindow window, Action callback) { }

	// RVA: 0x1B2E138 Offset: 0x1B2A138 VA: 0x1B2E138
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B2E36C Offset: 0x1B2A36C VA: 0x1B2E36C
	private void <OnPopMessage>b__64_0() { }
}
