// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Certificate2Enumerator : IEnumerator // TypeDefIndex: 14136
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate2 Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x34933FC Offset: 0x348F3FC VA: 0x34933FC
	internal void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0x349355C Offset: 0x348F55C VA: 0x349355C
	public X509Certificate2 get_Current() { }

	// RVA: 0x349364C Offset: 0x348F64C VA: 0x349364C
	public bool MoveNext() { }

	// RVA: 0x34936EC Offset: 0x348F6EC VA: 0x34936EC Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x3493790 Offset: 0x348F790 VA: 0x3493790 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x3493830 Offset: 0x348F830 VA: 0x3493830 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
}
