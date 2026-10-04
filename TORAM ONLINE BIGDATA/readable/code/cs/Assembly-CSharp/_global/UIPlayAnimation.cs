// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Play Animation")]
[ExecuteInEditMode]
public class UIPlayAnimation : MonoBehaviour // TypeDefIndex: 42
{
	// Fields
	public Animation target; // 0x20
	public string clipName; // 0x28
	public Trigger trigger; // 0x30
	public Direction playDirection; // 0x34
	public bool resetOnPlay; // 0x38
	public bool clearSelection; // 0x39
	public EnableCondition ifDisabledOnPlay; // 0x3C
	public DisableCondition disableWhenFinished; // 0x40
	public List<EventDelegate> onFinished; // 0x48
	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver; // 0x50
	[SerializeField]
	[HideInInspector]
	private string callWhenFinished; // 0x58
	private bool mStarted; // 0x60
	private bool mHighlighted; // 0x61
	private int mActive; // 0x64

	// Methods

	// RVA: 0x171EEB8 Offset: 0x171AEB8 VA: 0x171EEB8
	private void Awake() { }

	// RVA: 0x171EF90 Offset: 0x171AF90 VA: 0x171EF90
	private void Start() { }

	// RVA: 0x171F048 Offset: 0x171B048 VA: 0x171F048
	private void OnEnable() { }

	// RVA: 0x171F0DC Offset: 0x171B0DC VA: 0x171F0DC
	private void OnHover(bool isOver) { }

	// RVA: 0x171F3B0 Offset: 0x171B3B0 VA: 0x171F3B0
	private void OnPress(bool isPressed) { }

	// RVA: 0x171F41C Offset: 0x171B41C VA: 0x171F41C
	private void OnClick() { }

	// RVA: 0x171F450 Offset: 0x171B450 VA: 0x171F450
	private void OnDoubleClick() { }

	// RVA: 0x171F488 Offset: 0x171B488 VA: 0x171F488
	private void OnSelect(bool isSelected) { }

	// RVA: 0x171F4F4 Offset: 0x171B4F4 VA: 0x171F4F4
	private void OnActivate(bool isActive) { }

	// RVA: 0x171F148 Offset: 0x171B148 VA: 0x171F148
	public void Play(bool forward) { }

	// RVA: 0x171F560 Offset: 0x171B560 VA: 0x171F560
	private void OnFinished() { }

	// RVA: 0x171F654 Offset: 0x171B654 VA: 0x171F654
	public void .ctor() { }
}
