// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 14844
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x327D784 Offset: 0x3279784 VA: 0x327D784
	public void .ctor(DataColumn column) { }

	// RVA: 0x327D8BC Offset: 0x32798BC VA: 0x327D8BC Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x327E704 Offset: 0x327A704 VA: 0x327E704 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x327E7A4 Offset: 0x327A7A4 VA: 0x327E7A4 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x327E860 Offset: 0x327A860 VA: 0x327E860 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x327E8D8 Offset: 0x327A8D8 VA: 0x327E8D8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x327E914 Offset: 0x327A914 VA: 0x327E914 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x327E994 Offset: 0x327A994 VA: 0x327E994 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x327EA10 Offset: 0x327AA10 VA: 0x327EA10 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x327EA58 Offset: 0x327AA58 VA: 0x327EA58 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x327EB18 Offset: 0x327AB18 VA: 0x327EB18 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x327EE00 Offset: 0x327AE00 VA: 0x327EE00 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x327F0A0 Offset: 0x327B0A0 VA: 0x327F0A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x327F0E8 Offset: 0x327B0E8 VA: 0x327F0E8 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x327F1E8 Offset: 0x327B1E8 VA: 0x327F1E8 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
