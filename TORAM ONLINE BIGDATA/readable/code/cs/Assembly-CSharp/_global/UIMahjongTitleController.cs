// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongTitleController : MonoBehaviour // TypeDefIndex: 5963
{
	// Fields
	[SerializeField]
	private GameObject roomButtons; // 0x20
	[SerializeField]
	private GameObject roomIdInputWindow; // 0x28
	[SerializeField]
	private GameObject roomIdInputWindowAnchor; // 0x30
	[SerializeField]
	private UIButtonCallAction roomIdInputNumButton; // 0x38
	[SerializeField]
	private UILabel roomIdInputLabel; // 0x40
	private MahjongRoomData roomData; // 0x48
	private UIMahjongMainManager main; // 0x50
	private string inputedRoomId; // 0x58
	private GameObject[] numButtons; // 0x60
	private const byte NumButtonMaxCount = 12;
	private const int NumButtonSpacingWidth = 90;
	private const int NumButtonSpacingHeight = -65;
	private const byte RoomNumLength = 6;

	// Properties
	private bool InputLock { get; }
	public bool IsActiveRoomIdInputWindow { get; }

	// Methods

	// RVA: 0x185547C Offset: 0x185147C VA: 0x185547C
	private bool get_InputLock() { }

	// RVA: 0x1855520 Offset: 0x1851520 VA: 0x1855520
	public bool get_IsActiveRoomIdInputWindow() { }

	// RVA: 0x18555A8 Offset: 0x18515A8 VA: 0x18555A8
	public void Initialize(MahjongRoomData roomData, UIMahjongMainManager mainManager) { }

	// RVA: 0x1855AC8 Offset: 0x1851AC8 VA: 0x1855AC8
	public void OnClickCloseButton() { }

	// RVA: 0x1855D5C Offset: 0x1851D5C VA: 0x1855D5C
	public void OnClickCreateRoom() { }

	// RVA: 0x1855DD0 Offset: 0x1851DD0 VA: 0x1855DD0
	public void OnClickJoinRoom() { }

	// RVA: 0x1856138 Offset: 0x1852138 VA: 0x1856138
	public void OnClickJoinRoomEnter() { }

	// RVA: 0x18561D8 Offset: 0x18521D8 VA: 0x18561D8
	public void OnClickSettingsButton() { }

	// RVA: 0x1856248 Offset: 0x1852248 VA: 0x1856248
	public void OnClickVoiceListButton() { }

	// RVA: 0x1855690 Offset: 0x1851690 VA: 0x1855690
	private void InstantiateRoomInputNumButtons() { }

	// RVA: 0x1855F24 Offset: 0x1851F24 VA: 0x1855F24
	private void InputRoomIdNum(int value) { }

	// RVA: 0x18562C0 Offset: 0x18522C0 VA: 0x18562C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1856318 Offset: 0x1852318 VA: 0x1856318
	private void <OnClickCloseButton>b__18_0() { }

	[CompilerGenerated]
	// RVA: 0x185638C Offset: 0x185238C VA: 0x185638C
	private void <OnClickCloseButton>b__18_1() { }

	[IteratorStateMachine(typeof(UIMahjongTitleController.<<OnClickCloseButton>g__InputWindowFadeOut|18_2>d))]
	[CompilerGenerated]
	// RVA: 0x1855CF0 Offset: 0x1851CF0 VA: 0x1855CF0
	private IEnumerator <OnClickCloseButton>g__InputWindowFadeOut|18_2() { }
}
