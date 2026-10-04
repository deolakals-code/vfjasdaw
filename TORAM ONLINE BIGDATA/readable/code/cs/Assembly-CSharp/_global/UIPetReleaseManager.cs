// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetReleaseManager : UIPetManager // TypeDefIndex: 7834
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x58
	private UIIruna2Anchor mainAnchor; // 0x60
	[SerializeField]
	private GameObject scrollWindowButton; // 0x68
	private List<GameObject> scrollButtonList; // 0x70
	private UICamera uiCamera; // 0x78
	[SerializeField]
	private GameObject dontHaveLabelObj; // 0x80
	[SerializeField]
	private Transform cameraView; // 0x88
	[SerializeField]
	private Transform modelParent; // 0x90
	[SerializeField]
	private GameObject cageObj; // 0x98
	[SerializeField]
	private GameObject petNameLabelObj; // 0xA0
	[SerializeField]
	private UILabel[] typePersonalLabel; // 0xA8
	[SerializeField]
	private UIImageButton releaseButton; // 0xB0
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0xB8
	[SerializeField]
	private UIIruna2Anchor entryNameAnchor; // 0xC0
	[SerializeField]
	private UILabel nameLabel; // 0xC8
	[SerializeField]
	private UILabel pleaseNameLabel; // 0xD0
	[SerializeField]
	private UILabel noPrintNameLabel; // 0xD8
	[SerializeField]
	private UIImageButton nameButton; // 0xE0
	[SerializeField]
	private UILabel nameButtonLabel; // 0xE8
	[SerializeField]
	private GameObject petModelCameraObj; // 0xF0
	[SerializeField]
	private GameObject petScriptFade; // 0xF8
	[SerializeField]
	private GameObject personaPanel; // 0x100
	[SerializeField]
	private UILabel personaExpLabel; // 0x108
	private Dictionary<int, GameObject> petModelObjectList; // 0x110
	private PetModelLoader petModelLoader; // 0x118
	private float playerAngle; // 0x120
	private float buttonHeight; // 0x124
	private GameObject scrollWindowObject; // 0x128
	private UIScrollWindow scrollWindow; // 0x130
	private UIIruna2Anchor scrollAnchor; // 0x138
	private PetInfoData petInfoData; // 0x140
	private List<ItemPetData> itemPetDataList; // 0x148
	private List<ItemData> itemDataList; // 0x150
	private int cageID; // 0x158
	private string nameText; // 0x160
	private float effectTimer; // 0x168
	private bool effectEndFlag; // 0x16C
	private bool popWindow; // 0x16D

	// Methods

	// RVA: 0x1C2F6B4 Offset: 0x1C2B6B4 VA: 0x1C2F6B4 Slot: 7
	protected override void Start() { }

	// RVA: 0x1C2F9E8 Offset: 0x1C2B9E8 VA: 0x1C2F9E8
	private void OnDestroy() { }

	// RVA: 0x1C2F7D4 Offset: 0x1C2B7D4 VA: 0x1C2F7D4
	private void initializeScrollWindow() { }

	// RVA: 0x1C2FA40 Offset: 0x1C2BA40 VA: 0x1C2FA40
	private void initializeScrollButton() { }

	// RVA: 0x1C2F978 Offset: 0x1C2B978 VA: 0x1C2F978
	private void initialize() { }

	// RVA: 0x1C30688 Offset: 0x1C2C688 VA: 0x1C30688
	private void Update() { }

	// RVA: 0x1C30290 Offset: 0x1C2C290 VA: 0x1C30290
	private void addCageButton(int index, string name, bool cage) { }

	// RVA: 0x1C307F8 Offset: 0x1C2C7F8 VA: 0x1C307F8
	private void onClick(int param) { }

	[IteratorStateMachine(typeof(UIPetReleaseManager.<onRelease>d__46))]
	// RVA: 0x1C310C8 Offset: 0x1C2D0C8 VA: 0x1C310C8
	private IEnumerator onRelease() { }

	// RVA: 0x1C3115C Offset: 0x1C2D15C VA: 0x1C3115C
	private void onEnter() { }

	// RVA: 0x1C31220 Offset: 0x1C2D220 VA: 0x1C31220
	private void onCloseWindow() { }

	[IteratorStateMachine(typeof(UIPetReleaseManager.<PetNaming>d__49))]
	// RVA: 0x1C31190 Offset: 0x1C2D190 VA: 0x1C31190
	private IEnumerator PetNaming(long id, string name) { }

	// RVA: 0x1C3129C Offset: 0x1C2D29C VA: 0x1C3129C
	private void EndNameChange() { }

	[IteratorStateMachine(typeof(UIPetReleaseManager.<WindowEnable>d__51))]
	// RVA: 0x1C31654 Offset: 0x1C2D654 VA: 0x1C31654
	private IEnumerator WindowEnable(bool flag) { }

	// RVA: 0x1C316FC Offset: 0x1C2D6FC VA: 0x1C316FC
	public void OnClick_SubmitActive() { }

	// RVA: 0x1C31700 Offset: 0x1C2D700 VA: 0x1C31700
	public void OnSubmitName() { }

	[IteratorStateMachine(typeof(UIPetReleaseManager.<UpdateNameLabel>d__54))]
	// RVA: 0x1C317D0 Offset: 0x1C2D7D0 VA: 0x1C317D0
	private IEnumerator UpdateNameLabel() { }

	// RVA: 0x1C30DCC Offset: 0x1C2CDCC VA: 0x1C30DCC
	private void LoadPetModel() { }

	// RVA: 0x1C30514 Offset: 0x1C2C514 VA: 0x1C30514
	private void DeleteModel() { }

	[IteratorStateMachine(typeof(UIPetReleaseManager.<LoadModel>d__57))]
	// RVA: 0x1C31864 Offset: 0x1C2D864 VA: 0x1C31864
	private IEnumerator LoadModel() { }

	// RVA: 0x1C318F8 Offset: 0x1C2D8F8 VA: 0x1C318F8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C31988 Offset: 0x1C2D988 VA: 0x1C31988 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C31A18 Offset: 0x1C2DA18 VA: 0x1C31A18
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C31C60 Offset: 0x1C2DC60 VA: 0x1C31C60
	private void <PetNaming>b__49_0(Game game, HousePetNamingResponse response) { }
}
