// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIItemPanelButton : MonoBehaviour // TypeDefIndex: 8962
{
	// Fields
	[SerializeField]
	private UIIcon dragIcon; // 0x20
	[SerializeField]
	private GameObject dragButton; // 0x28
	[SerializeField]
	private UIIcon itemIcon; // 0x30
	[SerializeField]
	private UILabel paramLabel1; // 0x38
	[SerializeField]
	private UILabel paramLabel2; // 0x40
	[SerializeField]
	private UILabel paramLabel3; // 0x48
	[SerializeField]
	private UISprite buttonFrame; // 0x50
	[SerializeField]
	private UISprite buttonBack; // 0x58
	[SerializeField]
	private UIIcon[] cristaSlot; // 0x60
	[SerializeField]
	private UISprite[] cristaSlotBack; // 0x68
	[SerializeField]
	private UILabel equipCheck; // 0x70
	[SerializeField]
	private UISprite lockIcon; // 0x78
	[SerializeField]
	private UISprite selectIcon; // 0x80
	[SerializeField]
	private UILabel questCheck; // 0x88
	private UIIItemPanelManager panelManager; // 0x90
	private UISprite newSlotIcon; // 0x98
	private UISprite randomPropIcon; // 0xA0
	[CompilerGenerated]
	private ItemData <ItemData>k__BackingField; // 0xA8
	private bool dragCheck; // 0xB0
	private bool createItem; // 0xB1
	private UIPartyFieldLabel partyFieldLabel; // 0xB8
	private SystemTextManager systemManager; // 0xC0
	[CompilerGenerated]
	private int <LocationId>k__BackingField; // 0xC8
	private UIRoot parentRoot; // 0xD0
	private TweenColor lockTweenColor; // 0xD8
	[CompilerGenerated]
	private UIItemPanelButton.ItemButtonTypes <ItemButtonType>k__BackingField; // 0xE0
	[CompilerGenerated]
	private bool <IsCanDrag>k__BackingField; // 0xE4

	// Properties
	public ItemData ItemData { get; set; }
	private SystemTextManager systemTextManager { get; }
	public int LocationId { get; set; }
	public bool IsLock { get; }
	public UIItemPanelButton.ItemButtonTypes ItemButtonType { get; set; }
	public bool IsCanDrag { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E6B0D4 Offset: 0x1E670D4 VA: 0x1E6B0D4
	private void set_ItemData(ItemData value) { }

	[CompilerGenerated]
	// RVA: 0x1E6B0DC Offset: 0x1E670DC VA: 0x1E6B0DC
	public ItemData get_ItemData() { }

	// RVA: 0x1E6B0E4 Offset: 0x1E670E4 VA: 0x1E6B0E4
	private SystemTextManager get_systemTextManager() { }

	[CompilerGenerated]
	// RVA: 0x1E6B1D0 Offset: 0x1E671D0 VA: 0x1E6B1D0
	private void set_LocationId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1E6B1D8 Offset: 0x1E671D8 VA: 0x1E6B1D8
	public int get_LocationId() { }

	// RVA: 0x1E6B1E0 Offset: 0x1E671E0 VA: 0x1E6B1E0
	public bool get_IsLock() { }

	[CompilerGenerated]
	// RVA: 0x1E6B1FC Offset: 0x1E671FC VA: 0x1E6B1FC
	private void set_ItemButtonType(UIItemPanelButton.ItemButtonTypes value) { }

	[CompilerGenerated]
	// RVA: 0x1E6B204 Offset: 0x1E67204 VA: 0x1E6B204
	public UIItemPanelButton.ItemButtonTypes get_ItemButtonType() { }

	[CompilerGenerated]
	// RVA: 0x1E6B20C Offset: 0x1E6720C VA: 0x1E6B20C
	public bool get_IsCanDrag() { }

	[CompilerGenerated]
	// RVA: 0x1E6B214 Offset: 0x1E67214 VA: 0x1E6B214
	private void set_IsCanDrag(bool value) { }

	// RVA: 0x1E5FDEC Offset: 0x1E5BDEC VA: 0x1E5FDEC
	public void Initialize(ItemData itemData, UIIItemPanelManager panelManager) { }

	// RVA: 0x1E60A44 Offset: 0x1E5CA44 VA: 0x1E60A44
	public void InitializeAddSlot(UIIItemPanelManager panelManager) { }

	// RVA: 0x1E5F6F0 Offset: 0x1E5B6F0 VA: 0x1E5F6F0
	public void Clear() { }

	// RVA: 0x1E6005C Offset: 0x1E5C05C VA: 0x1E6005C
	public void SetLocationId(int locationId) { }

	// RVA: 0x1E6C614 Offset: 0x1E68614 VA: 0x1E6C614
	public void Close() { }

	// RVA: 0x1E6C648 Offset: 0x1E68648 VA: 0x1E6C648
	public void Select() { }

	// RVA: 0x1E6C124 Offset: 0x1E68124 VA: 0x1E6C124
	public void DeSelect() { }

	// RVA: 0x1E5FAA8 Offset: 0x1E5BAA8 VA: 0x1E5FAA8
	public void SetEnable(bool enabled) { }

	// RVA: 0x1E6BFC4 Offset: 0x1E67FC4 VA: 0x1E6BFC4
	public void SetLock(bool lockFlag) { }

	// RVA: 0x1E6C7A4 Offset: 0x1E687A4 VA: 0x1E6C7A4
	public void SetNew(bool flag) { }

	// RVA: 0x1E6C398 Offset: 0x1E68398 VA: 0x1E6C398
	public void SetFavorite(bool flag) { }

	// RVA: 0x1E6C85C Offset: 0x1E6885C VA: 0x1E6C85C
	private void Update() { }

	// RVA: 0x1E6C2E0 Offset: 0x1E682E0 VA: 0x1E6C2E0
	private void SetDragObjectActive(bool flag) { }

	// RVA: 0x1E6114C Offset: 0x1E5D14C VA: 0x1E6114C
	public bool DragCheck(Vector3 position, float r) { }

	// RVA: 0x1E60E44 Offset: 0x1E5CE44 VA: 0x1E60E44
	public void EquipCheck(bool flag) { }

	// RVA: 0x1E60F1C Offset: 0x1E5CF1C VA: 0x1E60F1C
	public void QuestCheck(bool flag) { }

	// RVA: 0x1E6B4B8 Offset: 0x1E674B8 VA: 0x1E6B4B8
	public void ItemUpdateCheck(ItemData itemData) { }

	// RVA: 0x1E6C4F8 Offset: 0x1E684F8 VA: 0x1E6C4F8
	public void SetSelectIcon(string spriteName, bool enabled) { }

	// RVA: 0x1E60144 Offset: 0x1E5C144 VA: 0x1E60144
	public void ChangeDetachIcon() { }

	// RVA: 0x1E604DC Offset: 0x1E5C4DC VA: 0x1E604DC
	public void ChangeAvatarCategoryIcon() { }

	[IteratorStateMachine(typeof(UIItemPanelButton.<ScrollCategoryLabel>d__64))]
	// RVA: 0x1E6C8D0 Offset: 0x1E688D0 VA: 0x1E6C8D0
	private IEnumerator ScrollCategoryLabel(float maxSize, int maxLength) { }

	// RVA: 0x1E60980 Offset: 0x1E5C980 VA: 0x1E60980
	public void SetDragEnable(bool enable) { }

	// RVA: 0x1E6B220 Offset: 0x1E67220 VA: 0x1E6B220
	private void CreateRandomPropIcon() { }

	// RVA: 0x1E6C984 Offset: 0x1E68984 VA: 0x1E6C984
	private void OnPress(bool push) { }

	// RVA: 0x1E6CB50 Offset: 0x1E68B50 VA: 0x1E6CB50
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1E6CCCC Offset: 0x1E68CCC VA: 0x1E6CCCC
	public void .ctor() { }
}
