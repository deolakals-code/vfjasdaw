// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongSettingWindowController : MonoBehaviour // TypeDefIndex: 5958
{
	// Fields
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x20
	[SerializeField]
	private UIMahjongSettingContentManagerBase[] settingContents; // 0x28
	private MahjongRoomData roomData; // 0x30
	private UIMahjongMainManager main; // 0x38
	private List<UIMahjongSettingContentManagerBase> settingContentManagers; // 0x40
	private bool isInstanceTitle; // 0x48
	private const float contentHeight = 180;
	private MahjongSettingData beforeSettingData; // 0x50

	// Properties
	public bool InputLock { get; }

	// Methods

	// RVA: 0x18530CC Offset: 0x184F0CC VA: 0x18530CC
	public bool get_InputLock() { }

	// RVA: 0x1853170 Offset: 0x184F170 VA: 0x1853170
	public void Initialize(MahjongRoomData roomData, UIMahjongMainManager main) { }

	// RVA: 0x18535E0 Offset: 0x184F5E0 VA: 0x18535E0
	public void OnClickCloseButton() { }

	// RVA: 0x18536D0 Offset: 0x184F6D0 VA: 0x18536D0
	public void .ctor() { }
}
