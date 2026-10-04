// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIItemProperty : MonoBehaviour // TypeDefIndex: 7354
{
	// Fields
	protected readonly string IconSpaceText; // 0x20
	private static readonly short[] HightPropertys; // 0x0
	[SerializeField]
	protected UILabel propertyPanelText; // 0x28
	[SerializeField]
	protected UILabel propertyPanelPlayerText; // 0x30
	[SerializeField]
	protected UISprite[] cristaIcon; // 0x38
	[SerializeField]
	protected UISprite[] cristaSlotIcon; // 0x40
	[SerializeField]
	protected UISprite[] equipColorIcon; // 0x48
	[SerializeField]
	protected UISprite[] equipColorIconBack; // 0x50
	protected UISprite randomPropertyIcon; // 0x58
	protected readonly Color[] randomPropIconColorList; // 0x60
	protected int randomPropIconSize; // 0x68
	private SystemTextManager systemManager; // 0x70
	private ItemTextManager itemManager; // 0x78
	private ItemPropertyTextManager itemPropertyManager; // 0x80
	private SkillTextManager skillManager; // 0x88
	private ItemRandomPropertyTextManager itemRandomPropertyMananager; // 0x90
	private int widthWord; // 0x98

	// Properties
	public SystemTextManager systemTextManager { get; }
	public ItemTextManager itemTextManager { get; }
	public ItemPropertyTextManager itemPropertyTextManager { get; }
	public SkillTextManager skillTextManager { get; }
	public ItemRandomPropertyTextManager itemRandomPropertyTextMananager { get; }

	// Methods

	// RVA: 0x1B1EC9C Offset: 0x1B1AC9C VA: 0x1B1EC9C
	public static string AddCapPropertyNoColor(short id, short val, ItemPropertyTextManager itemPropertyTextManager, SystemTextManager systemManager) { }

	// RVA: 0x1B1F400 Offset: 0x1B1B400 VA: 0x1B1F400
	public static string AddCapProperty(short id, short val, ItemPropertyTextManager itemPropertyTextManager, SystemTextManager systemManager) { }

	// RVA: 0x1B1ED1C Offset: 0x1B1AD1C VA: 0x1B1ED1C
	public static string AddCapProperty(bool isColor, short id, short val, ItemPropertyTextManager itemPropertyTextManager, SystemTextManager systemManager) { }

	// RVA: 0x1B1F480 Offset: 0x1B1B480 VA: 0x1B1F480
	public static string GetItemPropertysTextData(short[] capId, short[] capVal, int widthWord, ItemPropertyTextManager itemPropertyTextManager, SystemTextManager systemManager) { }

	// RVA: 0x1B1F960 Offset: 0x1B1B960 VA: 0x1B1F960
	public SystemTextManager get_systemTextManager() { }

	// RVA: 0x1B1FA4C Offset: 0x1B1BA4C VA: 0x1B1FA4C
	public ItemTextManager get_itemTextManager() { }

	// RVA: 0x1B1FB38 Offset: 0x1B1BB38 VA: 0x1B1FB38
	public ItemPropertyTextManager get_itemPropertyTextManager() { }

	// RVA: 0x1B1FC24 Offset: 0x1B1BC24 VA: 0x1B1FC24
	public SkillTextManager get_skillTextManager() { }

	// RVA: 0x1B1FD10 Offset: 0x1B1BD10 VA: 0x1B1FD10
	public ItemRandomPropertyTextManager get_itemRandomPropertyTextMananager() { }

	// RVA: 0x1B1FDFC Offset: 0x1B1BDFC VA: 0x1B1FDFC
	private void Awake() { }

	// RVA: 0x1B1FEEC Offset: 0x1B1BEEC VA: 0x1B1FEEC
	public static int RowCount(string text) { }

	// RVA: 0x1B1FFAC Offset: 0x1B1BFAC VA: 0x1B1FFAC
	public void SetWidthWord(int num) { }

	// RVA: 0x1B1FFB4 Offset: 0x1B1BFB4 VA: 0x1B1FFB4
	public void Clear() { }

	// RVA: 0x1B20008 Offset: 0x1B1C008 VA: 0x1B20008
	protected string ItemLockPropertys(int lockFlag, bool creater) { }

	// RVA: 0x1B20128 Offset: 0x1B1C128 VA: 0x1B20128
	protected string ItemPropertysData(ItemData itemData) { }

	// RVA: 0x1B201BC Offset: 0x1B1C1BC VA: 0x1B201BC
	public void ItemDBProperty(int itemId) { }

	// RVA: 0x1B20744 Offset: 0x1B1C744 VA: 0x1B20744
	private string ItemText(int itemId) { }

	// RVA: 0x1B20CB0 Offset: 0x1B1CCB0 VA: 0x1B20CB0 Slot: 4
	public virtual float WeaponPropertys(ItemData itemData) { }

	// RVA: 0x1B20D0C Offset: 0x1B1CD0C VA: 0x1B20D0C
	public float WeaponPropertys(ItemData itemData, string text) { }

	// RVA: 0x1B20D14 Offset: 0x1B1CD14 VA: 0x1B20D14
	public float WeaponPropertys(ItemData itemData, string text, bool isPotentialZero) { }

	// RVA: 0x1B228E4 Offset: 0x1B1E8E4 VA: 0x1B228E4 Slot: 5
	public virtual float AvatarEquipPropertys(ItemData itemData) { }

	// RVA: 0x1B22EA8 Offset: 0x1B1EEA8 VA: 0x1B22EA8 Slot: 6
	public virtual float ItemPropertys(ItemData itemData) { }

	// RVA: 0x1B23694 Offset: 0x1B1F694 VA: 0x1B23694 Slot: 7
	public virtual float CristaPropertys(ItemData itemData) { }

	// RVA: 0x1B23D7C Offset: 0x1B1FD7C VA: 0x1B23D7C Slot: 8
	public virtual float PetcagePropertys(ItemData itemData) { }

	// RVA: 0x1B2444C Offset: 0x1B2044C VA: 0x1B2444C Slot: 9
	public virtual float StarGemPropertys(StarGemData starGemData) { }

	// RVA: 0x1B2473C Offset: 0x1B2073C VA: 0x1B2473C Slot: 10
	protected virtual void CreateRandomPropertyIcon() { }

	// RVA: 0x1B24A6C Offset: 0x1B20A6C VA: 0x1B24A6C
	public void .ctor() { }

	// RVA: 0x1B24C3C Offset: 0x1B20C3C VA: 0x1B24C3C
	private static void .cctor() { }
}
