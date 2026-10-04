// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyLinkInvitation : UIBasePanel // TypeDefIndex: 7689
{
	// Fields
	[SerializeField]
	private GameObject invitePanel; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private UILabel mainLabel; // 0x40
	[SerializeField]
	private UILabel buttonLabel; // 0x48
	private bool isFailure; // 0x50

	// Properties
	private int targetId { get; }
	private string targetName { get; }

	// Methods

	// RVA: 0x1BE52EC Offset: 0x1BE12EC VA: 0x1BE52EC
	private int get_targetId() { }

	// RVA: 0x1BE5404 Offset: 0x1BE1404 VA: 0x1BE5404
	private string get_targetName() { }

	// RVA: 0x1BE550C Offset: 0x1BE150C VA: 0x1BE550C
	private void Start() { }

	// RVA: 0x1BE5750 Offset: 0x1BE1750 VA: 0x1BE5750
	private void OnClick() { }

	[IteratorStateMachine(typeof(UIPartyLinkInvitation.<Invite>d__11))]
	// RVA: 0x1BE5808 Offset: 0x1BE1808 VA: 0x1BE5808
	private IEnumerator Invite() { }

	// RVA: 0x1BE589C Offset: 0x1BE189C VA: 0x1BE589C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1BE58F8 Offset: 0x1BE18F8 VA: 0x1BE58F8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1BE5954 Offset: 0x1BE1954 VA: 0x1BE5954
	public void .ctor() { }
}
