// Assembly: System.dll
// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class AttributeCollection : ICollection, IEnumerable // TypeDefIndex: 14179
{
	// Fields
	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable s_defaultAttributes; // 0x8
	private readonly Attribute[] _attributes; // 0x10
	private static readonly object s_internalSyncObject; // 0x10
	private AttributeCollection.AttributeEntry[] _foundAttributeTypes; // 0x18
	private int _index; // 0x20

	// Properties
	protected virtual Attribute[] Attributes { get; }
	public int Count { get; }
	public virtual Attribute Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x349EECC Offset: 0x349AECC VA: 0x349EECC
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x349F00C Offset: 0x349B00C VA: 0x349F00C Slot: 9
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x349F014 Offset: 0x349B014 VA: 0x349F014
	public int get_Count() { }

	// RVA: 0x349F038 Offset: 0x349B038 VA: 0x349F038 Slot: 10
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x349FAA0 Offset: 0x349BAA0 VA: 0x349FAA0
	public bool Contains(Attribute attribute) { }

	// RVA: 0x349F528 Offset: 0x349B528 VA: 0x349F528
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x349FB00 Offset: 0x349BB00 VA: 0x349FB00
	public IEnumerator GetEnumerator() { }

	// RVA: 0x349FB24 Offset: 0x349BB24 VA: 0x349FB24 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x349FB2C Offset: 0x349BB2C VA: 0x349FB2C Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x349FB34 Offset: 0x349BB34 VA: 0x349FB34 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x349FB58 Offset: 0x349BB58 VA: 0x349FB58 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x349FB5C Offset: 0x349BB5C VA: 0x349FB5C Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x349FBC8 Offset: 0x349BBC8 VA: 0x349FBC8
	private static void .cctor() { }
}
