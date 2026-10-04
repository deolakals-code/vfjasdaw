// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRightStick : MonoBehaviour // TypeDefIndex: 6559
{
	// Fields
	[SerializeField]
	private Vector3 fadeInMove; // 0x20
	private Vector2 firstPoint; // 0x2C
	private Vector2 pushingPoint; // 0x34
	private Vector2 firstDelta; // 0x3C
	private Vector2 inputStick; // 0x44
	private EmotionPlayer emotionPlayer; // 0x50
	private UIIruna2Anchor anchor; // 0x58
	private bool activeStick; // 0x60
	private AvoidActionManager avoidManager; // 0x68
	[CompilerGenerated]
	private bool <Pressed>k__BackingField; // 0x70

	// Properties
	public bool Pressed { get; set; }
	public Vector2 InputStick { get; }
	public Vector2 FirstDelta { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19814F4 Offset: 0x197D4F4 VA: 0x19814F4
	public bool get_Pressed() { }

	[CompilerGenerated]
	// RVA: 0x19814FC Offset: 0x197D4FC VA: 0x19814FC
	private void set_Pressed(bool value) { }

	// RVA: 0x1981508 Offset: 0x197D508 VA: 0x1981508
	public Vector2 get_InputStick() { }

	// RVA: 0x1981574 Offset: 0x197D574 VA: 0x1981574
	public Vector2 get_FirstDelta() { }

	// RVA: 0x198157C Offset: 0x197D57C VA: 0x198157C
	private Vector2 correctPosition(Vector2 pos) { }

	// RVA: 0x198160C Offset: 0x197D60C VA: 0x198160C
	private void OnPress(bool pres) { }

	// RVA: 0x19816D4 Offset: 0x197D6D4 VA: 0x19816D4
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x19817AC Offset: 0x197D7AC VA: 0x19817AC
	private void OnDoubleClick() { }

	// RVA: 0x1981AD8 Offset: 0x197DAD8 VA: 0x1981AD8
	public void Fade(bool flag) { }

	// RVA: 0x1981C5C Offset: 0x197DC5C VA: 0x1981C5C
	public void .ctor() { }
}
