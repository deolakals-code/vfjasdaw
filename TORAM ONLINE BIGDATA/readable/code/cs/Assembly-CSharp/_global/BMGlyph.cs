// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class BMGlyph // TypeDefIndex: 67
{
	// Fields
	public int index; // 0x10
	public int x; // 0x14
	public int y; // 0x18
	public int width; // 0x1C
	public int height; // 0x20
	public int offsetX; // 0x24
	public int offsetY; // 0x28
	public int advance; // 0x2C
	public int channel; // 0x30
	public List<int> kerning; // 0x38

	// Methods

	// RVA: 0x1729D78 Offset: 0x1725D78 VA: 0x1729D78
	public int GetKerning(int previousChar) { }

	// RVA: 0x1729E3C Offset: 0x1725E3C VA: 0x1729E3C
	public void SetKerning(int previousChar, int amount) { }

	// RVA: 0x1729C10 Offset: 0x1725C10 VA: 0x1729C10
	public void Trim(int xMin, int yMin, int xMax, int yMax) { }

	// RVA: 0x1729A94 Offset: 0x1725A94 VA: 0x1729A94
	public void .ctor() { }
}
