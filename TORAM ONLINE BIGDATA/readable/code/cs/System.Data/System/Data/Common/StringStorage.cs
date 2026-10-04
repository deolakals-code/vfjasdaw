// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class StringStorage : DataStorage // TypeDefIndex: 14861
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x3293CB8 Offset: 0x328FCB8 VA: 0x3293CB8
	public void .ctor(DataColumn column) { }

	// RVA: 0x3293D9C Offset: 0x328FD9C VA: 0x3293D9C Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x329408C Offset: 0x329008C VA: 0x329408C Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3294104 Offset: 0x3290104 VA: 0x3294104 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x32941D8 Offset: 0x32901D8 VA: 0x32941D8 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3294208 Offset: 0x3290208 VA: 0x3294208 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3294248 Offset: 0x3290248 VA: 0x3294248 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x3294284 Offset: 0x3290284 VA: 0x3294284 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x32942C4 Offset: 0x32902C4 VA: 0x32942C4 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x32942FC Offset: 0x32902FC VA: 0x32942FC Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x329437C Offset: 0x329037C VA: 0x329437C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x329443C Offset: 0x329043C VA: 0x329443C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3294444 Offset: 0x3290444 VA: 0x3294444 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x32944A4 Offset: 0x32904A4 VA: 0x32944A4 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x32944EC Offset: 0x32904EC VA: 0x32944EC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x32945F4 Offset: 0x32905F4 VA: 0x32945F4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
