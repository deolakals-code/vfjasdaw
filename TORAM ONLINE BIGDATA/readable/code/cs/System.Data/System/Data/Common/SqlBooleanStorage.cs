// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 14857
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x3290180 Offset: 0x328C180 VA: 0x3290180
	public void .ctor(DataColumn column) { }

	// RVA: 0x32902C0 Offset: 0x328C2C0 VA: 0x32902C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3290744 Offset: 0x328C744 VA: 0x3290744 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x32907E4 Offset: 0x328C7E4 VA: 0x32907E4 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x32908A0 Offset: 0x328C8A0 VA: 0x32908A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3290918 Offset: 0x328C918 VA: 0x3290918 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3290954 Offset: 0x328C954 VA: 0x3290954 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x32909D4 Offset: 0x328C9D4 VA: 0x32909D4 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x3290A50 Offset: 0x328CA50 VA: 0x3290A50 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3290A98 Offset: 0x328CA98 VA: 0x3290A98 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3290B58 Offset: 0x328CB58 VA: 0x3290B58 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3290E40 Offset: 0x328CE40 VA: 0x3290E40 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x32910E0 Offset: 0x328D0E0 VA: 0x32910E0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3291128 Offset: 0x328D128 VA: 0x3291128 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3291228 Offset: 0x328D228 VA: 0x3291228 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
