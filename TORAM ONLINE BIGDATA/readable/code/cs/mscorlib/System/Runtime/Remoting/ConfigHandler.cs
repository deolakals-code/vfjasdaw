// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
internal class ConfigHandler : SmallXmlParser.IContentHandler // TypeDefIndex: 10201
{
	// Fields
	private ArrayList typeEntries; // 0x10
	private ArrayList channelInstances; // 0x18
	private ChannelData currentChannel; // 0x20
	private Stack currentProviderData; // 0x28
	private string currentClientUrl; // 0x30
	private string appName; // 0x38
	private string currentXmlPath; // 0x40
	private bool onlyDelayedChannels; // 0x48

	// Methods

	// RVA: 0x2ECF778 Offset: 0x2ECB778 VA: 0x2ECF778
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0x2ED3AB0 Offset: 0x2ECFAB0 VA: 0x2ED3AB0
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0x2ED3B8C Offset: 0x2ECFB8C VA: 0x2ED3B8C
	private bool CheckPath(string path) { }

	// RVA: 0x2ED3C6C Offset: 0x2ECFC6C VA: 0x2ED3C6C Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x2ED3C70 Offset: 0x2ECFC70 VA: 0x2ED3C70 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x2ED3C74 Offset: 0x2ECFC74 VA: 0x2ED3C74 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x2ED3C78 Offset: 0x2ECFC78 VA: 0x2ED3C78 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x2ED3E38 Offset: 0x2ECFE38 VA: 0x2ED3E38
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x2ED674C Offset: 0x2ED274C VA: 0x2ED674C Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x2ED4DC4 Offset: 0x2ED0DC4 VA: 0x2ED4DC4
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x2ED5120 Offset: 0x2ED1120 VA: 0x2ED5120
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x2ED68A4 Offset: 0x2ED28A4 VA: 0x2ED68A4
	private TimeSpan ParseTime(string s) { }

	// RVA: 0x2ED5668 Offset: 0x2ED1668 VA: 0x2ED5668
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x2ED5A50 Offset: 0x2ED1A50 VA: 0x2ED5A50
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x2ED6130 Offset: 0x2ED2130 VA: 0x2ED6130
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x2ED6270 Offset: 0x2ED2270 VA: 0x2ED6270
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x2ED5E60 Offset: 0x2ED1E60 VA: 0x2ED5E60
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x2ED5F50 Offset: 0x2ED1F50 VA: 0x2ED5F50
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x2ED6338 Offset: 0x2ED2338 VA: 0x2ED6338
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0x2ED64D4 Offset: 0x2ED24D4 VA: 0x2ED64D4
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x2ED6E9C Offset: 0x2ED2E9C VA: 0x2ED6E9C
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0x2ED6FCC Offset: 0x2ED2FCC VA: 0x2ED6FCC
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x2ED7C5C Offset: 0x2ED3C5C VA: 0x2ED7C5C Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x2ED7C60 Offset: 0x2ED3C60 VA: 0x2ED7C60 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}
