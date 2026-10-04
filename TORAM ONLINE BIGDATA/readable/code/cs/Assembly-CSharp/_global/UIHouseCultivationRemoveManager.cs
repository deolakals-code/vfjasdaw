// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCultivationRemoveManager : UIBasePanel // TypeDefIndex: 7237
{
	// Fields
	private bool cancelCheck; // 0x29
	[SerializeField]
	private GameObject titleIcon; // 0x30
	[SerializeField]
	private GameObject flowerGrowthIcon; // 0x38
	[SerializeField]
	private GameObject treeGrowthIcon; // 0x40
	[SerializeField]
	private GameObject fieldGrowthIcon; // 0x48
	[SerializeField]
	private UILabel paramText; // 0x50
	private GameObject[] iconDataList; // 0x58
	private UIPopBaseWindow popWindow; // 0x60

	// Methods

	// RVA: 0x1AE7448 Offset: 0x1AE3448 VA: 0x1AE7448
	private void IconCreate(int num) { }

	// RVA: 0x1AE756C Offset: 0x1AE356C VA: 0x1AE756C
	private void AddIcon(int i, GameObject icon, Vector3 pos) { }

	// RVA: 0x1AE7728 Offset: 0x1AE3728 VA: 0x1AE7728
	private void FlowerPanelCreate(ProduceDataBase data) { }

	// RVA: 0x1AE799C Offset: 0x1AE399C VA: 0x1AE799C
	private void TreePanelCreate(ProduceDataBase data) { }

	// RVA: 0x1AE7B7C Offset: 0x1AE3B7C VA: 0x1AE7B7C
	private void FarmPanelCreate(ProduceDataBase data) { }

	// RVA: 0x1AE7CC0 Offset: 0x1AE3CC0 VA: 0x1AE7CC0
	public void Initialize(int index) { }

	[IteratorStateMachine(typeof(UIHouseCultivationRemoveManager.<CultivationRemovePopUpThread>d__14))]
	// RVA: 0x1AE7E40 Offset: 0x1AE3E40 VA: 0x1AE7E40
	private IEnumerator CultivationRemovePopUpThread(short index) { }

	// RVA: 0x1AE7EE4 Offset: 0x1AE3EE4 VA: 0x1AE7EE4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AE7F8C Offset: 0x1AE3F8C VA: 0x1AE7F8C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AE8018 Offset: 0x1AE4018 VA: 0x1AE8018
	public void .ctor() { }
}
