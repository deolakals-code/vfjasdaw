// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWorldTreasureSearchPotumPanel : MonoBehaviour, IWorldTreasurePanel // TypeDefIndex: 8241
{
	// Fields
	[SerializeField]
	private GameObject panelObject; // 0x20
	[SerializeField]
	private UILabel messaageLabel; // 0x28
	[SerializeField]
	private UILabel nameLabel; // 0x30
	[SerializeField]
	private GameObject discoveryLabel; // 0x38
	private SystemTextManager systemTextManager; // 0x40
	private UIWorldTreasureManager manager; // 0x48
	private PlayerDataManager playerDataManager; // 0x50

	// Methods

	// RVA: 0x1D006DC Offset: 0x1CFC6DC VA: 0x1D006DC Slot: 4
	public void Initialize(UIWorldTreasureManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x1D00878 Offset: 0x1CFC878 VA: 0x1D00878 Slot: 5
	public void Close() { }

	// RVA: 0x1D0087C Offset: 0x1CFC87C VA: 0x1D0087C Slot: 6
	public bool PushLeftTopButton() { }

	// RVA: 0x1CFE498 Offset: 0x1CFA498 VA: 0x1CFE498
	public void UpdateWindowProperty(int manageId, int signatureId, string signatureName) { }

	[IteratorStateMachine(typeof(UIWorldTreasureSearchPotumPanel.<HideSeekCheck>d__11))]
	// RVA: 0x1D00818 Offset: 0x1CFC818 VA: 0x1D00818
	private IEnumerator HideSeekCheck(int manageId) { }

	// RVA: 0x1D00908 Offset: 0x1CFC908 VA: 0x1D00908
	private void OnClickButton() { }

	// RVA: 0x1D00994 Offset: 0x1CFC994 VA: 0x1D00994
	public void .ctor() { }
}
