// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongRoomSettingManager : MonoBehaviour // TypeDefIndex: 5951
{
	// Fields
	[SerializeField]
	private UILabel[] settingLabels; // 0x20
	[SerializeField]
	private GameObject changeSettingButton; // 0x28
	[SerializeField]
	private GameObject autoMatchingButtonDescription; // 0x30
	[SerializeField]
	private UISprite autoMatchingButton; // 0x38
	[SerializeField]
	private GameObject autoMatchingDescription; // 0x40
	[SerializeField]
	private GameObject[] changeAutoMatchingPlanButton; // 0x48
	[SerializeField]
	private GameObject changeSettingDescription; // 0x50
	private MahjongRoomSettingData roomSettingData; // 0x58
	private MahjongRoomData roomData; // 0x60
	private UIMahjongRoomController roomController; // 0x68
	private readonly MahjongRoomSettingData autoMatchingRule; // 0x70

	// Methods

	// RVA: 0x184F2A4 Offset: 0x184B2A4 VA: 0x184F2A4
	public void Initialize(MahjongRoomData roomData, UIMahjongRoomController roomController) { }

	// RVA: 0x1851180 Offset: 0x184D180 VA: 0x1851180
	public string GetRoomSettingLocalizeData(UIMahjongRoomSettingManager.RoomSettingTypes settingTypes, int value) { }

	// RVA: 0x1851814 Offset: 0x184D814 VA: 0x1851814
	private void RoomSettingContentInitialize(UIMahjongRoomSettingManager.RoomSettingTypes settingsType, UILabel label) { }

	// RVA: 0x1851F0C Offset: 0x184DF0C VA: 0x1851F0C
	public void OnClickAutoMatching() { }

	// RVA: 0x1851AA0 Offset: 0x184DAA0 VA: 0x1851AA0
	private void ChangeActiveAutoMatchingObject(bool flag) { }

	// RVA: 0x185201C Offset: 0x184E01C VA: 0x185201C
	public void OnClickChangeAutoMatchingRule() { }

	// RVA: 0x1852118 Offset: 0x184E118 VA: 0x1852118
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18521A8 Offset: 0x184E1A8 VA: 0x18521A8
	private bool <RoomSettingContentInitialize>b__14_0(MahjongMemberData x) { }
}
