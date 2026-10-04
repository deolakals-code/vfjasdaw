// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildJoinRequest : MonoBehaviour, IUIGuild // TypeDefIndex: 7116
{
	// Fields
	[SerializeField]
	private GameObject Title; // 0x20
	[SerializeField]
	private UILabel TitleNumLabel; // 0x28
	[SerializeField]
	private GameObject Message; // 0x30
	[SerializeField]
	private GameObject RequestPlate; // 0x38
	[CompilerGenerated]
	private UIBasePanelControl <TopControl>k__BackingField; // 0x40
	private GuildManager guildManager; // 0x48
	private SystemTextManager systemText; // 0x50
	private UIPopBaseWindow popWindow; // 0x58
	private UIScrollWindow scrollWindow; // 0x60
	private GameObject loadingObject; // 0x68
	private UIPopBaseWindow errorPopWindow; // 0x70
	private List<int> JoinUserIdList; // 0x78

	// Properties
	public UIBasePanelControl TopControl { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A98BF8 Offset: 0x1A94BF8 VA: 0x1A98BF8
	public UIBasePanelControl get_TopControl() { }

	[CompilerGenerated]
	// RVA: 0x1A98C00 Offset: 0x1A94C00 VA: 0x1A98C00
	public void set_TopControl(UIBasePanelControl value) { }

	// RVA: 0x1A98C08 Offset: 0x1A94C08 VA: 0x1A98C08
	private void Awake() { }

	[IteratorStateMachine(typeof(UIGuildJoinRequest.<Start>d__18))]
	// RVA: 0x1A98DA4 Offset: 0x1A94DA4 VA: 0x1A98DA4
	private IEnumerator Start() { }

	[IteratorStateMachine(typeof(UIGuildJoinRequest.<CreateScrollList>d__19))]
	// RVA: 0x1A98E38 Offset: 0x1A94E38 VA: 0x1A98E38
	private IEnumerator CreateScrollList() { }

	// RVA: 0x1A98ECC Offset: 0x1A94ECC VA: 0x1A98ECC
	private void SetGuildMemberNum() { }

	// RVA: 0x1A99368 Offset: 0x1A95368 VA: 0x1A99368
	private bool UpdateScroll() { }

	// RVA: 0x1A99E58 Offset: 0x1A95E58 VA: 0x1A99E58
	public void OnAllow(int id) { }

	// RVA: 0x1A99FE4 Offset: 0x1A95FE4 VA: 0x1A99FE4
	public void OnReject(int id) { }

	// RVA: 0x1A9A094 Offset: 0x1A96094 VA: 0x1A9A094
	public void OnSuccessAcceptance(int id) { }

	// RVA: 0x1A9A1E4 Offset: 0x1A961E4 VA: 0x1A9A1E4
	public void OnSuccessReject(int id) { }

	// RVA: 0x1A9A214 Offset: 0x1A96214 VA: 0x1A9A214
	private void OnFailed(string messageKey, string[] list) { }

	[IteratorStateMachine(typeof(UIGuildJoinRequest.<PopErrorWindow>d__27))]
	// RVA: 0x1A9A2E4 Offset: 0x1A962E4 VA: 0x1A9A2E4
	private IEnumerator PopErrorWindow(string title, string message) { }

	// RVA: 0x1A99F08 Offset: 0x1A95F08 VA: 0x1A99F08
	private void SetConnection(IReconnectionSubData data) { }

	// RVA: 0x1A9A154 Offset: 0x1A96154 VA: 0x1A9A154
	private void EndConnection() { }

	// RVA: 0x1A99D04 Offset: 0x1A95D04 VA: 0x1A99D04 Slot: 4
	public void OnClose() { }

	// RVA: 0x1A9A3A8 Offset: 0x1A963A8 VA: 0x1A9A3A8
	public void .ctor() { }
}
