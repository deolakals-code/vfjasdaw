// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Tween/Tween Scale")]
public class TweenScale : UITweener // TypeDefIndex: 140
{
	// Fields
	public Vector3 from; // 0x74
	public Vector3 to; // 0x80
	public bool updateTable; // 0x8C
	private Transform mTrans; // 0x90
	private UITable mTable; // 0x98

	// Properties
	public Transform cachedTransform { get; }
	public Vector3 scale { get; set; }

	// Methods

	// RVA: 0x1EE0774 Offset: 0x1EDC774 VA: 0x1EE0774
	public Transform get_cachedTransform() { }

	// RVA: 0x1EE0808 Offset: 0x1EDC808 VA: 0x1EE0808
	public Vector3 get_scale() { }

	// RVA: 0x1EE0824 Offset: 0x1EDC824 VA: 0x1EE0824
	public void set_scale(Vector3 value) { }

	// RVA: 0x1EE0868 Offset: 0x1EDC868 VA: 0x1EE0868 Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EE09E8 Offset: 0x1EDC9E8 VA: 0x1EE09E8
	public static TweenScale Begin(GameObject go, float duration, Vector3 scale) { }

	// RVA: 0x1EE0AA0 Offset: 0x1EDCAA0 VA: 0x1EE0AA0
	public void .ctor() { }
}
