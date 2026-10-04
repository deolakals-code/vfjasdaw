// Assembly: mscorlib.dll
// Namespace: System
public class ResolveEventArgs : EventArgs // TypeDefIndex: 9658
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Assembly <RequestingAssembly>k__BackingField; // 0x18

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x2FF6A18 Offset: 0x2FF2A18 VA: 0x2FF6A18
	public void .ctor(string name) { }

	// RVA: 0x2FF6A8C Offset: 0x2FF2A8C VA: 0x2FF6A8C
	public void .ctor(string name, Assembly requestingAssembly) { }

	[CompilerGenerated]
	// RVA: 0x2FF6B14 Offset: 0x2FF2B14 VA: 0x2FF6B14
	public string get_Name() { }
}
