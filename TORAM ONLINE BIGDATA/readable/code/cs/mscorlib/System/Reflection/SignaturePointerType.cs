// Assembly: mscorlib.dll
// Namespace: System.Reflection
internal sealed class SignaturePointerType : SignatureHasElementType // TypeDefIndex: 10621
{
	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x2F2DFDC Offset: 0x2F29FDC VA: 0x2F2DFDC
	internal void .ctor(SignatureType elementType) { }

	// RVA: 0x2F2E008 Offset: 0x2F2A008 VA: 0x2F2E008 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x2F2E010 Offset: 0x2F2A010 VA: 0x2F2E010 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x2F2E018 Offset: 0x2F2A018 VA: 0x2F2E018 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x2F2E020 Offset: 0x2F2A020 VA: 0x2F2E020 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x2F2E028 Offset: 0x2F2A028 VA: 0x2F2E028 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x2F2E030 Offset: 0x2F2A030 VA: 0x2F2E030 Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x2F2E07C Offset: 0x2F2A07C VA: 0x2F2E07C Slot: 130
	protected sealed override string get_Suffix() { }
}
