// Assembly: System.dll
// Namespace: 
[CompilerGenerated]
private sealed class CertificateData.<ReadReverseRdns>d__21 : IEnumerable<KeyValuePair<string, string>>, IEnumerable, IEnumerator<KeyValuePair<string, string>>, IDisposable, IEnumerator // TypeDefIndex: 14023
{
	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, string> <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x28
	private X500DistinguishedName name; // 0x30
	public X500DistinguishedName <>3__name; // 0x38
	private Stack<DerSequenceReader> <rdnReaders>5__2; // 0x40
	private DerSequenceReader <rdnReader>5__3; // 0x48

	// Properties
	private KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x31A40A4 Offset: 0x31A00A4 VA: 0x31A40A4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x31A40D8 Offset: 0x31A00D8 VA: 0x31A40D8 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x31A40DC Offset: 0x31A00DC VA: 0x31A40DC Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x31A43A4 Offset: 0x31A03A4 VA: 0x31A43A4 Slot: 6
	private KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x31A43B0 Offset: 0x31A03B0 VA: 0x31A43B0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x31A43E8 Offset: 0x31A03E8 VA: 0x31A43E8 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x31A4444 Offset: 0x31A0444 VA: 0x31A4444 Slot: 4
	private IEnumerator<KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x31A44E8 Offset: 0x31A04E8 VA: 0x31A44E8 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}
