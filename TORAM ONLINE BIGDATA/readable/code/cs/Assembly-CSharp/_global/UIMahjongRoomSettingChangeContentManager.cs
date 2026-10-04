// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongRoomSettingChangeContentManager : MonoBehaviour // TypeDefIndex: 5947
{
	// Fields
	[SerializeField]
	private UILabel titleLabel; // 0x20
	[SerializeField]
	private UISprite button; // 0x28
	[SerializeField]
	private Transform buttonParent; // 0x30
	[SerializeField]
	private GameObject line; // 0x38
	private MahjongRoomData roomData; // 0x40
	private UIMahjongRoomSettingManager.RoomSettingTypes settingType; // 0x48
	private List<UISprite> buttons; // 0x50
	private const float ButtonWidthSpacing = 186;
	private const float ButtonHeightSpacing = -70;
	private const byte ButtonRowMaxCount = 4;
	private const string ButtonEnableSpritName = "flex_butt01";
	private const string ButtonDisableSpritName = "flex_butt02";

	// Properties
	public int ButtonCount { get; }

	// Methods

	// RVA: 0x185062C Offset: 0x184C62C VA: 0x185062C
	public int get_ButtonCount() { }

	// RVA: 0x1850678 Offset: 0x184C678 VA: 0x1850678
	public void Initialize(MahjongRoomData roomData, UIMahjongRoomSettingManager settingManager, UIMahjongRoomSettingManager.RoomSettingTypes settingType, Action<UIMahjongRoomSettingManager.RoomSettingTypes, int> buttonAction) { }

	// RVA: 0x1851294 Offset: 0x184D294 VA: 0x1851294
	public void ChangeActiveButtons(int activeIndex) { }

	// RVA: 0x1851390 Offset: 0x184D390 VA: 0x1851390
	public void .ctor() { }
}
