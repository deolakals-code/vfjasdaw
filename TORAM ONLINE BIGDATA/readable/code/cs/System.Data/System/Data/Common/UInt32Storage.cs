// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 14864
{
	// Fields
	private static readonly uint s_defaultValue; // 0x0
	private uint[] _values; // 0x50

	// Methods

	// RVA: 0x32973B0 Offset: 0x32933B0 VA: 0x32973B0
	public void .ctor(DataColumn column) { }

	// RVA: 0x32974C8 Offset: 0x32934C8 VA: 0x32974C8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3297D28 Offset: 0x3293D28 VA: 0x3297D28 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3297DF4 Offset: 0x3293DF4 VA: 0x3297DF4 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3297F10 Offset: 0x3293F10 VA: 0x3297F10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3298058 Offset: 0x3294058 VA: 0x3298058 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x32980B0 Offset: 0x32940B0 VA: 0x32980B0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3298180 Offset: 0x3294180 VA: 0x3298180 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3298318 Offset: 0x3294318 VA: 0x3298318 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x32983EC Offset: 0x32943EC VA: 0x32983EC Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3298478 Offset: 0x3294478 VA: 0x3298478 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3298510 Offset: 0x3294510 VA: 0x3298510 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3298558 Offset: 0x3294558 VA: 0x3298558 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3298658 Offset: 0x3294658 VA: 0x3298658 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
