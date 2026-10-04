// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRegistletEditPanel : MonoBehaviour, UIRegistletBasePanel // TypeDefIndex: 7912
{
	// Fields
	[SerializeField]
	private GameObject leftAnchorGameObject; // 0x20
	[SerializeField]
	private GameObject rightAnchorGameObject; // 0x28
	[SerializeField]
	private UICamera uiCamera; // 0x30
	[SerializeField]
	private UILabel gemPowderNumLabel; // 0x38
	[SerializeField]
	private UILabel gemCartNumLabel; // 0x40
	[SerializeField]
	private GameObject addSlotWindowObj; // 0x48
	[SerializeField]
	private UILabel[] addSlotWindowLabels; // 0x50
	[SerializeField]
	private GameObject actionLabelObj; // 0x58
	[SerializeField]
	private UIImageButton editButton; // 0x60
	private UIRegistletMainManager manager; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private RegistletTextManager registletTextManager; // 0x78
	private UIIruna2Anchor leftAnchor; // 0x80
	private UIIruna2Anchor rightAnchor; // 0x88
	private UIScrollWindow equipGemCartListWindow; // 0x90
	private GameObject equipButtonObj; // 0x98
	private PlayerDataManager playerDataManager; // 0xA0
	private Action returnCall; // 0xA8
	private GemCartData selectData; // 0xB0
	private GemCartData changeData; // 0xB8
	private bool isCanAddSlot; // 0xC0
	private bool isAction; // 0xC1
	private bool isChangeEquip; // 0xC2
	private int selectedParam; // 0xC4

	// Methods

	// RVA: 0x1C5FCB4 Offset: 0x1C5BCB4 VA: 0x1C5FCB4 Slot: 4
	public void Initialize(UIRegistletMainManager manager, SystemTextManager systemTextManager, RegistletTextManager registletTextManager) { }

	// RVA: 0x1C5FE3C Offset: 0x1C5BE3C VA: 0x1C5FE3C Slot: 8
	public void FadeIn() { }

	// RVA: 0x1C6046C Offset: 0x1C5C46C VA: 0x1C6046C Slot: 9
	public void FadeOut() { }

	// RVA: 0x1C60540 Offset: 0x1C5C540 VA: 0x1C60540 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x1C60548 Offset: 0x1C5C548 VA: 0x1C60548 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1C607C8 Offset: 0x1C5C7C8 VA: 0x1C607C8 Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x1C607D0 Offset: 0x1C5C7D0 VA: 0x1C607D0
	private void Update() { }

	// RVA: 0x1C60000 Offset: 0x1C5C000 VA: 0x1C60000
	private void SetEquipList() { }

	// RVA: 0x1C608A0 Offset: 0x1C5C8A0 VA: 0x1C608A0
	private GameObject CreateEquipGemButton(int param, Vector3 pos, GemCartData data, bool addSlot = False) { }

	// RVA: 0x1C606B8 Offset: 0x1C5C6B8 VA: 0x1C606B8
	private void SetEnableEquipGemCartListWindow(bool enabled) { }

	// RVA: 0x1C60E78 Offset: 0x1C5CE78 VA: 0x1C60E78
	public void Equip() { }

	// RVA: 0x1C60F74 Offset: 0x1C5CF74 VA: 0x1C60F74
	public void OpenGemList() { }

	// RVA: 0x1C616E0 Offset: 0x1C5D6E0 VA: 0x1C616E0
	public void OnEditButton() { }

	// RVA: 0x1C616FC Offset: 0x1C5D6FC VA: 0x1C616FC
	public void OnClickEquipGem(int param) { }

	// RVA: 0x1C619F4 Offset: 0x1C5D9F4 VA: 0x1C619F4
	public void OnClickEquipButton(int param) { }

	// RVA: 0x1C61CB0 Offset: 0x1C5DCB0 VA: 0x1C61CB0
	public void OnClickAddSlotButton(int param) { }

	// RVA: 0x1C61F94 Offset: 0x1C5DF94 VA: 0x1C61F94
	public void OnClickSelectGem(int param) { }

	// RVA: 0x1C6215C Offset: 0x1C5E15C VA: 0x1C6215C
	public void OnClickRemoveGem(int param) { }

	// RVA: 0x1C621F8 Offset: 0x1C5E1F8 VA: 0x1C621F8
	public void OnClickAddSlotWindowButton() { }

	// RVA: 0x1C607B4 Offset: 0x1C5C7B4 VA: 0x1C607B4
	public void ReloadList() { }

	[IteratorStateMachine(typeof(UIRegistletEditPanel.<AddSlot>d__44))]
	// RVA: 0x1C6226C Offset: 0x1C5E26C VA: 0x1C6226C
	private IEnumerator AddSlot() { }

	// RVA: 0x1C62300 Offset: 0x1C5E300 VA: 0x1C62300
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C6236C Offset: 0x1C5E36C VA: 0x1C6236C
	private void <AddSlot>b__44_0() { }
}
