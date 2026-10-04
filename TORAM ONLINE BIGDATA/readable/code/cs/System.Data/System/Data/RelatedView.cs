// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 14763
{
	// Fields
	private readonly Nullable<DataKey> _parentKey; // 0xB0
	private readonly DataKey _childKey; // 0xC0
	private readonly DataRowView _parentRowView; // 0xC8
	private readonly object[] _filterValues; // 0xD0

	// Methods

	// RVA: 0x320DBE0 Offset: 0x3209BE0 VA: 0x320DBE0
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0x320DD1C Offset: 0x3209D1C VA: 0x320DD1C
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0x320DE58 Offset: 0x3209E58 VA: 0x320DE58
	private object[] GetParentValues() { }

	// RVA: 0x320DEF0 Offset: 0x3209EF0 VA: 0x320DEF0 Slot: 33
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x320E078 Offset: 0x320A078 VA: 0x320E078 Slot: 27
	internal override IFilter GetFilter() { }

	// RVA: 0x320E07C Offset: 0x320A07C VA: 0x320E07C Slot: 26
	public override DataRowView AddNew() { }

	// RVA: 0x320E0DC Offset: 0x320A0DC VA: 0x320E0DC Slot: 30
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }
}
