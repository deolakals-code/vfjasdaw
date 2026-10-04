// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 14843
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x327C870 Offset: 0x3278870 VA: 0x327C870
	public void .ctor(DataColumn column) { }

	// RVA: 0x327C9B0 Offset: 0x32789B0 VA: 0x327C9B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x327CBEC Offset: 0x3278BEC VA: 0x327CBEC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x327CC8C Offset: 0x3278C8C VA: 0x327CC8C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x327CD48 Offset: 0x3278D48 VA: 0x327CD48 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x327CDC0 Offset: 0x3278DC0 VA: 0x327CDC0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x327CE04 Offset: 0x3278E04 VA: 0x327CE04 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x327CE84 Offset: 0x3278E84 VA: 0x327CE84 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x327CF00 Offset: 0x3278F00 VA: 0x327CF00 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x327CF50 Offset: 0x3278F50 VA: 0x327CF50 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x327D010 Offset: 0x3279010 VA: 0x327D010 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x327D2F8 Offset: 0x32792F8 VA: 0x327D2F8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x327D598 Offset: 0x3279598 VA: 0x327D598 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x327D5E0 Offset: 0x32795E0 VA: 0x327D5E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x327D6E8 Offset: 0x32796E8 VA: 0x327D6E8 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
