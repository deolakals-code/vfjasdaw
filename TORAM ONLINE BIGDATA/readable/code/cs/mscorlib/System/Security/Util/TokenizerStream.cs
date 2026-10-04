// Assembly: mscorlib.dll
// Namespace: System.Security.Util
internal sealed class TokenizerStream // TypeDefIndex: 10086
{
	// Fields
	private int m_countTokens; // 0x10
	private TokenizerShortBlock m_headTokens; // 0x18
	private TokenizerShortBlock m_lastTokens; // 0x20
	private TokenizerShortBlock m_currentTokens; // 0x28
	private int m_indexTokens; // 0x30
	private TokenizerStringBlock m_headStrings; // 0x38
	private TokenizerStringBlock m_currentStrings; // 0x40
	private int m_indexStrings; // 0x48

	// Methods

	// RVA: 0x2EA7554 Offset: 0x2EA3554 VA: 0x2EA7554
	internal void .ctor() { }

	// RVA: 0x2EA7978 Offset: 0x2EA3978 VA: 0x2EA7978
	internal void AddToken(short token) { }

	// RVA: 0x2EA7A90 Offset: 0x2EA3A90 VA: 0x2EA7A90
	internal void AddString(string str) { }

	// RVA: 0x2EA7604 Offset: 0x2EA3604 VA: 0x2EA7604
	internal void Reset() { }

	// RVA: 0x2EA7648 Offset: 0x2EA3648 VA: 0x2EA7648
	internal short GetNextFullToken() { }

	// RVA: 0x2EA6560 Offset: 0x2EA2560 VA: 0x2EA6560
	internal short GetNextToken() { }

	// RVA: 0x2EA65EC Offset: 0x2EA25EC VA: 0x2EA65EC
	internal string GetNextString() { }

	// RVA: 0x2EA6574 Offset: 0x2EA2574 VA: 0x2EA6574
	internal void ThrowAwayNextString() { }

	// RVA: 0x2EA6578 Offset: 0x2EA2578 VA: 0x2EA6578
	internal void TagLastToken(short tag) { }

	// RVA: 0x2EA7E94 Offset: 0x2EA3E94 VA: 0x2EA7E94
	internal int GetTokenCount() { }

	// RVA: 0x2EA6FF8 Offset: 0x2EA2FF8 VA: 0x2EA6FF8
	internal void GoToPosition(int position) { }
}
