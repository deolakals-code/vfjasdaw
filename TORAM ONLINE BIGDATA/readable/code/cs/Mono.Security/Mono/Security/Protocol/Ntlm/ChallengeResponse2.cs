// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Protocol.Ntlm
public static class ChallengeResponse2 // TypeDefIndex: 16892
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x2E54A14 Offset: 0x2E50A14 VA: 0x2E54A14
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x2E5519C Offset: 0x2E5119C VA: 0x2E5519C
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x2E552A0 Offset: 0x2E512A0 VA: 0x2E552A0
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x2E5530C Offset: 0x2E5130C VA: 0x2E5530C
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x2E554F0 Offset: 0x2E514F0 VA: 0x2E554F0
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x2E55A14 Offset: 0x2E51A14 VA: 0x2E55A14
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x2E54EA8 Offset: 0x2E50EA8 VA: 0x2E54EA8
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x2E55C2C Offset: 0x2E51C2C VA: 0x2E55C2C
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x2E54D40 Offset: 0x2E50D40 VA: 0x2E54D40
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x2E55E24 Offset: 0x2E51E24 VA: 0x2E55E24
	private static void .cctor() { }
}
