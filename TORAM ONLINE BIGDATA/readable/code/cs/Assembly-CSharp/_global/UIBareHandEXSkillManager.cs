// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBareHandEXSkillManager : UIBasePanelConnection // TypeDefIndex: 6782
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	[SerializeField]
	private GameObject scrollWindowPanel; // 0x38
	[SerializeField]
	private UILabel titleLabel; // 0x40
	[SerializeField]
	private GameObject[] cristaIconObjects; // 0x48
	[SerializeField]
	private GameObject lineSpriteObject; // 0x50
	[SerializeField]
	private GameObject scrollWindowContent; // 0x58
	[SerializeField]
	private UIImageButton decisionButton; // 0x60
	[SerializeField]
	private UIItemPropertyStretch descriptionPanel; // 0x68
	private PlayerDataManager playerDataManager; // 0x70
	private SkillTextManager skillTextManager; // 0x78
	private ItemTextManager itemTextManager; // 0x80
	private List<ItemData> userCristaList; // 0x88
	private List<ItemData> changeCristaList; // 0x90
	private GameObject mainTweenObject; // 0x98
	private UIIruna2Anchor scrollWindowAnchor; // 0xA0
	private UILabel decisionButtonLabel; // 0xA8
	private UIIruna2Anchor descriptionWindowAnchor; // 0xB0
	private UIScrollWindow scrollWindow; // 0xB8
	private readonly UISprite[] lines; // 0xC0
	private readonly string[] colorCode; // 0xC8
	private List<GameObject> scrollWindowContentList; // 0xD0
	private const float instanceStartPosY = -50;
	private const float buttonHeight = 85;
	private int selectedContentIndex; // 0xD8
	private byte selectedSlotIndex; // 0xDC
	private int selectedCristaId; // 0xE0
	private int selectedBeforeCristaId; // 0xE4
	private int[] slotIdsUnaltered; // 0xE8
	private int[] slotIds; // 0xF0
	private UIBareHandEXSkillManager.PanelState panelState; // 0xF8
	private bool isRemove; // 0xFC
	private bool inputLock; // 0xFD
	private TweenScale[] scaleAnimations; // 0x100
	private TweenAlpha[] alphaAnimations; // 0x108

	// Methods

	// RVA: 0x19FBC3C Offset: 0x19F7C3C VA: 0x19FBC3C
	private void Start() { }

	// RVA: 0x19FBDC4 Offset: 0x19F7DC4 VA: 0x19FBDC4
	private void Initialize() { }

	// RVA: 0x19FC4D0 Offset: 0x19F84D0 VA: 0x19FC4D0
	private void CreatCircleLine() { }

	// RVA: 0x19FC694 Offset: 0x19F8694 VA: 0x19FC694
	private void CristaIconApply(byte index) { }

	// RVA: 0x19FC82C Offset: 0x19F882C VA: 0x19FC82C
	private void OpenCristaItemList(int index) { }

	// RVA: 0x19FC928 Offset: 0x19F8928 VA: 0x19FC928
	private void CreatCristaButtonList() { }

	// RVA: 0x19FD6F4 Offset: 0x19F96F4 VA: 0x19FD6F4
	private void CloseCristaItemList() { }

	// RVA: 0x19FD5A4 Offset: 0x19F95A4 VA: 0x19FD5A4
	private void SetRemoveButton(float posY) { }

	// RVA: 0x19FD4BC Offset: 0x19F94BC VA: 0x19FD4BC
	private GameObject CreatButton(float posY, string text, int index) { }

	// RVA: 0x19FD82C Offset: 0x19F982C VA: 0x19FD82C
	private GameObject CreatButton(float posY, string text) { }

	// RVA: 0x19FD3D0 Offset: 0x19F93D0 VA: 0x19FD3D0
	private List<ItemData> GetFilterCristaIdList() { }

	// RVA: 0x19FDA20 Offset: 0x19F9A20 VA: 0x19FDA20
	private void OnClickCristaButton(int index) { }

	// RVA: 0x19FDBD4 Offset: 0x19F9BD4 VA: 0x19FDBD4
	private void ChangeScrollWindowContentVisual(int index) { }

	[IteratorStateMachine(typeof(UIBareHandEXSkillManager.<CloseUI>d__48))]
	// RVA: 0x19FDF68 Offset: 0x19F9F68 VA: 0x19FDF68
	private IEnumerator CloseUI(bool isLeftButton) { }

	// RVA: 0x19FD320 Offset: 0x19F9320 VA: 0x19FD320
	private void ChangeBlinkingState(bool flag) { }

	// RVA: 0x19FE010 Offset: 0x19FA010 VA: 0x19FE010
	public void OnClickOpenScrollWindow(int index) { }

	// RVA: 0x19FE09C Offset: 0x19FA09C VA: 0x19FE09C
	public void OnClickDecisionButton() { }

	// RVA: 0x19FE154 Offset: 0x19FA154 VA: 0x19FE154
	public void OnPressSkillIcon(int param) { }

	// RVA: 0x19FE270 Offset: 0x19FA270 VA: 0x19FE270
	public void OnReleaseSkillIcon(int param) { }

	// RVA: 0x19FE310 Offset: 0x19FA310 VA: 0x19FE310 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19FE3BC Offset: 0x19FA3BC VA: 0x19FE3BC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19FE448 Offset: 0x19FA448 VA: 0x19FE448
	public void .ctor() { }
}
