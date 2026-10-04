// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DivingRoomSelectController : SummerEventPanelBase // TypeDefIndex: 6312
{
	// Fields
	[SerializeField]
	private Transform topPanel; // 0x30
	[SerializeField]
	private UISprite listUpdateIcon; // 0x38
	[SerializeField]
	private UILabel listUpdateLabel; // 0x40
	[SerializeField]
	private UILabel listUpdateWarningLabel; // 0x48
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x50
	[SerializeField]
	private GameObject scrollButton; // 0x58
	[SerializeField]
	private GameObject notFoundLabel; // 0x60
	private byte recruitType; // 0x68

	// Methods

	// RVA: 0x18E4740 Offset: 0x18E0740 VA: 0x18E4740 Slot: 5
	public override void Open(Action<int> _change_state_callback) { }

	[IteratorStateMachine(typeof(DivingRoomSelectController.<GetListData>d__9))]
	// RVA: 0x18E4780 Offset: 0x18E0780 VA: 0x18E4780
	private IEnumerator GetListData(byte recruitType) { }

	// RVA: 0x18E4714 Offset: 0x18E0714 VA: 0x18E4714
	public void EnterLobbyId(int lobbyId) { }

	// RVA: 0x18E4824 Offset: 0x18E0824 VA: 0x18E4824 Slot: 4
	public override void ChangeState() { }

	// RVA: 0x18E4828 Offset: 0x18E0828 VA: 0x18E4828
	public void OnCraeteButton() { }

	// RVA: 0x18E48AC Offset: 0x18E08AC VA: 0x18E48AC
	public void OnUpdateButton() { }

	// RVA: 0x18E4978 Offset: 0x18E0978 VA: 0x18E4978
	public void .ctor() { }
}
