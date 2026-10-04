// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Geometry/AABB.h")]
[NativeType(Header = "Runtime/Geometry/AABB.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeHeader("Runtime/Geometry/Ray.h")]
[NativeHeader("Runtime/Geometry/Intersection.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("AABB")]
public struct Bounds : IEquatable<Bounds>, IFormattable // TypeDefIndex: 16225
{
	// Fields
	private Vector3 m_Center; // 0x0
	[NativeName("m_Extent")]
	private Vector3 m_Extents; // 0xC

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; set; }
	public Vector3 max { get; set; }

	// Methods

	// RVA: 0x37D0E6C Offset: 0x37CCE6C VA: 0x37D0E6C
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x37D0E8C Offset: 0x37CCE8C VA: 0x37D0E8C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37D0F5C Offset: 0x37CCF5C VA: 0x37D0F5C Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37D102C Offset: 0x37CD02C VA: 0x37D102C Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x37D1098 Offset: 0x37CD098 VA: 0x37D1098
	public Vector3 get_center() { }

	// RVA: 0x37D10A4 Offset: 0x37CD0A4 VA: 0x37D10A4
	public void set_center(Vector3 value) { }

	// RVA: 0x37D10B0 Offset: 0x37CD0B0 VA: 0x37D10B0
	public Vector3 get_size() { }

	// RVA: 0x37D10C8 Offset: 0x37CD0C8 VA: 0x37D10C8
	public Vector3 get_extents() { }

	// RVA: 0x37D10D4 Offset: 0x37CD0D4 VA: 0x37D10D4
	public void set_extents(Vector3 value) { }

	// RVA: 0x37D10E0 Offset: 0x37CD0E0 VA: 0x37D10E0
	public Vector3 get_min() { }

	// RVA: 0x37D1100 Offset: 0x37CD100 VA: 0x37D1100
	public void set_min(Vector3 value) { }

	// RVA: 0x37D1150 Offset: 0x37CD150 VA: 0x37D1150
	public Vector3 get_max() { }

	// RVA: 0x37D1170 Offset: 0x37CD170 VA: 0x37D1170
	public void set_max(Vector3 value) { }

	// RVA: 0x37D11C0 Offset: 0x37CD1C0 VA: 0x37D11C0
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x37D11F8 Offset: 0x37CD1F8 VA: 0x37D11F8
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x37D1270 Offset: 0x37CD270 VA: 0x37D1270
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x37D136C Offset: 0x37CD36C VA: 0x37D136C
	public bool Intersects(Bounds bounds) { }

	// RVA: 0x37D140C Offset: 0x37CD40C VA: 0x37D140C Slot: 3
	public override string ToString() { }

	// RVA: 0x37D141C Offset: 0x37CD41C VA: 0x37D141C Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
