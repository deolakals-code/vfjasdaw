// Assembly: mscorlib.dll
// Namespace: System.Globalization
public sealed class IdnMapping // TypeDefIndex: 10829
{
	// Fields
	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18

	// Methods

	// RVA: 0x2FAEF08 Offset: 0x2FAAF08 VA: 0x2FAEF08
	public void .ctor() { }

	// RVA: 0x2FAEFDC Offset: 0x2FAAFDC VA: 0x2FAEFDC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2FAF068 Offset: 0x2FAB068 VA: 0x2FAF068 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FAF078 Offset: 0x2FAB078 VA: 0x2FAF078
	public string GetAscii(string unicode) { }

	// RVA: 0x2FAF0D8 Offset: 0x2FAB0D8 VA: 0x2FAF0D8
	public string GetAscii(string unicode, int index, int count) { }

	// RVA: 0x2FAF1A0 Offset: 0x2FAB1A0 VA: 0x2FAF1A0
	private string Convert(string input, int index, int count, bool toAscii) { }

	// RVA: 0x2FAF3A8 Offset: 0x2FAB3A8 VA: 0x2FAF3A8
	private string ToAscii(string s, int offset) { }

	// RVA: 0x2FAFDFC Offset: 0x2FABDFC VA: 0x2FAFDFC
	private void VerifyLength(string s, int offset) { }

	// RVA: 0x2FAF7A8 Offset: 0x2FAB7A8 VA: 0x2FAF7A8
	private string NamePrep(string s, int offset) { }

	// RVA: 0x2FAFEC0 Offset: 0x2FABEC0 VA: 0x2FAFEC0
	private void VerifyProhibitedCharacters(string s, int offset) { }

	// RVA: 0x2FAF8EC Offset: 0x2FAB8EC VA: 0x2FAF8EC
	private void VerifyStd3AsciiRules(string s, int offset) { }

	// RVA: 0x2FB00F8 Offset: 0x2FAC0F8 VA: 0x2FB00F8
	public string GetUnicode(string ascii) { }

	// RVA: 0x2FB0158 Offset: 0x2FAC158 VA: 0x2FB0158
	public string GetUnicode(string ascii, int index, int count) { }

	// RVA: 0x2FAF5DC Offset: 0x2FAB5DC VA: 0x2FAF5DC
	private string ToUnicode(string s, int offset) { }
}
