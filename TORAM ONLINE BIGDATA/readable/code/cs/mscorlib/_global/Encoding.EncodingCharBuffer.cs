// Assembly: mscorlib.dll
// Namespace: 
internal class Encoding.EncodingCharBuffer // TypeDefIndex: 10059
{
	// Fields
	private char* chars; // 0x10
	private char* charStart; // 0x18
	private char* charEnd; // 0x20
	private int charCountResult; // 0x28
	private Encoding enc; // 0x30
	private DecoderNLS decoder; // 0x38
	private byte* byteStart; // 0x40
	private byte* byteEnd; // 0x48
	private byte* bytes; // 0x50
	private DecoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int BytesUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x2E9FA60 Offset: 0x2E9BA60 VA: 0x2E9FA60
	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	// RVA: 0x2E9FB40 Offset: 0x2E9BB40 VA: 0x2E9FB40
	internal bool AddChar(char ch, int numBytes) { }

	// RVA: 0x2E9FBB0 Offset: 0x2E9BBB0 VA: 0x2E9FBB0
	internal bool AddChar(char ch) { }

	// RVA: 0x2E9FBB8 Offset: 0x2E9BBB8 VA: 0x2E9FBB8
	internal void AdjustBytes(int count) { }

	// RVA: 0x2E9FBC8 Offset: 0x2E9BBC8 VA: 0x2E9FBC8
	internal bool get_MoreData() { }

	// RVA: 0x2E9FBD8 Offset: 0x2E9BBD8 VA: 0x2E9FBD8
	internal byte GetNextByte() { }

	// RVA: 0x2E9FBFC Offset: 0x2E9BBFC VA: 0x2E9FBFC
	internal int get_BytesUsed() { }

	// RVA: 0x2E9FC0C Offset: 0x2E9BC0C VA: 0x2E9FC0C
	internal bool Fallback(byte fallbackByte) { }

	// RVA: 0x2E9FC84 Offset: 0x2E9BC84 VA: 0x2E9FC84
	internal bool Fallback(byte[] byteBuffer) { }

	// RVA: 0x2E9FD60 Offset: 0x2E9BD60 VA: 0x2E9FD60
	internal int get_Count() { }
}
