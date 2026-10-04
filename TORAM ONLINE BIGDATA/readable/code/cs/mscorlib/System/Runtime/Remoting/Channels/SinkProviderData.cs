// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public class SinkProviderData // TypeDefIndex: 10264
{
	// Fields
	private string sinkName; // 0x10
	private ArrayList children; // 0x18
	private Hashtable properties; // 0x20

	// Properties
	public IList Children { get; }
	public IDictionary Properties { get; }

	// Methods

	// RVA: 0x2ED67E4 Offset: 0x2ED27E4 VA: 0x2ED67E4
	public void .ctor(string name) { }

	// RVA: 0x2EE9A4C Offset: 0x2EE5A4C VA: 0x2EE9A4C
	public IList get_Children() { }

	// RVA: 0x2EE9A54 Offset: 0x2EE5A54 VA: 0x2EE9A54
	public IDictionary get_Properties() { }
}
