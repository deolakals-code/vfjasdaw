// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private class BitArray.BitArrayEnumeratorSimple : IEnumerator, ICloneable // TypeDefIndex: 10893
{
	// Fields
	private BitArray bitarray; // 0x10
	private int index; // 0x18
	private int version; // 0x1C
	private bool currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x2FBBE8C Offset: 0x2FB7E8C VA: 0x2FBBE8C
	internal void .ctor(BitArray bitarray) { }

	// RVA: 0x2FBBEDC Offset: 0x2FB7EDC VA: 0x2FBBEDC Slot: 7
	public object Clone() { }

	// RVA: 0x2FBBEE4 Offset: 0x2FB7EE4 VA: 0x2FBBEE4 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x2FBC088 Offset: 0x2FB8088 VA: 0x2FBC088 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x2FBC1DC Offset: 0x2FB81DC VA: 0x2FBC1DC Slot: 6
	public void Reset() { }
}
