// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeType("Runtime/Graphics/RefreshRate.h")]
public struct RefreshRate : IEquatable<RefreshRate>, IComparable<RefreshRate> // TypeDefIndex: 16238
{
	// Fields
	public uint numerator; // 0x0
	public uint denominator; // 0x4

	// Properties
	public double value { get; }

	// Methods

	// RVA: 0x37D3F9C Offset: 0x37CFF9C VA: 0x37D3F9C
	public double get_value() { }

	// RVA: 0x37D3FB0 Offset: 0x37CFFB0 VA: 0x37D3FB0 Slot: 4
	public bool Equals(RefreshRate other) { }

	// RVA: 0x37D3FEC Offset: 0x37CFFEC VA: 0x37D3FEC Slot: 5
	public int CompareTo(RefreshRate other) { }

	// RVA: 0x37D403C Offset: 0x37D003C VA: 0x37D403C Slot: 3
	public override string ToString() { }
}
