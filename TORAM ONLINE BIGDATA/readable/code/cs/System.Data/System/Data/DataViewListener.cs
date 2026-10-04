// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class DataViewListener // TypeDefIndex: 14715
{
	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0x31F2C2C Offset: 0x31EEC2C VA: 0x31F2C2C
	internal void .ctor(DataView dv) { }

	// RVA: 0x31F5B60 Offset: 0x31F1B60 VA: 0x31F5B60
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x31F5C2C Offset: 0x31F1C2C VA: 0x31F5C2C
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x31F5CDC Offset: 0x31F1CDC VA: 0x31F5CDC
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x31F5DA8 Offset: 0x31F1DA8 VA: 0x31F5DA8
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x31F5E74 Offset: 0x31F1E74 VA: 0x31F5E74
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0x31F2CB0 Offset: 0x31EECB0 VA: 0x31F2CB0
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0x31F3528 Offset: 0x31EF528 VA: 0x31F3528
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0x31F6140 Offset: 0x31F2140 VA: 0x31F6140
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0x31F52E0 Offset: 0x31F12E0 VA: 0x31F52E0
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0x31F51D8 Offset: 0x31F11D8 VA: 0x31F51D8
	internal void UnregisterListChangedEvent() { }

	// RVA: 0x31F5C10 Offset: 0x31F1C10 VA: 0x31F5C10
	private void CleanUp(bool updateListeners) { }

	// RVA: 0x31F5F24 Offset: 0x31F1F24 VA: 0x31F5F24
	private void RegisterListener(DataTable table) { }
}
