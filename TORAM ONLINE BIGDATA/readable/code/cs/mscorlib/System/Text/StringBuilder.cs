// Assembly: mscorlib.dll
// Namespace: System.Text
[DefaultMember("Chars")]
[Serializable]
public sealed class StringBuilder : ISerializable // TypeDefIndex: 10040
{
	// Fields
	internal char[] m_ChunkChars; // 0x10
	internal StringBuilder m_ChunkPrevious; // 0x18
	internal int m_ChunkLength; // 0x20
	internal int m_ChunkOffset; // 0x24
	internal int m_MaxCapacity; // 0x28

	// Properties
	public int Capacity { get; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }
	private Span<char> RemainingCurrentChunk { get; }

	// Methods

	// RVA: 0x2E8B424 Offset: 0x2E87424 VA: 0x2E8B424
	public void .ctor() { }

	// RVA: 0x2E8B490 Offset: 0x2E87490 VA: 0x2E8B490
	public void .ctor(int capacity) { }

	// RVA: 0x2E8B668 Offset: 0x2E87668 VA: 0x2E8B668
	public void .ctor(string value) { }

	// RVA: 0x2E8B684 Offset: 0x2E87684 VA: 0x2E8B684
	public void .ctor(string value, int capacity) { }

	// RVA: 0x2E8B6A0 Offset: 0x2E876A0 VA: 0x2E8B6A0
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x2E8B498 Offset: 0x2E87498 VA: 0x2E8B498
	public void .ctor(int capacity, int maxCapacity) { }

	// RVA: 0x2E8B9C0 Offset: 0x2E879C0 VA: 0x2E8B9C0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E8BCC8 Offset: 0x2E87CC8 VA: 0x2E8BCC8 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2E8BE0C Offset: 0x2E87E0C VA: 0x2E8BE0C
	public int get_Capacity() { }

	// RVA: 0x2E8BE30 Offset: 0x2E87E30 VA: 0x2E8BE30
	public int get_MaxCapacity() { }

	// RVA: 0x2E8BE38 Offset: 0x2E87E38 VA: 0x2E8BE38 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E8BF80 Offset: 0x2E87F80 VA: 0x2E8BF80
	public string ToString(int startIndex, int length) { }

	// RVA: 0x2E8C2E4 Offset: 0x2E882E4 VA: 0x2E8C2E4
	public StringBuilder Clear() { }

	// RVA: 0x2E8BF74 Offset: 0x2E87F74 VA: 0x2E8BF74
	public int get_Length() { }

	// RVA: 0x2E8C300 Offset: 0x2E88300 VA: 0x2E8C300
	public void set_Length(int value) { }

	// RVA: 0x2E8C6D0 Offset: 0x2E886D0 VA: 0x2E8C6D0
	public char get_Chars(int index) { }

	// RVA: 0x2E8C758 Offset: 0x2E88758 VA: 0x2E8C758
	public void set_Chars(int index, char value) { }

	// RVA: 0x2E8C56C Offset: 0x2E8856C VA: 0x2E8C56C
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x2E8C9C0 Offset: 0x2E889C0 VA: 0x2E8C9C0
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x2E8CC4C Offset: 0x2E88C4C VA: 0x2E8CC4C
	public StringBuilder Append(string value) { }

	// RVA: 0x2E8CD50 Offset: 0x2E88D50 VA: 0x2E8CD50
	private void AppendHelper(string value) { }

	// RVA: 0x2E8CD88 Offset: 0x2E88D88 VA: 0x2E8CD88
	public StringBuilder Append(string value, int startIndex, int count) { }

	// RVA: 0x2E8CEC0 Offset: 0x2E88EC0 VA: 0x2E8CEC0
	public StringBuilder Append(StringBuilder value) { }

	// RVA: 0x2E8CEDC Offset: 0x2E88EDC VA: 0x2E8CEDC
	private StringBuilder AppendCore(StringBuilder value, int startIndex, int count) { }

	// RVA: 0x2E8D0F4 Offset: 0x2E890F4 VA: 0x2E8D0F4
	public StringBuilder AppendLine() { }

	// RVA: 0x2E8D114 Offset: 0x2E89114 VA: 0x2E8D114
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x2E8C118 Offset: 0x2E88118 VA: 0x2E8C118
	public void CopyTo(int sourceIndex, Span<char> destination, int count) { }

	// RVA: 0x2E8D2A0 Offset: 0x2E892A0 VA: 0x2E8D2A0
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x2E8D564 Offset: 0x2E89564 VA: 0x2E8D564
	public StringBuilder Append(char value) { }

