// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct Ray : IFormattable // TypeDefIndex: 16229
{
	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; set; }
	public Vector3 direction { get; set; }

	// Methods

	// RVA: 0x37D2340 Offset: 0x37CE340 VA: 0x37D2340
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x37D242C Offset: 0x37CE42C VA: 0x37D242C
	public Vector3 get_origin() { }

	// RVA: 0x37D2438 Offset: 0x37CE438 VA: 0x37D2438
	public void set_origin(Vector3 value) { }

	// RVA: 0x37D2444 Offset: 0x37CE444 VA: 0x37D2444
	public Vector3 get_direction() { }

	// RVA: 0x37D2450 Offset: 0x37CE450 VA: 0x37D2450
	public void set_direction(Vector3 value) { }

	// RVA: 0x37D2534 Offset: 0x37CE534 VA: 0x37D2534
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x37D255C Offset: 0x37CE55C VA: 0x37D255C Slot: 3
	public override string ToString() { }

	// RVA: 0x37D256C Offset: 0x37CE56C VA: 0x37D256C Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}
