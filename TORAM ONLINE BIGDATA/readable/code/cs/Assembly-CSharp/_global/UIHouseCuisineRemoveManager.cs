// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCuisineRemoveManager : UIBasePanelConnection // TypeDefIndex: 7221
{
	// Fields
	[SerializeField]
	private GameObject popWindow; // 0x30
	[SerializeField]
	private GameObject removePanel; // 0x38
	[SerializeField]
	private UILabel cuisineLabel; // 0x40
	[SerializeField]
	private UILabel bufferTimerLabel; // 0x48
	[SerializeField]
	private GameObject freeButton; // 0x50
	[SerializeField]
	private GameObject orbButton; // 0x58
	[SerializeField]
	private UILabel orbNumLabel; // 0x60
	[SerializeField]
	private GameObject waitPanel; // 0x68
	[SerializeField]
	private UISlider waitSlider; // 0x70
	private HouseCuisineManager cuisineManager; // 0x78
	private HouseCuisineManager.CuisineData cuisine; // 0x80
	private byte step; // 0x88
	private float updateTime; // 0x8C

	// Methods

	// RVA: 0x1ADDD74 Offset: 0x1AD9D74 VA: 0x1ADDD74
	private void Awake() { }

	[IteratorStateMachine(typeof(UIHouseCuisineRemoveManager.<Start>d__16))]
	// RVA: 0x1ADDE94 Offset: 0x1AD9E94 VA: 0x1ADDE94
	private IEnumerator Start() { }

	[IteratorStateMachine(typeof(UIHouseCuisineRemoveManager.<WaitThread>d__17))]
	// RVA: 0x1ADDF28 Offset: 0x1AD9F28 VA: 0x1ADDF28
	private IEnumerator WaitThread(byte type) { }

	// RVA: 0x1ADDFAC Offset: 0x1AD9FAC VA: 0x1ADDFAC
	public void OnClick_Remove(int type) { }

	// RVA: 0x1ADE02C Offset: 0x1ADA02C VA: 0x1ADE02C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1ADE100 Offset: 0x1ADA100 VA: 0x1ADE100 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1ADE1A4 Offset: 0x1ADA1A4 VA: 0x1ADE1A4
	public void .ctor() { }
}
