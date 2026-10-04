// Assembly: System.Numerics.dll
// Namespace: System.Text
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
[DefaultMember("Item")]
internal struct ValueStringBuilder // TypeDefIndex: 17497
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x32A48BC Offset: 0x32A08BC VA: 0x32A48BC
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x32A9BC0 Offset: 0x32A5BC0 VA: 0x32A9BC0
	public int get_Length() { }

	// RVA: 0x32A4B78 Offset: 0x32A0B78 VA: 0x32A4B78 Slot: 3
	public override string ToString() { }

	// RVA: 0x32A4A90 Offset: 0x32A0A90 VA: 0x32A4A90
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x32A48CC Offset: 0x32A08CC VA: 0x32A48CC
	public void Insert(int index, char value, int count) { }

	// RVA: 0x32A9E0C Offset: 0x32A5E0C VA: 0x32A9E0C
	public void Append(char c) { }

	// RVA: 0x32A9F08 Offset: 0x32A5F08 VA: 0x32A9F08
	public void Append(string s) { }

	// RVA: 0x32A9FB4 Offset: 0x32A5FB4 VA: 0x32A9FB4
	private void AppendSlow(string s) { }

	// RVA: 0x32A8CD4 Offset: 0x32A4CD4 VA: 0x32A8CD4
	public void Append(char c, int count) { }

	// RVA: 0x32A8BF4 Offset: 0x32A4BF4 VA: 0x32A8BF4
	public void Append(char* value, int length) { }

	// RVA: 0x32AA0E0 Offset: 0x32A60E0 VA: 0x32AA0E0
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x32A9E88 Offset: 0x32A5E88 VA: 0x32A9E88
	private void GrowAndAppend(char c) { }

	// RVA: 0x32A9BC8 Offset: 0x32A5BC8 VA: 0x32A9BC8
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x32AA19C Offset: 0x32A619C VA: 0x32AA19C
	public void Dispose() { }
}
