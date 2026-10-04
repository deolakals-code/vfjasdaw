// Assembly: System.dll
// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary // TypeDefIndex: 14224
{
	// Fields
	public static readonly PropertyDescriptorCollection Empty; // 0x0
	private IDictionary _cachedFoundProperties; // 0x10
	private bool _cachedIgnoreCase; // 0x18
	private PropertyDescriptor[] _properties; // 0x20
	private readonly string[] _namedSort; // 0x28
	private readonly IComparer _comparer; // 0x30
	private bool _propsOwned; // 0x38
	private bool _needSort; // 0x39
	private bool _readOnly; // 0x3A
	private readonly object _internalSyncObject; // 0x40
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x48

	// Properties
	public int Count { get; set; }
	public virtual PropertyDescriptor Item { get; }
	public virtual PropertyDescriptor Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x34AEB04 Offset: 0x34AAB04 VA: 0x34AEB04
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x34AEC1C Offset: 0x34AAC1C VA: 0x34AEC1C
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x34AEC40 Offset: 0x34AAC40 VA: 0x34AEC40
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	[CompilerGenerated]
	// RVA: 0x34AED8C Offset: 0x34AAD8C VA: 0x34AED8C
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x34AED94 Offset: 0x34AAD94 VA: 0x34AED94
	private void set_Count(int value) { }

	// RVA: 0x34AED9C Offset: 0x34AAD9C VA: 0x34AED9C Slot: 30
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x34AEEDC Offset: 0x34AAEDC VA: 0x34AEEDC Slot: 31
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x34AEEF0 Offset: 0x34AAEF0 VA: 0x34AEEF0
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x34AF0E8 Offset: 0x34AB0E8 VA: 0x34AF0E8
	public void Clear() { }

	// RVA: 0x34AF13C Offset: 0x34AB13C VA: 0x34AF13C
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x34AF1B4 Offset: 0x34AB1B4 VA: 0x34AF1B4 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x34AEE20 Offset: 0x34AAE20 VA: 0x34AEE20
	private void EnsurePropsOwned() { }

	// RVA: 0x34AEFC0 Offset: 0x34AAFC0 VA: 0x34AEFC0
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x34AF470 Offset: 0x34AB470 VA: 0x34AF470 Slot: 32
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x34AF154 Offset: 0x34AB154 VA: 0x34AF154
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x34AF99C Offset: 0x34AB99C VA: 0x34AF99C
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x34AFA8C Offset: 0x34ABA8C VA: 0x34AFA8C
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x34AFAF4 Offset: 0x34ABAF4 VA: 0x34AFAF4
	public void RemoveAt(int index) { }

	// RVA: 0x34AFBB0 Offset: 0x34ABBB0 VA: 0x34AFBB0 Slot: 33
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x34AF1F0 Offset: 0x34AB1F0 VA: 0x34AF1F0
	protected void InternalSort(string[] names) { }

	// RVA: 0x34AFC2C Offset: 0x34ABC2C VA: 0x34AFC2C
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x34AFCA4 Offset: 0x34ABCA4 VA: 0x34AFCA4 Slot: 34
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x34AFD40 Offset: 0x34ABD40 VA: 0x34AFD40 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x34AFD48 Offset: 0x34ABD48 VA: 0x34AFD48 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x34AFD50 Offset: 0x34ABD50 VA: 0x34AFD50 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x34AFD58 Offset: 0x34ABD58 VA: 0x34AFD58 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x34AFD5C Offset: 0x34ABD5C VA: 0x34AFD5C Slot: 26
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x34AFD60 Offset: 0x34ABD60 VA: 0x34AFD60 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x34AFD70 Offset: 0x34ABD70 VA: 0x34AFD70 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x34AFD74 Offset: 0x34ABD74 VA: 0x34AFD74 Slot: 25
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x34AFE38 Offset: 0x34ABE38 VA: 0x34AFE38 Slot: 24
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x34AFEB8 Offset: 0x34ABEB8 VA: 0x34AFEB8 Slot: 28
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x34AFF60 Offset: 0x34ABF60 VA: 0x34AFF60 Slot: 27
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x34AFF68 Offset: 0x34ABF68 VA: 0x34AFF68 Slot: 20
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x34AFFE4 Offset: 0x34ABFE4 VA: 0x34AFFE4 Slot: 21
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x34B039C Offset: 0x34AC39C VA: 0x34B039C Slot: 22
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x34B047C Offset: 0x34AC47C VA: 0x34B047C Slot: 23
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x34B0554 Offset: 0x34AC554 VA: 0x34B0554 Slot: 29
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x34B0648 Offset: 0x34AC648 VA: 0x34B0648 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x34B06CC Offset: 0x34AC6CC VA: 0x34B06CC Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x34B075C Offset: 0x34AC75C VA: 0x34B075C Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x34B07E0 Offset: 0x34AC7E0 VA: 0x34B07E0 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x34B0874 Offset: 0x34AC874 VA: 0x34B0874 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x34B087C Offset: 0x34AC87C VA: 0x34B087C Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x34B0884 Offset: 0x34AC884 VA: 0x34B0884 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x34B0908 Offset: 0x34AC908 VA: 0x34B0908 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x34B0918 Offset: 0x34AC918 VA: 0x34B0918 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x34B0AE8 Offset: 0x34ACAE8 VA: 0x34B0AE8
	private static void .cctor() { }
}
