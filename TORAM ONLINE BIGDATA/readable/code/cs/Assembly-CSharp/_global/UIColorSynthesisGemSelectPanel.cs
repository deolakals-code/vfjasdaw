// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIColorSynthesisGemSelectPanel : MonoBehaviour, IUIColorSynthesisPanel // TypeDefIndex: 6723
{
	// Fields
	public const int SubSlotCount = 4;
	public const int MaxCandidateColors = 19;
	[SerializeField]
	private LabelWithIcon createItemDisplay; // 0x20
	[SerializeField]
	private UIColorSynthesisGemListElement mainGemElement; // 0x28
	[SerializeField]
	private UIColorSynthesisGemListElement[] subGemElements; // 0x30
	[SerializeField]
	private GameObject subSlotRoot; // 0x38
	[SerializeField]
	private UIColorSynthesisGemListElement originColor; // 0x40
	[SerializeField]
	private UILabel successRateLabel; // 0x48
	[SerializeField]
	private GameObject nextButton; // 0x50
	[SerializeField]
	private UIColorSynthesisGemListPopup gemListPopup; // 0x58
	[SerializeField]
	private UIScrollPanel scrollWindow; // 0x60
	[SerializeField]
	private GameObject metalPointRoot; // 0x68
	[SerializeField]
	private UIInput metalPointInput; // 0x70
	[SerializeField]
	private UILabel ownedMetalLabel; // 0x78
	[SerializeField]
	private UIImageButton metalPanelNextButton; // 0x80
	[SerializeField]
	private GameObject warningLabel; // 0x88
	private UIColorSynthesisMainManager manager; // 0x90
	private PlayerDataManager playerDataManager; // 0x98
	private SystemTextManager systemTextManager; // 0xA0
	private ItemTextManager itemTextManager; // 0xA8
	private int editingSlot; // 0xB0
	private List<UIColorSynthesisGemListElement> condidateColorIcons; // 0xB8

	// Methods

	// RVA: 0x19C99F4 Offset: 0x19C59F4 VA: 0x19C99F4 Slot: 4
	public void Initialize(UIColorSynthesisMainManager manager, PlayerDataManager playerDataManager, SystemTextManager systemTextManager, ItemTextManager itemTextManager) { }

	// RVA: 0x19C9AEC Offset: 0x19C5AEC VA: 0x19C9AEC Slot: 5
	public void Open() { }

	// RVA: 0x19CA2B0 Offset: 0x19C62B0 VA: 0x19CA2B0 Slot: 6
	public bool Close() { }

	// RVA: 0x19C9B04 Offset: 0x19C5B04 VA: 0x19C9B04
	private void ValidateSelectedGems() { }

	// RVA: 0x19C9C84 Offset: 0x19C5C84 VA: 0x19C9C84
	private void RefreshPrediction() { }

	// RVA: 0x19CA824 Offset: 0x19C6824 VA: 0x19CA824
	private void ClearCandidateColors() { }

	// RVA: 0x19CA59C Offset: 0x19C659C VA: 0x19CA59C
	private void RefreshPhilosophersStone() { }

	// RVA: 0x19CAC60 Offset: 0x19C6C60 VA: 0x19CAC60
	private void RefreshMetalPanelNextButton() { }

	// RVA: 0x19CA328 Offset: 0x19C6328 VA: 0x19CA328
	private void RefreshSlotElements() { }

	// RVA: 0x19CAE88 Offset: 0x19C6E88 VA: 0x19CAE88
	private int SlotPreviewColor(int gemId, int slotCenter) { }

	// RVA: 0x19CADD8 Offset: 0x19C6DD8 VA: 0x19CADD8
	private string GetItemName(int itemId) { }

	// RVA: 0x19CAF68 Offset: 0x19C6F68 VA: 0x19CAF68
	public void OnTapMainSlot() { }

	// RVA: 0x19CB070 Offset: 0x19C7070 VA: 0x19CB070
	public void OnTapSubSlot0() { }

	// RVA: 0x19CB198 Offset: 0x19C7198 VA: 0x19CB198
	public void OnTapSubSlot1() { }

	// RVA: 0x19CB1A0 Offset: 0x19C71A0 VA: 0x19CB1A0
	public void OnTapSubSlot2() { }

	// RVA: 0x19CB1A8 Offset: 0x19C71A8 VA: 0x19CB1A8
	public void OnTapSubSlot3() { }

	// RVA: 0x19CB078 Offset: 0x19C7078 VA: 0x19CB078
	private void OpenSubSlot(int slotIndex) { }

	// RVA: 0x19CB1B0 Offset: 0x19C71B0 VA: 0x19CB1B0
	private void OnGemSelected(int itemId) { }

	// RVA: 0x19CB224 Offset: 0x19C7224 VA: 0x19CB224
	public void OnSelectMainGem(int itemId) { }

	// RVA: 0x19CAA1C Offset: 0x19C6A1C VA: 0x19CAA1C
	public void OnMetalPointChanged() { }

	// RVA: 0x19CB3AC Offset: 0x19C73AC VA: 0x19CB3AC
	public void OnSelectSubGem(int slotIndex, int itemId) { }

	// RVA: 0x19CB4E0 Offset: 0x19C74E0 VA: 0x19CB4E0
	public void OnNext() { }

	// RVA: 0x19CB97C Offset: 0x19C797C VA: 0x19CB97C
	public void .ctor() { }
}
