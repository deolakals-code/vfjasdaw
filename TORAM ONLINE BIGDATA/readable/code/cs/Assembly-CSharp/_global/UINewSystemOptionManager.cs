// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINewSystemOptionManager : UISystemOptionManager // TypeDefIndex: 7495
{
	// Fields
	[SerializeField]
	private GameObject weaponMonsterTargetPanel; // 0xC8
	[SerializeField]
	private UILabel weaponMonsterTargetMesLabel; // 0xD0
	[SerializeField]
	private GameObject[] weaponMonsterTargetElement; // 0xD8
	[SerializeField]
	private UIToggle[] targetToggles; // 0xE0
	private Dictionary<OptionsSystem.WeaponMonsterTargetType, UISprite[]> weaponMonsterTargetSpriteList; // 0xE8
	protected const float monsterTargetHeight = 950;
	private UISelectButton guardSelectButton; // 0xF0
	private UISelectButton avoidSelectButton; // 0xF8
	private int guardBaseParam; // 0x100
	private int avoidBaseParam; // 0x104
	private string guardAvoidSettingMes; // 0x108

	// Methods

	// RVA: 0x1B70DD4 Offset: 0x1B6CDD4 VA: 0x1B70DD4
	private void Update() { }

	// RVA: 0x1B70EBC Offset: 0x1B6CEBC VA: 0x1B70EBC Slot: 7
	protected override void Initialize() { }

	// RVA: 0x1B71DA0 Offset: 0x1B6DDA0 VA: 0x1B71DA0
	protected void WeaponMosnterTargetPopUp() { }

	// RVA: 0x1B71E28 Offset: 0x1B6DE28 VA: 0x1B71E28
	private void CreateWeaponMonsterTargetPanel(Transform parent) { }

	// RVA: 0x1B727D0 Offset: 0x1B6E7D0 VA: 0x1B727D0
	private void WeaponMonsterTargetCallBack() { }

	// RVA: 0x1B72C64 Offset: 0x1B6EC64 VA: 0x1B72C64
	private void UpdateWeaponMonsterTargetSetting(OptionsSystem.WeaponMonsterTargetType type, int param) { }

	// RVA: 0x1B72768 Offset: 0x1B6E768 VA: 0x1B72768
	private string GetToggleSpriteName(bool isOn) { }

	// RVA: 0x1B72D94 Offset: 0x1B6ED94 VA: 0x1B72D94
	public void OnClickOneHandSword(int param) { }

	// RVA: 0x1B72DA0 Offset: 0x1B6EDA0 VA: 0x1B72DA0
	public void OnClickTwoHandSword(int param) { }

	// RVA: 0x1B72DAC Offset: 0x1B6EDAC VA: 0x1B72DAC
	public void OnClickBow(int param) { }

	// RVA: 0x1B72DB8 Offset: 0x1B6EDB8 VA: 0x1B72DB8
	public void OnClickBowgun(int param) { }

	// RVA: 0x1B72DC4 Offset: 0x1B6EDC4 VA: 0x1B72DC4
	public void OnClickRod(int param) { }

	// RVA: 0x1B72DD0 Offset: 0x1B6EDD0 VA: 0x1B72DD0
	public void OnClickMagictool(int param) { }

	// RVA: 0x1B72DDC Offset: 0x1B6EDDC VA: 0x1B72DDC
	public void OnClickKnuckle(int param) { }

	// RVA: 0x1B72DE8 Offset: 0x1B6EDE8 VA: 0x1B72DE8
	public void OnClickHalberd(int param) { }

	// RVA: 0x1B72DF4 Offset: 0x1B6EDF4 VA: 0x1B72DF4
	public void OnClickKatana(int param) { }

	// RVA: 0x1B72E00 Offset: 0x1B6EE00 VA: 0x1B72E00
	public void OnClickNull(int param) { }

	// RVA: 0x1B72E0C Offset: 0x1B6EE0C VA: 0x1B72E0C
	public void OnClickTarget(int param) { }

	// RVA: 0x1B72EA4 Offset: 0x1B6EEA4 VA: 0x1B72EA4 Slot: 27
	protected override void GuardAvoidSettingPopUp() { }

	// RVA: 0x1B72F2C Offset: 0x1B6EF2C VA: 0x1B72F2C
	private void CreateGuardAvoidPanel(Transform parent) { }

	// RVA: 0x1B73508 Offset: 0x1B6F508 VA: 0x1B73508 Slot: 28
	protected override void GuardAvoidSettingCallBack(int state) { }

	// RVA: 0x1B70DD8 Offset: 0x1B6CDD8 VA: 0x1B70DD8
	private void UpdateGuardAvoidSetting() { }

	// RVA: 0x1B735C8 Offset: 0x1B6F5C8 VA: 0x1B735C8
	protected void EquipBonusColorPopUp() { }

	// RVA: 0x1B73650 Offset: 0x1B6F650 VA: 0x1B73650
	private void CreateEquipBonusColorPanel(Transform parent) { }

	// RVA: 0x1B73BAC Offset: 0x1B6FBAC VA: 0x1B73BAC
	private void UpdateEquipBonusColor(Color color) { }

	// RVA: 0x1B73BCC Offset: 0x1B6FBCC VA: 0x1B73BCC
	private void UpdateEquipLimitBonusColor(Color color) { }

	// RVA: 0x1B73BEC Offset: 0x1B6FBEC VA: 0x1B73BEC
	protected void AutoRejectApplyPopUp() { }

	// RVA: 0x1B73C74 Offset: 0x1B6FC74 VA: 0x1B73C74
	private void CreateRejectApplyPanel(Transform parent) { }

	// RVA: 0x1B74280 Offset: 0x1B70280 VA: 0x1B74280
	private void UpdateRejectApply(int param) { }

	// RVA: 0x1B742A4 Offset: 0x1B702A4 VA: 0x1B742A4
	private void UpdateConditionApply(int param) { }

	// RVA: 0x1B742C8 Offset: 0x1B702C8 VA: 0x1B742C8
	public void .ctor() { }
}
