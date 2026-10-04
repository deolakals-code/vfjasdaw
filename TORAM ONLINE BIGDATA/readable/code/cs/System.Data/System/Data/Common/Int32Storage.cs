// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class Int32Storage : DataStorage // TypeDefIndex: 14839
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x326D04C Offset: 0x326904C VA: 0x326D04C
	internal void .ctor(DataColumn column) { }

	// RVA: 0x327487C Offset: 0x327087C VA: 0x327487C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32750BC Offset: 0x32710BC VA: 0x32750BC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3275128 Offset: 0x3271128 VA: 0x3275128 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3275218 Offset: 0x3271218 VA: 0x3275218 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3275368 Offset: 0x3271368 VA: 0x3275368 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x32753BC Offset: 0x32713BC VA: 0x32753BC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3275458 Offset: 0x3271458 VA: 0x3275458 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x32755DC Offset: 0x32715DC VA: 0x32755DC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x32756AC Offset: 0x32716AC VA: 0x32756AC Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3275738 Offset: 0x3271738 VA: 0x3275738 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x32757D0 Offset: 0x32717D0 VA: 0x32757D0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3275818 Offset: 0x3271818 VA: 0x3275818 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3275914 Offset: 0x3271914 VA: 0x3275914 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
