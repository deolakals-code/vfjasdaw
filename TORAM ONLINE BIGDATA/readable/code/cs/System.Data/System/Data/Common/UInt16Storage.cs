// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class UInt16Storage : DataStorage // TypeDefIndex: 14863
{
	// Fields
	private static readonly ushort s_defaultValue; // 0x0
	private ushort[] _values; // 0x50

	// Methods

	// RVA: 0x3296058 Offset: 0x3292058 VA: 0x3296058
	public void .ctor(DataColumn column) { }

	// RVA: 0x3296170 Offset: 0x3292170 VA: 0x3296170 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32969CC Offset: 0x32929CC VA: 0x32969CC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3296A88 Offset: 0x3292A88 VA: 0x3296A88 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3296BA4 Offset: 0x3292BA4 VA: 0x3296BA4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3296CEC Offset: 0x3292CEC VA: 0x3296CEC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3296D44 Offset: 0x3292D44 VA: 0x3296D44 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3296E14 Offset: 0x3292E14 VA: 0x3296E14 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3296FAC Offset: 0x3292FAC VA: 0x3296FAC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3297080 Offset: 0x3293080 VA: 0x3297080 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x329710C Offset: 0x329310C VA: 0x329710C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x32971A4 Offset: 0x32931A4 VA: 0x32971A4 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x32971EC Offset: 0x32931EC VA: 0x32971EC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x32972EC Offset: 0x32932EC VA: 0x32972EC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
