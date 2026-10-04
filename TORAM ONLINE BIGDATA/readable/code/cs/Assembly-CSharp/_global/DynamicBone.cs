// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DynamicBone : MonoBehaviour, IMotionLateUpdate, IBoneClone // TypeDefIndex: 5316
{
	// Fields
	[SerializeField]
	private Transform parentBone; // 0x20
	[SerializeField]
	private Transform baseBone; // 0x28
	[SerializeField]
	private Vector3 maxRot; // 0x30
	[SerializeField]
	private float power; // 0x3C
	[SerializeField]
	private float weight; // 0x40
	[SerializeField]
	private float limit; // 0x44
	private Vector3 savePosition; // 0x48
	private Vector3 boneVec; // 0x54
	private Vector3 offsetPosition; // 0x60

	// Methods

	// RVA: 0x262BDA4 Offset: 0x2627DA4 VA: 0x262BDA4
	public void Initialize(Transform parentBone, Transform bone, Vector3 max, float p, float w, float l) { }

	// RVA: 0x262C32C Offset: 0x262832C VA: 0x262C32C
	public void Clone(IBoneClone iBoneClone, List<Transform> bones) { }

	// RVA: 0x262C664 Offset: 0x2628664 VA: 0x262C664 Slot: 5
	public void Clone(SkinnedMeshRenderer render) { }

	// RVA: 0x262C530 Offset: 0x2628530 VA: 0x262C530
	private void Clone(DynamicBone dynamicBone, Transform pBone) { }

	// RVA: 0x262C89C Offset: 0x262889C VA: 0x262C89C
	public void LateUpdate() { }

	// RVA: 0x262CD40 Offset: 0x2628D40 VA: 0x262CD40 Slot: 4
	public void MotionLateUpdate() { }

	// RVA: 0x262C8A0 Offset: 0x26288A0 VA: 0x262C8A0
	private void UpdateDynamicBone() { }

	// RVA: 0x262CD44 Offset: 0x2628D44 VA: 0x262CD44
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x262CDE0 Offset: 0x2628DE0 VA: 0x262CDE0
	private bool <Clone>b__11_0(Transform x) { }

	[CompilerGenerated]
	// RVA: 0x262CE44 Offset: 0x2628E44 VA: 0x262CE44
	private bool <Clone>b__11_1(Transform x) { }
}
