// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 14851
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x328663C Offset: 0x328263C VA: 0x328663C
	public void .ctor(DataColumn column) { }

	// RVA: 0x3286774 Offset: 0x3282774 VA: 0x3286774 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32875CC Offset: 0x32835CC VA: 0x32875CC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x328766C Offset: 0x328366C VA: 0x328766C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3287728 Offset: 0x3283728 VA: 0x3287728 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x32877A0 Offset: 0x32837A0 VA: 0x32877A0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x32877DC Offset: 0x32837DC VA: 0x32877DC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x328785C Offset: 0x328385C VA: 0x328785C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x32878D8 Offset: 0x32838D8 VA: 0x32878D8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3287920 Offset: 0x3283920 VA: 0x3287920 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x32879E0 Offset: 0x32839E0 VA: 0x32879E0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3287CC8 Offset: 0x3283CC8 VA: 0x3287CC8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3287F68 Offset: 0x3283F68 VA: 0x3287F68 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3287FB0 Offset: 0x3283FB0 VA: 0x3287FB0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x32880B0 Offset: 0x32840B0 VA: 0x32880B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
