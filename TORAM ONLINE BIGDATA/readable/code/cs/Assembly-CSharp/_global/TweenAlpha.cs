// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Tween/Tween Alpha")]
public class TweenAlpha : UITweener // TypeDefIndex: 132
{
	// Fields
	[Range(0, 1)]
	public float from; // 0x74
	[Range(0, 1)]
	public float to; // 0x78
	private Transform mTrans; // 0x80
	private IUIWidget mWidget; // 0x88
	private UIPanel mPanel; // 0x90

	// Properties
	public float alpha { get; set; }

	// Methods

	// RVA: 0x1EDEE28 Offset: 0x1EDAE28 VA: 0x1EDEE28
	public float get_alpha() { }

	// RVA: 0x1EDEF20 Offset: 0x1EDAF20 VA: 0x1EDEF20
	public void set_alpha(float value) { }

	// RVA: 0x1EDF040 Offset: 0x1EDB040 VA: 0x1EDF040
	private void Awake() { }

	// RVA: 0x1EDF120 Offset: 0x1EDB120 VA: 0x1EDF120 Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EDF148 Offset: 0x1EDB148 VA: 0x1EDF148
	public static TweenAlpha Begin(GameObject go, float duration, float alpha) { }

	// RVA: 0x1EDF350 Offset: 0x1EDB350 VA: 0x1EDF350
	public void .ctor() { }
}
