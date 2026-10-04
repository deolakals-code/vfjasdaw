// Assembly: System.dll
// Namespace: System.Security.Cryptography
public sealed class OidEnumerator : IEnumerator // TypeDefIndex: 14115
{
	// Fields
	private readonly OidCollection _oids; // 0x10
	private int _current; // 0x18

	// Properties
	public Oid Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x348B7DC Offset: 0x34877DC VA: 0x348B7DC
	internal void .ctor(OidCollection oids) { }

	// RVA: 0x348B9D4 Offset: 0x34879D4 VA: 0x348B9D4
	public Oid get_Current() { }

	// RVA: 0x348B9F4 Offset: 0x34879F4 VA: 0x348B9F4 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x348B9F8 Offset: 0x34879F8 VA: 0x348B9F8 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x348BA44 Offset: 0x3487A44 VA: 0x348BA44 Slot: 6
	public void Reset() { }
}
