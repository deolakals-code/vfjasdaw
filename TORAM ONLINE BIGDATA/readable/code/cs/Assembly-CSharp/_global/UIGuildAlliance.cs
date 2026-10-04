// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildAlliance : UITargetMenuBase // TypeDefIndex: 8074
{
	// Fields
	[SerializeField]
	private GameObject windowPanel; // 0x90
	[SerializeField]
	private GameObject targetPanel; // 0x98
	[SerializeField]
	private UILabel targetLabel; // 0xA0
	[SerializeField]
	private UILabel messageLabel; // 0xA8
	[SerializeField]
	private GameObject[] buttons; // 0xB0
	private PlayerDataManager playerDataManager; // 0xB8
	private UIGuildAlliance.State activeState; // 0xC0
	private float activeTime; // 0xC4

	// Methods

	// RVA: 0x1CBAA88 Offset: 0x1CB6A88 VA: 0x1CBAA88
	private void Awake() { }

	// RVA: 0x1CBAC48 Offset: 0x1CB6C48 VA: 0x1CBAC48
	private void Start() { }

	// RVA: 0x1CBAD44 Offset: 0x1CB6D44 VA: 0x1CBAD44
	private void LateUpdate() { }

	// RVA: 0x1CBADB4 Offset: 0x1CB6DB4 VA: 0x1CBADB4
	private void OnDestroy() { }

	// RVA: 0x1CBAE14 Offset: 0x1CB6E14 VA: 0x1CBAE14
	public void OnClick_OKButton() { }

	// RVA: 0x1CBAF28 Offset: 0x1CB6F28 VA: 0x1CBAF28
	public void OnClick_Request() { }

	// RVA: 0x1CBB240 Offset: 0x1CB7240 VA: 0x1CBB240
	private void ErrPop(string messageKey, int code) { }

	// RVA: 0x1CBB458 Offset: 0x1CB7458 VA: 0x1CBB458
	private void SuccessPop() { }

	// RVA: 0x1CBB580 Offset: 0x1CB7580 VA: 0x1CBB580
	public void .ctor() { }
}
