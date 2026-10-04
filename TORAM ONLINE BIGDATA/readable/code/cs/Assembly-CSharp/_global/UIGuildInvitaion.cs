// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildInvitaion : MonoBehaviour, IUIGuild // TypeDefIndex: 7110
{
	// Fields
	[SerializeField]
	private GameObject reserveElementObject; // 0x20
	[SerializeField]
	private float elementHeight; // 0x28
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private GameObject fullScrollSubObject; // 0x38
	[CompilerGenerated]
	private UIBasePanelControl <TopControl>k__BackingField; // 0x40
	private SystemTextManager systemTextManager; // 0x48
	private GuildManager guildManager; // 0x50
	private IList<GuildMemberRequestData> requestList; // 0x58
	private List<UIFriendReserveElement> elementList; // 0x60
	private int selectedIndex; // 0x68
	private bool isClose; // 0x6C
	private UIPopWindow popWindow; // 0x70

	// Properties
	public UIBasePanelControl TopControl { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A97760 Offset: 0x1A93760 VA: 0x1A97760
	public UIBasePanelControl get_TopControl() { }

	[CompilerGenerated]
	// RVA: 0x1A97768 Offset: 0x1A93768 VA: 0x1A97768
	public void set_TopControl(UIBasePanelControl value) { }

	// RVA: 0x1A97770 Offset: 0x1A93770 VA: 0x1A97770
	private void Awake() { }

	// RVA: 0x1A97920 Offset: 0x1A93920 VA: 0x1A97920
	private void Start() { }

	// RVA: 0x1A97924 Offset: 0x1A93924 VA: 0x1A97924
	public void updateReserveList() { }

	// RVA: 0x1A97EE0 Offset: 0x1A93EE0 VA: 0x1A97EE0
	private void onSelected(int index) { }

	// RVA: 0x1A97F80 Offset: 0x1A93F80 VA: 0x1A97F80
	private void onReject() { }

	// RVA: 0x1A98130 Offset: 0x1A94130 VA: 0x1A98130
	private void onAccept() { }

	[IteratorStateMachine(typeof(UIGuildInvitaion.<ConnectWait>d__21))]
	// RVA: 0x1A980B4 Offset: 0x1A940B4 VA: 0x1A980B4
	private IEnumerator ConnectWait(OperationCode code) { }

	// RVA: 0x1A9828C Offset: 0x1A9428C VA: 0x1A9828C Slot: 4
	public void OnClose() { }

	// RVA: 0x1A9835C Offset: 0x1A9435C VA: 0x1A9835C
	private void OnDestroy() { }

	// RVA: 0x1A98360 Offset: 0x1A94360 VA: 0x1A98360
	private void OnDisable() { }

	// RVA: 0x1A983C0 Offset: 0x1A943C0 VA: 0x1A983C0
	public void OnBlock() { }

	[IteratorStateMachine(typeof(UIGuildInvitaion.<BlockWindow>d__26))]
	// RVA: 0x1A983E0 Offset: 0x1A943E0 VA: 0x1A983E0
	private IEnumerator BlockWindow() { }

	// RVA: 0x1A98474 Offset: 0x1A94474 VA: 0x1A98474
	public void .ctor() { }
}
