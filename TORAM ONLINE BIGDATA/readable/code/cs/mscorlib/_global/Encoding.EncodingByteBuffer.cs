// Assembly: mscorlib.dll
// Namespace: 
internal class Encoding.EncodingByteBuffer // TypeDefIndex: 10060
{
	// Fields
	private byte* bytes; // 0x10
	private byte* byteStart; // 0x18
	private byte* byteEnd; // 0x20
	private char* chars; // 0x28
	private char* charStart; // 0x30
	private char* charEnd; // 0x38
	private int byteCountResult; // 0x40
	private Encoding enc; // 0x48
	private EncoderNLS encoder; // 0x50
	internal EncoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int CharsUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x2E9FD68 Offset: 0x2E9BD68 VA: 0x2E9FD68
	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	// RVA: 0x2E9FFAC Offset: 0x2E9BFAC VA: 0x2E9FFAC
	internal bool AddByte(byte b, int moreBytesExpected) { }

	// RVA: 0x2EA0078 Offset: 0x2E9C078 VA: 0x2EA0078
	internal bool AddByte(byte b1) { }

	// RVA: 0x2EA0080 Offset: 0x2E9C080 VA: 0x2EA0080
	internal bool AddByte(byte b1, byte b2) { }

	// RVA: 0x2EA0088 Offset: 0x2E9C088 VA: 0x2EA0088
	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	// RVA: 0x2E9FFFC Offset: 0x2E9BFFC VA: 0x2E9FFFC
	internal void MovePrevious(bool bThrow) { }

	// RVA: 0x2EA00D0 Offset: 0x2E9C0D0 VA: 0x2EA00D0
	internal bool get_MoreData() { }

	// RVA: 0x2EA0118 Offset: 0x2E9C118 VA: 0x2EA0118
	internal char GetNextChar() { }

	// RVA: 0x2EA0168 Offset: 0x2E9C168 VA: 0x2EA0168
	internal int get_CharsUsed() { }

	// RVA: 0x2EA0180 Offset: 0x2E9C180 VA: 0x2EA0180
	internal int get_Count() { }
}
