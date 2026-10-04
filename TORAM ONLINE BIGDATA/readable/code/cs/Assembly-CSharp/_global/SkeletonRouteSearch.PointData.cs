// Assembly: Assembly-CSharp.dll
// Namespace: 
private class SkeletonRouteSearch.PointData // TypeDefIndex: 2888
{
	// Fields
	public short GridX; // 0x10
	public short GridZ; // 0x12
	public float PosY; // 0x14
	public byte distance; // 0x18
	public byte Rating; // 0x19

	// Methods

	// RVA: 0x22BEE5C Offset: 0x22BAE5C VA: 0x22BEE5C
	public void .ctor(short x, short z, float y, byte dist, byte rating) { }

	// RVA: 0x22BF30C Offset: 0x22BB30C VA: 0x22BF30C
	public bool IsMatchPoint(short x, short z) { }

	// RVA: 0x22BF264 Offset: 0x22BB264 VA: 0x22BF264
	public bool IsNearPosY(float y) { }

	// RVA: 0x22BF824 Offset: 0x22BB824 VA: 0x22BF824
	public ValueTuple<short, short> GetGridPos() { }

	// RVA: 0x22BF05C Offset: 0x22BB05C VA: 0x22BF05C
	public Vector3 GetPos() { }
}
