// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISpecialStorageCreateExpDrinkPanel : MonoBehaviour, IUISpecialStoragePanel // TypeDefIndex: 7943
{
	// Fields
	[SerializeField]
	private UILabel popText; // 0x20
	[SerializeField]
	private UILabel limitText; // 0x28
	[SerializeField]
	private UILabel itemText; // 0x30
	[SerializeField]
	private UILabel warningText; // 0x38
	[SerializeField]
	private UIImageButton buttonImage; // 0x40
	private UISpecialStorageManager manager; // 0x48
	private SystemTextManager systemTextManager; // 0x50
	private int viewExpPotLevel; // 0x58

	// Methods

	// RVA: 0x1C7E370 Offset: 0x1C7A370 VA: 0x1C7E370 Slot: 4
	public int GetMainPanelFlag() { }

	// RVA: 0x1C7E378 Offset: 0x1C7A378 VA: 0x1C7E378 Slot: 5
	public void Initialize(UISpecialStorageManager manager) { }

	// RVA: 0x1C7E470 Offset: 0x1C7A470 VA: 0x1C7E470 Slot: 6
	public bool ChangeActivate() { }

	// RVA: 0x1C7EBB4 Offset: 0x1C7ABB4 VA: 0x1C7EBB4 Slot: 7
	public void OnClickAsobimoMarket() { }

	// RVA: 0x1C7EC0C Offset: 0x1C7AC0C VA: 0x1C7EC0C
	public void OnClickResult() { }

	[IteratorStateMachine(typeof(UISpecialStorageCreateExpDrinkPanel.<CreateExpDrinkConnect>d__13))]
	// RVA: 0x1C7EDF0 Offset: 0x1C7ADF0 VA: 0x1C7EDF0
	private IEnumerator CreateExpDrinkConnect() { }

	// RVA: 0x1C7EE84 Offset: 0x1C7AE84 VA: 0x1C7EE84 Slot: 8
	public bool OnLeftTopButton() { }

	// RVA: 0x1C7F2EC Offset: 0x1C7B2EC VA: 0x1C7F2EC
	public void .ctor() { }
}
