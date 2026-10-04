// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Tween/Tween Transform")]
public class TweenTransform : UITweener // TypeDefIndex: 141
{
	// Fields
	public Transform from; // 0x78
	public Transform to; // 0x80
	public bool parentWhenFinished; // 0x88
	private Transform mTrans; // 0x90
	private Vector3 mPos; // 0x98
	private Quaternion mRot; // 0xA4
	private Vector3 mScale; // 0xB4

	// Methods

	// RVA: 0x1EE0B10 Offset: 0x1EDCB10 VA: 0x1EE0B10 Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EE0EC8 Offset: 0x1EDCEC8 VA: 0x1EE0EC8
	public static TweenTransform Begin(GameObject go, float duration, Transform to) { }

	// RVA: 0x1EE0ED4 Offset: 0x1EDCED4 VA: 0x1EE0ED4
	public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to) { }

	// RVA: 0x1EE0F94 Offset: 0x1EDCF94 VA: 0x1EE0F94
	public void .ctor() { }
}
