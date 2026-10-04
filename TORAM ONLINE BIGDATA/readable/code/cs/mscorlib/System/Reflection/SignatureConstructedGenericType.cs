// Assembly: mscorlib.dll
// Namespace: System.Reflection
internal sealed class SignatureConstructedGenericType : SignatureType // TypeDefIndex: 10619
{
	// Fields
	private readonly Type _genericTypeDefinition; // 0x18
	private readonly Type[] _genericTypeArguments; // 0x20

	// Properties
	public sealed override bool IsGenericTypeDefinition { get; }
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	public sealed override bool IsConstructedGenericType { get; }
	public sealed override bool IsGenericParameter { get; }
	public sealed override bool IsGenericMethodParameter { get; }
	public sealed override bool ContainsGenericParameters { get; }
	internal sealed override SignatureType ElementType { get; }
	public sealed override Type[] GenericTypeArguments { get; }
	public sealed override int GenericParameterPosition { get; }
	public sealed override string Name { get; }
	public sealed override string Namespace { get; }

	// Methods

	// RVA: 0x2F2D7A4 Offset: 0x2F297A4 VA: 0x2F2D7A4
	internal void .ctor(Type genericTypeDefinition, Type[] typeArguments) { }

	// RVA: 0x2F2D9B0 Offset: 0x2F299B0 VA: 0x2F2D9B0 Slot: 41
	public sealed override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x2F2D9B8 Offset: 0x2F299B8 VA: 0x2F2D9B8 Slot: 45
	protected sealed override bool HasElementTypeImpl() { }

	// RVA: 0x2F2D9C0 Offset: 0x2F299C0 VA: 0x2F2D9C0 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x2F2D9C8 Offset: 0x2F299C8 VA: 0x2F2D9C8 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x2F2D9D0 Offset: 0x2F299D0 VA: 0x2F2D9D0 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x2F2D9D8 Offset: 0x2F299D8 VA: 0x2F2D9D8 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x2F2D9E0 Offset: 0x2F299E0 VA: 0x2F2D9E0 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x2F2D9E8 Offset: 0x2F299E8 VA: 0x2F2D9E8 Slot: 37
	public sealed override bool get_IsConstructedGenericType() { }

	// RVA: 0x2F2D9F0 Offset: 0x2F299F0 VA: 0x2F2D9F0 Slot: 38
	public sealed override bool get_IsGenericParameter() { }

	// RVA: 0x2F2D9F8 Offset: 0x2F299F8 VA: 0x2F2D9F8 Slot: 39
	public sealed override bool get_IsGenericMethodParameter() { }

	// RVA: 0x2F2DA00 Offset: 0x2F29A00 VA: 0x2F2DA00 Slot: 20
	public sealed override bool get_ContainsGenericParameters() { }

	// RVA: 0x2F2DA74 Offset: 0x2F29A74 VA: 0x2F2DA74 Slot: 129
	internal sealed override SignatureType get_ElementType() { }

	// RVA: 0x2F2DA7C Offset: 0x2F29A7C VA: 0x2F2DA7C Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x2F2DAC8 Offset: 0x2F29AC8 VA: 0x2F2DAC8 Slot: 48
	public sealed override Type GetGenericTypeDefinition() { }

	// RVA: 0x2F2DAD0 Offset: 0x2F29AD0 VA: 0x2F2DAD0 Slot: 50
	public sealed override Type[] GetGenericArguments() { }

	// RVA: 0x2F2DAE0 Offset: 0x2F29AE0 VA: 0x2F2DAE0 Slot: 49
	public sealed override Type[] get_GenericTypeArguments() { }

	// RVA: 0x2F2DB58 Offset: 0x2F29B58 VA: 0x2F2DB58 Slot: 51
	public sealed override int get_GenericParameterPosition() { }

	// RVA: 0x2F2DBA4 Offset: 0x2F29BA4 VA: 0x2F2DBA4 Slot: 8
	public sealed override string get_Name() { }

	// RVA: 0x2F2DBC4 Offset: 0x2F29BC4 VA: 0x2F2DBC4 Slot: 24
	public sealed override string get_Namespace() { }

	// RVA: 0x2F2DBE8 Offset: 0x2F29BE8 VA: 0x2F2DBE8 Slot: 3
	public sealed override string ToString() { }
}
