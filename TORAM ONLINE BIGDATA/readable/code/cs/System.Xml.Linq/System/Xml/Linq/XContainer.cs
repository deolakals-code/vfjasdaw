// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public abstract class XContainer : XNode // TypeDefIndex: 17508
{
	// Fields
	internal object content; // 0x28

	// Properties
	public XNode LastNode { get; }

	// Methods

	// RVA: 0x32BBF70 Offset: 0x32B7F70 VA: 0x32BBF70
	internal void .ctor() { }

	// RVA: 0x32BBF78 Offset: 0x32B7F78 VA: 0x32BBF78
	internal void .ctor(XContainer other) { }

	// RVA: 0x32BC1AC Offset: 0x32B81AC VA: 0x32BC1AC
	public XNode get_LastNode() { }

	// RVA: 0x32BC300 Offset: 0x32B8300 VA: 0x32BC300
	public void Add(object content) { }

	[IteratorStateMachine(typeof(XContainer.<Nodes>d__18))]
	// RVA: 0x32BD0B4 Offset: 0x32B90B4 VA: 0x32BD0B4
	public IEnumerable<XNode> Nodes() { }

	// RVA: 0x32BD164 Offset: 0x32B9164 VA: 0x32BD164 Slot: 11
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x32BD168 Offset: 0x32B9168 VA: 0x32BD168 Slot: 12
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x32BC860 Offset: 0x32B8860 VA: 0x32BC860
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x32BCD2C Offset: 0x32B8D2C VA: 0x32BCD2C
	internal void AddNode(XNode n) { }

	// RVA: 0x32BD16C Offset: 0x32B916C VA: 0x32BD16C
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x32BCDAC Offset: 0x32B8DAC VA: 0x32BCDAC
	internal void AddString(string s) { }

	// RVA: 0x32BD1EC Offset: 0x32B91EC VA: 0x32BD1EC
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x32BD45C Offset: 0x32B945C VA: 0x32BD45C
	internal void AppendNode(XNode n) { }

	// RVA: 0x32BC0BC Offset: 0x32B80BC VA: 0x32BC0BC
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x32BD7CC Offset: 0x32B97CC VA: 0x32BD7CC Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x32BD374 Offset: 0x32B9374 VA: 0x32BD374
	internal void ConvertTextToNode() { }

	// RVA: 0x32BACEC Offset: 0x32B6CEC VA: 0x32BACEC
	internal static string GetStringValue(object value) { }

	// RVA: 0x32BD8B4 Offset: 0x32B98B4 VA: 0x32BD8B4
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x32BDFA8 Offset: 0x32B9FA8 VA: 0x32BDFA8
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x32BEE48 Offset: 0x32BAE48 VA: 0x32BEE48
	internal void RemoveNode(XNode n) { }

	// RVA: 0x32BF028 Offset: 0x32BB028 VA: 0x32BF028 Slot: 13
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x32BF02C Offset: 0x32BB02C VA: 0x32BF02C Slot: 14
	internal virtual void ValidateString(string s) { }

	// RVA: 0x32BF030 Offset: 0x32BB030 VA: 0x32BF030
	internal void WriteContentTo(XmlWriter writer) { }
}
