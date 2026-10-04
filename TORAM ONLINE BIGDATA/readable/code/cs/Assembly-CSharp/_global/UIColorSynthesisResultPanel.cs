// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIColorSynthesisResultPanel : MonoBehaviour, IUIColorSynthesisPanel // TypeDefIndex: 6732
{
	// Fields
	[SerializeField]
	private GameObject successRoot; // 0x20
	[SerializeField]
	private LabelWithIcon resultMessage; // 0x28
	[SerializeField]
	private LabelWithIcon resultEquip; // 0x30
	[SerializeField]
	private UIColorSynthesisGemListElement colorElement; // 0x38
	[SerializeField]
	private UILabel resultSpinaLabel; // 0x40
	[SerializeField]
	private UIToggle stockColorToggle; // 0x48
	[SerializeField]
	private GameObject failRoot; // 0x50
	private UIColorSynthesisMainManager manager; // 0x58
	private PlayerDataManager playerDataManager; // 0x60
	private SystemTextManager systemTextManager; // 0x68
	private ItemTextManager itemTextManager; // 0x70
	private bool lastSuccess; // 0x78
	private bool isProcessing; // 0x79

	// Methods

	// RVA: 0x19CD9C4 Offset: 0x19C99C4 VA: 0x19CD9C4 Slot: 4
	public void Initialize(UIColorSynthesisMainManager manager, PlayerDataManager playerDataManager, SystemTextManager systemTextManager, ItemTextManager itemTextManager) { }

	// RVA: 0x19CDA24 Offset: 0x19C9A24 VA: 0x19CDA24 Slot: 5
	public void Open() { }

	// RVA: 0x19CE740 Offset: 0x19CA740 VA: 0x19CE740 Slot: 6
	public bool Close() { }

	// RVA: 0x19CDB24 Offset: 0x19C9B24 VA: 0x19CDB24
	private void ApplyResultView(ColorSynthesisResponse response) { }

	// RVA: 0x19CE53C Offset: 0x19CA53C VA: 0x19CE53C
	private void UpdateStockColorToggle() { }

	// RVA: 0x19CE480 Offset: 0x19CA480 VA: 0x19CE480
	private bool IsPhilosophers() { }

	// RVA: 0x19CE898 Offset: 0x19CA898 VA: 0x19CE898
	private string GetItemName(int itemId) { }

	// RVA: 0x19CE748 Offset: 0x19CA748 VA: 0x19CE748
	private void AppendBrokenGem(StringBuilder sb, Dictionary<int, int> remaining, int itemId) { }

	// RVA: 0x19CE948 Offset: 0x19CA948 VA: 0x19CE948
	public void OnOk() { }

	// RVA: 0x19CEA04 Offset: 0x19CAA04 VA: 0x19CEA04
	private void StepStockColor() { }

	// RVA: 0x19CEAF8 Offset: 0x19CAAF8 VA: 0x19CEAF8
	private void StepPhilosophersStonePopup() { }

	// RVA: 0x19CEBC8 Offset: 0x19CABC8 VA: 0x19CEBC8
	private void StepReturnToSelect() { }

	// RVA: 0x19CEBE4 Offset: 0x19CABE4 VA: 0x19CEBE4
	public void .ctor() { }
}
