// Assembly: Mono.Security.dll
// Namespace: 
public class X509CertificateCollection.X509CertificateEnumerator : IEnumerator // TypeDefIndex: 16880
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x2E50988 Offset: 0x2E4C988 VA: 0x2E50988
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x2E47E48 Offset: 0x2E43E48 VA: 0x2E47E48
	public X509Certificate get_Current() { }

	// RVA: 0x2E50B18 Offset: 0x2E4CB18 VA: 0x2E50B18 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2E50BBC Offset: 0x2E4CBBC VA: 0x2E50BBC Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x2E50C5C Offset: 0x2E4CC5C VA: 0x2E50C5C Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2E48220 Offset: 0x2E44220 VA: 0x2E48220
	public bool MoveNext() { }
}
