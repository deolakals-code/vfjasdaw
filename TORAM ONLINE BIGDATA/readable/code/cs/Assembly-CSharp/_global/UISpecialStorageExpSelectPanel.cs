// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISpecialStorageExpSelectPanel : MonoBehaviour, IUISpecialStoragePanel // TypeDefIndex: 7954
{
	// Fields
	[SerializeField]
	private GameObject expIcon; // 0x20
	[SerializeField]
	private GameObject noIcon; // 0x28
	[SerializeField]
	private UILabel lvIconLabel; // 0x30
	[SerializeField]
	private UILabel percentIconLabel; // 0x38
	[SerializeField]
	private UISprite[] expItemIcon; // 0x40
	[SerializeField]
	private UILabel expItemLabel; // 0x48
	[SerializeField]
	private UILabel limitLabel; // 0x50
	[SerializeField]
	private GameObject[] button; // 0x58
	private UISpecialStorageManager manager; // 0x60
	private SystemTextManager systemTextManager; // 0x68

	// Methods

	// RVA: 0x1C83A94 Offset: 0x1C7FA94 VA: 0x1C83A94 Slot: 4
	public int GetMainPanelFlag() { }

	// RVA: 0x1C83A9C Offset: 0x1C7FA9C VA: 0x1C83A9C Slot: 5
	public void Initialize(UISpecialStorageManager manager) { }

	// RVA: 0x1C83B94 Offset: 0x1C7FB94 VA: 0x1C83B94
	public void OnClickCreateExpPot() { }

	// RVA: 0x1C83C94 Offset: 0x1C7FC94 VA: 0x1C83C94
	public void OnClickCreateExpDrink() { }

	// RVA: 0x1C83D94 Offset: 0x1C7FD94 VA: 0x1C83D94
	public void OnClickUseExDrink() { }

	// RVA: 0x1C83E94 Offset: 0x1C7FE94 VA: 0x1C83E94 Slot: 6
	public bool ChangeActivate() { }

	// RVA: 0x1C845BC Offset: 0x1C805BC VA: 0x1C845BC Slot: 7
	public void OnClickAsobimoMarket() { }

	// RVA: 0x1C84724 Offset: 0x1C80724 VA: 0x1C84724 Slot: 8
	public bool OnLeftTopButton() { }

	// RVA: 0x1C84814 Offset: 0x1C80814 VA: 0x1C84814
	public void .ctor() { }
}
