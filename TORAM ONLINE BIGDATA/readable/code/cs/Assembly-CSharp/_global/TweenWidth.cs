// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Tween/Tween Width")]
public class TweenWidth : UITweener // TypeDefIndex: 143
{
	// Fields
	public int from; // 0x74
	public int to; // 0x78
	public bool updateTable; // 0x7C
	private UIWidget mWidget; // 0x80
	private UITable mTable; // 0x88

	// Properties
	public UIWidget cachedWidget { get; }
	public int width { get; set; }

	// Methods

	// RVA: 0x1EE1334 Offset: 0x1EDD334 VA: 0x1EE1334
	public UIWidget get_cachedWidget() { }

	// RVA: 0x1EE13DC Offset: 0x1EDD3DC VA: 0x1EE13DC
	public int get_width() { }

	// RVA: 0x1EE13F8 Offset: 0x1EDD3F8 VA: 0x1EE13F8
	public void set_width(int value) { }

	// RVA: 0x1EE141C Offset: 0x1EDD41C VA: 0x1EE141C Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EE1648 Offset: 0x1EDD648 VA: 0x1EE1648
	public static TweenWidth Begin(UIWidget widget, float duration, int width) { }

	// RVA: 0x1EE16F4 Offset: 0x1EDD6F4 VA: 0x1EE16F4
	public void .ctor() { }
}
