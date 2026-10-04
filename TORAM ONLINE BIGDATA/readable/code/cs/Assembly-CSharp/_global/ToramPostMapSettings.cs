// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ToramPostMapSettings : MonoBehaviour // TypeDefIndex: 4661
{
	// Fields
	[SerializeField]
	private Vector3 directionalLightAngle; // 0x20
	[SerializeField]
	private Material colorGradingMaterial; // 0x30
	[SerializeField]
	private ColorGradingSettings colorGradingSettings; // 0x38

	// Properties
	public bool IsColorGrading { get; }

	// Methods

	// RVA: 0x2587BD0 Offset: 0x2583BD0 VA: 0x2587BD0
	public static bool DirectionalLightAngle(GameObject field, out Vector3 dir) { }

	// RVA: 0x2587BE8 Offset: 0x2583BE8 VA: 0x2587BE8
	public static ToramPostMapSettings GetSettnig(GameObject field) { }

	// RVA: 0x2587BF0 Offset: 0x2583BF0 VA: 0x2587BF0
	public bool get_IsColorGrading() { }

	// RVA: 0x2587C50 Offset: 0x2583C50 VA: 0x2587C50
	private void Awake() { }

	// RVA: 0x2587C54 Offset: 0x2583C54 VA: 0x2587C54
	public void .ctor() { }
}
