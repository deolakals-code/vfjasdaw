// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
public struct Plane : IFormattable // TypeDefIndex: 16228
{
	// Fields
	internal const int size = 16;
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; set; }
	public float distance { get; set; }

	// Methods

	// RVA: 0x37D1DB4 Offset: 0x37CDDB4 VA: 0x37D1DB4
	public Vector3 get_normal() { }

	// RVA: 0x37D1DC0 Offset: 0x37CDDC0 VA: 0x37D1DC0
	public void set_normal(Vector3 value) { }

	// RVA: 0x37D1DCC Offset: 0x37CDDCC VA: 0x37D1DCC
	public float get_distance() { }

	// RVA: 0x37D1DD4 Offset: 0x37CDDD4 VA: 0x37D1DD4
	public void set_distance(float value) { }

	// RVA: 0x37D1DDC Offset: 0x37CDDDC VA: 0x37D1DDC
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x37D1EEC Offset: 0x37CDEEC VA: 0x37D1EEC
	public void .ctor(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0x37D2064 Offset: 0x37CE064 VA: 0x37D2064
	public bool GetSide(Vector3 point) { }

	// RVA: 0x37D2090 Offset: 0x37CE090 VA: 0x37D2090
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x37D2190 Offset: 0x37CE190 VA: 0x37D2190 Slot: 3
	public override string ToString() { }

	// RVA: 0x37D21A0 Offset: 0x37CE1A0 VA: 0x37D21A0 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}
