// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemRandomPropertyManager // TypeDefIndex: 2032
{
	// Fields
	public const short NonRPropertyIdLimit = 9;
	[CompilerGenerated]
	private bool <IsPrevSuccess>k__BackingField; // 0x10
	private readonly BonusManager bonusManager; // 0x18
	private readonly EquipBuffManager equipBuffManager; // 0x20
	private Dictionary<ItemDBData.EquipType, ItemRandomPropertyData> equipDataList; // 0x28

	// Properties
	public Dictionary<ItemDBData.EquipType, ItemRandomPropertyData> EquipDataList { get; }
	public bool IsPrevSuccess { get; set; }

	// Methods

	// RVA: 0x213911C Offset: 0x213511C VA: 0x213911C
	public void .ctor(BonusManager bonusManager, EquipBuffManager equipBuffManager) { }

	// RVA: 0x21392A0 Offset: 0x21352A0 VA: 0x21392A0
	public Dictionary<ItemDBData.EquipType, ItemRandomPropertyData> get_EquipDataList() { }

	[CompilerGenerated]
	// RVA: 0x21392A8 Offset: 0x21352A8 VA: 0x21392A8
	public bool get_IsPrevSuccess() { }

	[CompilerGenerated]
	// RVA: 0x21392B0 Offset: 0x21352B0 VA: 0x21392B0
	private void set_IsPrevSuccess(bool value) { }

	// RVA: 0x21391DC Offset: 0x21351DC VA: 0x21391DC
	public void Initialize() { }

	// RVA: 0x21392BC Offset: 0x21352BC VA: 0x21392BC
	public void Clear() { }

	// RVA: 0x213930C Offset: 0x213530C VA: 0x213930C
	public void Update() { }

	// RVA: 0x2139470 Offset: 0x2135470 VA: 0x2139470
	public void UpdateItem(ItemDBData.EquipType type, ItemData item) { }

	// RVA: 0x2139538 Offset: 0x2135538 VA: 0x2139538
	public bool RemoveEquip(ItemDBData.EquipType type) { }

	// RVA: 0x21395F8 Offset: 0x21355F8 VA: 0x21395F8
	public bool SetEquip(ItemDBData.EquipType type, short randomProperty) { }

	// RVA: 0x2139950 Offset: 0x2135950 VA: 0x2139950
	public bool TryGetRandomProperty(byte equipType, short propertyId, out ItemRandomPropertyData randomPropertyData) { }

	// RVA: 0x2139A5C Offset: 0x2135A5C VA: 0x2139A5C
	public void ResetRandomProperty() { }

	// RVA: 0x2139BC0 Offset: 0x2135BC0 VA: 0x2139BC0
	public void TransferItemRandomProperty(int shopId, int targetItemUuid, int materialItemUuid, short useMagicHammer, short useSuperMagicHammer, short useHyperMagicHammer, short useOrbMagicHammer) { }
}
