// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipSlotButton : MonoBehaviour // TypeDefIndex: 7010
{
	// Fields
	[SerializeField]
	private UISprite button; // 0x20
	[SerializeField]
	private UISprite frame; // 0x28
	[SerializeField]
	private UIIcon[] cristaSlot; // 0x30
	[SerializeField]
	private UISprite[] cristaSlotBack; // 0x38
	[SerializeField]
	private UILabel equipLabel; // 0x40
	[SerializeField]
	private UISprite winBase; // 0x48
	[SerializeField]
	private UISprite winBaseSele; // 0x50
	private IUIEquipMainManager manager; // 0x58
	private ItemDBData.EquipType equipType; // 0x60
	private bool equipLock; // 0x64
	private bool changeEquipLock; // 0x65
	private bool equipItemFlag; // 0x66
	private UIIcon equipIcon; // 0x68
	private ItemManager itemManager; // 0x70
	private const int equipLabelSize = 400;
	[SerializeField]
	private UISprite avatarEnableButton; // 0x78
	private BodyCustomType customType; // 0x80
	private ItemType equipItemType; // 0x82
	private Action modelUpdateAction; // 0x88
	private Action fieldModelUpdateAction; // 0x90

	// Methods

	// RVA: 0x1A73044 Offset: 0x1A6F044 VA: 0x1A73044
	public void SetModelUpdateAction(Action action, Action fieldAction) { }

	// RVA: 0x1A73074 Offset: 0x1A6F074 VA: 0x1A73074
	public void Initialize(IUIEquipMainManager manager, ItemDBData.EquipType equipType, ItemManager itemManager) { }

	// RVA: 0x1A7310C Offset: 0x1A6F10C VA: 0x1A7310C
	public void SetEquipItem(string itemName, ItemType itemType, int ability, int cristaSlotNum, int[] cristaSlotId) { }

	// RVA: 0x1A738A8 Offset: 0x1A6F8A8 VA: 0x1A738A8
	public void DeleteEquipItem() { }

	// RVA: 0x1A73C74 Offset: 0x1A6FC74 VA: 0x1A73C74
	public void LockEquipItem() { }

	// RVA: 0x1A735F8 Offset: 0x1A6F5F8 VA: 0x1A735F8
	public void ChangeLockEquipItem(bool lockFlag) { }

	// RVA: 0x1A73FF0 Offset: 0x1A6FFF0 VA: 0x1A73FF0
	private void OnClick() { }

	// RVA: 0x1A740B4 Offset: 0x1A700B4 VA: 0x1A740B4
	public void ChangeDepth(bool on) { }

	// RVA: 0x1A742F4 Offset: 0x1A702F4 VA: 0x1A742F4
	public void SetActiveOfAvatarEnableButton(bool isActive) { }

	// RVA: 0x1A74398 Offset: 0x1A70398 VA: 0x1A74398
	public void OnAvatarEnable() { }

	// RVA: 0x1A737CC Offset: 0x1A6F7CC VA: 0x1A737CC
	private void ChangeAvatarEnableButton(bool isEnable) { }

	// RVA: 0x1A744D4 Offset: 0x1A704D4 VA: 0x1A744D4
	public void .ctor() { }
}
