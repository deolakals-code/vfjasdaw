// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EffectTargetTap : MonoBehaviour // TypeDefIndex: 6174
{
	// Fields
	private int motionId; // 0x20
	private AnimationBase animationSimple; // 0x28
	private GameObject target; // 0x30
	private UILabel breakPartsTimer; // 0x38
	private BoxCollider tapCollider; // 0x40
	private Vector3 center; // 0x48
	[CompilerGenerated]
	private Action<GameObject> TapCallback; // 0x58
	private float timer; // 0x60

	// Properties
	public float Timer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18B0BB4 Offset: 0x18ACBB4 VA: 0x18B0BB4
	public void add_TapCallback(Action<GameObject> value) { }

	[CompilerGenerated]
	// RVA: 0x18B0C64 Offset: 0x18ACC64 VA: 0x18B0C64
	public void remove_TapCallback(Action<GameObject> value) { }

	// RVA: 0x18B0D14 Offset: 0x18ACD14 VA: 0x18B0D14
	public float get_Timer() { }

	// RVA: 0x18B0D1C Offset: 0x18ACD1C VA: 0x18B0D1C
	public void set_Timer(float value) { }

	// RVA: 0x18B0DC8 Offset: 0x18ACDC8 VA: 0x18B0DC8
	public void SetTarget(GameObject target) { }

	// RVA: 0x18B0DD0 Offset: 0x18ACDD0 VA: 0x18B0DD0
	public void SetPriority() { }

	// RVA: 0x18B0EA4 Offset: 0x18ACEA4 VA: 0x18B0EA4
	private void Start() { }

	// RVA: 0x18B1750 Offset: 0x18AD750 VA: 0x18B1750
	private void Update() { }

	// RVA: 0x18B1938 Offset: 0x18AD938 VA: 0x18B1938
	private void OnClick() { }

	// RVA: 0x18B1958 Offset: 0x18AD958 VA: 0x18B1958
	public void .ctor() { }
}
