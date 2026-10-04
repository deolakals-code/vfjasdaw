// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Tween/Tween Position")]
public class TweenPosition : UITweener // TypeDefIndex: 138
{
	// Fields
	public Vector3 from; // 0x74
	public Vector3 to; // 0x80
	private Transform mTrans; // 0x90

	// Properties
	public Transform cachedTransform { get; }
	public Vector3 position { get; set; }

	// Methods

	// RVA: 0x1EE0278 Offset: 0x1EDC278 VA: 0x1EE0278
	public Transform get_cachedTransform() { }

	// RVA: 0x1EE030C Offset: 0x1EDC30C VA: 0x1EE030C
	public Vector3 get_position() { }

	// RVA: 0x1EE0328 Offset: 0x1EDC328 VA: 0x1EE0328
	public void set_position(Vector3 value) { }

	// RVA: 0x1EE036C Offset: 0x1EDC36C VA: 0x1EE036C Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EE03D0 Offset: 0x1EDC3D0 VA: 0x1EE03D0
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos) { }

	// RVA: 0x1EE0488 Offset: 0x1EDC488 VA: 0x1EE0488
	public void .ctor() { }
}
