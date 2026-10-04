// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultMember("Item")]
[DefaultEvent("CollectionChanged")]
public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 14683
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataColumn[] _delayedAddRangeColumns; // 0x28
	private readonly Dictionary<string, DataColumn> _columnFromName; // 0x30
	private bool _fInClear; // 0x38
	private DataColumn[] _columnsImplementingIChangeTracking; // 0x40
	private int _nColumnsImplementingIChangeTracking; // 0x48
	private int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanged; // 0x50
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanging; // 0x58
	[CompilerGenerated]
	private CollectionChangeEventHandler ColumnPropertyChanged; // 0x60

	// Properties
	protected override ArrayList List { get; }
	internal DataColumn[] ColumnsImplementingIChangeTracking { get; }
	internal int ColumnsImplementingIChangeTrackingCount { get; }
	internal int ColumnsImplementingIRevertibleChangeTrackingCount { get; }
	public DataColumn Item { get; }
	public DataColumn Item { get; }
	internal DataColumn Item { get; }

	// Methods

	// RVA: 0x31E1A2C Offset: 0x31DDA2C VA: 0x31E1A2C
	internal void .ctor(DataTable table) { }

	// RVA: 0x31E1BA0 Offset: 0x31DDBA0 VA: 0x31E1BA0 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x31E1BA8 Offset: 0x31DDBA8 VA: 0x31E1BA8
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0x31E1BB0 Offset: 0x31DDBB0 VA: 0x31E1BB0
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0x31E1BB8 Offset: 0x31DDBB8 VA: 0x31E1BB8
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0x31E1BC0 Offset: 0x31DDBC0 VA: 0x31E1BC0
	public DataColumn get_Item(int index) { }

	// RVA: 0x31E1CF0 Offset: 0x31DDCF0 VA: 0x31E1CF0
	public DataColumn get_Item(string name) { }

	// RVA: 0x31E1F88 Offset: 0x31DDF88 VA: 0x31E1F88
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0x31E202C Offset: 0x31DE02C VA: 0x31E202C
	public void Add(DataColumn column) { }

	// RVA: 0x31E2038 Offset: 0x31DE038 VA: 0x31E2038
	internal void AddAt(int index, DataColumn column) { }

	[CompilerGenerated]
	// RVA: 0x31E26E4 Offset: 0x31DE6E4 VA: 0x31E26E4
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x31E2780 Offset: 0x31DE780 VA: 0x31E2780
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x31E281C Offset: 0x31DE81C VA: 0x31E281C
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x31E28B8 Offset: 0x31DE8B8 VA: 0x31E28B8
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x31E25D4 Offset: 0x31DE5D4 VA: 0x31E25D4
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0x31E2594 Offset: 0x31DE594 VA: 0x31E2594
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0x31E299C Offset: 0x31DE99C VA: 0x31E299C
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0x31E2BE4 Offset: 0x31DEBE4 VA: 0x31E2BE4
	internal string AssignName() { }

	// RVA: 0x31E22BC Offset: 0x31DE2BC VA: 0x31E22BC
	private void BaseAdd(DataColumn column) { }

	// RVA: 0x31E2FAC Offset: 0x31DEFAC VA: 0x31E2FAC
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0x31E318C Offset: 0x31DF18C VA: 0x31E318C
	private void BaseRemove(DataColumn column) { }

	// RVA: 0x31E3244 Offset: 0x31DF244 VA: 0x31E3244
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0x31E2954 Offset: 0x31DE954 VA: 0x31E2954
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0x31E3AA4 Offset: 0x31DFAA4 VA: 0x31E3AA4
	public void Clear() { }

	// RVA: 0x31E3D84 Offset: 0x31DFD84 VA: 0x31E3D84
	public bool Contains(string name) { }

	// RVA: 0x31E3E18 Offset: 0x31DFE18 VA: 0x31E3E18
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x31E3EB4 Offset: 0x31DFEB4 VA: 0x31E3EB4
	public int IndexOf(string columnName) { }

	// RVA: 0x31E1E38 Offset: 0x31DDE38 VA: 0x31E1E38
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0x31E2C78 Offset: 0x31DEC78 VA: 0x31E2C78
	private string MakeName(int index) { }

	// RVA: 0x31E2640 Offset: 0x31DE640 VA: 0x31E2640
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x31E2294 Offset: 0x31DE294 VA: 0x31E2294
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x31E3FB4 Offset: 0x31DFFB4 VA: 0x31E3FB4
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x31E2D30 Offset: 0x31DED30 VA: 0x31E2D30
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0x31E400C Offset: 0x31E000C VA: 0x31E400C
	internal bool CanRegisterName(string name) { }

	// RVA: 0x31E4070 Offset: 0x31E0070 VA: 0x31E4070
	public void Remove(DataColumn column) { }

	// RVA: 0x31E2EF0 Offset: 0x31DEEF0 VA: 0x31E2EF0
	internal void UnregisterName(string name) { }

	// RVA: 0x31E39C8 Offset: 0x31DF9C8 VA: 0x31E39C8
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0x31E2ACC Offset: 0x31DEACC VA: 0x31E2ACC
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }
}
