// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Play Tween")]
[ExecuteInEditMode]
public class UIPlayTween : MonoBehaviour // TypeDefIndex: 45
{
	// Fields
	public GameObject tweenTarget; // 0x20
	public int tweenGroup; // 0x28
	public Trigger trigger; // 0x2C
	public Direction playDirection; // 0x30
	public bool resetOnPlay; // 0x34
	public bool resetIfDisabled; // 0x35
	public EnableCondition ifDisabledOnPlay; // 0x38
	public DisableCondition disableWhenFinished; // 0x3C
	public bool includeChildren; // 0x40
	public List<EventDelegate> onFinished; // 0x48
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver; // 0x50
	[SerializeField]
	[HideInInspector]
	private string callWhenFinished; // 0x58
	private UITweener[] mTweens; // 0x60
	private bool mStarted; // 0x68
	private bool mHighlighted; // 0x69
	private int mActive; // 0x6C

	// Methods

	// RVA: 0x171F8E4 Offset: 0x171B8E4 VA: 0x171F8E4
	private void Awake() { }

	// RVA: 0x171F9BC Offset: 0x171B9BC VA: 0x171F9BC
	private void Start() { }

	// RVA: 0x171FA60 Offset: 0x171BA60 VA: 0x171FA60
	private void OnEnable() { }

	// RVA: 0x171FAF4 Offset: 0x171BAF4 VA: 0x171FAF4
	private void OnHover(bool isOver) { }

	// RVA: 0x171FEE8 Offset: 0x171BEE8 VA: 0x171FEE8
	private void OnPress(bool isPressed) { }

	// RVA: 0x171FF54 Offset: 0x171BF54 VA: 0x171FF54
	private void OnClick() { }

	// RVA: 0x171FF88 Offset: 0x171BF88 VA: 0x171FF88
	private void OnDoubleClick() { }

	// RVA: 0x171FFC0 Offset: 0x171BFC0 VA: 0x171FFC0
	private void OnSelect(bool isSelected) { }

	// RVA: 0x172002C Offset: 0x171C02C VA: 0x172002C
	private void OnActivate(bool isActive) { }

	// RVA: 0x1720098 Offset: 0x171C098 VA: 0x1720098
	private void Update() { }

	// RVA: 0x171FB60 Offset: 0x171BB60 VA: 0x171FB60
	public void Play(bool forward) { }

	// RVA: 0x17201C8 Offset: 0x171C1C8 VA: 0x17201C8
	private void OnFinished() { }

	// RVA: 0x17202BC Offset: 0x171C2BC VA: 0x17202BC
	public void .ctor() { }
}
