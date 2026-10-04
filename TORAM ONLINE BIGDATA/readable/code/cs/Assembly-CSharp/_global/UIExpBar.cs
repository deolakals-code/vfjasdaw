// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIExpBar : MonoBehaviour // TypeDefIndex: 6522
{
	// Fields
	[SerializeField]
	private GameObject leftAnchorObject; // 0x20
	private UIIruna2Anchor leftAnchor; // 0x28
	[SerializeField]
	private GameObject rightAnchorObject; // 0x30
	private UIIruna2Anchor rightAnchor; // 0x38
	[SerializeField]
	private GameObject gaugeAnchorObject; // 0x40
	private UIIruna2Anchor centerAnchor; // 0x48
	private UISlider expGaugeSlider; // 0x50
	[SerializeField]
	private UIWidget centerFrame; // 0x58
	[SerializeField]
	private UIWidget centerBack; // 0x60
	[SerializeField]
	private UIWidget centerBar; // 0x68
	[SerializeField]
	private UILabel expLabel; // 0x70
	private PlayerDataManager playerDataManager; // 0x78
	[SerializeField]
	private Transform leftAnchorPoint; // 0x80
	[SerializeField]
	private Transform rightAnchorPoint; // 0x88
	private int expWidth; // 0x90
	[SerializeField]
	private bool isFullWidth; // 0x94
	[SerializeField]
	private Vector3 textSize; // 0x98

	// Methods

	// RVA: 0x19694A4 Offset: 0x19654A4 VA: 0x19694A4
	private void Awake() { }

	// RVA: 0x196959C Offset: 0x196559C VA: 0x196959C
	private void Update() { }

	// RVA: 0x19699A0 Offset: 0x19659A0 VA: 0x19699A0
	public void Fade(bool flag) { }

	// RVA: 0x196992C Offset: 0x196592C VA: 0x196992C
	private int GetPCExpBarWidth() { }

	// RVA: 0x1969BCC Offset: 0x1965BCC VA: 0x1969BCC
	public void .ctor() { }
}
