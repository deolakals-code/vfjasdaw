// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 17046
{
	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3812C34 Offset: 0x380EC34 VA: 0x3812C34
	public void .ctor() { }

	// RVA: 0x3812C90 Offset: 0x380EC90 VA: 0x3812C90 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x3812D0C Offset: 0x380ED0C VA: 0x3812D0C Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x3812E08 Offset: 0x380EE08 VA: 0x3812E08 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x3812F04 Offset: 0x380EF04 VA: 0x3812F04 Slot: 11
	public override void SetVertical(float y, float height) { }
}
