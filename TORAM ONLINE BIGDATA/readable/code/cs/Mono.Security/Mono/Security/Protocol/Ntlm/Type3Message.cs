// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Protocol.Ntlm
public class Type3Message : MessageBase // TypeDefIndex: 16899
{
	// Fields
	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	// Properties
	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }

	// Methods

	// RVA: 0x2E56CF0 Offset: 0x2E52CF0 VA: 0x2E56CF0
	public void .ctor(Type2Message type2) { }

	// RVA: 0x2E56F34 Offset: 0x2E52F34 VA: 0x2E56F34 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E57014 Offset: 0x2E53014 VA: 0x2E57014
	public void set_Domain(string value) { }

	// RVA: 0x2E570A0 Offset: 0x2E530A0 VA: 0x2E570A0
	public void set_Password(string value) { }

	// RVA: 0x2E570A8 Offset: 0x2E530A8 VA: 0x2E570A8
	public void set_Username(string value) { }

	// RVA: 0x2E570B0 Offset: 0x2E530B0 VA: 0x2E570B0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x2E57320 Offset: 0x2E53320 VA: 0x2E57320
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x2E57378 Offset: 0x2E53378 VA: 0x2E57378
	private byte[] EncodeString(string text) { }

	// RVA: 0x2E57408 Offset: 0x2E53408 VA: 0x2E57408 Slot: 5
	public override byte[] GetBytes() { }
}
