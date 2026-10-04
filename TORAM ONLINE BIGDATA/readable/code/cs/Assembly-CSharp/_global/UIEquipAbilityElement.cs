// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipAbilityElement : MonoBehaviour // TypeDefIndex: 6898
{
	// Fields
	[SerializeField]
	private UIImageButton imageButton; // 0x20
	[SerializeField]
	private UILabel buttonLabel; // 0x28
	[SerializeField]
	private UISprite[] buttonIcons; // 0x30
	[SerializeField]
	private GameObject equipIconObj; // 0x38
	[SerializeField]
	private UIIcon itemIcon; // 0x40
	[SerializeField]
	private GameObject itemBatsuIcon; // 0x48
	[SerializeField]
	private UILabel itemLabel; // 0x50
	[SerializeField]
	private UILabel[] itemAbilityLabels; // 0x58
	[SerializeField]
	private UISprite[] itemAbilityMaxIcons; // 0x60
	[SerializeField]
	private GameObject buySlotButton; // 0x68
	private int index; // 0x70
	private OrbEnchantData enchantData; // 0x78
	private Action<int, OrbEnchantData> callback; // 0x80
	private SystemTextManager systemTextManager; // 0x88
	private ItemTextManager itemTextManager; // 0x90
	private ItemPropertyTextManager itemPropertyTextManager; // 0x98
	private Action buySlotCallBack; // 0xA0

	// Methods

	// RVA: 0x1A3ED74 Offset: 0x1A3AD74 VA: 0x1A3ED74
	public void InitializeRegant(int index, OrbEnchantData enchantData, EquipType itemEquipType, bool isOld, Action<int, OrbEnchantData> buttonCallBack) { }

	// RVA: 0x1A3F39C Offset: 0x1A3B39C VA: 0x1A3F39C
	public void InitializeExtract(int index, OrbEnchantData enchantData, Action<int, OrbEnchantData> buttonCallBack) { }

	// RVA: 0x1A3F8FC Offset: 0x1A3B8FC VA: 0x1A3F8FC
	public void InitializeBuySlot(Action callBack) { }

	// RVA: 0x1A3F9E8 Offset: 0x1A3B9E8 VA: 0x1A3F9E8
	public void OnBuySlot() { }

	// RVA: 0x1A3FA04 Offset: 0x1A3BA04 VA: 0x1A3FA04
	private void onSelect() { }

	// RVA: 0x1A3FA28 Offset: 0x1A3BA28 VA: 0x1A3FA28
	public void .ctor() { }
}
