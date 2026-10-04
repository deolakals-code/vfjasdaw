// Assembly: mscorlib.dll
// Namespace: Mono
internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 9427
{
	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x2E65A34 Offset: 0x2E61A34 VA: 0x2E65A34
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x2E65A54 Offset: 0x2E61A54 VA: 0x2E65A54
	internal Type[] get_Constraints() { }

	// RVA: 0x2E65B90 Offset: 0x2E61B90 VA: 0x2E65B90
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x2E65A58 Offset: 0x2E61A58 VA: 0x2E65A58
	private Type[] GetConstraints() { }

	// RVA: 0x2E65BAC Offset: 0x2E61BAC VA: 0x2E65BAC
	private int GetConstraintsCount() { }
}
