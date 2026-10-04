// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 14837
{
	// Fields
	private double[] _values; // 0x50

	// Methods

	// RVA: 0x326D234 Offset: 0x3269234 VA: 0x326D234
	internal void .ctor(DataColumn column) { }

	// RVA: 0x32726A4 Offset: 0x326E6A4 VA: 0x32726A4 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3272DDC Offset: 0x326EDDC VA: 0x3272DDC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3272E5C Offset: 0x326EE5C VA: 0x3272E5C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3272F64 Offset: 0x326EF64 VA: 0x3272F64 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x32730B0 Offset: 0x326F0B0 VA: 0x32730B0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3273104 Offset: 0x326F104 VA: 0x3273104 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x32731A4 Offset: 0x326F1A4 VA: 0x32731A4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3273328 Offset: 0x326F328 VA: 0x3273328 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x32733F8 Offset: 0x326F3F8 VA: 0x32733F8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3273480 Offset: 0x326F480 VA: 0x3273480 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3273518 Offset: 0x326F518 VA: 0x3273518 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3273560 Offset: 0x326F560 VA: 0x3273560 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3273660 Offset: 0x326F660 VA: 0x3273660 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
