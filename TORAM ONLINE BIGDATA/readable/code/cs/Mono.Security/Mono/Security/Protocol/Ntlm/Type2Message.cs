// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Protocol.Ntlm
public class Type2Message : MessageBase // TypeDefIndex: 16898
{
	// Fields
	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	// Properties
	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }

	// Methods

	// RVA: 0x2E56940 Offset: 0x2E52940 VA: 0x2E56940
	public void .ctor(byte[] message) { }

	// RVA: 0x2E569F0 Offset: 0x2E529F0 VA: 0x2E569F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E5599C Offset: 0x2E5199C VA: 0x2E5599C
	public byte[] get_Nonce() { }

	// RVA: 0x2E56A98 Offset: 0x2E52A98 VA: 0x2E56A98
	public string get_TargetName() { }

	// RVA: 0x2E55924 Offset: 0x2E51924 VA: 0x2E55924
	public byte[] get_TargetInfo() { }

	// RVA: 0x2E56AA0 Offset: 0x2E52AA0 VA: 0x2E56AA0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x2E56C38 Offset: 0x2E52C38 VA: 0x2E56C38 Slot: 5
	public override byte[] GetBytes() { }
}
