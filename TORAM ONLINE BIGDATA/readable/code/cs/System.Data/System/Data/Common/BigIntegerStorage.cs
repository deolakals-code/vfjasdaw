// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 14828
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x3267920 Offset: 0x3263920 VA: 0x3267920
	internal void .ctor(DataColumn column) { }

	// RVA: 0x3267AF4 Offset: 0x3263AF4 VA: 0x3267AF4 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3267B24 Offset: 0x3263B24 VA: 0x3267B24 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3267CAC Offset: 0x3263CAC VA: 0x3267CAC Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3267DFC Offset: 0x3263DFC VA: 0x3267DFC
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x32685D0 Offset: 0x32645D0 VA: 0x32685D0
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x3268D64 Offset: 0x3264D64 VA: 0x3268D64 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3268E04 Offset: 0x3264E04 VA: 0x3268E04 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3268EA4 Offset: 0x3264EA4 VA: 0x3268EA4 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3268F98 Offset: 0x3264F98 VA: 0x3268F98 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3269108 Offset: 0x3265108 VA: 0x3269108 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x326925C Offset: 0x326525C VA: 0x326925C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x326930C Offset: 0x326530C VA: 0x326930C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x32693FC Offset: 0x32653FC VA: 0x32693FC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3269444 Offset: 0x3265444 VA: 0x3269444 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3269558 Offset: 0x3265558 VA: 0x3269558 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
