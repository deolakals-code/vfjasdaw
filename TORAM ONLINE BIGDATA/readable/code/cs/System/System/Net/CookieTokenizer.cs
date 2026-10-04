// Assembly: System.dll
// Namespace: System.Net
internal class CookieTokenizer // TypeDefIndex: 14440
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x34FA96C Offset: 0x34F696C VA: 0x34FA96C
	internal void .ctor(string tokenStream) { }

	// RVA: 0x34FA9AC Offset: 0x34F69AC VA: 0x34FA9AC
	internal bool get_EndOfCookie() { }

	// RVA: 0x34FA9B4 Offset: 0x34F69B4 VA: 0x34FA9B4
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x34FA9C0 Offset: 0x34F69C0 VA: 0x34FA9C0
	internal bool get_Eof() { }

	// RVA: 0x34FA9D0 Offset: 0x34F69D0 VA: 0x34FA9D0
	internal string get_Name() { }

	// RVA: 0x34FA9D8 Offset: 0x34F69D8 VA: 0x34FA9D8
	internal void set_Name(string value) { }

	// RVA: 0x34FA9E0 Offset: 0x34F69E0 VA: 0x34FA9E0
	internal bool get_Quoted() { }

	// RVA: 0x34FA9E8 Offset: 0x34F69E8 VA: 0x34FA9E8
	internal void set_Quoted(bool value) { }

	// RVA: 0x34FA9F4 Offset: 0x34F69F4 VA: 0x34FA9F4
	internal CookieToken get_Token() { }

	// RVA: 0x34FA9FC Offset: 0x34F69FC VA: 0x34FA9FC
	internal void set_Token(CookieToken value) { }

	// RVA: 0x34FAA04 Offset: 0x34F6A04 VA: 0x34FAA04
	internal string get_Value() { }

	// RVA: 0x34FAA0C Offset: 0x34F6A0C VA: 0x34FAA0C
	internal void set_Value(string value) { }

	// RVA: 0x34FAA14 Offset: 0x34F6A14 VA: 0x34FAA14
	internal string Extract() { }

	// RVA: 0x34FAA9C Offset: 0x34F6A9C VA: 0x34FAA9C
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x34FAD3C Offset: 0x34F6D3C VA: 0x34FAD3C
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x34FAE68 Offset: 0x34F6E68 VA: 0x34FAE68
	internal void Reset() { }

	// RVA: 0x34FAEE8 Offset: 0x34F6EE8 VA: 0x34FAEE8
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x34FB0C8 Offset: 0x34F70C8 VA: 0x34FB0C8
	private static void .cctor() { }
}
