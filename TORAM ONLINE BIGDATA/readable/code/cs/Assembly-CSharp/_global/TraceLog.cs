// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TraceLog // TypeDefIndex: 5594
{
	// Fields
	private string title; // 0x10
	private int maxLog; // 0x18
	private readonly List<string> logList; // 0x20

	// Properties
	public string Title { get; }

	// Methods

	// RVA: 0x17A2C90 Offset: 0x179EC90 VA: 0x17A2C90
	public string get_Title() { }

	// RVA: 0x17A2C98 Offset: 0x179EC98 VA: 0x17A2C98
	public void .ctor() { }

	// RVA: 0x17A2D50 Offset: 0x179ED50 VA: 0x17A2D50
	public void .ctor(int logCount) { }

	// RVA: 0x17A2E18 Offset: 0x179EE18 VA: 0x17A2E18
	public void .ctor(string title) { }

	// RVA: 0x17A2EF0 Offset: 0x179EEF0 VA: 0x17A2EF0
	public void .ctor(string title, int logCount) { }

	// RVA: 0x17A2FD0 Offset: 0x179EFD0 VA: 0x17A2FD0
	public void Add(string msg) { }

	// RVA: 0x17A3134 Offset: 0x179F134 VA: 0x17A3134
	public void Clear() { }

	// RVA: 0x17A31A4 Offset: 0x179F1A4 VA: 0x17A31A4
	public string GetLogString() { }
}
