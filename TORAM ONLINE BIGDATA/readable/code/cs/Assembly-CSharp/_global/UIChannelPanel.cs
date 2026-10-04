// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIChannelPanel : UIBasePanelControl // TypeDefIndex: 7361
{
	// Fields
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x58
	[SerializeField]
	private UIScrollBar scrollBar; // 0x60
	[SerializeField]
	private UISprite scrollForeground; // 0x68
	[SerializeField]
	private GameObject pcKeyLabel; // 0x70
	[SerializeField]
	private UILabel channelLabel; // 0x78
	[SerializeField]
	private UILabel channelStateLabel; // 0x80
	[SerializeField]
	private GameObject admissionButton; // 0x88
	[SerializeField]
	private UILabel admissionLabel; // 0x90
	[SerializeField]
	private UISprite iconSprite; // 0x98
	[SerializeField]
	private UISprite nameBack; // 0xA0
	[SerializeField]
	private GameObject elementObject; // 0xA8
	[SerializeField]
	private float elementHeight; // 0xB0
	[SerializeField]
	private GameObject selectWorld; // 0xB8
	[SerializeField]
	private UIImageButton japaneseButton; // 0xC0
	[SerializeField]
	private UISprite CountryIcon; // 0xC8
	[SerializeField]
	private UIImageButton internationalButton; // 0xD0
	private int channel; // 0xD8
	private int worldId; // 0xDC
	private bool isWorldSelect; // 0xE0
	private ChannelGetListResponse channelList; // 0xE8
	private ChannelGetWorldResponse worldList; // 0xF0
	private Dictionary<WorldType, string[]> worldSelectList; // 0xF8
	private PlayerDataManager playerDataManager; // 0x100

	// Properties
	private PlayerDataManager pData { get; }
	private bool isGMPlayer { get; }

	// Methods

	// RVA: 0x1B24CDC Offset: 0x1B20CDC VA: 0x1B24CDC
	private PlayerDataManager get_pData() { }

	// RVA: 0x1B24D64 Offset: 0x1B20D64 VA: 0x1B24D64
	private bool get_isGMPlayer() { }

	[IteratorStateMachine(typeof(UIChannelPanel.<Start>d__27))]
	// RVA: 0x1B24D80 Offset: 0x1B20D80 VA: 0x1B24D80
	private IEnumerator Start() { }

	[IteratorStateMachine(typeof(UIChannelPanel.<reloadChannnelList>d__28))]
	// RVA: 0x1B24E14 Offset: 0x1B20E14 VA: 0x1B24E14
	private IEnumerator reloadChannnelList() { }

	[IteratorStateMachine(typeof(UIChannelPanel.<getChannelList>d__29))]
	// RVA: 0x1B24EA8 Offset: 0x1B20EA8 VA: 0x1B24EA8
	private IEnumerator getChannelList() { }

	// RVA: 0x1B24F3C Offset: 0x1B20F3C VA: 0x1B24F3C
	private void initializeChannelList() { }

	[IteratorStateMachine(typeof(UIChannelPanel.<reloadWorldList>d__31))]
	// RVA: 0x1B25BB0 Offset: 0x1B21BB0 VA: 0x1B25BB0
	private IEnumerator reloadWorldList() { }

	[IteratorStateMachine(typeof(UIChannelPanel.<getWorldList>d__32))]
	// RVA: 0x1B25C44 Offset: 0x1B21C44 VA: 0x1B25C44
	private IEnumerator getWorldList() { }

	// RVA: 0x1B25CD8 Offset: 0x1B21CD8 VA: 0x1B25CD8
	private void initializeWorldList() { }

	// RVA: 0x1B254E0 Offset: 0x1B214E0 VA: 0x1B254E0
	private void changeChannelState(byte worldType, int channel, int people) { }

	// RVA: 0x1B260F0 Offset: 0x1B220F0 VA: 0x1B260F0
	private void changeWorldState(int worldId, byte worldType, byte state) { }

	// RVA: 0x1B269D4 Offset: 0x1B229D4 VA: 0x1B269D4
	private void setWorldTypeAnother() { }

	// RVA: 0x1B26D5C Offset: 0x1B22D5C VA: 0x1B26D5C
	private void setMyWorld(int worldtype) { }

	[Obsolete]
	// RVA: 0x1B26E00 Offset: 0x1B22E00 VA: 0x1B26E00
	private void setWorldTypeJapan() { }

	// RVA: 0x1B26EB8 Offset: 0x1B22EB8 VA: 0x1B26EB8
	private void OnClick(int param) { }

	// RVA: 0x1B271A8 Offset: 0x1B231A8 VA: 0x1B271A8
	private void onClose() { }

	// RVA: 0x1B26B14 Offset: 0x1B22B14 VA: 0x1B26B14
	private void openPopup() { }

	// RVA: 0x1B27204 Offset: 0x1B23204 VA: 0x1B27204
	private void onClosePopup() { }

	// RVA: 0x1B26C4C Offset: 0x1B22C4C VA: 0x1B26C4C
	private void openItemWarningPopup() { }

	[IteratorStateMachine(typeof(UIChannelPanel.<ItemWarningPopupWindow>d__44))]
	// RVA: 0x1B27230 Offset: 0x1B23230 VA: 0x1B27230
	private IEnumerator ItemWarningPopupWindow(UIPopBaseWindow window) { }

	// RVA: 0x1B272E0 Offset: 0x1B232E0 VA: 0x1B272E0
	private void ScrollActive(bool active) { }

	// RVA: 0x1B27338 Offset: 0x1B23338 VA: 0x1B27338
	public void .ctor() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1B27824 Offset: 0x1B23824 VA: 0x1B27824
	private void <>n__0(Action pushFunction) { }
}
