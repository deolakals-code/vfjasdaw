// Assembly: System.Xml.dll
// Namespace: System.Xml
[DefaultMember("ItemOf")]
public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable // TypeDefIndex: 13388
{
	// Properties
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x33B1B00 Offset: 0x33ADB00 VA: 0x33B1B00
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x33B1B08 Offset: 0x33ADB08 VA: 0x33B1B08
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x33B1C4C Offset: 0x33ADC4C VA: 0x33B1C4C
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0x33B1D74 Offset: 0x33ADD74 VA: 0x33B1D74
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0x33B1ECC Offset: 0x33ADECC VA: 0x33B1ECC
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0x33B2050 Offset: 0x33AE050 VA: 0x33B2050 Slot: 6
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x33B2284 Offset: 0x33AE284 VA: 0x33B2284
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x33B2538 Offset: 0x33AE538 VA: 0x33B2538
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x33B25C0 Offset: 0x33AE5C0 VA: 0x33B25C0
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0x33B266C Offset: 0x33AE66C VA: 0x33B266C
	public void RemoveAll() { }

	// RVA: 0x33B26B4 Offset: 0x33AE6B4 VA: 0x33B26B4 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x33B2738 Offset: 0x33AE738 VA: 0x33B2738 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x33B2740 Offset: 0x33AE740 VA: 0x33B2740 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x33B2744 Offset: 0x33AE744 VA: 0x33B2744 Slot: 14
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x33B274C Offset: 0x33AE74C VA: 0x33B274C Slot: 9
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0x33B2934 Offset: 0x33AE934 VA: 0x33B2934 Slot: 12
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x33B29E4 Offset: 0x33AE9E4 VA: 0x33B29E4 Slot: 11
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x33B2398 Offset: 0x33AE398 VA: 0x33B2398
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0x33B23E0 Offset: 0x33AE3E0 VA: 0x33B23E0
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x33B2B84 Offset: 0x33AEB84 VA: 0x33B2B84
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x33B2830 Offset: 0x33AE830 VA: 0x33B2830
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x33B106C Offset: 0x33AD06C VA: 0x33B106C
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x33B1160 Offset: 0x33AD160 VA: 0x33B1160
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x33B21E4 Offset: 0x33AE1E4 VA: 0x33B21E4
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }
}
