// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public sealed class X509ExtensionCollection : ICollection, IEnumerable // TypeDefIndex: 14153
{
	// Fields
	private static byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x348F7D4 Offset: 0x348B7D4 VA: 0x348F7D4
	public void .ctor() { }

	// RVA: 0x3490FB0 Offset: 0x348CFB0 VA: 0x3490FB0 Slot: 5
	public int get_Count() { }

	// RVA: 0x349B544 Offset: 0x3497544 VA: 0x349B544 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x349B568 Offset: 0x3497568 VA: 0x349B568 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x3491A08 Offset: 0x348DA08 VA: 0x3491A08
	public X509Extension get_Item(string oid) { }

	// RVA: 0x348FA90 Offset: 0x348BA90 VA: 0x348FA90
	public int Add(X509Extension extension) { }

	// RVA: 0x349B56C Offset: 0x349756C VA: 0x349B56C Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x3490FD4 Offset: 0x348CFD4 VA: 0x3490FD4
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x349B6B0 Offset: 0x34976B0 VA: 0x349B6B0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x349B70C Offset: 0x349770C VA: 0x349B70C
	private static void .cctor() { }
}