	// RVA: 0x2E8D5B4 Offset: 0x2E895B4 VA: 0x2E8D5B4
	public StringBuilder Append(byte value) { }

	// RVA: 0x2E8D60C Offset: 0x2E8960C VA: 0x2E8D60C
	public StringBuilder Append(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2E8D664 Offset: 0x2E89664 VA: 0x2E8D664
	public StringBuilder Append(uint value) { }

	// RVA: -1 Offset: -1
	private StringBuilder AppendSpanFormattable<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F385C Offset: 0x26EF85C VA: 0x26F385C
	|-StringBuilder.AppendSpanFormattable<byte>
	|
	|-RVA: 0x26F38E8 Offset: 0x26EF8E8 VA: 0x26F38E8
	|-StringBuilder.AppendSpanFormattable<int>
	|
	|-RVA: 0x26F3974 Offset: 0x26EF974 VA: 0x26F3974
	|-StringBuilder.AppendSpanFormattable<uint>
	|
	|-RVA: 0x26F3A00 Offset: 0x26EFA00 VA: 0x26F3A00
	|-StringBuilder.AppendSpanFormattable<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E8D6BC Offset: 0x2E896BC VA: 0x2E8D6BC
	public StringBuilder Append(object value) { }

	// RVA: 0x2E8D6F4 Offset: 0x2E896F4 VA: 0x2E8D6F4
	public StringBuilder Append(char[] value) { }

	// RVA: 0x2E8D71C Offset: 0x2E8971C VA: 0x2E8D71C
	public StringBuilder Append(ReadOnlySpan<char> value) { }

	// RVA: 0x2E8D7A4 Offset: 0x2E897A4 VA: 0x2E8D7A4
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x2E8D924 Offset: 0x2E89924 VA: 0x2E8D924
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x2E8D950 Offset: 0x2E89950 VA: 0x2E8D950
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x2E8E4C4 Offset: 0x2E8A4C4 VA: 0x2E8E4C4
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x2E8E520 Offset: 0x2E8A520 VA: 0x2E8E520
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x2E8E580 Offset: 0x2E8A580 VA: 0x2E8E580
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x2E8E634 Offset: 0x2E8A634 VA: 0x2E8E634
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x2E8E690 Offset: 0x2E8A690 VA: 0x2E8E690
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x2E8E6F4 Offset: 0x2E8A6F4 VA: 0x2E8E6F4
	private static void FormatError() { }

	// RVA: 0x2E8D9A8 Offset: 0x2E899A8 VA: 0x2E8D9A8
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x2E8E740 Offset: 0x2E8A740 VA: 0x2E8E740
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x2E8E750 Offset: 0x2E8A750 VA: 0x2E8E750
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	// RVA: 0x2E8ECF8 Offset: 0x2E8ACF8 VA: 0x2E8ECF8
	public StringBuilder Replace(char oldChar, char newChar) { }

	// RVA: 0x2E8ED08 Offset: 0x2E8AD08 VA: 0x2E8ED08
	public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x2E8CAFC Offset: 0x2E88AFC VA: 0x2E8CAFC
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x2E8D854 Offset: 0x2E89854 VA: 0x2E8D854
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x2E8EB3C Offset: 0x2E8AB3C VA: 0x2E8EB3C
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x2E8EA64 Offset: 0x2E8AA64 VA: 0x2E8EA64
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x2E8F1AC Offset: 0x2E8B1AC VA: 0x2E8F1AC
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x2E8B8F8 Offset: 0x2E878F8 VA: 0x2E8B8F8
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2E8D138 Offset: 0x2E89138 VA: 0x2E8D138
	private static void ThreadSafeCopy(char[] source, int sourceIndex, Span<char> destination, int destinationIndex, int count) { }

	// RVA: 0x2E8C6A8 Offset: 0x2E886A8 VA: 0x2E8C6A8
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x2E8F300 Offset: 0x2E8B300 VA: 0x2E8F300
	private Span<char> get_RemainingCurrentChunk() { }

	// RVA: 0x2E8F2C0 Offset: 0x2E8B2C0 VA: 0x2E8F2C0
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x2E8C810 Offset: 0x2E88810 VA: 0x2E8C810
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x2E8F368 Offset: 0x2E8B368 VA: 0x2E8F368
	private void .ctor(StringBuilder from) { }

	// RVA: 0x2E8EECC Offset: 0x2E8AECC VA: 0x2E8EECC
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars) { }

	// RVA: 0x2E8F3C4 Offset: 0x2E8B3C4 VA: 0x2E8F3C4
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x2E8D3D4 Offset: 0x2E893D4 VA: 0x2E8D3D4
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }
}
