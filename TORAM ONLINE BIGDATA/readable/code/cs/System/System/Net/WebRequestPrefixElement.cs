// Assembly: System.dll
// Namespace: System.Net
internal class WebRequestPrefixElement // TypeDefIndex: 14400
{
	// Fields
	public string Prefix; // 0x10
	internal IWebRequestCreate creator; // 0x18
	internal Type creatorType; // 0x20

	// Properties
	public IWebRequestCreate Creator { get; set; }

	// Methods

	// RVA: 0x34EEA4C Offset: 0x34EAA4C VA: 0x34EEA4C
	public IWebRequestCreate get_Creator() { }

	// RVA: 0x34EEC5C Offset: 0x34EAC5C VA: 0x34EEC5C
	public void set_Creator(IWebRequestCreate value) { }

	// RVA: 0x34EEC64 Offset: 0x34EAC64 VA: 0x34EEC64
	public void .ctor(string P, IWebRequestCreate C) { }
}
