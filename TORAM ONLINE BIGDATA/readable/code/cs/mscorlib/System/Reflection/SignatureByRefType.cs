// Assembly: mscorlib.dll
// Namespace: System.Reflection
internal sealed class SignatureByRefType : SignatureHasElementType // TypeDefIndex: 10618
{
	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x2F2D6C4 Offset: 0x2F296C4 VA: 0x2F2D6C4
	internal void .ctor(SignatureType elementType) { }

	// RVA: 0x2F2D6F0 Offset: 0x2F296F0 VA: 0x2F2D6F0 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x2F2D6F8 Offset: 0x2F296F8 VA: 0x2F2D6F8 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x2F2D700 Offset: 0x2F29700 VA: 0x2F2D700 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x2F2D708 Offset: 0x2F29708 VA: 0x2F2D708 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x2F2D710 Offset: 0x2F29710 VA: 0x2F2D710 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x2F2D718 Offset: 0x2F29718 VA: 0x2F2D718 Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x2F2D764 Offset: 0x2F29764 VA: 0x2F2D764 Slot: 130
	protected sealed override string get_Suffix() { }
}
