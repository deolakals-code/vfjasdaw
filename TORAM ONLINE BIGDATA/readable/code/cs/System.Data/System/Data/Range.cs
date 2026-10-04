// Assembly: System.Data.dll
// Namespace: System.Data
internal struct Range // TypeDefIndex: 14753
{
	// Fields
	private int _min; // 0x0
	private int _max; // 0x4
	private bool _isNotNull; // 0x8

	// Properties
	public int Count { get; }
	public bool IsNull { get; }
	public int Min { get; }

	// Methods

	// RVA: 0x320D02C Offset: 0x320902C VA: 0x320D02C
	public void .ctor(int min, int max) { }

	// RVA: 0x3207990 Offset: 0x3203990 VA: 0x3207990
	public int get_Count() { }

	// RVA: 0x32074B4 Offset: 0x32034B4 VA: 0x32074B4
	public bool get_IsNull() { }

	// RVA: 0x32079B0 Offset: 0x32039B0 VA: 0x32079B0
	public int get_Min() { }

	// RVA: 0x320D078 Offset: 0x3209078 VA: 0x320D078
	internal void CheckNull() { }
}
