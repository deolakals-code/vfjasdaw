// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithTransferSelectWeapon : MonoBehaviour // TypeDefIndex: 8574
{
	// Fields
	[SerializeField]
	private UISprite buttonBack; // 0x20
	[SerializeField]
	private UILabel label; // 0x28
	[SerializeField]
	private UIImageButton[] buttons; // 0x30
	[SerializeField]
	private UIItemScrollPanelButton itemButton; // 0x38
	private ItemData itemData; // 0x40
	private SmithTransferSelectWeapon.SelectType selectType; // 0x48
	private Action<SmithTransferSelectWeapon.SelectType> onSelect; // 0x50
	private Action<int> onDetail; // 0x58
	private ItemTextManager itemTextManager; // 0x60
	private SystemTextManager systemTextManager; // 0x68
	private ItemRandomPropertyTextManager itemRandomPropTextManager; // 0x70

	// Properties
	public ItemData SelectItemData { get; }
	public bool IsHaveItemData { get; }

	// Methods

	// RVA: 0x1DB0718 Offset: 0x1DAC718 VA: 0x1DB0718
	public ItemData get_SelectItemData() { }

	// RVA: 0x1DAE9D8 Offset: 0x1DAA9D8 VA: 0x1DAE9D8
	public bool get_IsHaveItemData() { }

	// RVA: 0x1DAC20C Offset: 0x1DA820C VA: 0x1DAC20C
	public void Initialize(SmithTransferSelectWeapon.SelectType selectType, Action<SmithTransferSelectWeapon.SelectType> onSelect, Action<int> onDetail) { }

	// RVA: 0x1DAE9E8 Offset: 0x1DAA9E8 VA: 0x1DAE9E8
	public void Clear() { }

	// RVA: 0x1DACF8C Offset: 0x1DA8F8C VA: 0x1DACF8C
	public void SetData(ItemData itemData, bool onlyItemData = False) { }

	// RVA: 0x1DB09D0 Offset: 0x1DAC9D0 VA: 0x1DB09D0
	public void OnSelect() { }

	// RVA: 0x1DB09F0 Offset: 0x1DAC9F0 VA: 0x1DB09F0
	public void OnDetail() { }

	// RVA: 0x1DB0720 Offset: 0x1DAC720 VA: 0x1DB0720
	private void SetText(string text) { }

	// RVA: 0x1DB07B8 Offset: 0x1DAC7B8 VA: 0x1DB07B8
	private void ChangeActiveSelectButton(bool isActive) { }

	// RVA: 0x1DB090C Offset: 0x1DAC90C VA: 0x1DB090C
	private void ChangeActiveDetailButton(bool isActive) { }

	// RVA: 0x1DB0A34 Offset: 0x1DACA34 VA: 0x1DB0A34
	public void .ctor() { }
}
