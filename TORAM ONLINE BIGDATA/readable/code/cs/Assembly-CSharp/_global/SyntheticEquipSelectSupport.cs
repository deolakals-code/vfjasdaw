// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SyntheticEquipSelectSupport : MonoBehaviour // TypeDefIndex: 8717
{
	// Fields
	[SerializeField]
	private UILabel nameLabel; // 0x20
	[SerializeField]
	private UILabel descriptionLabel; // 0x28
	private ItemTextManager itemTextManager; // 0x30
	private SystemTextManager systemTextManager; // 0x38
	private PlayerDataManager playerDataManager; // 0x40
	private ItemDBData[] itemDatas; // 0x48
	private int selectedIndex; // 0x50

	// Properties
	public bool IsNotUse { get; }

	// Methods

	// RVA: 0x1DF1A50 Offset: 0x1DEDA50 VA: 0x1DF1A50
	public bool get_IsNotUse() { }

	// RVA: 0x1DF1A68 Offset: 0x1DEDA68 VA: 0x1DF1A68
	private void Awake() { }

	// RVA: 0x1DF1C20 Offset: 0x1DEDC20 VA: 0x1DF1C20
	private void Start() { }

	// RVA: 0x1DF1FC8 Offset: 0x1DEDFC8 VA: 0x1DF1FC8
	public void Initialize(ItemDBData[] items) { }

	// RVA: 0x1DE745C Offset: 0x1DE345C VA: 0x1DE745C
	public ItemDBData GetSelectItem() { }

	// RVA: 0x1DF223C Offset: 0x1DEE23C VA: 0x1DF223C
	public void onRight() { }

	// RVA: 0x1DF2270 Offset: 0x1DEE270 VA: 0x1DF2270
	public void onLeft() { }

	// RVA: 0x1DF2100 Offset: 0x1DEE100 VA: 0x1DF2100
	private void updateName() { }

	// RVA: 0x1DF22A4 Offset: 0x1DEE2A4 VA: 0x1DF22A4
	public void .ctor() { }
}
