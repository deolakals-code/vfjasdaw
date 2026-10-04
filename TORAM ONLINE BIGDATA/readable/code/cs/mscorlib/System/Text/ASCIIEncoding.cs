// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public class ASCIIEncoding : Encoding // TypeDefIndex: 10013
{
	// Fields
	internal static readonly ASCIIEncoding.ASCIIEncodingSealed s_default; // 0x0

	// Methods

	// RVA: 0x3064C44 Offset: 0x3060C44 VA: 0x3064C44
	public void .ctor() { }

	// RVA: 0x3064C50 Offset: 0x3060C50 VA: 0x3064C50 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x3064DA8 Offset: 0x3060DA8 VA: 0x3064DA8 Slot: 13
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x3064F20 Offset: 0x3060F20 VA: 0x3064F20 Slot: 12
	public override int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	// RVA: 0x3064FAC Offset: 0x3060FAC VA: 0x3064FAC Slot: 14
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x306507C Offset: 0x306107C VA: 0x306507C Slot: 19
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x30652C4 Offset: 0x30612C4 VA: 0x30652C4 Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x3065528 Offset: 0x3061528 VA: 0x3065528 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x3065620 Offset: 0x3061620 VA: 0x3065620 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x3065798 Offset: 0x3061798 VA: 0x3065798 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x3065868 Offset: 0x3061868 VA: 0x3065868 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x3065ACC Offset: 0x3061ACC VA: 0x3065ACC Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x3065BC4 Offset: 0x3061BC4 VA: 0x3065BC4 Slot: 36
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x3065D80 Offset: 0x3061D80 VA: 0x3065D80 Slot: 15
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x3066168 Offset: 0x3062168 VA: 0x3066168 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x30665CC Offset: 0x30625CC VA: 0x30665CC Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x3066770 Offset: 0x3062770 VA: 0x3066770 Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x3066A08 Offset: 0x3062A08 VA: 0x3066A08 Slot: 33
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x3066B08 Offset: 0x3062B08 VA: 0x3066B08 Slot: 34
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x3066C04 Offset: 0x3062C04 VA: 0x3066C04 Slot: 31
	public override Decoder GetDecoder() { }

	// RVA: 0x3066CBC Offset: 0x3062CBC VA: 0x3066CBC Slot: 32
	public override Encoder GetEncoder() { }

	// RVA: 0x3066D74 Offset: 0x3062D74 VA: 0x3066D74
	private static void .cctor() { }
}
