// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Tween/Tween Height")]
[RequireComponent(typeof(UIWidget))]
public class TweenHeight : UITweener // TypeDefIndex: 136
{
	// Fields
	public int from; // 0x74
	public int to; // 0x78
	public bool updateTable; // 0x7C
	private UIWidget mWidget; // 0x80
	private UITable mTable; // 0x88

	// Properties
	public UIWidget cachedWidget { get; }
	public int height { get; set; }

	// Methods

	// RVA: 0x1EDFCCC Offset: 0x1EDBCCC VA: 0x1EDFCCC
	public UIWidget get_cachedWidget() { }

	// RVA: 0x1EDFD74 Offset: 0x1EDBD74 VA: 0x1EDFD74
	public int get_height() { }

	// RVA: 0x1EDFD90 Offset: 0x1EDBD90 VA: 0x1EDFD90
	public void set_height(int value) { }

	// RVA: 0x1EDFDB4 Offset: 0x1EDBDB4 VA: 0x1EDFDB4 Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EDFFE0 Offset: 0x1EDBFE0 VA: 0x1EDFFE0
	public static TweenHeight Begin(UIWidget widget, float duration, int height) { }

	// RVA: 0x1EE008C Offset: 0x1EDC08C VA: 0x1EE008C
	public void .ctor() { }
}
