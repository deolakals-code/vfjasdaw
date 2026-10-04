// Assembly: mscorlib.dll
// Namespace: System
[Usage(6140, Inherited = False)]
[Serializable]
public sealed class ObsoleteAttribute : Attribute // TypeDefIndex: 9647
{
	// Fields
	private string _message; // 0x10
	private bool _error; // 0x18

	// Properties
	public string Message { get; }

	// Methods

	// RVA: 0x2FF45CC Offset: 0x2FF05CC VA: 0x2FF45CC
	public void .ctor() { }

	// RVA: 0x2FF45F8 Offset: 0x2FF05F8 VA: 0x2FF45F8
	public void .ctor(string message) { }

	// RVA: 0x2FF4630 Offset: 0x2FF0630 VA: 0x2FF4630
	public void .ctor(string message, bool error) { }

	// RVA: 0x2FF466C Offset: 0x2FF066C VA: 0x2FF466C
	public string get_Message() { }
}
