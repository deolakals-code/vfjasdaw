// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIColorSynthesisGemListPopup : MonoBehaviour // TypeDefIndex: 6722
{
	// Fields
	[SerializeField]
	private GameObject root; // 0x20
	[SerializeField]
	private UILabel titleLabel; // 0x28
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private GameObject elementPrefab; // 0x38
	private UIColorSynthesisMainManager manager; // 0x40
	private SystemTextManager systemTextManager; // 0x48
	private ItemTextManager itemTextManager; // 0x50
	private Action<int> onSelect; // 0x58
	private readonly List<GameObject> spawned; // 0x60
	private Transform listParent; // 0x68
	private int editingSlot; // 0x70

	// Methods

	// RVA: 0x19C86E0 Offset: 0x19C46E0 VA: 0x19C86E0
	public void Initialize(UIColorSynthesisMainManager manager, SystemTextManager systemTextManager, ItemTextManager itemTextManager) { }

	// RVA: 0x19C87D0 Offset: 0x19C47D0 VA: 0x19C87D0
	public void Open(int editingSlot, Action<int> onSelect) { }

	// RVA: 0x19C8FF8 Offset: 0x19C4FF8 VA: 0x19C8FF8
	public void Close() { }

	// RVA: 0x19C88C0 Offset: 0x19C48C0 VA: 0x19C88C0
	private List<int> BuildSortedList(bool forMainSlot) { }

	// RVA: 0x19C8BB4 Offset: 0x19C4BB4 VA: 0x19C8BB4
	private void Rebuild(List<int> ids) { }

	// RVA: 0x19C92AC Offset: 0x19C52AC VA: 0x19C92AC
	private UIColorSynthesisGemListElement SpawnElement(float posY) { }

	// RVA: 0x19C908C Offset: 0x19C508C VA: 0x19C908C
	private void ClearSpawned() { }

	// RVA: 0x19C9770 Offset: 0x19C5770 VA: 0x19C9770
	private void OnElementSelected(int itemId) { }

	// RVA: 0x19C91C8 Offset: 0x19C51C8 VA: 0x19C91C8
	private int GetCount(int itemId) { }

	// RVA: 0x19C9860 Offset: 0x19C5860 VA: 0x19C9860
	private int CountUsedInSlots(int itemId) { }

	// RVA: 0x19C94D4 Offset: 0x19C54D4 VA: 0x19C94D4
	private string GetItemName(int itemId) { }

	// RVA: 0x19C9584 Offset: 0x19C5584 VA: 0x19C9584
	private int CalcPreviewColor(int gemId) { }

	// RVA: 0x19C9964 Offset: 0x19C5964 VA: 0x19C9964
	public void .ctor() { }
}
