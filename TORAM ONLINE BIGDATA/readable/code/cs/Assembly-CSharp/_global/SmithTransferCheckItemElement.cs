// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithTransferCheckItemElement : MonoBehaviour // TypeDefIndex: 8571
{
	// Fields
	[SerializeField]
	private GameObject[] buttonObjs; // 0x20
	[SerializeField]
	private UISprite icon; // 0x28
	[SerializeField]
	private UILabel[] labels; // 0x30
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x38
	private PlayerDataManager playerDataManaer; // 0x40
	private int count; // 0x48
	private int itemCount; // 0x4C
	private ItemTextManager itemTextManager; // 0x50
	private int successRate; // 0x58
	private Action callBack; // 0x60

	// Properties
	public int ItemId { get; set; }
	public int SelectCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DB044C Offset: 0x1DAC44C VA: 0x1DB044C
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x1DB0454 Offset: 0x1DAC454 VA: 0x1DB0454
	private void set_ItemId(int value) { }

	// RVA: 0x1DB045C Offset: 0x1DAC45C VA: 0x1DB045C
	public int get_SelectCount() { }

	// RVA: 0x1DADE6C Offset: 0x1DA9E6C VA: 0x1DADE6C
	public void Initialize(int itemId, int successRate, Action callBack) { }

	// RVA: 0x1DAED7C Offset: 0x1DAAD7C VA: 0x1DAED7C
	public void SetCount(int count) { }

	// RVA: 0x1DAEF10 Offset: 0x1DAAF10 VA: 0x1DAEF10
	public void UpdateSuccessRate(int successRate) { }

	// RVA: 0x1DB05DC Offset: 0x1DAC5DC VA: 0x1DB05DC
	public void OnMinus() { }

	// RVA: 0x1DB062C Offset: 0x1DAC62C VA: 0x1DB062C
	public void OnPlus() { }

	// RVA: 0x1DB0558 Offset: 0x1DAC558 VA: 0x1DB0558
	private void UpdateButton() { }

	// RVA: 0x1DB0464 Offset: 0x1DAC464 VA: 0x1DB0464
	private void UpdateCountText() { }

	// RVA: 0x1DB067C Offset: 0x1DAC67C VA: 0x1DB067C
	public void .ctor() { }
}
