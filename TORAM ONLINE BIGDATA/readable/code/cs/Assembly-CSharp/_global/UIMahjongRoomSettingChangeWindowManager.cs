// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongRoomSettingChangeWindowManager : MonoBehaviour // TypeDefIndex: 5948
{
	// Fields
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x20
	[SerializeField]
	private UIMahjongRoomSettingChangeContentManager defaultSettingContent; // 0x28
	private MahjongRoomData room; // 0x30
	private UIMahjongRoomSettingManager settingManager; // 0x38
	private Dictionary<UIMahjongRoomSettingManager.RoomSettingTypes, UIMahjongRoomSettingChangeContentManager> settingTypeObjects; // 0x40
	private MahjongRoomSettingData beforeSettingData; // 0x48
	private MahjongRoomSettingData afterSettingData; // 0x50
	private const float ContentHeight = 160;

	// Methods

	// RVA: 0x184F4A8 Offset: 0x184B4A8 VA: 0x184F4A8
	public void Initialize(MahjongRoomData roomData, UIMahjongRoomSettingManager settingManager) { }

	// RVA: 0x18513CC Offset: 0x184D3CC VA: 0x18513CC
	private void ChangeSettingData(UIMahjongRoomSettingManager.RoomSettingTypes settingType, int value) { }

	// RVA: 0x18515C0 Offset: 0x184D5C0 VA: 0x18515C0
	public void OnClickEnter() { }

	// RVA: 0x18517E0 Offset: 0x184D7E0 VA: 0x18517E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18517E8 Offset: 0x184D7E8 VA: 0x18517E8
	private bool <OnClickEnter>b__10_0(MahjongMemberData x) { }
}
