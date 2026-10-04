// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
internal class ChannelData // TypeDefIndex: 10202
{
	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	// Properties
	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }

	// Methods

	// RVA: 0x2ED1C70 Offset: 0x2ECDC70 VA: 0x2ED1C70
	internal ArrayList get_ServerProviders() { }

	// RVA: 0x2ED2404 Offset: 0x2ECE404 VA: 0x2ED2404
	public ArrayList get_ClientProviders() { }

	// RVA: 0x2ED6DBC Offset: 0x2ED2DBC VA: 0x2ED6DBC
	public Hashtable get_CustomProperties() { }

	// RVA: 0x2ED1318 Offset: 0x2ECD318 VA: 0x2ED1318
	public void CopyFrom(ChannelData other) { }

	// RVA: 0x2ED6CEC Offset: 0x2ED2CEC VA: 0x2ED6CEC
	public void .ctor() { }
}
