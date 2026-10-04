// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 14846
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x327FF80 Offset: 0x327BF80 VA: 0x327FF80
	public void .ctor(DataColumn column) { }

	// RVA: 0x3280060 Offset: 0x327C060 VA: 0x3280060 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3280274 Offset: 0x327C274 VA: 0x3280274 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x328027C Offset: 0x327C27C VA: 0x328027C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3280284 Offset: 0x327C284 VA: 0x3280284 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x32802C4 Offset: 0x327C2C4 VA: 0x32802C4 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x32802F4 Offset: 0x327C2F4 VA: 0x32802F4 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x328032C Offset: 0x327C32C VA: 0x328032C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3280424 Offset: 0x327C424 VA: 0x3280424 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x32804E4 Offset: 0x327C4E4 VA: 0x32804E4 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x32807FC Offset: 0x327C7FC VA: 0x32807FC Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3280A9C Offset: 0x327CA9C VA: 0x3280A9C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3280AE4 Offset: 0x327CAE4 VA: 0x3280AE4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3280BEC Offset: 0x327CBEC VA: 0x3280BEC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
