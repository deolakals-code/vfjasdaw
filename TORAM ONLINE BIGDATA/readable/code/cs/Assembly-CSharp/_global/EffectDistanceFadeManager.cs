// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EffectDistanceFadeManager : MonoBehaviour // TypeDefIndex: 229
{
	// Fields
	[SerializeField]
	private float fadeStartDistance; // 0x20
	[SerializeField]
	private float fadeEndDistance; // 0x24
	[SerializeField]
	private float minAlphaRate; // 0x28
	private float fadeAlphaSpeed; // 0x2C
	[SerializeField]
	private float maxAlphaRate; // 0x30
	private float currentAlpha; // 0x34
	private Renderer[] allRenderer; // 0x38
	[CompilerGenerated]
	private Transform <TargetObject>k__BackingField; // 0x40
	[CompilerGenerated]
	private float <ThisObjectSize>k__BackingField; // 0x48

	// Properties
	private float FadeStartDistance { get; set; }
	private float FadeEndDistance { get; set; }
	private float MinAlphaRate { get; set; }
	private Transform TargetObject { get; set; }
	public float ThisObjectSize { get; set; }

	// Methods

	// RVA: 0x21CA7AC Offset: 0x21C67AC VA: 0x21CA7AC
	private float get_FadeStartDistance() { }

	// RVA: 0x21CA7B4 Offset: 0x21C67B4 VA: 0x21CA7B4
	public void set_FadeStartDistance(float value) { }

	// RVA: 0x21CA7BC Offset: 0x21C67BC VA: 0x21CA7BC
	private float get_FadeEndDistance() { }

	// RVA: 0x21CA7C4 Offset: 0x21C67C4 VA: 0x21CA7C4
	public void set_FadeEndDistance(float value) { }

	// RVA: 0x21CA7CC Offset: 0x21C67CC VA: 0x21CA7CC
	private float get_MinAlphaRate() { }

	// RVA: 0x21CA7D4 Offset: 0x21C67D4 VA: 0x21CA7D4
	public void set_MinAlphaRate(float value) { }

	[CompilerGenerated]
	// RVA: 0x21CA7DC Offset: 0x21C67DC VA: 0x21CA7DC
	private Transform get_TargetObject() { }

	[CompilerGenerated]
	// RVA: 0x21CA7E4 Offset: 0x21C67E4 VA: 0x21CA7E4
	public void set_TargetObject(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x21CA7EC Offset: 0x21C67EC VA: 0x21CA7EC
	public float get_ThisObjectSize() { }

	[CompilerGenerated]
	// RVA: 0x21CA7F4 Offset: 0x21C67F4 VA: 0x21CA7F4
	public void set_ThisObjectSize(float value) { }

	// RVA: 0x21CA7FC Offset: 0x21C67FC VA: 0x21CA7FC
	private void Awake() { }

	// RVA: 0x21CA83C Offset: 0x21C683C VA: 0x21CA83C
	private void Update() { }

	// RVA: 0x21CA9F8 Offset: 0x21C69F8 VA: 0x21CA9F8
	private float calcAlphaRate(float currentDistance, float StartDistance) { }

	// RVA: 0x21CAA38 Offset: 0x21C6A38 VA: 0x21CAA38
	private float calcNextAlpha(float targetValue, float startValue, float speed) { }

	// RVA: 0x21CAA60 Offset: 0x21C6A60 VA: 0x21CAA60
	public void SetAllMaterialAlpha(float alpha) { }

	// RVA: 0x21CACD8 Offset: 0x21C6CD8 VA: 0x21CACD8
	public void .ctor() { }
}
