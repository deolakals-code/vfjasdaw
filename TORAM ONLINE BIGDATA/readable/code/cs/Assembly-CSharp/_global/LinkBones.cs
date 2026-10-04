// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LinkBones : MonoBehaviour // TypeDefIndex: 902
{
	// Fields
	private Transform[] linkObjBones; // 0x20
	private Transform[] linkBaseBones; // 0x28
	private int[] linkRemoveId; // 0x30
	private bool updateCheck; // 0x38

	// Methods

	// RVA: 0x1EFF580 Offset: 0x1EFB580 VA: 0x1EFF580
	public void Initialize(SkinnedMeshRenderer baseSkin) { }

	// RVA: 0x1EFF75C Offset: 0x1EFB75C VA: 0x1EFF75C
	public void Initialize(SkinnedMeshRenderer baseSkin, string[] boneName, Transform[] linkBaseBones) { }

	// RVA: 0x1EFF8E0 Offset: 0x1EFB8E0 VA: 0x1EFF8E0
	public void Initialize(Transform baseBone) { }

	// RVA: 0x1EFFA08 Offset: 0x1EFBA08 VA: 0x1EFFA08
	public void RemoveBoneLink(string[] boneName) { }

	// RVA: 0x1EFFBE8 Offset: 0x1EFBBE8 VA: 0x1EFFBE8
	private void OnBecameVisible() { }

	// RVA: 0x1EFFBF0 Offset: 0x1EFBBF0 VA: 0x1EFFBF0
	private void OnBecameInvisible() { }

	// RVA: 0x1EFFBF8 Offset: 0x1EFBBF8 VA: 0x1EFFBF8
	private void LateUpdate() { }

	// RVA: 0x1EFFECC Offset: 0x1EFBECC VA: 0x1EFFECC
	private void OnWillRenderObject() { }

	// RVA: 0x1EFFC14 Offset: 0x1EFBC14 VA: 0x1EFFC14
	private bool BoneLink() { }

	// RVA: 0x1EFFEDC Offset: 0x1EFBEDC VA: 0x1EFFEDC
	public void .ctor() { }
}
