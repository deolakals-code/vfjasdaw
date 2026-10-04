// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Tween/Tween Rotation")]
public class TweenRotation : UITweener // TypeDefIndex: 139
{
	// Fields
	public Vector3 from; // 0x74
	public Vector3 to; // 0x80
	private Transform mTrans; // 0x90

	// Properties
	public Transform cachedTransform { get; }
	public Quaternion rotation { get; set; }

	// Methods

	// RVA: 0x1EE048C Offset: 0x1EDC48C VA: 0x1EE048C
	public Transform get_cachedTransform() { }

	// RVA: 0x1EE0520 Offset: 0x1EDC520 VA: 0x1EE0520
	public Quaternion get_rotation() { }

	// RVA: 0x1EE053C Offset: 0x1EDC53C VA: 0x1EE053C
	public void set_rotation(Quaternion value) { }

	// RVA: 0x1EE0588 Offset: 0x1EDC588 VA: 0x1EE0588 Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EE0658 Offset: 0x1EDC658 VA: 0x1EE0658
	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot) { }

	// RVA: 0x1EE0770 Offset: 0x1EDC770 VA: 0x1EE0770
	public void .ctor() { }
}
