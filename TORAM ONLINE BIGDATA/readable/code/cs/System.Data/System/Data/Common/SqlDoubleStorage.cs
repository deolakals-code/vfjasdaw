// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 14849
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x3283D38 Offset: 0x327FD38 VA: 0x3283D38
	public void .ctor(DataColumn column) { }

	// RVA: 0x3283E78 Offset: 0x327FE78 VA: 0x3283E78 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3284B90 Offset: 0x3280B90 VA: 0x3284B90 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3284C38 Offset: 0x3280C38 VA: 0x3284C38 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3284CF4 Offset: 0x3280CF4 VA: 0x3284CF4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3284D6C Offset: 0x3280D6C VA: 0x3284D6C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3284DA8 Offset: 0x3280DA8 VA: 0x3284DA8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3284E2C Offset: 0x3280E2C VA: 0x3284E2C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x3284EA8 Offset: 0x3280EA8 VA: 0x3284EA8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3284EF4 Offset: 0x3280EF4 VA: 0x3284EF4 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3284FB4 Offset: 0x3280FB4 VA: 0x3284FB4 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x328529C Offset: 0x328129C VA: 0x328529C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x328553C Offset: 0x328153C VA: 0x328553C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3285584 Offset: 0x3281584 VA: 0x3285584 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x328568C Offset: 0x328168C VA: 0x328568C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
