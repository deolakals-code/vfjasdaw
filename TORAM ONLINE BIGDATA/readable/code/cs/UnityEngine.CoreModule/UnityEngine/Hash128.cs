// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
[NativeHeader("Runtime/Utilities/Hash128.h")]
[UsedByNativeCode]
[Serializable]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128> // TypeDefIndex: 16289
{
	// Fields
	internal ulong u64_0; // 0x0
	internal ulong u64_1; // 0x8

	// Methods

	// RVA: 0x37DED90 Offset: 0x37DAD90 VA: 0x37DED90
	public void .ctor(uint u32_0, uint u32_1, uint u32_2, uint u32_3) { }

	// RVA: 0x37CC1F8 Offset: 0x37C81F8 VA: 0x37CC1F8
	public void .ctor(ulong u64_0, ulong u64_1) { }

	// RVA: 0x37DEDA8 Offset: 0x37DADA8 VA: 0x37DEDA8 Slot: 5
	public int CompareTo(Hash128 rhs) { }

	// RVA: 0x37DEE50 Offset: 0x37DAE50 VA: 0x37DEE50 Slot: 3
	public override string ToString() { }

	[FreeFunction("Hash128ToString", IsThreadSafe = True)]
	// RVA: 0x37DEE5C Offset: 0x37DAE5C VA: 0x37DEE5C
	private static string Hash128ToStringImpl(Hash128 hash) { }

	// RVA: 0x37DEED8 Offset: 0x37DAED8 VA: 0x37DEED8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x37DEF74 Offset: 0x37DAF74 VA: 0x37DEF74 Slot: 6
	public bool Equals(Hash128 obj) { }

	// RVA: 0x37DEF90 Offset: 0x37DAF90 VA: 0x37DEF90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37DEFC4 Offset: 0x37DAFC4 VA: 0x37DEFC4 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x37DEF5C Offset: 0x37DAF5C VA: 0x37DEF5C
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x37DEDFC Offset: 0x37DADFC VA: 0x37DEDFC
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x37DEE14 Offset: 0x37DAE14 VA: 0x37DEE14
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x37DEE9C Offset: 0x37DAE9C VA: 0x37DEE9C
	private static string Hash128ToStringImpl_Injected(ref Hash128 hash) { }
}
