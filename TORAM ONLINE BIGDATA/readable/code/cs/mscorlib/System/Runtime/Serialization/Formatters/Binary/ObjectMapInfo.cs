// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectMapInfo // TypeDefIndex: 10413
{
	// Fields
	internal int objectId; // 0x10
	private int numMembers; // 0x14
	private string[] memberNames; // 0x18
	private Type[] memberTypes; // 0x20

	// Methods

	// RVA: 0x2F0F070 Offset: 0x2F0B070 VA: 0x2F0F070
	internal void .ctor(int objectId, int numMembers, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x2F0EF34 Offset: 0x2F0AF34 VA: 0x2F0EF34
	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes) { }
}
