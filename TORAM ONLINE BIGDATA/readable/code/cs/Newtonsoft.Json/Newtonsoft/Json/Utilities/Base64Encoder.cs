// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class Base64Encoder // TypeDefIndex: 15877
{
	// Fields
	private readonly char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	[Nullable(2)]
	private byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28

	// Methods

	// RVA: 0x30819E4 Offset: 0x307D9E4 VA: 0x30819E4
	public void .ctor(TextWriter writer) { }

	// RVA: 0x3081AD0 Offset: 0x307DAD0 VA: 0x3081AD0
	private void ValidateEncode(byte[] buffer, int index, int count) { }

	// RVA: 0x3081B94 Offset: 0x307DB94 VA: 0x3081B94
	public void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x3081DF4 Offset: 0x307DDF4 VA: 0x3081DF4
	private void StoreLeftOverBytes(byte[] buffer, int index, ref int count) { }

	// RVA: 0x3081D34 Offset: 0x307DD34 VA: 0x3081D34
	private bool FulfillFromLeftover(byte[] buffer, int index, ref int count) { }

	// RVA: 0x3081F10 Offset: 0x307DF10 VA: 0x3081F10
	public void Flush() { }

	// RVA: 0x3081DD0 Offset: 0x307DDD0 VA: 0x3081DD0
	private void WriteChars(char[] chars, int index, int count) { }
}
