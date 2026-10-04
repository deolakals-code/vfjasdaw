// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public sealed class ConsoleCancelEventArgs : EventArgs // TypeDefIndex: 9709
{
	// Fields
	private readonly ConsoleSpecialKey _type; // 0x10
	[CompilerGenerated]
	private bool <Cancel>k__BackingField; // 0x14

	// Properties
	public bool Cancel { get; }

	// Methods

	// RVA: 0x3005384 Offset: 0x3001384 VA: 0x3005384
	internal void .ctor(ConsoleSpecialKey type) { }

	[CompilerGenerated]
	// RVA: 0x30053F0 Offset: 0x30013F0 VA: 0x30053F0
	public bool get_Cancel() { }

	// RVA: 0x30053F8 Offset: 0x30013F8 VA: 0x30053F8
	internal void .ctor() { }
}
