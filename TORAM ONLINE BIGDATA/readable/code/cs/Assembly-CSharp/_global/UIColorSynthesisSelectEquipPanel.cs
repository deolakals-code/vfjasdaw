// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIColorSynthesisSelectEquipPanel : MonoBehaviour, IUIColorSynthesisPanel // TypeDefIndex: 6733
{
	// Fields
	private const int PartCount = 3;
	private static readonly ItemType[] WeaponTypes; // 0x0
	private static readonly string[] EquipTypeIcons; // 0x8
	private static readonly string[] WeaponTypeIcons; // 0x10
	[SerializeField]
	private UISelectButton equipTypeSelectButton; // 0x20
	[SerializeField]
	private UISelectButton partsTypeSelectButton; // 0x28
	[SerializeField]
	private UISelectButton weaponTypeSelectButton; // 0x30
	[SerializeField]
	private UILabel costLabel; // 0x38
	[SerializeField]
	private UIImageButton nextButton; // 0x40
	private UIColorSynthesisMainManager manager; // 0x48
	private PlayerDataManager playerDataManager; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private ItemTextManager itemTextManager; // 0x60
	private bool suppressCallback; // 0x68
	private bool equipBagAvailable; // 0x69
	private bool collectBagAvailable; // 0x6A
	private bool consumeBagAvailable; // 0x6B

	// Methods

	// RVA: 0x19CEBEC Offset: 0x19CABEC VA: 0x19CEBEC Slot: 4
	public void Initialize(UIColorSynthesisMainManager manager, PlayerDataManager playerDataManager, SystemTextManager systemTextManager, ItemTextManager itemTextManager) { }

	// RVA: 0x19CEC4C Offset: 0x19CAC4C VA: 0x19CEC4C Slot: 5
	public void Open() { }

	// RVA: 0x19CFA84 Offset: 0x19CBA84 VA: 0x19CFA84 Slot: 6
	public bool Close() { }

	// RVA: 0x19CF084 Offset: 0x19CB084 VA: 0x19CF084
	private void SetupSelectButtons() { }

	// RVA: 0x19CFBB0 Offset: 0x19CBBB0 VA: 0x19CFBB0
	private void ApplySelection(bool resetGems) { }

	// RVA: 0x19CF7D0 Offset: 0x19CB7D0 VA: 0x19CF7D0
	private void Refresh() { }

	// RVA: 0x19CFA8C Offset: 0x19CBA8C VA: 0x19CFA8C
	private bool IsTargetUnlocked(ColorSynthesisCostTable.Target target) { }

	// RVA: 0x19CEDCC Offset: 0x19CADCC VA: 0x19CEDCC
	private bool IsEquipBagAvailable() { }

	// RVA: 0x19CEE98 Offset: 0x19CAE98 VA: 0x19CEE98
	private bool IsCollectBagAvailable() { }

	// RVA: 0x19CEFA0 Offset: 0x19CAFA0 VA: 0x19CEFA0
	private bool IsConsumeBagAvailable() { }

	// RVA: 0x19CFF14 Offset: 0x19CBF14 VA: 0x19CFF14
	private int RequiredCollectBagSlots(ItemManager im) { }

	// RVA: 0x19CFF5C Offset: 0x19CBF5C VA: 0x19CFF5C
	private int SlotIncrease(ItemManager im, int itemId, int gain) { }

	// RVA: 0x19CFE24 Offset: 0x19CBE24 VA: 0x19CFE24
	private bool IsAffordable() { }

	// RVA: 0x19D0014 Offset: 0x19CC014 VA: 0x19D0014
	private void OnSelectionChanged() { }

	// RVA: 0x19D0098 Offset: 0x19CC098 VA: 0x19D0098
	public void OnNext() { }

	// RVA: 0x19D01C4 Offset: 0x19CC1C4 VA: 0x19D01C4
	public void .ctor() { }

	// RVA: 0x19D01CC Offset: 0x19CC1CC VA: 0x19D01CC
	private static void .cctor() { }
}
