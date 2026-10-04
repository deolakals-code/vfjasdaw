// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 14834
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0x326D58C Offset: 0x326958C VA: 0x326D58C
	internal void .ctor(DataColumn column) { }

	// RVA: 0x326ED54 Offset: 0x326AD54 VA: 0x326ED54 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x326F23C Offset: 0x326B23C VA: 0x326F23C Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x326F3E0 Offset: 0x326B3E0 VA: 0x326F3E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x326F560 Offset: 0x326B560 VA: 0x326F560 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x326F604 Offset: 0x326B604 VA: 0x326F604 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x326F658 Offset: 0x326B658 VA: 0x326F658 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x326F764 Offset: 0x326B764 VA: 0x326F764 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x326F884 Offset: 0x326B884 VA: 0x326F884 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x326F954 Offset: 0x326B954 VA: 0x326F954 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x326F9E0 Offset: 0x326B9E0 VA: 0x326F9E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x326FA7C Offset: 0x326BA7C VA: 0x326FA7C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x326FAC4 Offset: 0x326BAC4 VA: 0x326FAC4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x326FBC8 Offset: 0x326BBC8 VA: 0x326FBC8 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x326FC8C Offset: 0x326BC8C VA: 0x326FC8C
	private static void .cctor() { }
}
