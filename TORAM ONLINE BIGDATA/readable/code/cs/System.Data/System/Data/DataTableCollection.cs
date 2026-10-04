// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultMember("Item")]
[DefaultEvent("CollectionChanged")]
[ListBindable(False)]
public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 14709
{
	// Fields
	private readonly DataSet _dataSet; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataTable[] _delayedAddRangeTables; // 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x40

	// Properties
	protected override ArrayList List { get; }
	internal int ObjectID { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }

	// Methods

	// RVA: 0x31F0434 Offset: 0x31EC434 VA: 0x31F0434
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x31F059C Offset: 0x31EC59C VA: 0x31F059C Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x31F05A4 Offset: 0x31EC5A4 VA: 0x31F05A4
	internal int get_ObjectID() { }

	// RVA: 0x31F05AC Offset: 0x31EC5AC VA: 0x31F05AC
	public DataTable get_Item(int index) { }

	// RVA: 0x31F06DC Offset: 0x31EC6DC VA: 0x31F06DC
	public DataTable get_Item(string name) { }

	// RVA: 0x31E9010 Offset: 0x31E5010 VA: 0x31E9010
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0x31F0B24 Offset: 0x31ECB24 VA: 0x31F0B24
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0x31F0C40 Offset: 0x31ECC40 VA: 0x31F0C40
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0x31F0D7C Offset: 0x31ECD7C VA: 0x31F0D7C
	public void Add(DataTable table) { }

	// RVA: 0x31F11FC Offset: 0x31ED1FC VA: 0x31F11FC
	private void ArrayAdd(DataTable table) { }

	// RVA: 0x31F12F0 Offset: 0x31ED2F0 VA: 0x31F12F0
	internal string AssignName() { }

	// RVA: 0x31F10E8 Offset: 0x31ED0E8 VA: 0x31F10E8
	private void BaseAdd(DataTable table) { }

	// RVA: 0x31F1668 Offset: 0x31ED668 VA: 0x31F1668
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0x31F17E0 Offset: 0x31ED7E0 VA: 0x31F17E0
	private void BaseRemove(DataTable table) { }

	// RVA: 0x31F1858 Offset: 0x31ED858 VA: 0x31F1858
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0x31F1DE0 Offset: 0x31EDDE0 VA: 0x31F1DE0
	public void Clear() { }

	// RVA: 0x31F13F0 Offset: 0x31ED3F0 VA: 0x31F13F0
	public bool Contains(string name) { }

	// RVA: 0x31F20B8 Offset: 0x31EE0B8 VA: 0x31F20B8
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0x31F222C Offset: 0x31EE22C VA: 0x31F222C
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x31F2354 Offset: 0x31EE354 VA: 0x31F2354
	public int IndexOf(DataTable table) { }

	// RVA: 0x31F2438 Offset: 0x31EE438 VA: 0x31F2438
	public int IndexOf(string tableName) { }

	// RVA: 0x31F2450 Offset: 0x31EE450 VA: 0x31F2450
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0x31F24B0 Offset: 0x31EE4B0 VA: 0x31F24B0
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	// RVA: 0x31F07D0 Offset: 0x31EC7D0 VA: 0x31F07D0
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0x31F0998 Offset: 0x31EC998 VA: 0x31F0998
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0x31F1338 Offset: 0x31ED338 VA: 0x31F1338
	private string MakeName(int index) { }

	// RVA: 0x31F1220 Offset: 0x31ED220 VA: 0x31F1220
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x31F1018 Offset: 0x31ED018 VA: 0x31F1018
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x31F1408 Offset: 0x31ED408 VA: 0x31F1408
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0x31F2500 Offset: 0x31EE500 VA: 0x31F2500
	public void Remove(DataTable table) { }

	// RVA: 0x31F1CD4 Offset: 0x31EDCD4 VA: 0x31F1CD4
	internal void UnregisterName(string name) { }
}
