// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SyntheticEquipProperty : MonoBehaviour // TypeDefIndex: 8713
{
	// Fields
	[SerializeField]
	private UISprite icon; // 0x20
	[SerializeField]
	private UISprite colorIcon; // 0x28
	[SerializeField]
	private UILabel nameLabel; // 0x30
	[SerializeField]
	private UISprite[] cristaIcon; // 0x38
	[SerializeField]
	private GameObject[] selectButtons; // 0x40
	private SystemTextManager systemTextManager; // 0x48
	private ItemTextManager itemTextManager; // 0x50
	private ItemData[] itemDatas; // 0x58
	private bool IsCristaShow; // 0x60
	private int selectedIndex; // 0x64
	private Vector3 nameLabelDefaultPosition; // 0x68
	private Action<int> OnChangedCallback; // 0x78
	private int colorIndex; // 0x80
	private int propertyIndex; // 0x84
	private bool isLock; // 0x88
	private bool isEnabled; // 0x89

	// Properties
	public bool IsRandom { get; }
	public ItemData SelectedItemData { get; }

	// Methods

	// RVA: 0x1DF0608 Offset: 0x1DEC608 VA: 0x1DF0608
	public bool get_IsRandom() { }

	// RVA: 0x1DF0638 Offset: 0x1DEC638 VA: 0x1DF0638
	public ItemData get_SelectedItemData() { }

	// RVA: 0x1DF067C Offset: 0x1DEC67C VA: 0x1DF067C
	private void Awake() { }

	// RVA: 0x1DF0908 Offset: 0x1DEC908 VA: 0x1DF0908
	public void SetIsLock(bool isLock) { }

	// RVA: 0x1DF084C Offset: 0x1DEC84C VA: 0x1DF084C
	public void SetEnabled(bool enabled) { }

	// RVA: 0x1DF0B20 Offset: 0x1DECB20 VA: 0x1DF0B20
	public void Initialize(int index, bool isCrista, bool isEquipIcon, int colorIndex, Action<int> onChanged, ItemData[] items) { }

	// RVA: 0x1DF1348 Offset: 0x1DED348 VA: 0x1DF1348
	public void Reset() { }

	// RVA: 0x1DF0634 Offset: 0x1DEC634 VA: 0x1DF0634
	public ItemData GetSelectItem() { }

	// RVA: 0x1DF1368 Offset: 0x1DED368 VA: 0x1DF1368
	public void onRight() { }

	// RVA: 0x1DF13AC Offset: 0x1DED3AC VA: 0x1DF13AC
	public void onLeft() { }

	// RVA: 0x1DF0D24 Offset: 0x1DECD24 VA: 0x1DF0D24
	private void updateName() { }

	// RVA: 0x1DF13F0 Offset: 0x1DED3F0 VA: 0x1DF13F0
	public void .ctor() { }
}
