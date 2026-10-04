// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbShopPaidBuyPopupWindow : MonoBehaviour // TypeDefIndex: 8194
{
	// Fields
	[SerializeField]
	private UILabel paidOrbNumLabel; // 0x20
	[SerializeField]
	private UILabel freeOrbNumLabel; // 0x28
	[SerializeField]
	private UILabel usePaidOrbNumLabel; // 0x30
	[SerializeField]
	private UILabel useButtonLabel; // 0x38
	[SerializeField]
	private GameObject useButtonBackObj; // 0x40
	[SerializeField]
	private GameObject useButtonObj; // 0x48
	[SerializeField]
	private TweenAlpha useButtonAlphaTween; // 0x50
	[SerializeField]
	private TweenColor useButtonColorTween; // 0x58
	[SerializeField]
	private GameObject popTrans; // 0x60
	private Action callback; // 0x68
	private bool isCheckBuyItem; // 0x70
	[CompilerGenerated]
	private bool <IsPopup>k__BackingField; // 0x71
	private SystemTextManager systemManager; // 0x78
	private float lockTimer; // 0x80

	// Properties
	public bool IsPopup { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CEAE28 Offset: 0x1CE6E28 VA: 0x1CEAE28
	public bool get_IsPopup() { }

	[CompilerGenerated]
	// RVA: 0x1CEAE30 Offset: 0x1CE6E30 VA: 0x1CEAE30
	private void set_IsPopup(bool value) { }

	// RVA: 0x1CEAE3C Offset: 0x1CE6E3C VA: 0x1CEAE3C
	private void Awake() { }

	// RVA: 0x1CEAF1C Offset: 0x1CE6F1C VA: 0x1CEAF1C
	public void Initialize(int usedPaidOrb, Action callback) { }

	// RVA: 0x1CEB294 Offset: 0x1CE7294 VA: 0x1CEB294
	private void Update() { }

	// RVA: 0x1CEB2C0 Offset: 0x1CE72C0 VA: 0x1CEB2C0
	public void OnClick() { }

	// RVA: 0x1CEB390 Offset: 0x1CE7390 VA: 0x1CEB390
	public bool Close() { }

	// RVA: 0x1CEB444 Offset: 0x1CE7444 VA: 0x1CEB444
	public void .ctor() { }
}
