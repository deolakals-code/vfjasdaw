// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Tween/Tween Color")]
public class TweenColor : UITweener // TypeDefIndex: 133
{
	// Fields
	public Color from; // 0x74
	public Color to; // 0x84
	private Transform mTrans; // 0x98
	private IUIWidget mWidget; // 0xA0
	private Material mMat; // 0xA8
	private Light mLight; // 0xB0

	// Properties
	public Color color { get; set; }

	// Methods

	// RVA: 0x1EDF514 Offset: 0x1EDB514 VA: 0x1EDF514
	public Color get_color() { }

	// RVA: 0x1EDF668 Offset: 0x1EDB668 VA: 0x1EDF668
	public void set_color(Color value) { }

	// RVA: 0x1EDF81C Offset: 0x1EDB81C VA: 0x1EDF81C
	private void Awake() { }

	// RVA: 0x1EDF930 Offset: 0x1EDB930 VA: 0x1EDF930 Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EDF968 Offset: 0x1EDB968 VA: 0x1EDF968
	public static TweenColor Begin(GameObject go, float duration, Color color) { }

	// RVA: 0x1EDFA30 Offset: 0x1EDBA30 VA: 0x1EDFA30
	public void .ctor() { }
}
