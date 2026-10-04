// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class ByteStorage : DataStorage // TypeDefIndex: 14830
{
	// Fields
	private byte[] _values; // 0x50

	// Methods

	// RVA: 0x326A474 Offset: 0x3266474 VA: 0x326A474
	internal void .ctor(DataColumn column) { }

	// RVA: 0x326A568 Offset: 0x3266568 VA: 0x326A568 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x326AD30 Offset: 0x3266D30 VA: 0x326AD30 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x326ADA0 Offset: 0x3266DA0 VA: 0x326ADA0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x326AEA4 Offset: 0x3266EA4 VA: 0x326AEA4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x326AFF4 Offset: 0x3266FF4 VA: 0x326AFF4 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x326B048 Offset: 0x3267048 VA: 0x326B048 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x326B0E4 Offset: 0x32670E4 VA: 0x326B0E4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x326B268 Offset: 0x3267268 VA: 0x326B268 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x326B338 Offset: 0x3267338 VA: 0x326B338 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x326B3C4 Offset: 0x32673C4 VA: 0x326B3C4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x326B45C Offset: 0x326745C VA: 0x326B45C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x326B4A4 Offset: 0x32674A4 VA: 0x326B4A4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x326B5A4 Offset: 0x32675A4 VA: 0x326B5A4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
