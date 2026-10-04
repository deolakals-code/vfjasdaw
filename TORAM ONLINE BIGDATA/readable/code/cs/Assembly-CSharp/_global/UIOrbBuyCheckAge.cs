// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbBuyCheckAge : MonoBehaviour // TypeDefIndex: 7547
{
	// Fields
	private readonly string disableSpriteName; // 0x20
	private readonly string enableSpriteName; // 0x28
	[SerializeField]
	private GameObject checkAgeParent; // 0x30
	[SerializeField]
	private GameObject underParent; // 0x38
	[SerializeField]
	private GameObject overParent; // 0x40
	[SerializeField]
	private GameObject errorParent; // 0x48
	[SerializeField]
	private UISprite checkBoxSprite; // 0x50
	[SerializeField]
	private GameObject over20Sprite; // 0x58
	private bool isChecked; // 0x60
	private Action acceptCallback; // 0x68
	private Action failureCallback; // 0x70

	// Methods

	// RVA: 0x1BA79B8 Offset: 0x1BA39B8 VA: 0x1BA79B8
	public static UIOrbBuyCheckAge OpenCheckAge() { }

	// RVA: 0x1BA7AB8 Offset: 0x1BA3AB8 VA: 0x1BA7AB8
	private void Start() { }

	// RVA: 0x1BA7B24 Offset: 0x1BA3B24 VA: 0x1BA7B24
	public void SetAcceptCallback(Action callback) { }

	// RVA: 0x1BA7B2C Offset: 0x1BA3B2C VA: 0x1BA7B2C
	public void SetFailureCallback(Action callback) { }

	// RVA: 0x1BA7ABC Offset: 0x1BA3ABC VA: 0x1BA7ABC
	private void initialize() { }

	// RVA: 0x1BA7BC0 Offset: 0x1BA3BC0 VA: 0x1BA7BC0
	private void onCheckBox() { }

	// RVA: 0x1BA7B34 Offset: 0x1BA3B34 VA: 0x1BA7B34
	private void updateCheckBox() { }

	// RVA: 0x1BA7BD0 Offset: 0x1BA3BD0 VA: 0x1BA7BD0
	private void onOver() { }

	// RVA: 0x1BA7CAC Offset: 0x1BA3CAC VA: 0x1BA7CAC
	private void onOverCheckOK() { }

	// RVA: 0x1BA7D4C Offset: 0x1BA3D4C VA: 0x1BA7D4C
	private void onOverCheckError() { }

	// RVA: 0x1BA7D50 Offset: 0x1BA3D50 VA: 0x1BA7D50
	private void onUnder() { }

	// RVA: 0x1BA7DB0 Offset: 0x1BA3DB0 VA: 0x1BA7DB0
	private void onUnderCheckOK() { }

	// RVA: 0x1BA7E2C Offset: 0x1BA3E2C VA: 0x1BA7E2C
	private void onCheckError() { }

	// RVA: 0x1BA7E30 Offset: 0x1BA3E30 VA: 0x1BA7E30
	private void toError() { }

	// RVA: 0x1BA7E90 Offset: 0x1BA3E90 VA: 0x1BA7E90
	private void closeError() { }

	// RVA: 0x1BA7F14 Offset: 0x1BA3F14 VA: 0x1BA7F14
	private void close() { }

	// RVA: 0x1BA7F98 Offset: 0x1BA3F98 VA: 0x1BA7F98
	public void CloseForce() { }

	// RVA: 0x1BA7D28 Offset: 0x1BA3D28 VA: 0x1BA7D28
	private void toWebAPI(bool isOver) { }

	[IteratorStateMachine(typeof(UIOrbBuyCheckAge.<connectWebAPI>d__29))]
	// RVA: 0x1BA801C Offset: 0x1BA401C VA: 0x1BA801C
	private IEnumerator connectWebAPI(bool isOver) { }

	// RVA: 0x1BA80C4 Offset: 0x1BA40C4 VA: 0x1BA80C4
	private void OnDestroy() { }

	// RVA: 0x1BA8124 Offset: 0x1BA4124 VA: 0x1BA8124
	public void .ctor() { }
}
