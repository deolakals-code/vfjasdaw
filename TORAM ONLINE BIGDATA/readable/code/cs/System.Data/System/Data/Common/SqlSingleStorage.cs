// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 14855
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x328D384 Offset: 0x3289384 VA: 0x328D384
	public void .ctor(DataColumn column) { }

	// RVA: 0x328D4C4 Offset: 0x32894C4 VA: 0x328D4C4 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x328E2B8 Offset: 0x328A2B8 VA: 0x328E2B8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x328E358 Offset: 0x328A358 VA: 0x328E358 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x328E414 Offset: 0x328A414 VA: 0x328E414 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x328E48C Offset: 0x328A48C VA: 0x328E48C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x328E4C8 Offset: 0x328A4C8 VA: 0x328E4C8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x328E548 Offset: 0x328A548 VA: 0x328E548 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x328E5C4 Offset: 0x328A5C4 VA: 0x328E5C4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x328E60C Offset: 0x328A60C VA: 0x328E60C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x328E6CC Offset: 0x328A6CC VA: 0x328E6CC Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x328E9B4 Offset: 0x328A9B4 VA: 0x328E9B4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x328EC54 Offset: 0x328AC54 VA: 0x328EC54 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x328EC9C Offset: 0x328AC9C VA: 0x328EC9C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x328ED9C Offset: 0x328AD9C VA: 0x328ED9C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
