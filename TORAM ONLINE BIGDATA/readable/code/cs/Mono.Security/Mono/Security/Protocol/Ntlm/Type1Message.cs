// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Protocol.Ntlm
public class Type1Message : MessageBase // TypeDefIndex: 16897
{
	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x2E56438 Offset: 0x2E52438 VA: 0x2E56438
	public void .ctor() { }

	// RVA: 0x2E564D4 Offset: 0x2E524D4 VA: 0x2E564D4
	public void set_Domain(string value) { }

	// RVA: 0x2E56560 Offset: 0x2E52560 VA: 0x2E56560
	public void set_Host(string value) { }

	// RVA: 0x2E565EC Offset: 0x2E525EC VA: 0x2E565EC Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x2E566F4 Offset: 0x2E526F4 VA: 0x2E566F4 Slot: 5
	public override byte[] GetBytes() { }
}
