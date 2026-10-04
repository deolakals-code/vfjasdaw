// Assembly: mscorlib.dll
// Namespace: System.Reflection
internal abstract class SignatureHasElementType : SignatureType // TypeDefIndex: 10620
{
	// Fields
	private readonly SignatureType _elementType; // 0x18

	// Properties
	public sealed override bool IsGenericTypeDefinition { get; }
	public abstract override bool IsSZArray { get; }
	public abstract override bool IsVariableBoundArray { get; }
	public sealed override bool IsConstructedGenericType { get; }
	public sealed override bool IsGenericParameter { get; }
	public sealed override bool IsGenericMethodParameter { get; }
	public sealed override bool ContainsGenericParameters { get; }
	internal sealed override SignatureType ElementType { get; }
	public sealed override Type[] GenericTypeArguments { get; }
	public sealed override int GenericParameterPosition { get; }
	public sealed override string Name { get; }
	public sealed override string Namespace { get; }
	protected abstract string Suffix { get; }

	// Methods

	// RVA: 0x2F2D598 Offset: 0x2F29598 VA: 0x2F2D598
	protected void .ctor(SignatureType elementType) { }

	// RVA: 0x2F2DD0C Offset: 0x2F29D0C VA: 0x2F2DD0C Slot: 41
	public sealed override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x2F2DD14 Offset: 0x2F29D14 VA: 0x2F2DD14 Slot: 45
	protected sealed override bool HasElementTypeImpl() { }

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract override bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract override bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract override bool IsPointerImpl();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract override bool get_IsSZArray();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract override bool get_IsVariableBoundArray();

	// RVA: 0x2F2DD1C Offset: 0x2F29D1C VA: 0x2F2DD1C Slot: 37
	public sealed override bool get_IsConstructedGenericType() { }

	// RVA: 0x2F2DD24 Offset: 0x2F29D24 VA: 0x2F2DD24 Slot: 38
	public sealed override bool get_IsGenericParameter() { }

	// RVA: 0x2F2DD2C Offset: 0x2F29D2C VA: 0x2F2DD2C Slot: 39
	public sealed override bool get_IsGenericMethodParameter() { }

	// RVA: 0x2F2DD34 Offset: 0x2F29D34 VA: 0x2F2DD34 Slot: 20
	public sealed override bool get_ContainsGenericParameters() { }

	// RVA: 0x2F2DD58 Offset: 0x2F29D58 VA: 0x2F2DD58 Slot: 129
	internal sealed override SignatureType get_ElementType() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract override int GetArrayRank();

	// RVA: 0x2F2DD60 Offset: 0x2F29D60 VA: 0x2F2DD60 Slot: 48
	public sealed override Type GetGenericTypeDefinition() { }

	// RVA: 0x2F2DDAC Offset: 0x2F29DAC VA: 0x2F2DDAC Slot: 50
	public sealed override Type[] GetGenericArguments() { }

	// RVA: 0x2F2DE38 Offset: 0x2F29E38 VA: 0x2F2DE38 Slot: 49
	public sealed override Type[] get_GenericTypeArguments() { }

	// RVA: 0x2F2DEC4 Offset: 0x2F29EC4 VA: 0x2F2DEC4 Slot: 51
	public sealed override int get_GenericParameterPosition() { }

	// RVA: 0x2F2DF10 Offset: 0x2F29F10 VA: 0x2F2DF10 Slot: 8
	public sealed override string get_Name() { }

	// RVA: 0x2F2DF64 Offset: 0x2F29F64 VA: 0x2F2DF64 Slot: 24
	public sealed override string get_Namespace() { }

	// RVA: 0x2F2DF88 Offset: 0x2F29F88 VA: 0x2F2DF88 Slot: 3
	public sealed override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 130
	protected abstract string get_Suffix();
}
