// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGlobalChannelPanel : UIBasePanelControl // TypeDefIndex: 7368
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
	private GlobalChannelGetListResponse channelList; // 0xE8
	private GlobalChannelGetWorldResponse worldList; // 0xF0
	private Dictionary<WorldType, string[]> worldSelectList; // 0xF8
	private PlayerDataManager playerDataManager; // 0x100

	// Properties
	private PlayerDataManager pData { get; }

	// Methods

	// RVA: 0x1B286E4 Offset: 0x1B246E4 VA: 0x1B286E4
	private PlayerDataManager get_pData() { }

	[IteratorStateMachine(typeof(UIGlobalChannelPanel.<Start>d__25))]
	// RVA: 0x1B2876C Offset: 0x1B2476C VA: 0x1B2876C
	private IEnumerator Start() { }

	// RVA: 0x1B28800 Offset: 0x1B24800 VA: 0x1B28800
	public void ReceiveChannelList(GlobalChannelGetListResponse response) { }

	[IteratorStateMachine(typeof(UIGlobalChannelPanel.<reloadChannnelList>d__27))]
	// RVA: 0x1B28808 Offset: 0x1B24808 VA: 0x1B28808
	private IEnumerator reloadChannnelList() { }

	[IteratorStateMachine(typeof(UIGlobalChannelPanel.<getChannelList>d__28))]
	// RVA: 0x1B2889C Offset: 0x1B2489C VA: 0x1B2889C
	private IEnumerator getChannelList() { }

	// RVA: 0x1B28930 Offset: 0x1B24930 VA: 0x1B28930
	private void initializeChannelList() { }

	// RVA: 0x1B295B8 Offset: 0x1B255B8 VA: 0x1B295B8
	public void ReceiveWorldList(GlobalChannelGetWorldResponse response) { }

	[IteratorStateMachine(typeof(UIGlobalChannelPanel.<reloadWorldList>d__31))]
	// RVA: 0x1B295C0 Offset: 0x1B255C0 VA: 0x1B295C0
	private IEnumerator reloadWorldList() { }

	[IteratorStateMachine(typeof(UIGlobalChannelPanel.<getWorldList>d__32))]
	// RVA: 0x1B29654 Offset: 0x1B25654 VA: 0x1B29654
	private IEnumerator getWorldList() { }

	// RVA: 0x1B296E8 Offset: 0x1B256E8 VA: 0x1B296E8
	private void initializeWorldList() { }

	// RVA: 0x1B28F58 Offset: 0x1B24F58 VA: 0x1B28F58
	private void changeChannelState(byte worldType, int channel, int people) { }

	// RVA: 0x1B29A14 Offset: 0x1B25A14 VA: 0x1B29A14
	private void changeWorldState(int worldId, byte worldType, byte state) { }

	// RVA: 0x1B2A2F8 Offset: 0x1B262F8 VA: 0x1B2A2F8
	private void setWorldTypeAnother() { }

	// RVA: 0x1B2A674 Offset: 0x1B26674 VA: 0x1B2A674
	private void setMyWorld(int worldtype) { }

	[Obsolete]
	// RVA: 0x1B2A718 Offset: 0x1B26718 VA: 0x1B2A718
	private void setWorldTypeJapan() { }

	// RVA: 0x1B2A7D0 Offset: 0x1B267D0 VA: 0x1B2A7D0
	private void OnClick(int param) { }

	// RVA: 0x1B28F14 Offset: 0x1B24F14 VA: 0x1B28F14
	private byte GetCountry(int worldId) { }

	// RVA: 0x1B2AA9C Offset: 0x1B26A9C VA: 0x1B2AA9C
	private void onClose() { }

	// RVA: 0x1B2A438 Offset: 0x1B26438 VA: 0x1B2A438
	private void openPopup() { }

	// RVA: 0x1B2AAF8 Offset: 0x1B26AF8 VA: 0x1B2AAF8
	private void onClosePopup() { }

	// RVA: 0x1B2A564 Offset: 0x1B26564 VA: 0x1B2A564
	private void openItemWarningPopup() { }

	[IteratorStateMachine(typeof(UIGlobalChannelPanel.<ItemWarningPopupWindow>d__45))]
	// RVA: 0x1B2AB18 Offset: 0x1B26B18 VA: 0x1B2AB18
	private IEnumerator ItemWarningPopupWindow(UIPopBaseWindow window) { }

	// RVA: 0x1B2ABC8 Offset: 0x1B26BC8 VA: 0x1B2ABC8
	private void ScrollActive(bool active) { }

	// RVA: 0x1B2AC20 Offset: 0x1B26C20 VA: 0x1B2AC20
	public void .ctor() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1B2B10C Offset: 0x1B2710C VA: 0x1B2B10C
	private void <>n__0(Action pushFunction) { }
}
