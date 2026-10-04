// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SByteStorage : DataStorage // TypeDefIndex: 14841
{
	// Fields
	private sbyte[] _values; // 0x50

	// Methods

	// RVA: 0x326CE64 Offset: 0x3268E64 VA: 0x326CE64
	public void .ctor(DataColumn column) { }

	// RVA: 0x3276B04 Offset: 0x3272B04 VA: 0x3276B04 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32772F4 Offset: 0x32732F4 VA: 0x32772F4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x32773AC Offset: 0x32733AC VA: 0x32773AC Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x32774B0 Offset: 0x32734B0 VA: 0x32774B0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3277600 Offset: 0x3273600 VA: 0x3277600 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3277654 Offset: 0x3273654 VA: 0x3277654 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3277704 Offset: 0x3273704 VA: 0x3277704 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3277888 Offset: 0x3273888 VA: 0x3277888 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3277958 Offset: 0x3273958 VA: 0x3277958 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x32779E4 Offset: 0x32739E4 VA: 0x32779E4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3277A7C Offset: 0x3273A7C VA: 0x3277A7C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3277AC4 Offset: 0x3273AC4 VA: 0x3277AC4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3277BC4 Offset: 0x3273BC4 VA: 0x3277BC4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
