// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 14850
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x3285728 Offset: 0x3281728 VA: 0x3285728
	public void .ctor(DataColumn column) { }

	// RVA: 0x3285868 Offset: 0x3281868 VA: 0x3285868 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3285AA4 Offset: 0x3281AA4 VA: 0x3285AA4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3285B44 Offset: 0x3281B44 VA: 0x3285B44 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3285C00 Offset: 0x3281C00 VA: 0x3285C00 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3285C78 Offset: 0x3281C78 VA: 0x3285C78 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3285CBC Offset: 0x3281CBC VA: 0x3285CBC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3285D3C Offset: 0x3281D3C VA: 0x3285D3C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x3285DB8 Offset: 0x3281DB8 VA: 0x3285DB8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3285E08 Offset: 0x3281E08 VA: 0x3285E08 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3285EC8 Offset: 0x3281EC8 VA: 0x3285EC8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x32861B0 Offset: 0x32821B0 VA: 0x32861B0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3286450 Offset: 0x3282450 VA: 0x3286450 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3286498 Offset: 0x3282498 VA: 0x3286498 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x32865A0 Offset: 0x32825A0 VA: 0x32865A0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
