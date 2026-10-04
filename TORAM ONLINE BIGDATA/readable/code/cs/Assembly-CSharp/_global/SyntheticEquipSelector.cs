// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SyntheticEquipSelector : MonoBehaviour // TypeDefIndex: 8716
{
	// Fields
	[SerializeField]
	private GameObject arrowRight; // 0x20
	[SerializeField]
	private GameObject arrowLeft; // 0x28
	private ItemData MainItemData; // 0x30
	private ItemData SubItemData; // 0x38
	private Action<ItemData> callback; // 0x40
	private SyntheticEquipSelector.SelectState state; // 0x48

	// Properties
	public bool IsRandom { get; }
	public bool IsEmptyColor1 { get; }
	public bool IsEmptyColor2 { get; }
	public bool IsEmptyColor3 { get; }
	public bool[] GetIsEmptyColors { get; }

	// Methods

	// RVA: 0x1DF14D4 Offset: 0x1DED4D4 VA: 0x1DF14D4
	public bool get_IsRandom() { }

	// RVA: 0x1DF14E4 Offset: 0x1DED4E4 VA: 0x1DF14E4
	public bool get_IsEmptyColor1() { }

	// RVA: 0x1DF151C Offset: 0x1DED51C VA: 0x1DF151C
	public bool get_IsEmptyColor2() { }

	// RVA: 0x1DF1554 Offset: 0x1DED554 VA: 0x1DF1554
	public bool get_IsEmptyColor3() { }

	// RVA: 0x1DF158C Offset: 0x1DED58C VA: 0x1DF158C
	public bool[] get_GetIsEmptyColors() { }

	// RVA: 0x1DF16A4 Offset: 0x1DED6A4 VA: 0x1DF16A4
	public void SetItemData(ItemData main, ItemData sub) { }

	// RVA: 0x1DF174C Offset: 0x1DED74C VA: 0x1DF174C
	public void SetCallback(Action<ItemData> _callback) { }

	// RVA: 0x1DF1708 Offset: 0x1DED708 VA: 0x1DF1708
	public void SetEnableSelect(bool isEnabled) { }

	// RVA: 0x1DE7C88 Offset: 0x1DE3C88 VA: 0x1DE7C88
	public ItemData GetSelectItem() { }

	// RVA: 0x1DF1790 Offset: 0x1DED790 VA: 0x1DF1790
	public SyntheticEquipSelector.SelectState GetSelectState() { }

	// RVA: 0x1DF1798 Offset: 0x1DED798 VA: 0x1DF1798
	private void OnLeftArrow() { }

	// RVA: 0x1DF1838 Offset: 0x1DED838 VA: 0x1DF1838
	private void OnRightArrow() { }

	// RVA: 0x1DF18DC Offset: 0x1DED8DC VA: 0x1DF18DC
	public void .ctor() { }
}
