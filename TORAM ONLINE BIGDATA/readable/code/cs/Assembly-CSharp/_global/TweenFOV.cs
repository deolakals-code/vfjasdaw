// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Tween/Tween Field of View")]
public class TweenFOV : UITweener // TypeDefIndex: 135
{
	// Fields
	public float from; // 0x74
	public float to; // 0x78
	private Camera mCam; // 0x80

	// Properties
	public Camera cachedCamera { get; }
	public float fov { get; set; }

	// Methods

	// RVA: 0x1EDFAE8 Offset: 0x1EDBAE8 VA: 0x1EDFAE8
	public Camera get_cachedCamera() { }

	// RVA: 0x1EDFB90 Offset: 0x1EDBB90 VA: 0x1EDFB90
	public float get_fov() { }

	// RVA: 0x1EDFBAC Offset: 0x1EDBBAC VA: 0x1EDFBAC
	public void set_fov(float value) { }

	// RVA: 0x1EDFBD8 Offset: 0x1EDBBD8 VA: 0x1EDFBD8 Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EDFC1C Offset: 0x1EDBC1C VA: 0x1EDFC1C
	public static TweenFOV Begin(GameObject go, float duration, float to) { }

	// RVA: 0x1EDFCBC Offset: 0x1EDBCBC VA: 0x1EDFCBC
	public void .ctor() { }
}
