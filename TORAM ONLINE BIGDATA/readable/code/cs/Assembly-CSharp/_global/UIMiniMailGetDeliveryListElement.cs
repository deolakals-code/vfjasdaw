// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMiniMailGetDeliveryListElement : MonoBehaviour // TypeDefIndex: 7434
{
	// Fields
	private PlayerDataManager playerData; // 0x20
	[SerializeField]
	private UILabel nameLabel; // 0x28
	[SerializeField]
	private UILabel nameOtherLabel; // 0x30
	[SerializeField]
	private UISprite nameIconSprite; // 0x38
	[SerializeField]
	private UISprite limitTimeIcon; // 0x40
	[SerializeField]
	private UILabel limitDaysLabel; // 0x48
	[SerializeField]
	private UILabel sendDateLabel; // 0x50
	[SerializeField]
	private UISprite lineSprite; // 0x58
	[SerializeField]
	private UILabel attentionLabel; // 0x60
	[SerializeField]
	private UILabel getItemLabel; // 0x68
	[SerializeField]
	private UIImageButton getItemButton; // 0x70
	[SerializeField]
	private UILabel mailTitleLabel; // 0x78
	[SerializeField]
	private UILabel itemNameLabel; // 0x80
	[SerializeField]
	private UIIcon itemIcon; // 0x88
	[SerializeField]
	private GameObject MainPanelObj; // 0x90
	[SerializeField]
	private GameObject ExprirePanelObj; // 0x98
	[SerializeField]
	private UILabel textMessageLabel; // 0xA0
	[SerializeField]
	private GameObject mailObjectParent; // 0xA8
	private SystemTextManager systemTextManager; // 0xB0
	private ItemTextManager itemTextManager; // 0xB8
	private ItemData itemData; // 0xC0

	// Properties
	private PlayerDataManager playerDataManager { get; }

	// Methods

	// RVA: 0x1B4E498 Offset: 0x1B4A498 VA: 0x1B4E498
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1B4E51C Offset: 0x1B4A51C VA: 0x1B4E51C
	private void Awake() { }

	// RVA: 0x1B4E6A8 Offset: 0x1B4A6A8 VA: 0x1B4E6A8
	public void Initialize(MailDeliveryData mailData, DateTime serverTime) { }

	// RVA: 0x1B4F158 Offset: 0x1B4B158 VA: 0x1B4F158
	private string GetGetItemDisabledTextKey(MailDeliveryData mailData, bool adminFlag) { }

	// RVA: 0x1B4E8C4 Offset: 0x1B4A8C4 VA: 0x1B4E8C4
	private void SetHeaderData(MailDeliveryData mailData, bool adminFlag) { }

	// RVA: 0x1B4EBA8 Offset: 0x1B4ABA8 VA: 0x1B4EBA8
	private void SetItemData(DateTime serverTime, DateTime timeLimit, short itemType, byte itemAbility, byte type, int value, int num, bool adminFlag) { }

	// RVA: 0x1B4F368 Offset: 0x1B4B368 VA: 0x1B4F368
	private void LimitFlag(bool userFlag) { }

	// RVA: 0x1B4F428 Offset: 0x1B4B428 VA: 0x1B4F428
	private string getItemName(byte type, int value, int num) { }

	// RVA: 0x1B4FB40 Offset: 0x1B4BB40 VA: 0x1B4FB40
	public void Expire() { }

	// RVA: 0x1B4FB78 Offset: 0x1B4BB78 VA: 0x1B4FB78
	public void .ctor() { }
}
