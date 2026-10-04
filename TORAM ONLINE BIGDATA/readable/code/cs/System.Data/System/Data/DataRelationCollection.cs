// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 14691
{
	// Fields
	private DataRelation _inTransition; // 0x10
	private int _defaultNameIndex; // 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x30

	// Properties
	internal int ObjectID { get; }
	public abstract DataRelation Item { get; }
	public abstract DataRelation Item { get; }

	// Methods

	// RVA: 0x31E93D0 Offset: 0x31E53D0 VA: 0x31E93D0
	internal int get_ObjectID() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract DataRelation get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract DataRelation get_Item(string name);

	// RVA: 0x31E93D8 Offset: 0x31E53D8 VA: 0x31E93D8
	public void Add(DataRelation relation) { }

	// RVA: 0x31E9690 Offset: 0x31E5690 VA: 0x31E9690 Slot: 15
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0x31E9938 Offset: 0x31E5938 VA: 0x31E9938
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x31E9A40 Offset: 0x31E5A40 VA: 0x31E9A40
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x31E9B48 Offset: 0x31E5B48 VA: 0x31E9B48
	internal string AssignName() { }

	// RVA: 0x31E9C24 Offset: 0x31E5C24 VA: 0x31E9C24 Slot: 16
	public virtual void Clear() { }

	// RVA: 0x31E9E8C Offset: 0x31E5E8C VA: 0x31E9E8C Slot: 17
	public virtual bool Contains(string name) { }

	// RVA: 0x31E9EA4 Offset: 0x31E5EA4 VA: 0x31E9EA4
	internal int InternalIndexOf(string name) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract DataSet GetDataSet();

	// RVA: 0x31E9B6C Offset: 0x31E5B6C VA: 0x31E9B6C
	private string MakeName(int index) { }

	// RVA: 0x31EA01C Offset: 0x31E601C VA: 0x31EA01C Slot: 19
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x31EA0EC Offset: 0x31E60EC VA: 0x31EA0EC Slot: 20
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x31EA1BC Offset: 0x31E61BC VA: 0x31EA1BC
	internal void RegisterName(string name) { }

	// RVA: 0x31EA378 Offset: 0x31E6378 VA: 0x31EA378
	public void Remove(DataRelation relation) { }

	// RVA: 0x31EA574 Offset: 0x31E6574 VA: 0x31EA574
	public void RemoveAt(int index) { }

	// RVA: 0x31EA5E8 Offset: 0x31E65E8 VA: 0x31EA5E8 Slot: 21
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0x31EA7D0 Offset: 0x31E67D0 VA: 0x31EA7D0
	internal void UnregisterName(string name) { }

	// RVA: 0x31EA8FC Offset: 0x31E68FC VA: 0x31EA8FC
	protected void .ctor() { }
}
