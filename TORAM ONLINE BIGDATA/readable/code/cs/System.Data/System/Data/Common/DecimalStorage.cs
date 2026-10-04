// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 14836
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x326D328 Offset: 0x3269328 VA: 0x326D328
	internal void .ctor(DataColumn column) { }

	// RVA: 0x3271138 Offset: 0x326D138 VA: 0x3271138 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3271B54 Offset: 0x326DB54 VA: 0x3271B54 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3271CD0 Offset: 0x326DCD0 VA: 0x3271CD0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3271E3C Offset: 0x326DE3C VA: 0x3271E3C Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3271FB4 Offset: 0x326DFB4 VA: 0x3271FB4 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3272008 Offset: 0x326E008 VA: 0x3272008 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x32720CC Offset: 0x326E0CC VA: 0x32720CC Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3272274 Offset: 0x326E274 VA: 0x3272274 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3272344 Offset: 0x326E344 VA: 0x3272344 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x32723F8 Offset: 0x326E3F8 VA: 0x32723F8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3272494 Offset: 0x326E494 VA: 0x3272494 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x32724DC Offset: 0x326E4DC VA: 0x32724DC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x32725E0 Offset: 0x326E5E0 VA: 0x32725E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
