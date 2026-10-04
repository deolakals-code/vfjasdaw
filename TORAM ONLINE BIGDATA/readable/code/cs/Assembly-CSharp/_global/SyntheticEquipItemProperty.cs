// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SyntheticEquipItemProperty : UIItemProperty // TypeDefIndex: 8712
{
	// Fields
	[SerializeField]
	protected LocalizeText[] randomLabel; // 0xA0
	[SerializeField]
	private UIIruna2Viewport scroll; // 0xA8
	[SerializeField]
	private ItemIcon itemNameLabel; // 0xB0
	protected bool[] isLocks; // 0xB8

	// Methods

	// RVA: 0x1DEE21C Offset: 0x1DEA21C VA: 0x1DEE21C
	private void Start() { }

	// RVA: 0x1DE7490 Offset: 0x1DE3490 VA: 0x1DE7490
	public void SelectItem(ItemData itemData, bool[] prop) { }

	// RVA: 0x1DEE33C Offset: 0x1DEA33C VA: 0x1DEE33C Slot: 4
	public override float WeaponPropertys(ItemData itemData) { }

	// RVA: 0x1DEFBD4 Offset: 0x1DEBBD4 VA: 0x1DEFBD4
	public float WeaponRandomPropertys(ItemData main, ItemData sub) { }

	// RVA: 0x1DF0058 Offset: 0x1DEC058 VA: 0x1DF0058
	public void LuckyFailurePropertys() { }

	// RVA: 0x1DF03DC Offset: 0x1DEC3DC VA: 0x1DF03DC
	public void PropertyColors(byte[] colorId, bool[] isLocks) { }

	// RVA: 0x1DF04E0 Offset: 0x1DEC4E0 VA: 0x1DF04E0 Slot: 6
	public override float ItemPropertys(ItemData itemData) { }

	// RVA: 0x1DF0568 Offset: 0x1DEC568 VA: 0x1DF0568 Slot: 10
	protected override void CreateRandomPropertyIcon() { }

	// RVA: 0x1DF0578 Offset: 0x1DEC578 VA: 0x1DF0578
	public void .ctor() { }
}
