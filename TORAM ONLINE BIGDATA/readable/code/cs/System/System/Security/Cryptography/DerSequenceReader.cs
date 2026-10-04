// Assembly: System.dll
// Namespace: System.Security.Cryptography
internal class DerSequenceReader // TypeDefIndex: 14112
{
	// Fields
	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; // 0x0
	private static Encoding s_utf8EncodingWithExceptionFallback; // 0x8
	private static Encoding s_latin1Encoding; // 0x10
	private readonly byte[] _data; // 0x10
	private readonly int _end; // 0x18
	private int _position; // 0x1C
	[CompilerGenerated]
	private int <ContentLength>k__BackingField; // 0x20

	// Properties
	private int ContentLength { set; }
	internal bool HasData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3489A9C Offset: 0x3485A9C VA: 0x3489A9C
	private void set_ContentLength(int value) { }

	// RVA: 0x3489AA4 Offset: 0x3485AA4 VA: 0x3489AA4
	internal void .ctor(byte[] data) { }

	// RVA: 0x3489AC8 Offset: 0x3485AC8 VA: 0x3489AC8
	internal void .ctor(byte[] data, int offset, int length) { }

	// RVA: 0x3489ADC Offset: 0x3485ADC VA: 0x3489ADC
	private void .ctor(DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length) { }

	// RVA: 0x3489C98 Offset: 0x3485C98 VA: 0x3489C98
	internal bool get_HasData() { }

	// RVA: 0x3489CA8 Offset: 0x3485CA8 VA: 0x3489CA8
	internal byte PeekTag() { }

	// RVA: 0x3489D3C Offset: 0x3485D3C VA: 0x3489D3C
	internal void SkipValue() { }

	// RVA: 0x3489D8C Offset: 0x3485D8C VA: 0x3489D8C
	internal byte[] ReadNextEncodedValue() { }

	// RVA: 0x3489F68 Offset: 0x3485F68 VA: 0x3489F68
	internal bool ReadBoolean() { }

	// RVA: 0x348A030 Offset: 0x3486030 VA: 0x348A030
	internal int ReadInteger() { }

	// RVA: 0x348A0E4 Offset: 0x34860E4 VA: 0x348A0E4
	internal byte[] ReadIntegerBytes() { }

	// RVA: 0x348A1B4 Offset: 0x34861B4 VA: 0x348A1B4
	internal byte[] ReadBitString() { }

	// RVA: 0x348A2F8 Offset: 0x34862F8 VA: 0x348A2F8
	internal byte[] ReadOctetString() { }

	// RVA: 0x348A314 Offset: 0x3486314 VA: 0x348A314
	internal string ReadOidAsString() { }

	// RVA: 0x348A5DC Offset: 0x34865DC VA: 0x348A5DC
	internal string ReadUtf8String() { }

	// RVA: 0x348A6D8 Offset: 0x34866D8 VA: 0x348A6D8
	private DerSequenceReader ReadCollectionWithTag(DerSequenceReader.DerTag expected) { }

	// RVA: 0x348A830 Offset: 0x3486830 VA: 0x348A830
	internal DerSequenceReader ReadSequence() { }

	// RVA: 0x348A838 Offset: 0x3486838 VA: 0x348A838
	internal DerSequenceReader ReadSet() { }

	// RVA: 0x348A840 Offset: 0x3486840 VA: 0x348A840
	internal string ReadPrintableString() { }

	// RVA: 0x348A8C0 Offset: 0x34868C0 VA: 0x348A8C0
	internal string ReadIA5String() { }

	// RVA: 0x348A940 Offset: 0x3486940 VA: 0x348A940
	internal string ReadT61String() { }

	// RVA: 0x348AC28 Offset: 0x3486C28 VA: 0x348AC28
	internal DateTime ReadX509Date() { }

	// RVA: 0x348ACA8 Offset: 0x3486CA8 VA: 0x348ACA8
	internal DateTime ReadUtcTime() { }

	// RVA: 0x348ACF4 Offset: 0x3486CF4 VA: 0x348ACF4
	internal DateTime ReadGeneralizedTime() { }

	// RVA: 0x348AF88 Offset: 0x3486F88 VA: 0x348AF88
	internal string ReadBMPString() { }

	// RVA: 0x348A65C Offset: 0x348665C VA: 0x348A65C
	private static string TrimTrailingNulls(string value) { }

	// RVA: 0x348AD40 Offset: 0x3486D40 VA: 0x348AD40
	private DateTime ReadTime(DerSequenceReader.DerTag timeTag, string formatString) { }

	// RVA: 0x348A100 Offset: 0x3486100 VA: 0x348A100
	private byte[] ReadContentAsBytes() { }

	// RVA: 0x3489BDC Offset: 0x3485BDC VA: 0x3489BDC
	private void EatTag(DerSequenceReader.DerTag expected) { }

	// RVA: 0x348A79C Offset: 0x348679C VA: 0x348A79C
	private static void CheckTag(DerSequenceReader.DerTag expected, byte[] data, int position) { }

	// RVA: 0x3489C5C Offset: 0x3485C5C VA: 0x3489C5C
	private int EatLength() { }

	// RVA: 0x3489E44 Offset: 0x3485E44 VA: 0x3489E44
	private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed) { }
}
