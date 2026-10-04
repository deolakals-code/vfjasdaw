// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 14848
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x3281FE8 Offset: 0x327DFE8 VA: 0x3281FE8
	public void .ctor(DataColumn column) { }

	// RVA: 0x3282138 Offset: 0x327E138 VA: 0x3282138 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32830A0 Offset: 0x327F0A0 VA: 0x32830A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3283170 Offset: 0x327F170 VA: 0x3283170 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x328324C Offset: 0x327F24C VA: 0x328324C Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x32832D8 Offset: 0x327F2D8 VA: 0x32832D8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3283340 Offset: 0x327F340 VA: 0x3283340 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x32833CC Offset: 0x327F3CC VA: 0x32833CC Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x328344C Offset: 0x327F44C VA: 0x328344C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x32834D0 Offset: 0x327F4D0 VA: 0x32834D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3283590 Offset: 0x327F590 VA: 0x3283590 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3283884 Offset: 0x327F884 VA: 0x3283884 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3283B24 Offset: 0x327FB24 VA: 0x3283B24 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3283B6C Offset: 0x327FB6C VA: 0x3283B6C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3283C9C Offset: 0x327FC9C VA: 0x3283C9C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
