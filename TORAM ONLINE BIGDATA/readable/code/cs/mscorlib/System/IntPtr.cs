// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[IsReadOnly]
[Serializable]
public struct IntPtr : ISerializable, IEquatable<IntPtr> // TypeDefIndex: 9797
{
	// Fields
	private readonly void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	[ReliabilityContract(2, 1)]
	// RVA: 0x3030E6C Offset: 0x302CE6C VA: 0x3030E6C
	public void .ctor(int value) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x3030E78 Offset: 0x302CE78 VA: 0x3030E78
	public void .ctor(long value) { }

	[ReliabilityContract(2, 1)]
	[CLSCompliant(False)]
	// RVA: 0x3030E80 Offset: 0x302CE80 VA: 0x3030E80
	public void .ctor(void* value) { }

	// RVA: 0x3030E88 Offset: 0x302CE88 VA: 0x3030E88
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3030EE8 Offset: 0x302CEE8 VA: 0x3030EE8
	public static int get_Size() { }

	// RVA: 0x3030EF0 Offset: 0x302CEF0 VA: 0x3030EF0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3030F98 Offset: 0x302CF98 VA: 0x3030F98 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x302D1E0 Offset: 0x30291E0 VA: 0x302D1E0 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3030F90 Offset: 0x302CF90 VA: 0x3030F90
	public long ToInt64() { }

	[CLSCompliant(False)]
	[ReliabilityContract(3, 2)]
	// RVA: 0x3031010 Offset: 0x302D010 VA: 0x3031010
	public void* ToPointer() { }

	// RVA: 0x3031018 Offset: 0x302D018 VA: 0x3031018 Slot: 3
	public override string ToString() { }

	// RVA: 0x3031040 Offset: 0x302D040 VA: 0x3031040
	public string ToString(string format) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3028624 Offset: 0x3024624 VA: 0x3028624
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x30303EC Offset: 0x302C3EC VA: 0x30303EC
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x3031064 Offset: 0x302D064 VA: 0x3031064
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x303106C Offset: 0x302D06C VA: 0x303106C
	public static IntPtr op_Explicit(long value) { }

	[ReliabilityContract(2, 1)]
	[CLSCompliant(False)]
	// RVA: 0x3031070 Offset: 0x302D070 VA: 0x3031070
	public static IntPtr op_Explicit(void* value) { }

	// RVA: 0x3031074 Offset: 0x302D074 VA: 0x3031074
	public static int op_Explicit(IntPtr value) { }

	[CLSCompliant(False)]
	// RVA: 0x3031078 Offset: 0x302D078 VA: 0x3031078
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x303107C Offset: 0x302D07C VA: 0x303107C
	public static IntPtr Add(IntPtr pointer, int offset) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x3031084 Offset: 0x302D084 VA: 0x3031084
	public static IntPtr op_Addition(IntPtr pointer, int offset) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x303108C Offset: 0x302D08C VA: 0x303108C
	public static IntPtr op_Subtraction(IntPtr pointer, int offset) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3031094 Offset: 0x302D094 VA: 0x3031094
	internal bool IsNull() { }

	// RVA: 0x30310A4 Offset: 0x302D0A4 VA: 0x30310A4 Slot: 5
	private bool System.IEquatable<System.IntPtr>.Equals(IntPtr other) { }
}
