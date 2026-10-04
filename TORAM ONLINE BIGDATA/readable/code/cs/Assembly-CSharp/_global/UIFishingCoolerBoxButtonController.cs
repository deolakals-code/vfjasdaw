// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingCoolerBoxButtonController : MonoBehaviour // TypeDefIndex: 7020
{
	// Fields
	[SerializeField]
	private GameObject listObject; // 0x20
	[SerializeField]
	private GameObject processingObject; // 0x28
	[SerializeField]
	private UILabel fishNameLabel; // 0x30
	[SerializeField]
	private UILabel fishSizeLabel; // 0x38
	[SerializeField]
	private GameObject starIcon; // 0x40
	[SerializeField]
	private GameObject crownIcon; // 0x48
	[SerializeField]
	private UILabel foodPointLabel; // 0x50
	[SerializeField]
	private GameObject fishIcon; // 0x58
	[SerializeField]
	private GameObject kirimiIcon; // 0x60
	[SerializeField]
	private GameObject checkBoxButtonIcon; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private UIFishingCoolerBoxMenuController menuController; // 0x78
	private FishingMasterFishData masterFishData; // 0x80
	private FishingFishClientData fishData; // 0x88
	private short index; // 0x90
	private bool isProcessingMode; // 0x92
	private bool isProcessingSelect; // 0x93
	private bool isRareFlag; // 0x94

	// Properties
	public short Index { get; }

	// Methods

	// RVA: 0x1A76FDC Offset: 0x1A72FDC VA: 0x1A76FDC
	public short get_Index() { }

	// RVA: 0x1A76FE4 Offset: 0x1A72FE4 VA: 0x1A76FE4
	public void SetCoolerBoxMenuController(UIFishingCoolerBoxMenuController menuController) { }

	// RVA: 0x1A76FEC Offset: 0x1A72FEC VA: 0x1A76FEC
	public void Initialize(FishingFishClientData fishData) { }

	// RVA: 0x1A776B0 Offset: 0x1A736B0 VA: 0x1A776B0
	public void ChangeProcessingMode(bool isActive) { }

	// RVA: 0x1A7777C Offset: 0x1A7377C VA: 0x1A7777C
	public void OnClickProcessCheckBox(bool isActive) { }

	// RVA: 0x1A7778C Offset: 0x1A7378C VA: 0x1A7778C
	public void OnClickProcessCheckBox() { }

	// RVA: 0x1A77A44 Offset: 0x1A73A44 VA: 0x1A77A44
	public void OnClickProcessCheckBoxPlaySE() { }

	// RVA: 0x1A77AAC Offset: 0x1A73AAC VA: 0x1A77AAC
	public void OnClickDetailsButton() { }

	// RVA: 0x1A7738C Offset: 0x1A7338C VA: 0x1A7738C
	private void SetFishNameLabel(string fishName, bool isRed) { }

	// RVA: 0x1A77518 Offset: 0x1A73518 VA: 0x1A77518
	private void SetFishSizeLabel(int fishSize, bool isRed) { }

	// RVA: 0x1A783B4 Offset: 0x1A743B4 VA: 0x1A783B4
	public void .ctor() { }
}
