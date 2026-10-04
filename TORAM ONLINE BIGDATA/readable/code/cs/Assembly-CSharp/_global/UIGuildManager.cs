// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildManager : UIBasePanelControl, IUIMenuShortcutClose // TypeDefIndex: 7131
{
	// Fields
	[SerializeField]
	private GameObject addButtonObject; // 0x58
	[SerializeField]
	private GameObject[] addButtonIcons; // 0x60
	[SerializeField]
	private float buttonHeight; // 0x68
	[SerializeField]
	private UIGuildInfo guildInfo; // 0x70
	[SerializeField]
	private UIGuildMember guildMember; // 0x78
	[SerializeField]
	private UIGuildAnnounce guildAnnounce; // 0x80
	[SerializeField]
	private UIGuildInvitaion guildInvitation; // 0x88
	[SerializeField]
	private UIGuildNameWindow guildNameWindow; // 0x90
	[SerializeField]
	private UIGuildJoinRequest guildJoinRequest; // 0x98
	[SerializeField]
	private GameObject guildPointControl; // 0xA0
	[SerializeField]
	private GameObject errorWindowObj; // 0xA8
	private UIScrollWindow scrollWindow; // 0xB0
	private GameObject scrollWindowObject; // 0xB8
	private Dictionary<int, string> scrollMessage; // 0xC0
	private PlayerDataManager playerDataManager; // 0xC8
	private GuildManager guildManager; // 0xD0
	private IUIGuild activePage; // 0xD8
	private UIPopWindow popWindow; // 0xE0

	// Properties
	public IUIGuild ActivePage { get; }
	public bool IsShortcutClose { get; }

	// Methods

	// RVA: 0x1A9B448 Offset: 0x1A97448 VA: 0x1A9B448
	public IUIGuild get_ActivePage() { }

	// RVA: 0x1A9B450 Offset: 0x1A97450 VA: 0x1A9B450 Slot: 14
	public bool get_IsShortcutClose() { }

	// RVA: 0x1A9B470 Offset: 0x1A97470 VA: 0x1A9B470
	private void Awake() { }

	// RVA: 0x1A9B634 Offset: 0x1A97634 VA: 0x1A9B634
	private void Start() { }

	// RVA: 0x1A9B92C Offset: 0x1A9792C VA: 0x1A9B92C
	private void OnDestroy() { }

	// RVA: 0x1A9B9A8 Offset: 0x1A979A8 VA: 0x1A9B9A8
	public void CreatedProcess() { }

	[IteratorStateMachine(typeof(UIGuildManager.<createdProcess>d__26))]
	// RVA: 0x1A9B9C8 Offset: 0x1A979C8 VA: 0x1A9B9C8
	private IEnumerator createdProcess() { }

	// RVA: 0x1A9BA5C Offset: 0x1A97A5C VA: 0x1A9BA5C
	public void ResetGuildMenu() { }

	// RVA: 0x1A9BA7C Offset: 0x1A97A7C VA: 0x1A9BA7C
	private void returnGuildMenu() { }

	[IteratorStateMachine(typeof(UIGuildManager.<resetGuildMenu>d__29))]
	// RVA: 0x1A9B8C0 Offset: 0x1A978C0 VA: 0x1A9B8C0
	private IEnumerator resetGuildMenu() { }

	[IteratorStateMachine(typeof(UIGuildManager.<getGuildData>d__30))]
	// RVA: 0x1A9BAD4 Offset: 0x1A97AD4 VA: 0x1A9BAD4
	private IEnumerator getGuildData() { }

	[IteratorStateMachine(typeof(UIGuildManager.<GetMemberList>d__31))]
	// RVA: 0x1A9BB68 Offset: 0x1A97B68 VA: 0x1A9BB68
	private IEnumerator GetMemberList() { }

	[IteratorStateMachine(typeof(UIGuildManager.<getGuildBooster>d__32))]
	// RVA: 0x1A9BBFC Offset: 0x1A97BFC VA: 0x1A9BBFC
	private IEnumerator getGuildBooster() { }

	// RVA: 0x1A9BC90 Offset: 0x1A97C90 VA: 0x1A9BC90
	private void initializeScrollWindow() { }

	// RVA: 0x1A9BE10 Offset: 0x1A97E10 VA: 0x1A9BE10
	private void initializeMainMenu() { }

	// RVA: 0x1A9CCDC Offset: 0x1A98CDC VA: 0x1A9CCDC
	private void initializeGuildInfo() { }

	// RVA: 0x1A9D220 Offset: 0x1A99220 VA: 0x1A9D220
	public void UpdateGuildInfo() { }

	// RVA: 0x1A9D25C Offset: 0x1A9925C VA: 0x1A9D25C
	private void onCreate() { }

	// RVA: 0x1A9D3D8 Offset: 0x1A993D8 VA: 0x1A9D3D8
	private void closeNameWindow() { }

	// RVA: 0x1A9D420 Offset: 0x1A99420 VA: 0x1A9D420
	private void checkCreateCallback(string guildName) { }

	[IteratorStateMachine(typeof(UIGuildManager.<CheckCreate>d__40))]
	// RVA: 0x1A9D4B8 Offset: 0x1A994B8 VA: 0x1A9D4B8
	public static IEnumerator CheckCreate(string guildName, Action<bool> callback) { }

	// RVA: 0x1A9D568 Offset: 0x1A99568 VA: 0x1A9D568
	private void doCreate(string guildName) { }

	// RVA: 0x1A9D5E0 Offset: 0x1A995E0 VA: 0x1A9D5E0
	private void onDissolution() { }

	// RVA: 0x1A9D7B4 Offset: 0x1A997B4 VA: 0x1A9D7B4
	private void doDissolution() { }

	[IteratorStateMachine(typeof(UIGuildManager.<doDissolutionConnection>d__44))]
	// RVA: 0x1A9D7D4 Offset: 0x1A997D4 VA: 0x1A9D7D4
	private IEnumerator doDissolutionConnection() { }

	// RVA: 0x1A9D868 Offset: 0x1A99868 VA: 0x1A9D868
	private void onMemberList() { }

	// RVA: 0x1A9DA84 Offset: 0x1A99A84 VA: 0x1A9DA84
	private void onAnnounce() { }

	// RVA: 0x1A9DF24 Offset: 0x1A99F24 VA: 0x1A9DF24
	private void onBarRoom() { }

	// RVA: 0x1A9E0A8 Offset: 0x1A9A0A8 VA: 0x1A9E0A8
	private void onInvitation() { }

	// RVA: 0x1A9E28C Offset: 0x1A9A28C VA: 0x1A9E28C
	public void OnInvitation() { }

	// RVA: 0x1A9E4A0 Offset: 0x1A9A4A0 VA: 0x1A9E4A0
	private void onPointControl() { }

	// RVA: 0x1A9E54C Offset: 0x1A9A54C VA: 0x1A9E54C
	private void returnGuildPointMenu() { }

	// RVA: 0x1A9E890 Offset: 0x1A9A890 VA: 0x1A9E890
	private void onContribution() { }

	// RVA: 0x1A9EA68 Offset: 0x1A9AA68 VA: 0x1A9EA68
	private void onBooster() { }

	// RVA: 0x1A9EC40 Offset: 0x1A9AC40 VA: 0x1A9EC40
	private void onPresent() { }

	// RVA: 0x1A9D1B0 Offset: 0x1A991B0 VA: 0x1A9D1B0
	private void onHover(int index) { }

	// RVA: 0x1A9EE18 Offset: 0x1A9AE18 VA: 0x1A9EE18
	public void OnClose() { }

	// RVA: 0x1A9EE74 Offset: 0x1A9AE74 VA: 0x1A9EE74
	private void onMercenary() { }

	// RVA: 0x1A9EEF0 Offset: 0x1A9AEF0 VA: 0x1A9EEF0
	public void onSearchGuild() { }

	// RVA: 0x1A9EF4C Offset: 0x1A9AF4C VA: 0x1A9EF4C
	public void OnJoinRequest() { }

	// RVA: 0x1A9F178 Offset: 0x1A9B178 VA: 0x1A9F178
	public void onAllianceInvite() { }

	// RVA: 0x1A9F1A4 Offset: 0x1A9B1A4 VA: 0x1A9F1A4
	public void onAlliance() { }

	// RVA: 0x1A9DC74 Offset: 0x1A99C74 VA: 0x1A9DC74
	private void showLimitedFunction(int usableLevel) { }

	// RVA: 0x1A9F218 Offset: 0x1A9B218 VA: 0x1A9F218
	private void closePopwindow() { }

	// RVA: 0x1A9CFC4 Offset: 0x1A98FC4 VA: 0x1A9CFC4
	private GameObject addButton(GameObject icon, int index, string buttonText, string messageText, string functionName, bool enabled) { }

	// RVA: 0x1A9CD18 Offset: 0x1A98D18 VA: 0x1A9CD18
	private GameObject addButton(int index, string buttonText, string messageText, string functionName, bool enabled) { }

	// RVA: 0x1A9F2B8 Offset: 0x1A9B2B8 VA: 0x1A9F2B8
	private void ReturnTopMenu(int param) { }

	// RVA: 0x1A9B6C4 Offset: 0x1A976C4 VA: 0x1A9B6C4
	private void OpenNoMasterConnectMenu() { }

	// RVA: 0x1A9F35C Offset: 0x1A9B35C VA: 0x1A9F35C
	private void CloseNoMasterConnectMenu() { }

	// RVA: 0x1A9F448 Offset: 0x1A9B448 VA: 0x1A9F448
	private void OnErrorOk() { }

	// RVA: 0x1A9F4A4 Offset: 0x1A9B4A4 VA: 0x1A9F4A4
	private void ReturnGuildMemberToMenu() { }

	[IteratorStateMachine(typeof(UIGuildManager.<CloseGuildMemberPanel>d__71))]
	// RVA: 0x1A9F54C Offset: 0x1A9B54C VA: 0x1A9F54C
	private IEnumerator CloseGuildMemberPanel() { }

	[IteratorStateMachine(typeof(UIGuildManager.<ChangeOnlineNotice>d__72))]
	// RVA: 0x1A9F4F4 Offset: 0x1A9B4F4 VA: 0x1A9F4F4
	private IEnumerator ChangeOnlineNotice() { }

	// RVA: 0x1A9F608 Offset: 0x1A9B608 VA: 0x1A9F608 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A9F6A4 Offset: 0x1A9B6A4 VA: 0x1A9F6A4
	public void .ctor() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1A9F734 Offset: 0x1A9B734 VA: 0x1A9F734
	private void <>n__0(Action pushFunction) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1A9F73C Offset: 0x1A9B73C VA: 0x1A9F73C
	private void <>n__1() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1A9F744 Offset: 0x1A9B744 VA: 0x1A9F744
	private void <>n__2() { }

	[CompilerGenerated]
	// RVA: 0x1A9F74C Offset: 0x1A9B74C VA: 0x1A9F74C
	private void <onMemberList>b__45_0() { }

	[CompilerGenerated]
	// RVA: 0x1A9F76C Offset: 0x1A9B76C VA: 0x1A9F76C
	private void <onBarRoom>b__47_0() { }
}
