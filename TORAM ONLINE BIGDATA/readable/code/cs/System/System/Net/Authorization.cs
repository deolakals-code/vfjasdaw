// Assembly: System.dll
// Namespace: System.Net
public class Authorization // TypeDefIndex: 14385
{
	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties
	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x34EDCFC Offset: 0x34E9CFC VA: 0x34EDCFC
	public void .ctor(string token) { }

	// RVA: 0x34EDDA8 Offset: 0x34E9DA8 VA: 0x34EDDA8
	public void .ctor(string token, bool finished) { }

	// RVA: 0x34EDE44 Offset: 0x34E9E44 VA: 0x34EDE44
	public string get_Message() { }

	// RVA: 0x34EDE4C Offset: 0x34E9E4C VA: 0x34EDE4C
	public bool get_Complete() { }
}
