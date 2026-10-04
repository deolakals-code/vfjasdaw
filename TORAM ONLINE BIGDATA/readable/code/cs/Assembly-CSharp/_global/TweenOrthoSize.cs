// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Tween/Tween Orthographic Size")]
public class TweenOrthoSize : UITweener // TypeDefIndex: 137
{
	// Fields
	public float from; // 0x74
	public float to; // 0x78
	private Camera mCam; // 0x80

	// Properties
	public Camera cachedCamera { get; }
	public float orthoSize { get; set; }

	// Methods

	// RVA: 0x1EE0098 Offset: 0x1EDC098 VA: 0x1EE0098
	public Camera get_cachedCamera() { }

	// RVA: 0x1EE0140 Offset: 0x1EDC140 VA: 0x1EE0140
	public float get_orthoSize() { }

	// RVA: 0x1EE015C Offset: 0x1EDC15C VA: 0x1EE015C
	public void set_orthoSize(float value) { }

	// RVA: 0x1EE0188 Offset: 0x1EDC188 VA: 0x1EE0188 Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EE01CC Offset: 0x1EDC1CC VA: 0x1EE01CC
	public static TweenOrthoSize Begin(GameObject go, float duration, float to) { }

	// RVA: 0x1EE026C Offset: 0x1EDC26C VA: 0x1EE026C
	public void .ctor() { }
}
