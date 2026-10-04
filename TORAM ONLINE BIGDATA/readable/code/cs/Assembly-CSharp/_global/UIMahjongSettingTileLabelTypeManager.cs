// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongSettingTileLabelTypeManager : UIMahjongSettingContentManagerBase // TypeDefIndex: 5956
{
	// Fields
	[SerializeField]
	private UISprite button; // 0x30
	[SerializeField]
	private UILabel label; // 0x38
	[SerializeField]
	private GameObject changeWarningLabel; // 0x40
	private MahjongRoomData roomData; // 0x48

	// Properties
	public override UIMahjongSettingContentManagerBase.SettingType settingType { get; }

	// Methods

	// RVA: 0x1852818 Offset: 0x184E818 VA: 0x1852818 Slot: 4
	public override UIMahjongSettingContentManagerBase.SettingType get_settingType() { }

	// RVA: 0x1852820 Offset: 0x184E820 VA: 0x1852820 Slot: 5
	public override void Initialize(MahjongRoomData roomData) { }

	// RVA: 0x18529C4 Offset: 0x184E9C4 VA: 0x18529C4
	public void OnClickToggleButton() { }

	// RVA: 0x18528A8 Offset: 0x184E8A8 VA: 0x18528A8
	private void ChangeButtonSprite() { }

	// RVA: 0x1852A3C Offset: 0x184EA3C VA: 0x1852A3C
	public void .ctor() { }
}
