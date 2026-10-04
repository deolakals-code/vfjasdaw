// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator : IEnumerator // TypeDefIndex: 14146
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509ChainElement Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x3496A1C Offset: 0x3492A1C VA: 0x3496A1C
	internal void .ctor(IEnumerable enumerable) { }

	// RVA: 0x3496CE0 Offset: 0x3492CE0 VA: 0x3496CE0
	public X509ChainElement get_Current() { }

	// RVA: 0x3496DD0 Offset: 0x3492DD0 VA: 0x3496DD0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x3496E74 Offset: 0x3492E74 VA: 0x3496E74 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x3496F14 Offset: 0x3492F14 VA: 0x3496F14 Slot: 6
	public void Reset() { }
}
