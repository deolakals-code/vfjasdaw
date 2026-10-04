// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithStrengtheningCompleteDialog : MonoBehaviour // TypeDefIndex: 8561
{
	// Fields
	[SerializeField]
	private ItemIcon[] UsedItemLabel; // 0x20
	[SerializeField]
	private UILabel ItemNameLabel; // 0x28
	[SerializeField]
	private UILabel ItemNameSubLabel; // 0x30
	[SerializeField]
	private UILabel SuccessLabel; // 0x38
	[SerializeField]
	private UILabel TitleLabel; // 0x40
	private bool Result; // 0x48
	private SystemTextManager systemTextManager; // 0x50

	// Methods

	// RVA: 0x1DAB0F4 Offset: 0x1DA70F4 VA: 0x1DAB0F4
	private void Awake() { }

	// RVA: 0x1DAB1DC Offset: 0x1DA71DC VA: 0x1DAB1DC
	public void SetUsedItem(int[] names) { }

	// RVA: 0x1DAB31C Offset: 0x1DA731C VA: 0x1DAB31C
	public void SetCost(string cost, int index) { }

	// RVA: 0x1DAB48C Offset: 0x1DA748C VA: 0x1DAB48C
	public void SetItemName(string name) { }

	// RVA: 0x1DAB520 Offset: 0x1DA7520 VA: 0x1DAB520
	public void SetItemNameSub(string supplement) { }

	// RVA: 0x1DAB5B4 Offset: 0x1DA75B4 VA: 0x1DAB5B4
	public void Close() { }

	// RVA: 0x1DAB5D8 Offset: 0x1DA75D8 VA: 0x1DAB5D8
	public void Open() { }

	// RVA: 0x1DAB5FC Offset: 0x1DA75FC VA: 0x1DAB5FC
	public void SetResult(bool isSuccess) { }

	// RVA: 0x1DAB6F8 Offset: 0x1DA76F8 VA: 0x1DAB6F8
	public void .ctor() { }
}
