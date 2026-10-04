// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipCristaButton : MonoBehaviour // TypeDefIndex: 6902
{
	// Fields
	[SerializeField]
	private UIIcon cristaIcon; // 0x20
	[SerializeField]
	private UISprite cristaPanel; // 0x28
	[SerializeField]
	private UILabel cristaLabel; // 0x30
	[SerializeField]
	private UILabel cristaText; // 0x38
	[SerializeField]
	private GameObject customButton; // 0x40
	[SerializeField]
	private UILabel customButtonLabel; // 0x48
	[SerializeField]
	private BoxCollider boxCollider; // 0x50
	[SerializeField]
	private GameObject equipManager; // 0x58
	[SerializeField]
	private GameObject itemProperty; // 0x60
	[SerializeField]
	private GameObject thisLabel; // 0x68
	[SerializeField]
	private UIImageButton editButton; // 0x70
	[SerializeField]
	private GameObject hidePanel; // 0x78
	[SerializeField]
	private GameObject slotButton; // 0x80
	[SerializeField]
	private GameObject slotReleaseObj; // 0x88
	private UILabel[] slotReleaseLabels; // 0x90
	private UIButtonSendMessage slotReleaseMessage; // 0x98
	[SerializeField]
	private UISprite cristaBaseIcon; // 0xA0
	[SerializeField]
	private UISprite buttonBase; // 0xA8
	[SerializeField]
	private UISprite buttonFrame; // 0xB0
	private ItemData selectedItemData; // 0xB8
	[SerializeField]
	private GameObject strongButtonObj; // 0xC0
	[SerializeField]
	private GameObject slot2SelectItemObj; // 0xC8
	private int openSlotOrbItemId; // 0xD0
	private List<UILabel> itemPropertyText; // 0xD8
	private bool updateCheck; // 0xE0
	private UIButtonSendMessage buttonSendMessage; // 0xE8
	private SystemTextManager systemLocalizeManager; // 0xF0
	private ItemTextManager itemLocalizeManager; // 0xF8
	private ItemPropertyTextManager itemPropertyManager; // 0x100

	// Properties
	private SystemTextManager systemTextManager { get; }
	private ItemTextManager itemTextManager { get; }
	public ItemPropertyTextManager itemPropertyTextManager { get; }

	// Methods

	// RVA: 0x1A3FAE0 Offset: 0x1A3BAE0 VA: 0x1A3FAE0
	public void IsEditButton(bool flag) { }

	// RVA: 0x1A3FB48 Offset: 0x1A3BB48 VA: 0x1A3FB48
	public void StrongButtonEnable(bool flag) { }

	// RVA: 0x1A3FB68 Offset: 0x1A3BB68 VA: 0x1A3FB68
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1A3FC54 Offset: 0x1A3BC54 VA: 0x1A3FC54
	private ItemTextManager get_itemTextManager() { }

	// RVA: 0x1A3FD40 Offset: 0x1A3BD40 VA: 0x1A3FD40
	public ItemPropertyTextManager get_itemPropertyTextManager() { }

	// RVA: 0x1A3FE30 Offset: 0x1A3BE30 VA: 0x1A3FE30
	public void SetCrista(int id, int slot) { }

	// RVA: 0x1A40320 Offset: 0x1A3C320 VA: 0x1A40320
	private void SelectCrista(int slot) { }

	// RVA: 0x1A407A4 Offset: 0x1A3C7A4 VA: 0x1A407A4
	public void AddCristaSlot(int slot, string text) { }

	// RVA: 0x1A40490 Offset: 0x1A3C490 VA: 0x1A40490
	private void SetSendData(string functionName, GameObject target, int param) { }

	// RVA: 0x1A405F0 Offset: 0x1A3C5F0 VA: 0x1A405F0
	private void ClearItemProperty() { }

	// RVA: 0x1A409D8 Offset: 0x1A3C9D8 VA: 0x1A409D8
	private void Update() { }

	// RVA: 0x1A40C00 Offset: 0x1A3CC00 VA: 0x1A40C00
	public void InitSlot(bool flag) { }

	// RVA: 0x1A40DB8 Offset: 0x1A3CDB8 VA: 0x1A40DB8
	public void SelectSlot(ItemData itemData, int slot) { }

	// RVA: 0x1A40C88 Offset: 0x1A3CC88 VA: 0x1A40C88
	public void EditSlotDepth(bool flag) { }

	// RVA: 0x1A41158 Offset: 0x1A3D158 VA: 0x1A41158
	public void NoCristaSlot(bool flag) { }

	// RVA: 0x1A41208 Offset: 0x1A3D208 VA: 0x1A41208
	public void SetCristaSlot(int id) { }

	// RVA: 0x1A40E14 Offset: 0x1A3CE14 VA: 0x1A40E14
	private void CheckSlot(int slot) { }

	// RVA: 0x1A4130C Offset: 0x1A3D30C VA: 0x1A4130C
	private int CheckAddSlotOrbItemId(byte itemType, int slotNo) { }

	// RVA: 0x1A4144C Offset: 0x1A3D44C VA: 0x1A4144C
	private bool IsDoubleSlotTargetItem(byte type) { }

	// RVA: 0x1A41460 Offset: 0x1A3D460 VA: 0x1A41460
	private bool IsPrintDoubleSlotTargetItem(int targetItemNum, int multiItemNum) { }

	// RVA: 0x1A41478 Offset: 0x1A3D478 VA: 0x1A41478
	private void onSelectItemRight() { }

	// RVA: 0x1A41634 Offset: 0x1A3D634 VA: 0x1A41634
	private void onSelectItemLeft() { }

	[IteratorStateMachine(typeof(UIEquipCristaButton.<PopUpAddCristaSlot>d__54))]
	// RVA: 0x1A41290 Offset: 0x1A3D290 VA: 0x1A41290
	private IEnumerator PopUpAddCristaSlot(int slotId) { }

	[IteratorStateMachine(typeof(UIEquipCristaButton.<ConnectWait>d__55))]
	// RVA: 0x1A41660 Offset: 0x1A3D660 VA: 0x1A41660
	private IEnumerator ConnectWait(Func<bool> connectionCheck, Action resultAction) { }

	// RVA: 0x1A41724 Offset: 0x1A3D724 VA: 0x1A41724
	public void .ctor() { }
}
