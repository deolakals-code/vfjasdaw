// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UITweener : MonoBehaviour // TypeDefIndex: 146
{
	// Fields
	public static UITweener current; // 0x0
	[HideInInspector]
	public UITweener.Method method; // 0x20
	[HideInInspector]
	public UITweener.Style style; // 0x24
	[HideInInspector]
	public AnimationCurve animationCurve; // 0x28
	[HideInInspector]
	public bool ignoreTimeScale; // 0x30
	[HideInInspector]
	public float delay; // 0x34
	[HideInInspector]
	public float duration; // 0x38
	[HideInInspector]
	public bool steeperCurves; // 0x3C
	[HideInInspector]
	public int tweenGroup; // 0x40
	[HideInInspector]
	public List<EventDelegate> onFinished; // 0x48
	[HideInInspector]
	public GameObject eventReceiver; // 0x50
	[HideInInspector]
	public string callWhenFinished; // 0x58
	private bool mStarted; // 0x60
	private float mStartTime; // 0x64
	private float mDuration; // 0x68
	private float mAmountPerDelta; // 0x6C
	private float mFactor; // 0x70

	// Properties
	public float amountPerDelta { get; }
	public float tweenFactor { get; }
	public Direction direction { get; }

	// Methods

	// RVA: 0x1EE1700 Offset: 0x1EDD700 VA: 0x1EE1700
	public float get_amountPerDelta() { }

	// RVA: 0x1EE173C Offset: 0x1EDD73C VA: 0x1EE173C
	public float get_tweenFactor() { }

	// RVA: 0x1EE1744 Offset: 0x1EDD744 VA: 0x1EE1744
	public Direction get_direction() { }

	// RVA: 0x1EE1758 Offset: 0x1EDD758 VA: 0x1EE1758
	private void Start() { }

	// RVA: 0x1EE175C Offset: 0x1EDD75C VA: 0x1EE175C
	private void Update() { }

	// RVA: 0x1EE1A34 Offset: 0x1EDDA34 VA: 0x1EE1A34
	private void OnDisable() { }

	// RVA: 0x1EDF1E8 Offset: 0x1EDB1E8 VA: 0x1EDF1E8
	public void Sample(float factor, bool isFinished) { }

	// RVA: 0x1EE1A3C Offset: 0x1EDDA3C VA: 0x1EE1A3C
	private float BounceLogic(float val) { }

	// RVA: 0x1EE1AF4 Offset: 0x1EDDAF4 VA: 0x1EE1AF4
	public void Play() { }

	// RVA: 0x1EE1AFC Offset: 0x1EDDAFC VA: 0x1EE1AFC
	public void Play(bool forward) { }

	// RVA: 0x1EE1B6C Offset: 0x1EDDB6C VA: 0x1EE1B6C
	public void Reset() { }

	// RVA: 0x1EE1B90 Offset: 0x1EDDB90 VA: 0x1EE1B90
	public void Toggle() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnUpdate(float factor, bool isFinished);

	// RVA: -1 Offset: -1
	public static T Begin<T>(GameObject go, float duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FA23C Offset: 0x26F623C VA: 0x26FA23C
	|-UITweener.Begin<object>
	*/

	// RVA: 0x1EDF35C Offset: 0x1EDB35C VA: 0x1EDF35C
	protected void .ctor() { }
}
