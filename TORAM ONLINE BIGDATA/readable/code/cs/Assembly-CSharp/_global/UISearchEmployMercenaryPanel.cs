// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISearchEmployMercenaryPanel : MonoBehaviour // TypeDefIndex: 7432
{
	// Fields
	[SerializeField]
	private GameObject[] buttonObjs; // 0x20
	[SerializeField]
	private GameObject[] iconObjs; // 0x28
	private const int statusButtonNum = 6;
	private const int weaponTypeNum = 9;
	private UISearchEmployMercenaryPanel.WeaponType selectWeaponType; // 0x30
	private byte selectStatusType; // 0x34
	private UIImageButton[] statusButtons; // 0x38
	private UILabel[] weaponLabels; // 0x40
	private TweenScale[] iconTweenScales; // 0x48
	private Action endAction; // 0x50

	// Properties
	public bool IsActive { get; }
	public byte SelectStatusType { get; }
	public UISearchEmployMercenaryPanel.WeaponType SelectWeaponType { get; }
	public ItemType SelectWeaponItemType { get; }
	public bool IsAttacker { get; }
	public bool IsDefender { get; }
	public bool IsPower { get; }
	public bool IsMaxHp { get; }
	public bool IsStaminaMax { get; }
	public bool IsNoStamina { get; }

	// Methods

	// RVA: 0x1B46178 Offset: 0x1B42178 VA: 0x1B46178
	public bool get_IsActive() { }

	// RVA: 0x1B4D728 Offset: 0x1B49728 VA: 0x1B4D728
	public byte get_SelectStatusType() { }

	// RVA: 0x1B4D730 Offset: 0x1B49730 VA: 0x1B4D730
	public UISearchEmployMercenaryPanel.WeaponType get_SelectWeaponType() { }

	// RVA: 0x1B4517C Offset: 0x1B4117C VA: 0x1B4517C
	public ItemType get_SelectWeaponItemType() { }

	// RVA: 0x1B45164 Offset: 0x1B41164 VA: 0x1B45164
	public bool get_IsAttacker() { }

	// RVA: 0x1B45170 Offset: 0x1B41170 VA: 0x1B45170
	public bool get_IsDefender() { }

	// RVA: 0x1B4507C Offset: 0x1B4107C VA: 0x1B4507C
	public bool get_IsPower() { }

	// RVA: 0x1B45088 Offset: 0x1B41088 VA: 0x1B45088
	public bool get_IsMaxHp() { }

	// RVA: 0x1B451EC Offset: 0x1B411EC VA: 0x1B451EC
	public bool get_IsStaminaMax() { }

	// RVA: 0x1B451F8 Offset: 0x1B411F8 VA: 0x1B451F8
	public bool get_IsNoStamina() { }

	// RVA: 0x1B4D738 Offset: 0x1B49738 VA: 0x1B4D738
	public void SetAction(Action endAction) { }

	// RVA: 0x1B4D740 Offset: 0x1B49740 VA: 0x1B4D740
	private void Start() { }

	// RVA: 0x1B4DB68 Offset: 0x1B49B68 VA: 0x1B4DB68
	private void OnStatus(int param) { }

	// RVA: 0x1B4DBC0 Offset: 0x1B49BC0 VA: 0x1B4DBC0
	private void OnWeapon(int param) { }

	// RVA: 0x1B4DEA8 Offset: 0x1B49EA8 VA: 0x1B4DEA8
	private void OnSearch() { }

	// RVA: 0x1B4DACC Offset: 0x1B49ACC VA: 0x1B4DACC
	private void ChangeStatusButton(UIImageButton button, bool isEnable) { }

	// RVA: 0x1B4DBD4 Offset: 0x1B49BD4 VA: 0x1B4DBD4
	private void ChangeWeaponButton(UISearchEmployMercenaryPanel.WeaponType type) { }

	// RVA: 0x1B4DEC4 Offset: 0x1B49EC4 VA: 0x1B4DEC4
	public void .ctor() { }
}
