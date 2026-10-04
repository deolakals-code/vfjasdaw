// Assembly: System.Data.dll
// Namespace: 
[DefaultMember("Item")]
internal sealed class DataRelationCollection.DataTableRelationCollection : DataRelationCollection // TypeDefIndex: 14689
{
	// Fields
	private readonly DataTable _table; // 0x38
	private readonly ArrayList _relations; // 0x40
	private readonly bool _fParentCollection; // 0x48
	[CompilerGenerated]
	private CollectionChangeEventHandler RelationPropertyChanged; // 0x50

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0x31EA98C Offset: 0x31E698C VA: 0x31EA98C
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0x31EAA44 Offset: 0x31E6A44 VA: 0x31EAA44 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x31EAA4C Offset: 0x31E6A4C VA: 0x31EAA4C
	private void EnsureDataSet() { }

	// RVA: 0x31EAA90 Offset: 0x31E6A90 VA: 0x31EAA90 Slot: 18
	protected override DataSet GetDataSet() { }

	// RVA: 0x31EAAB4 Offset: 0x31E6AB4 VA: 0x31EAAB4 Slot: 13
	public override DataRelation get_Item(int index) { }

	// RVA: 0x31EABB4 Offset: 0x31E6BB4 VA: 0x31EABB4 Slot: 14
	public override DataRelation get_Item(string name) { }

	[CompilerGenerated]
	// RVA: 0x31EACA0 Offset: 0x31E6CA0 VA: 0x31EACA0
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x31EAD3C Offset: 0x31E6D3C VA: 0x31EAD3C
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x31EADD8 Offset: 0x31E6DD8 VA: 0x31EADD8
	private void AddCache(DataRelation relation) { }

	// RVA: 0x31EAE20 Offset: 0x31E6E20 VA: 0x31EAE20 Slot: 15
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0x31EAEE0 Offset: 0x31E6EE0 VA: 0x31EAEE0
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0x31EAFB4 Offset: 0x31E6FB4 VA: 0x31EAFB4 Slot: 21
	protected override void RemoveCore(DataRelation relation) { }
}
