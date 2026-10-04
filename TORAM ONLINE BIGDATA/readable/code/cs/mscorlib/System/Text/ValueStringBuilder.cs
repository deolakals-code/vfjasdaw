// Assembly: mscorlib.dll
// Namespace: System.Text
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[DefaultMember("Item")]
internal struct ValueStringBuilder // TypeDefIndex: 10055
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }
	public char Item { get; }

	// Methods

	// RVA: 0x2E9A7E4 Offset: 0x2E967E4 VA: 0x2E9A7E4
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x2E9A7F4 Offset: 0x2E967F4 VA: 0x2E9A7F4
	public int get_Length() { }

	// RVA: 0x2E9A7FC Offset: 0x2E967FC VA: 0x2E9A7FC
	public ref char get_Item(int index) { }

	// RVA: 0x2E9A820 Offset: 0x2E96820 VA: 0x2E9A820 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E9A8EC Offset: 0x2E968EC VA: 0x2E9A8EC
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x2E9A9D4 Offset: 0x2E969D4 VA: 0x2E9A9D4
	public void Append(char c) { }

	// RVA: 0x2E9AAD0 Offset: 0x2E96AD0 VA: 0x2E9AAD0
	public void Append(string s) { }

	// RVA: 0x2E9AB7C Offset: 0x2E96B7C VA: 0x2E9AB7C
	private void AppendSlow(string s) { }

	// RVA: 0x2E9AEEC Offset: 0x2E96EEC VA: 0x2E9AEEC
	public void Append(char c, int count) { }

	// RVA: 0x2E9B014 Offset: 0x2E97014 VA: 0x2E9B014
	public void Append(char* value, int length) { }

	// RVA: 0x2E9B0F4 Offset: 0x2E970F4 VA: 0x2E9B0F4
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x2E9AA50 Offset: 0x2E96A50 VA: 0x2E9AA50
	private void GrowAndAppend(char c) { }

	// RVA: 0x2E9ACA8 Offset: 0x2E96CA8 VA: 0x2E9ACA8
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x2E9B1B0 Offset: 0x2E971B0 VA: 0x2E9B1B0
	public void Dispose() { }
}
