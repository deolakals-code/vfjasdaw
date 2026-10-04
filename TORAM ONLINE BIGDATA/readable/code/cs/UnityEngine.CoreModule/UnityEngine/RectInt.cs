// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
public struct RectInt : IEquatable<RectInt>, IFormattable // TypeDefIndex: 16231
{
	// Fields
	private int m_XMin; // 0x0
	private int m_YMin; // 0x4
	private int m_Width; // 0x8
	private int m_Height; // 0xC

	// Properties
	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }

	// Methods

	// RVA: 0x37D2D98 Offset: 0x37CED98 VA: 0x37D2D98
	public int get_x() { }

	// RVA: 0x37D2DA0 Offset: 0x37CEDA0 VA: 0x37D2DA0
	public int get_y() { }

	// RVA: 0x37D2DA8 Offset: 0x37CEDA8 VA: 0x37D2DA8
	public int get_width() { }

	// RVA: 0x37D2DB0 Offset: 0x37CEDB0 VA: 0x37D2DB0
	public int get_height() { }

	// RVA: 0x37D2DB8 Offset: 0x37CEDB8 VA: 0x37D2DB8 Slot: 3
	public override string ToString() { }

	// RVA: 0x37D2DC8 Offset: 0x37CEDC8 VA: 0x37D2DC8 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x37D3000 Offset: 0x37CF000 VA: 0x37D3000 Slot: 4
	public bool Equals(RectInt other) { }
}
