// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultMember("Item")]
public class DataViewSettingCollection // TypeDefIndex: 14719
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Properties
	public virtual DataViewSetting Item { get; set; }

	// Methods

	// RVA: 0x31F6538 Offset: 0x31F2538 VA: 0x31F6538 Slot: 4
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0x31F6630 Offset: 0x31F2630 VA: 0x31F6630 Slot: 5
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0x31F66E0 Offset: 0x31F26E0 VA: 0x31F66E0
	internal void Remove(DataTable table) { }
}
