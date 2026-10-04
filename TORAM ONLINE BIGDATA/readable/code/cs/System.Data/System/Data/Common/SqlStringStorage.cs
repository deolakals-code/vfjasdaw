// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 14856
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x328EE38 Offset: 0x328AE38 VA: 0x328EE38
	public void .ctor(DataColumn column) { }

	// RVA: 0x328EF78 Offset: 0x328AF78 VA: 0x328EF78 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x328F394 Offset: 0x328B394 VA: 0x328F394 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x328F404 Offset: 0x328B404 VA: 0x328F404
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x328F540 Offset: 0x328B540 VA: 0x328F540 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x328F604 Offset: 0x328B604 VA: 0x328F604 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x328F684 Offset: 0x328B684 VA: 0x328F684 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x328F6E4 Offset: 0x328B6E4 VA: 0x328F6E4 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x328F768 Offset: 0x328B768 VA: 0x328F768 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x328F834 Offset: 0x328B834 VA: 0x328F834 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x328F8B4 Offset: 0x328B8B4 VA: 0x328F8B4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x328F92C Offset: 0x328B92C VA: 0x328F92C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x328F9EC Offset: 0x328B9EC VA: 0x328F9EC Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x328FCD8 Offset: 0x328BCD8 VA: 0x328FCD8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x328FF78 Offset: 0x328BF78 VA: 0x328FF78 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x328FFC0 Offset: 0x328BFC0 VA: 0x328FFC0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x32900E4 Offset: 0x328C0E4 VA: 0x32900E4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
