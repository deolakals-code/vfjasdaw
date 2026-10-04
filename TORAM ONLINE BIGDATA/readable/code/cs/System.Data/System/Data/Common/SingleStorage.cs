// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SingleStorage : DataStorage // TypeDefIndex: 14858
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x32912C4 Offset: 0x328D2C4 VA: 0x32912C4
	public void .ctor(DataColumn column) { }

	// RVA: 0x32913BC Offset: 0x328D3BC VA: 0x32913BC Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3291B14 Offset: 0x328DB14 VA: 0x3291B14 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3291B98 Offset: 0x328DB98 VA: 0x3291B98 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3291CA0 Offset: 0x328DCA0 VA: 0x3291CA0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3291DE4 Offset: 0x328DDE4 VA: 0x3291DE4 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3291E3C Offset: 0x328DE3C VA: 0x3291E3C Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3291EE0 Offset: 0x328DEE0 VA: 0x3291EE0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3292058 Offset: 0x328E058 VA: 0x3292058 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x329212C Offset: 0x328E12C VA: 0x329212C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x32921B4 Offset: 0x328E1B4 VA: 0x32921B4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x329224C Offset: 0x328E24C VA: 0x329224C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3292294 Offset: 0x328E294 VA: 0x3292294 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3292394 Offset: 0x328E394 VA: 0x3292394 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
