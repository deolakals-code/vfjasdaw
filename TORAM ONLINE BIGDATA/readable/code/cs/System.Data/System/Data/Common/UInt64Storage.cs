// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 14865
{
	// Fields
	private static readonly ulong s_defaultValue; // 0x0
	private ulong[] _values; // 0x50

	// Methods

	// RVA: 0x329871C Offset: 0x329471C VA: 0x329871C
	public void .ctor(DataColumn column) { }

	// RVA: 0x3298834 Offset: 0x3294834 VA: 0x3298834 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3299080 Offset: 0x3295080 VA: 0x3299080 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3299188 Offset: 0x3295188 VA: 0x3299188 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x32992A4 Offset: 0x32952A4 VA: 0x32992A4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x32993EC Offset: 0x32953EC VA: 0x32993EC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3299444 Offset: 0x3295444 VA: 0x3299444 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3299514 Offset: 0x3295514 VA: 0x3299514 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x32996AC Offset: 0x32956AC VA: 0x32996AC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3299780 Offset: 0x3295780 VA: 0x3299780 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x329980C Offset: 0x329580C VA: 0x329980C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x32998A4 Offset: 0x32958A4 VA: 0x32998A4 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x32998EC Offset: 0x32958EC VA: 0x32998EC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x32999EC Offset: 0x32959EC VA: 0x32999EC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
