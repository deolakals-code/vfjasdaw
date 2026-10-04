// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 14847
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x3280C88 Offset: 0x327CC88 VA: 0x3280C88
	public void .ctor(DataColumn column) { }

	// RVA: 0x3280DD8 Offset: 0x327CDD8 VA: 0x3280DD8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32813E8 Offset: 0x327D3E8 VA: 0x32813E8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x328149C Offset: 0x327D49C VA: 0x328149C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3281560 Offset: 0x327D560 VA: 0x3281560 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x32815DC Offset: 0x327D5DC VA: 0x32815DC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3281634 Offset: 0x327D634 VA: 0x3281634 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x32816C4 Offset: 0x327D6C4 VA: 0x32816C4 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x3281744 Offset: 0x327D744 VA: 0x3281744 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3281798 Offset: 0x327D798 VA: 0x3281798 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3281858 Offset: 0x327D858 VA: 0x3281858 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3281B4C Offset: 0x327DB4C VA: 0x3281B4C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3281DEC Offset: 0x327DDEC VA: 0x3281DEC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3281E34 Offset: 0x327DE34 VA: 0x3281E34 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3281F4C Offset: 0x327DF4C VA: 0x3281F4C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
