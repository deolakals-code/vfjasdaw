// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class UISpriteData // TypeDefIndex: 182
{
	// Fields
	public string name; // 0x10
	public int x; // 0x18
	public int y; // 0x1C
	public int width; // 0x20
	public int height; // 0x24
	public int borderLeft; // 0x28
	public int borderRight; // 0x2C
	public int borderTop; // 0x30
	public int borderBottom; // 0x34
	public int paddingLeft; // 0x38
	public int paddingRight; // 0x3C
	public int paddingTop; // 0x40
	public int paddingBottom; // 0x44

	// Properties
	public bool hasBorder { get; }
	public bool hasPadding { get; }

	// Methods

	// RVA: 0x20D6CA4 Offset: 0x20D2CA4 VA: 0x20D6CA4
	public bool get_hasBorder() { }

	// RVA: 0x20D7884 Offset: 0x20D3884 VA: 0x20D7884
	public bool get_hasPadding() { }

	// RVA: 0x20D78A4 Offset: 0x20D38A4 VA: 0x20D78A4
	public void SetRect(int x, int y, int width, int height) { }

	// RVA: 0x20D78B0 Offset: 0x20D38B0 VA: 0x20D78B0
	public void SetPadding(int left, int bottom, int right, int top) { }

	// RVA: 0x20D78BC Offset: 0x20D38BC VA: 0x20D78BC
	public void SetBorder(int left, int bottom, int right, int top) { }

	// RVA: 0x20D78C8 Offset: 0x20D38C8 VA: 0x20D78C8
	public void CopyFrom(UISpriteData sd) { }

	// RVA: 0x20D7914 Offset: 0x20D3914 VA: 0x20D7914
	public void .ctor() { }
}
