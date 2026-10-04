// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[RequiredByNativeCode(GenerateProxy = True)]
[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
internal struct AssemblyFullName // TypeDefIndex: 16348
{
	// Fields
	[NativeName("name")]
	public string Name; // 0x0
	[NativeName("version")]
	public AssemblyVersion Version; // 0x8
	[NativeName("publicKeyToken")]
	public string PublicKeyToken; // 0x10
	[NativeName("culture")]
	public string Culture; // 0x18

	// Methods

	// RVA: 0x37EB110 Offset: 0x37E7110 VA: 0x37EB110 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37EB1E8 Offset: 0x37E71E8 VA: 0x37EB1E8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37EB270 Offset: 0x37E7270 VA: 0x37EB270 Slot: 3
	public override string ToString() { }
}
