// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EffectSupportLine : MonoBehaviour // TypeDefIndex: 262
{
	// Fields
	private const float baseScale = 1;
	private Transform player; // 0x20
	private Transform target; // 0x28
	private float lineLength; // 0x30
	private float range; // 0x34
	private bool isHide; // 0x38
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x39

	// Properties
	public bool IsEnd { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x22AEA9C Offset: 0x22AAA9C VA: 0x22AEA9C
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x22AEAA4 Offset: 0x22AAAA4 VA: 0x22AEAA4
	public void set_IsEnd(bool value) { }

	// RVA: 0x22AEAB0 Offset: 0x22AAAB0 VA: 0x22AEAB0
	public void Initialize(Transform baseObject, Transform targetObject, float length, float dist) { }

	// RVA: 0x22AEF68 Offset: 0x22AAF68 VA: 0x22AEF68
	private void Update() { }

	// RVA: 0x22AEB6C Offset: 0x22AAB6C VA: 0x22AEB6C
	private void LineLengthUpdate() { }

	// RVA: 0x22AE608 Offset: 0x22AA608 VA: 0x22AE608
	public bool EndCheck() { }

	// RVA: 0x22AF078 Offset: 0x22AB078 VA: 0x22AF078
	public void .ctor() { }
}
