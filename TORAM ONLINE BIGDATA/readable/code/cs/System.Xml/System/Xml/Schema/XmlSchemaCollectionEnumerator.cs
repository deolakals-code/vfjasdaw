// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollectionEnumerator : IEnumerator // TypeDefIndex: 13762
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public XmlSchema Current { get; }
	internal XmlSchemaCollectionNode CurrentNode { get; }

	// Methods

	// RVA: 0x3334060 Offset: 0x3330060 VA: 0x3334060
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x3334754 Offset: 0x3330754 VA: 0x3334754 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x33347F8 Offset: 0x33307F8 VA: 0x33347F8 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x33342F4 Offset: 0x33302F4 VA: 0x33342F4
	public bool MoveNext() { }

	// RVA: 0x3334898 Offset: 0x3330898 VA: 0x3334898 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x333421C Offset: 0x333021C VA: 0x333421C
	public XmlSchema get_Current() { }

	// RVA: 0x333489C Offset: 0x333089C VA: 0x333489C
	internal XmlSchemaCollectionNode get_CurrentNode() { }
}
