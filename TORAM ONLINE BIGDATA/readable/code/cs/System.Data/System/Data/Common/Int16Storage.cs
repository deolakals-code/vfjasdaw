// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class Int16Storage : DataStorage // TypeDefIndex: 14838
{
	// Fields
	private short[] _values; // 0x50

	// Methods

	// RVA: 0x326CF58 Offset: 0x3268F58 VA: 0x326CF58
	internal void .ctor(DataColumn column) { }

	// RVA: 0x3273724 Offset: 0x326F724 VA: 0x3273724 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3273F6C Offset: 0x326FF6C VA: 0x3273F6C Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3273FCC Offset: 0x326FFCC VA: 0x3273FCC Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x32740BC Offset: 0x32700BC VA: 0x32740BC Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x327420C Offset: 0x327020C VA: 0x327420C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3274260 Offset: 0x3270260 VA: 0x3274260 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x32742FC Offset: 0x32702FC VA: 0x32742FC Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3274480 Offset: 0x3270480 VA: 0x3274480 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3274550 Offset: 0x3270550 VA: 0x3274550 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x32745DC Offset: 0x32705DC VA: 0x32745DC Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3274674 Offset: 0x3270674 VA: 0x3274674 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x32746BC Offset: 0x32706BC VA: 0x32746BC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x32747B8 Offset: 0x32707B8 VA: 0x32747B8 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
