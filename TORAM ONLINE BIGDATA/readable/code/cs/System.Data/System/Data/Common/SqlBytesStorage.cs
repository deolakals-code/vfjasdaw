// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 14845
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x327F284 Offset: 0x327B284 VA: 0x327F284
	public void .ctor(DataColumn column) { }

	// RVA: 0x327F364 Offset: 0x327B364 VA: 0x327F364 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x327F578 Offset: 0x327B578 VA: 0x327F578 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x327F580 Offset: 0x327B580 VA: 0x327F580 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x327F588 Offset: 0x327B588 VA: 0x327F588 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x327F5C8 Offset: 0x327B5C8 VA: 0x327F5C8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x327F5F8 Offset: 0x327B5F8 VA: 0x327F5F8 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x327F630 Offset: 0x327B630 VA: 0x327F630 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x327F728 Offset: 0x327B728 VA: 0x327F728 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x327F7E8 Offset: 0x327B7E8 VA: 0x327F7E8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x327FAF4 Offset: 0x327BAF4 VA: 0x327FAF4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x327FD94 Offset: 0x327BD94 VA: 0x327FD94 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x327FDDC Offset: 0x327BDDC VA: 0x327FDDC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x327FEE4 Offset: 0x327BEE4 VA: 0x327FEE4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
