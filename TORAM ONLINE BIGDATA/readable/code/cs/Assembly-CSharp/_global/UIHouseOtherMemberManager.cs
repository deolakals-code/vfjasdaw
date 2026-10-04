// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseOtherMemberManager : UIBasePanelConnection // TypeDefIndex: 7297
{
	// Fields
	[SerializeField]
	private GameObject prevButton; // 0x30
	private BoxCollider prevButtonCol; // 0x38
	[SerializeField]
	private GameObject nextButton; // 0x40
	private BoxCollider nextButtonCol; // 0x48
	[SerializeField]
	private GameObject scrollButton; // 0x50
	[SerializeField]
	private GameObject listWindow; // 0x58
	[SerializeField]
	private GameObject searchAddressButton; // 0x60
	[SerializeField]
	private UILabel topLabel; // 0x68
	[SerializeField]
	private UILabel noDataLabel; // 0x70
	[SerializeField]
	private byte type; // 0x78
	private UIScrollWindow scrollListWindow; // 0x80
	private HouseEntryData[] userList; // 0x88
	private int pageIndex; // 0x90
	private List<int> pageIndexList; // 0x98
	private bool cancel; // 0xA0
	private bool close; // 0xA1

	// Properties
	public bool IsCancel { get; }
	public bool IsClose { get; }

	// Methods

	// RVA: 0x1B02118 Offset: 0x1AFE118 VA: 0x1B02118
	public bool get_IsCancel() { }

	// RVA: 0x1B02120 Offset: 0x1AFE120 VA: 0x1B02120
	public bool get_IsClose() { }

	[IteratorStateMachine(typeof(UIHouseOtherMemberManager.<Start>d__20))]
	// RVA: 0x1B02128 Offset: 0x1AFE128 VA: 0x1B02128
	private IEnumerator Start() { }

	// RVA: 0x1B021BC Offset: 0x1AFE1BC VA: 0x1B021BC
	private void OnDestroy() { }

	// RVA: 0x1B02220 Offset: 0x1AFE220 VA: 0x1B02220
	private int UpdatePanel(int startIndex) { }

	// RVA: 0x1B0294C Offset: 0x1AFE94C VA: 0x1B0294C
	private void NextPageButton() { }

	// RVA: 0x1B02B74 Offset: 0x1AFEB74 VA: 0x1B02B74
	private void PrevPageButton() { }

	// RVA: 0x1B01EAC Offset: 0x1AFDEAC VA: 0x1B01EAC
	public void SelectedUser(int id) { }

	// RVA: 0x1B02CA8 Offset: 0x1AFECA8 VA: 0x1B02CA8
	public void OnSearchAddressButton() { }

	// RVA: 0x1B02D3C Offset: 0x1AFED3C VA: 0x1B02D3C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B02DEC Offset: 0x1AFEDEC VA: 0x1B02DEC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B02E84 Offset: 0x1AFEE84 VA: 0x1B02E84
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B02F0C Offset: 0x1AFEF0C VA: 0x1B02F0C
	private void <SelectedUser>b__25_1() { }

	[CompilerGenerated]
	// RVA: 0x1B03080 Offset: 0x1AFF080 VA: 0x1B03080
	private void <SelectedUser>b__25_2() { }
}
