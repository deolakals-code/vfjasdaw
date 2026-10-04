// Assembly: mscorlib.dll
// Namespace: 
private class Evidence.EvidenceEnumerator : IEnumerator // TypeDefIndex: 10087
{
	// Fields
	private IEnumerator currentEnum; // 0x10
	private IEnumerator hostEnum; // 0x18
	private IEnumerator assemblyEnum; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x2EA8074 Offset: 0x2EA4074 VA: 0x2EA8074
	public void .ctor(IEnumerator hostenum, IEnumerator assemblyenum) { }

	// RVA: 0x2EA80D4 Offset: 0x2EA40D4 VA: 0x2EA80D4 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2EA8220 Offset: 0x2EA4220 VA: 0x2EA8220 Slot: 6
	public void Reset() { }

	// RVA: 0x2EA8348 Offset: 0x2EA4348 VA: 0x2EA8348 Slot: 5
	public object get_Current() { }
}
