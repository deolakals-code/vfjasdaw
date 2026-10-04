// Assembly: Assembly-CSharp.dll
// Namespace: 
private class NemesisBuf.NemesisLineEffect : MonoBehaviour // TypeDefIndex: 3256
{
	// Fields
	private const float baseScale = 1;
	private Transform player; // 0x20
	private Transform playerRoot; // 0x28
	private Transform target; // 0x30
	private Transform targetRoot; // 0x38
	private float lineLength; // 0x40
	private bool isActive; // 0x44
	private NemesisBuf parentBuf; // 0x48

	// Methods

	// RVA: 0x233F814 Offset: 0x233B814 VA: 0x233F814
	public void Initialize(Transform baseObject, Transform targetObject, Transform baseRootBone, Transform targetRootBone, float length, NemesisBuf parent) { }

	// RVA: 0x233FEF0 Offset: 0x233BEF0 VA: 0x233FEF0
	public void ChangeTargetRootTransform(Transform targetRootBone) { }

	// RVA: 0x233FEF8 Offset: 0x233BEF8 VA: 0x233FEF8
	private void Update() { }

	// RVA: 0x233FB04 Offset: 0x233BB04 VA: 0x233FB04
	private void LineLengthUpdate() { }

	// RVA: 0x233FFE4 Offset: 0x233BFE4 VA: 0x233FFE4
	public void .ctor() { }
}
