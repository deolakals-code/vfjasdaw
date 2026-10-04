// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStampIcon : MonoBehaviour // TypeDefIndex: 7993
{
	// Fields
	[SerializeField]
	private Transform effectTransform; // 0x20
	[SerializeField]
	private UIIcon icon; // 0x28
	private bool isToday; // 0x30
	private TweenScale tscale; // 0x38
	private TweenAlpha talpha; // 0x40
	[CompilerGenerated]
	private int <stampId>k__BackingField; // 0x48
	private Dictionary<StampId, string> iconSpriteName; // 0x50

	// Properties
	public int stampId { get; set; }
	public bool IsToday { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C8F21C Offset: 0x1C8B21C VA: 0x1C8F21C
	private void set_stampId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C8F224 Offset: 0x1C8B224 VA: 0x1C8F224
	public int get_stampId() { }

	// RVA: 0x1C8F22C Offset: 0x1C8B22C VA: 0x1C8F22C
	public bool get_IsToday() { }

	// RVA: 0x1C8D9AC Offset: 0x1C899AC VA: 0x1C8D9AC
	public void set_IsToday(bool value) { }

	// RVA: 0x1C8F234 Offset: 0x1C8B234 VA: 0x1C8F234
	private void Awake() { }

	// RVA: 0x1C8D864 Offset: 0x1C89864 VA: 0x1C8D864
	public void Initialize(int stamp) { }

	// RVA: 0x1C8D82C Offset: 0x1C8982C VA: 0x1C8D82C
	public void Disable() { }

	// RVA: 0x1C8F400 Offset: 0x1C8B400 VA: 0x1C8F400
	private void Update() { }

	// RVA: 0x1C8F484 Offset: 0x1C8B484 VA: 0x1C8F484
	private void onFinishScaling() { }

	// RVA: 0x1C8F4B0 Offset: 0x1C8B4B0 VA: 0x1C8F4B0
	public void .ctor() { }
}
