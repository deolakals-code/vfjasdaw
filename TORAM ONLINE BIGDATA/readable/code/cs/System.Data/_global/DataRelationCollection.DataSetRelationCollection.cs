// Assembly: System.Data.dll
// Namespace: 
[DefaultMember("Item")]
internal sealed class DataRelationCollection.DataSetRelationCollection : DataRelationCollection // TypeDefIndex: 14690
{
	// Fields
	private readonly DataSet _dataSet; // 0x38
	private readonly ArrayList _relations; // 0x40
	private DataRelation[] _delayLoadingRelations; // 0x48

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0x31EB074 Offset: 0x31E7074 VA: 0x31EB074
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x31EB118 Offset: 0x31E7118 VA: 0x31EB118 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x31EB120 Offset: 0x31E7120 VA: 0x31EB120 Slot: 16
	public override void Clear() { }

	// RVA: 0x31EB164 Offset: 0x31E7164 VA: 0x31EB164 Slot: 18
	protected override DataSet GetDataSet() { }

	// RVA: 0x31EB16C Offset: 0x31E716C VA: 0x31EB16C Slot: 13
	public override DataRelation get_Item(int index) { }

	// RVA: 0x31EB26C Offset: 0x31E726C VA: 0x31EB26C Slot: 14
	public override DataRelation get_Item(string name) { }

	// RVA: 0x31EB358 Offset: 0x31E7358 VA: 0x31EB358 Slot: 15
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0x31EB8BC Offset: 0x31E78BC VA: 0x31EB8BC Slot: 21
	protected override void RemoveCore(DataRelation relation) { }
}
