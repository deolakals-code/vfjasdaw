// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRequest : UITargetMenuBase // TypeDefIndex: 8076
{
	// Fields
	[SerializeField]
	private GameObject inputMessageObject; // 0x90
	[SerializeField]
	private UILabel inputLabel; // 0x98
	[SerializeField]
	private TweenColor tweenColor; // 0xA0
	private PlayerDataManager playerDataManager; // 0xA8
	private bool isRequestSuccess; // 0xB0

	// Methods

	// RVA: 0x1CBBD9C Offset: 0x1CB7D9C VA: 0x1CBBD9C
	private void Awake() { }

	// RVA: 0x1CBBFE4 Offset: 0x1CB7FE4 VA: 0x1CBBFE4
	private void Start() { }

	// RVA: 0x1CBC228 Offset: 0x1CB8228 VA: 0x1CBC228
	private void OnWindowOpen() { }

	// RVA: 0x1CBC248 Offset: 0x1CB8248 VA: 0x1CBC248
	public void OnSubmit() { }

	// RVA: 0x1CBC33C Offset: 0x1CB833C VA: 0x1CBC33C
	private void OnRequest() { }

	[IteratorStateMachine(typeof(UIGuildRequest.<responseWait>d__10))]
	// RVA: 0x1CBC82C Offset: 0x1CB882C VA: 0x1CBC82C
	private IEnumerator responseWait() { }

	// RVA: 0x1CBC8C0 Offset: 0x1CB88C0 VA: 0x1CBC8C0
	private void setRequestError() { }

	// RVA: 0x1CBCA94 Offset: 0x1CB8A94 VA: 0x1CBCA94
	private void onSuccessRequest() { }

	// RVA: 0x1CBBF60 Offset: 0x1CB7F60 VA: 0x1CBBF60
	private void changeUI() { }

	// RVA: 0x1CBCCE8 Offset: 0x1CB8CE8 VA: 0x1CBCCE8
	private void OnClose() { }

	// RVA: 0x1CBCDF4 Offset: 0x1CB8DF4 VA: 0x1CBCDF4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CBCE74 Offset: 0x1CB8E74 VA: 0x1CBCE74
	public void .ctor() { }
}
