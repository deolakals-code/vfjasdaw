// Assembly: mscorlib.dll
// Namespace: System.Reflection
internal sealed class SignatureArrayType : SignatureHasElementType // TypeDefIndex: 10617
{
	// Fields
	private readonly int _rank; // 0x20
	private readonly bool _isMultiDim; // 0x24

	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x2F2D550 Offset: 0x2F29550 VA: 0x2F2D550
	internal void .ctor(SignatureType elementType, int rank, bool isMultiDim) { }

	// RVA: 0x2F2D5C4 Offset: 0x2F295C4 VA: 0x2F2D5C4 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x2F2D5CC Offset: 0x2F295CC VA: 0x2F2D5CC Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x2F2D5D4 Offset: 0x2F295D4 VA: 0x2F2D5D4 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x2F2D5DC Offset: 0x2F295DC VA: 0x2F2D5DC Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x2F2D5EC Offset: 0x2F295EC VA: 0x2F2D5EC Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x2F2D5F4 Offset: 0x2F295F4 VA: 0x2F2D5F4 Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x2F2D5FC Offset: 0x2F295FC VA: 0x2F2D5FC Slot: 130
	protected sealed override string get_Suffix() { }
}
