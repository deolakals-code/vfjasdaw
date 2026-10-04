// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FurnitureArrangeData // TypeDefIndex: 1963
{
	// Fields
	public readonly int ObjId; // 0x10
	private Dictionary<FurnitureArrangeData.KeyData, int> data; // 0x18

	// Properties
	public int ColorR { get; }
	public int ColorG { get; }
	public int ColorB { get; }

	// Methods

	// RVA: 0x2113CDC Offset: 0x210FCDC VA: 0x2113CDC
	public int get_ColorR() { }

	// RVA: 0x2113D8C Offset: 0x210FD8C VA: 0x2113D8C
	public int get_ColorG() { }

	// RVA: 0x2113D98 Offset: 0x210FD98 VA: 0x2113D98
	public int get_ColorB() { }

	// RVA: 0x2113DA4 Offset: 0x210FDA4 VA: 0x2113DA4
	public void .ctor(int objId) { }

	// RVA: 0x2113E38 Offset: 0x210FE38 VA: 0x2113E38
	public void SetColorIndex(byte[] colorIndexs) { }

	// RVA: 0x2113F7C Offset: 0x210FF7C VA: 0x2113F7C
	public void SetColorIndex(int colorIndexs) { }

	// RVA: 0x2113CE8 Offset: 0x210FCE8 VA: 0x2113CE8
	private int GetKey(FurnitureArrangeData.KeyData key, int defaultParam) { }
}
