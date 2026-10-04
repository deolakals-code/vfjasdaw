// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RotationBone : MonoBehaviour, IMotionLateUpdate, IBoneClone // TypeDefIndex: 5356
{
	// Fields
	[SerializeField]
	private Transform parentBone; // 0x20
	[SerializeField]
	private Transform baseBone; // 0x28
	[SerializeField]
	private Vector3 addRotationSpeed; // 0x30
	[SerializeField]
	private float loopTimer; // 0x3C
	private Quaternion saveBone; // 0x40
	private Matrix4x4 saveBoneTrans; // 0x50
	private float timer; // 0x90
	private bool isInit; // 0x94

	// Methods

	// RVA: 0x2648F88 Offset: 0x2644F88 VA: 0x2648F88
	private void Start() { }

	// RVA: 0x2648FA4 Offset: 0x2644FA4 VA: 0x2648FA4
	public void Initialize(Transform parentBone, Transform bone, Vector3 rotSpeed, float loopTimer) { }

	// RVA: 0x2649118 Offset: 0x2645118 VA: 0x2649118
	private void OnEnable() { }

	// RVA: 0x2649134 Offset: 0x2645134 VA: 0x2649134 Slot: 5
	public void Clone(SkinnedMeshRenderer render) { }

	// RVA: 0x264936C Offset: 0x264536C VA: 0x264936C
	private void Clone(RotationBone rotationBone, Transform pBone) { }

	// RVA: 0x264949C Offset: 0x264549C VA: 0x264949C
	public void LateUpdate() { }

	// RVA: 0x2649724 Offset: 0x2645724 VA: 0x2649724 Slot: 4
	public void MotionLateUpdate() { }

	// RVA: 0x26494A0 Offset: 0x26454A0 VA: 0x26494A0
	private void UpdateRotationBone() { }

	// RVA: 0x2649728 Offset: 0x2645728 VA: 0x2649728
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2649794 Offset: 0x2645794 VA: 0x2649794
	private bool <Clone>b__11_0(Transform x) { }

	[CompilerGenerated]
	// RVA: 0x26497F8 Offset: 0x26457F8 VA: 0x26497F8
	private bool <Clone>b__11_1(Transform x) { }
}
