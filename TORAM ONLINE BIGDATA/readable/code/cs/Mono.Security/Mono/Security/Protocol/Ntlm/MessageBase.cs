// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Protocol.Ntlm
public abstract class MessageBase // TypeDefIndex: 16893
{
	// Fields
	private static byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Properties
	public NtlmFlags Flags { get; set; }
	public int Type { get; }

	// Methods

	// RVA: 0x2E55F08 Offset: 0x2E51F08 VA: 0x2E55F08
	protected void .ctor(int messageType) { }

	// RVA: 0x2E55F30 Offset: 0x2E51F30 VA: 0x2E55F30
	public NtlmFlags get_Flags() { }

	// RVA: 0x2E55F38 Offset: 0x2E51F38 VA: 0x2E55F38
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0x2E55F40 Offset: 0x2E51F40 VA: 0x2E55F40
	public int get_Type() { }

	// RVA: 0x2E55F48 Offset: 0x2E51F48 VA: 0x2E55F48
	protected byte[] PrepareMessage(int messageSize) { }

	// RVA: 0x2E56048 Offset: 0x2E52048 VA: 0x2E56048 Slot: 4
	protected virtual void Decode(byte[] message) { }

	// RVA: 0x2E561E0 Offset: 0x2E521E0 VA: 0x2E561E0
	protected bool CheckHeader(byte[] message) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetBytes();

	// RVA: 0x2E562F4 Offset: 0x2E522F4 VA: 0x2E562F4
	private static void .cctor() { }
}
