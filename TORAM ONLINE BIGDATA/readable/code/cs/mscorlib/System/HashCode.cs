// Assembly: mscorlib.dll
// Namespace: System
public struct HashCode // TypeDefIndex: 9606
{
	// Fields
	private static readonly uint s_seed; // 0x0
	private uint _v1; // 0x0
	private uint _v2; // 0x4
	private uint _v3; // 0x8
	private uint _v4; // 0xC
	private uint _queue1; // 0x10
	private uint _queue2; // 0x14
	private uint _queue3; // 0x18
	private uint _length; // 0x1C

	// Methods

	// RVA: 0x2FE10D4 Offset: 0x2FDD0D4 VA: 0x2FE10D4
	private static uint GenerateGlobalSeed() { }

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2>(T1 value1, T2 value2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C3C60 Offset: 0x26BFC60 VA: 0x26C3C60
	|-HashCode.Combine<object, object>
	|
	|-RVA: 0x26C3DB8 Offset: 0x26BFDB8 VA: 0x26C3DB8
	|-HashCode.Combine<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C40DC Offset: 0x26C00DC VA: 0x26C40DC
	|-HashCode.Combine<object, AssemblyVersion, object, object>
	|
	|-RVA: 0x26C439C Offset: 0x26C039C VA: 0x26C439C
	|-HashCode.Combine<ushort, ushort, ushort, ushort>
	|
	|-RVA: 0x26C465C Offset: 0x26C065C VA: 0x26C465C
	|-HashCode.Combine<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2FE10F8 Offset: 0x2FDD0F8 VA: 0x2FE10F8
	private static uint Rol(uint value, int count) { }

	// RVA: 0x2FE1104 Offset: 0x2FDD104 VA: 0x2FE1104
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	// RVA: 0x2FE11BC Offset: 0x2FDD1BC VA: 0x2FE11BC
	private static uint Round(uint hash, uint input) { }

	// RVA: 0x2FE1234 Offset: 0x2FDD234 VA: 0x2FE1234
	private static uint QueueRound(uint hash, uint queuedValue) { }

	// RVA: 0x2FE12AC Offset: 0x2FDD2AC VA: 0x2FE12AC
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	// RVA: 0x2FE1350 Offset: 0x2FDD350 VA: 0x2FE1350
	private static uint MixEmptyState() { }

	// RVA: 0x2FE13B4 Offset: 0x2FDD3B4 VA: 0x2FE13B4
	private static uint MixFinal(uint hash) { }

	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", True)]
	// RVA: 0x2FE13DC Offset: 0x2FDD3DC VA: 0x2FE13DC Slot: 2
	public override int GetHashCode() { }

	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", True)]
	// RVA: 0x2FE1448 Offset: 0x2FDD448 VA: 0x2FE1448 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2FE1490 Offset: 0x2FDD490 VA: 0x2FE1490
	private static void .cctor() { }
}
