// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBagIcon : MonoBehaviour // TypeDefIndex: 7331
{
	// Fields
	[SerializeField]
	private UILabel itemNumLabel; // 0x20
	[SerializeField]
	private UILabel bagIdLabel; // 0x28
	[SerializeField]
	private UISprite stateSprite; // 0x30
	private int itemStock; // 0x38
	private int itemNum; // 0x3C
	[CompilerGenerated]
	private int <BagId>k__BackingField; // 0x40

	// Properties
	public int BagId { get; set; }
	public bool IsBagMax { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B13100 Offset: 0x1B0F100 VA: 0x1B13100
	private void set_BagId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B13108 Offset: 0x1B0F108 VA: 0x1B13108
	public int get_BagId() { }

	// RVA: 0x1B13110 Offset: 0x1B0F110 VA: 0x1B13110
	public bool get_IsBagMax() { }

	// RVA: 0x1B13120 Offset: 0x1B0F120 VA: 0x1B13120
	public void Initialize(int bagId, int itemNum, int itemStock) { }

	// RVA: 0x1B1346C Offset: 0x1B0F46C VA: 0x1B1346C
	public void ItemBagAdd() { }

	// RVA: 0x1B132CC Offset: 0x1B0F2CC VA: 0x1B132CC
	private void ItemNumUpdate(int itemNum) { }

	// RVA: 0x1B13478 Offset: 0x1B0F478 VA: 0x1B13478
	public void .ctor() { }
}
