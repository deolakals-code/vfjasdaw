// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal struct StringBuffer // TypeDefIndex: 15958
{
	// Fields
	private char[] _buffer; // 0x0
	private int _position; // 0x8

	// Properties
	public int Position { get; set; }
	public bool IsEmpty { get; }
	public char[] InternalBuffer { get; }

	// Methods

	// RVA: 0x30998E0 Offset: 0x30958E0 VA: 0x30998E0
	public int get_Position() { }

	// RVA: 0x30998E8 Offset: 0x30958E8 VA: 0x30998E8
	public void set_Position(int value) { }

	// RVA: 0x30998F0 Offset: 0x30958F0 VA: 0x30998F0
	public bool get_IsEmpty() { }

	// RVA: 0x3099900 Offset: 0x3095900 VA: 0x3099900
	public void .ctor(IArrayPool<char> bufferPool, int initalSize) { }

	[NullableContext(1)]
	// RVA: 0x3099930 Offset: 0x3095930 VA: 0x3099930
	private void .ctor(char[] buffer) { }

	// RVA: 0x309994C Offset: 0x309594C VA: 0x309994C
	public void Append(IArrayPool<char> bufferPool, char value) { }

	[NullableContext(1)]
	// RVA: 0x3099A2C Offset: 0x3095A2C VA: 0x3099A2C
	public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) { }

	// RVA: 0x3099AAC Offset: 0x3095AAC VA: 0x3099AAC
	public void Clear(IArrayPool<char> bufferPool) { }

	// RVA: 0x30999C4 Offset: 0x30959C4 VA: 0x30999C4
	private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) { }

	[NullableContext(1)]
	// RVA: 0x3099AE4 Offset: 0x3095AE4 VA: 0x3099AE4 Slot: 3
	public override string ToString() { }

	[NullableContext(1)]
	// RVA: 0x3099AFC Offset: 0x3095AFC VA: 0x3099AFC
	public string ToString(int start, int length) { }

	// RVA: 0x3099B18 Offset: 0x3095B18 VA: 0x3099B18
	public char[] get_InternalBuffer() { }
}
