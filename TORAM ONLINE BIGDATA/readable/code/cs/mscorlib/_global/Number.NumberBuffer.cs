// Assembly: mscorlib.dll
// Namespace: 
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct Number.NumberBuffer // TypeDefIndex: 9644
{
	// Fields
	public int precision; // 0x0
	public int scale; // 0x4
	private int _sign; // 0x8
	private Number.NumberBuffer.DigitsAndNullTerminator _digits; // 0xC
	private char* _allDigits; // 0x72

	// Properties
	public bool sign { get; set; }
	public char* digits { get; }

	// Methods

	// RVA: 0x2FF4154 Offset: 0x2FF0154 VA: 0x2FF4154
	public bool get_sign() { }

	// RVA: 0x2FF4164 Offset: 0x2FF0164 VA: 0x2FF4164
	public void set_sign(bool value) { }

	// RVA: 0x2FF4170 Offset: 0x2FF0170 VA: 0x2FF4170
	public char* get_digits() { }
}
