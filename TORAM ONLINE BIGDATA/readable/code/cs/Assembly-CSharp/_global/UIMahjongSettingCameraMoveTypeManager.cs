// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongSettingCameraMoveTypeManager : UIMahjongSettingContentManagerBase // TypeDefIndex: 5952
{
	// Fields
	[SerializeField]
	private UISprite button; // 0x30
	[SerializeField]
	private UILabel label; // 0x38
	private MahjongRoomData roomData; // 0x40

	// Properties
	public override UIMahjongSettingContentManagerBase.SettingType settingType { get; }

	// Methods

	// RVA: 0x1852280 Offset: 0x184E280 VA: 0x1852280 Slot: 4
	public override UIMahjongSettingContentManagerBase.SettingType get_settingType() { }

	// RVA: 0x1852288 Offset: 0x184E288 VA: 0x1852288 Slot: 5
	public override void Initialize(MahjongRoomData roomData) { }

	// RVA: 0x18523C0 Offset: 0x184E3C0 VA: 0x18523C0
	public void OnClickToggleButton() { }

	// RVA: 0x18522A4 Offset: 0x184E2A4 VA: 0x18522A4
	private void ChangeButtonSprite() { }

	// RVA: 0x1852438 Offset: 0x184E438 VA: 0x1852438
	public void .ctor() { }
}
