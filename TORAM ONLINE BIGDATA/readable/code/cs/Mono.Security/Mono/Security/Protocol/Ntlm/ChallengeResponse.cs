// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Protocol.Ntlm
[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
public class ChallengeResponse : IDisposable // TypeDefIndex: 16891
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x2E53AF4 Offset: 0x2E4FAF4 VA: 0x2E53AF4
	public void .ctor() { }

	// RVA: 0x2E53B78 Offset: 0x2E4FB78 VA: 0x2E53B78
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x2E540E8 Offset: 0x2E500E8 VA: 0x2E540E8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E53BB0 Offset: 0x2E4FBB0 VA: 0x2E53BB0
	public void set_Password(string value) { }

	// RVA: 0x2E53FB8 Offset: 0x2E4FFB8 VA: 0x2E53FB8
	public void set_Challenge(byte[] value) { }

	// RVA: 0x2E54330 Offset: 0x2E50330 VA: 0x2E54330
	public byte[] get_LM() { }

	// RVA: 0x2E5466C Offset: 0x2E5066C VA: 0x2E5466C
	public byte[] get_NT() { }

	// RVA: 0x2E54188 Offset: 0x2E50188 VA: 0x2E54188 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E546CC Offset: 0x2E506CC VA: 0x2E546CC
	private void Dispose(bool disposing) { }

	// RVA: 0x2E54390 Offset: 0x2E50390 VA: 0x2E54390
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x2E54738 Offset: 0x2E50738 VA: 0x2E54738
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x2E541EC Offset: 0x2E501EC VA: 0x2E541EC
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x2E54930 Offset: 0x2E50930 VA: 0x2E54930
	private static void .cctor() { }
}
