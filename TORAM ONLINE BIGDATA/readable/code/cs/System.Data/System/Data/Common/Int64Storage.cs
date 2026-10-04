// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class Int64Storage : DataStorage // TypeDefIndex: 14840
{
	// Fields
	private long[] _values; // 0x50

	// Methods

	// RVA: 0x326D140 Offset: 0x3269140 VA: 0x326D140
	internal void .ctor(DataColumn column) { }

	// RVA: 0x32759D8 Offset: 0x32719D8 VA: 0x32759D8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32761E8 Offset: 0x32721E8 VA: 0x32761E8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3276254 Offset: 0x3272254 VA: 0x3276254 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3276344 Offset: 0x3272344 VA: 0x3276344 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3276494 Offset: 0x3272494 VA: 0x3276494 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x32764E8 Offset: 0x32724E8 VA: 0x32764E8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3276584 Offset: 0x3272584 VA: 0x3276584 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3276708 Offset: 0x3272708 VA: 0x3276708 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x32767D8 Offset: 0x32727D8 VA: 0x32767D8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3276864 Offset: 0x3272864 VA: 0x3276864 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x32768FC Offset: 0x32728FC VA: 0x32768FC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3276944 Offset: 0x3272944 VA: 0x3276944 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3276A40 Offset: 0x3272A40 VA: 0x3276A40 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
