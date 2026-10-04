// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRezeroFieldPopWindowManager : UIBasePanel // TypeDefIndex: 6180
{
	// Fields
	[SerializeField]
	private GameObject waitPanel; // 0x30
	[SerializeField]
	private UILabel waitLabel; // 0x38
	[SerializeField]
	private GameObject battlePanel; // 0x40
	[SerializeField]
	private UILabel battleLabel; // 0x48
	[SerializeField]
	private UILabel partyErrorLabel; // 0x50
	[SerializeField]
	private UIImageButton battleImageButton; // 0x58
	private RezeroCollaborationEventData eventData; // 0x60
	private float timer; // 0x68
	private bool isBattle; // 0x6C
	private string battleLocalize; // 0x70
	private string searchLocalize; // 0x78

	// Methods

	// RVA: 0x18B2B44 Offset: 0x18AEB44 VA: 0x18B2B44
	private void Start() { }

	// RVA: 0x18B3108 Offset: 0x18AF108 VA: 0x18B3108
	private void Update() { }

	// RVA: 0x18B3070 Offset: 0x18AF070 VA: 0x18B3070
	private void CheckEventDate() { }

	// RVA: 0x18B32A8 Offset: 0x18AF2A8 VA: 0x18B32A8
	public void OnBattle() { }

	// RVA: 0x18B336C Offset: 0x18AF36C VA: 0x18B336C
	public void OnClosePanel() { }

	// RVA: 0x18B33F8 Offset: 0x18AF3F8 VA: 0x18B33F8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18B3484 Offset: 0x18AF484 VA: 0x18B3484 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18B3510 Offset: 0x18AF510 VA: 0x18B3510
	public void .ctor() { }
}
