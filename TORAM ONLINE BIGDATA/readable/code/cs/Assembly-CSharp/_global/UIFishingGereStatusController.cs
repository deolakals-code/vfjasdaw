// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingGereStatusController : MonoBehaviour // TypeDefIndex: 7041
{
	// Fields
	[SerializeField]
	private GameObject itemIcon; // 0x20
	[SerializeField]
	private UILabel[] statusNameLabels; // 0x28
	[SerializeField]
	private UILabel[] statusLabels; // 0x30
	[SerializeField]
	private UISlider durabilitySlider; // 0x38
	[SerializeField]
	private UILabel durabilityLabel; // 0x40
	[SerializeField]
	private UISprite checkBox; // 0x48
	[SerializeField]
	private UILabel checkBoxLabel; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private UISprite frameSprite; // 0x60
	private UISprite baseSprite; // 0x68
	private UISprite iconSprite; // 0x70
	private const string EquippedSpriteName = "sys_07";
	private const string UnequippedSpriteName = "sys_08";
	private string[] statusNameLocalizeIds; // 0x78

	// Methods

	// RVA: 0x1A7F2A0 Offset: 0x1A7B2A0 VA: 0x1A7F2A0
	private void Awake() { }

	// RVA: 0x1A7D3A0 Offset: 0x1A793A0 VA: 0x1A7D3A0
	public void ResetRodStatus() { }

	// RVA: 0x1A7C9FC Offset: 0x1A789FC VA: 0x1A7C9FC
	public void SetRodStatus(bool isPossession, byte[] statusValues, byte durabilityValue, byte successionFlag) { }

	// RVA: 0x1A7D3B4 Offset: 0x1A793B4 VA: 0x1A7D3B4
	public void ChangeEquipped(bool isEquipped) { }

	// RVA: 0x1A7F494 Offset: 0x1A7B494 VA: 0x1A7F494
	public void .ctor() { }
}
