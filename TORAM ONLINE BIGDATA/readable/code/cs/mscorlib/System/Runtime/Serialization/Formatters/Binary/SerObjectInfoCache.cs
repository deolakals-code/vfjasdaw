// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerObjectInfoCache // TypeDefIndex: 10417
{
	// Fields
	internal string fullTypeName; // 0x10
	internal string assemblyString; // 0x18
	internal bool hasTypeForwardedFrom; // 0x20
	internal MemberInfo[] memberInfos; // 0x28
	internal string[] memberNames; // 0x30
	internal Type[] memberTypes; // 0x38

	// Methods

	// RVA: 0x2F1124C Offset: 0x2F0D24C VA: 0x2F1124C
	internal void .ctor(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	// RVA: 0x2F111A8 Offset: 0x2F0D1A8 VA: 0x2F111A8
	internal void .ctor(Type type) { }
}
