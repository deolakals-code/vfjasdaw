// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingGereMenuController : UIBasePanelConnection // TypeDefIndex: 7040
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	[SerializeField]
	private UIFishingGereStatusController[] rodContent; // 0x38
	[SerializeField]
	private UILabel submergedItemLabel; // 0x40
	[SerializeField]
	private UILabel coolerBoxLabel; // 0x48
	[SerializeField]
	private GameObject infomationWindow; // 0x50
	[SerializeField]
	private GameObject infomationMoveWindow; // 0x58
	[SerializeField]
	private UILabel[] infomationDescriptionLabels; // 0x60
	private byte equipRodIndex; // 0x68
	private UIFishingSubmergedItemMenuController submergedItemMenuController; // 0x70
	private GameObject coolerBoxMenuObject; // 0x78
	private UIFishingCoolerBoxMenuController coolerBoxMenuController; // 0x80
	private UIFishingGereMenuController.PanelState panelState; // 0x88

	// Methods

	[IteratorStateMachine(typeof(UIFishingGereMenuController.<Start>d__13))]
	// RVA: 0x1A7C208 Offset: 0x1A78208 VA: 0x1A7C208
	private IEnumerator Start() { }

	// RVA: 0x1A7C29C Offset: 0x1A7829C VA: 0x1A7C29C
	private void OnDestroy() { }

	// RVA: 0x1A7C3B4 Offset: 0x1A783B4 VA: 0x1A7C3B4
	private void Initialize() { }

	// RVA: 0x1A7C490 Offset: 0x1A78490 VA: 0x1A7C490
	private void ChangePanelState(UIFishingGereMenuController.PanelState state) { }

	// RVA: 0x1A7C9E4 Offset: 0x1A789E4 VA: 0x1A7C9E4
	private void ChangeMainPanel() { }

	// RVA: 0x1A7C9EC Offset: 0x1A789EC VA: 0x1A7C9EC
	private bool InputFlag() { }

	// RVA: 0x1A7C690 Offset: 0x1A78690 VA: 0x1A7C690
	private void ResetRodStatuses() { }

	// RVA: 0x1A7C7CC Offset: 0x1A787CC VA: 0x1A7C7CC
	private void UpdateCoolerBoxLabel() { }

	[IteratorStateMachine(typeof(UIFishingGereMenuController.<SaveChangeEquipRod>d__21))]
	// RVA: 0x1A7D488 Offset: 0x1A79488 VA: 0x1A7D488
	private IEnumerator SaveChangeEquipRod(Action callBack) { }

	// RVA: 0x1A7D538 Offset: 0x1A79538 VA: 0x1A7D538
	private void LeftTopButton() { }

	// RVA: 0x1A7D6F4 Offset: 0x1A796F4 VA: 0x1A7D6F4
	private void RightTopButton() { }

	// RVA: 0x1A7D878 Offset: 0x1A79878 VA: 0x1A7D878
	public void OnClickChangeEquipped(int index) { }

	// RVA: 0x1A7D988 Offset: 0x1A79988 VA: 0x1A7D988
	public void OnClickSubmergedItem() { }

	// RVA: 0x1A7DA94 Offset: 0x1A79A94 VA: 0x1A7DA94
	public void OnClickCoolerBox() { }

	// RVA: 0x1A7DB64 Offset: 0x1A79B64 VA: 0x1A7DB64
	public void OnClickInfomation() { }

	// RVA: 0x1A7DCE0 Offset: 0x1A79CE0 VA: 0x1A7DCE0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A7DD0C Offset: 0x1A79D0C VA: 0x1A7DD0C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A7DD38 Offset: 0x1A79D38 VA: 0x1A7DD38
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A7DD48 Offset: 0x1A79D48 VA: 0x1A7DD48
	private void <OnClickSubmergedItem>b__25_0() { }

	[CompilerGenerated]
	// RVA: 0x1A7E53C Offset: 0x1A7A53C VA: 0x1A7E53C
	private void <OnClickCoolerBox>b__26_0() { }
}
