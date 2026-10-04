// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[ComVisible(True)]
[CLSCompliant(False)]
[Serializable]
public struct UIntPtr : ISerializable, IEquatable<UIntPtr> // TypeDefIndex: 9832
{
	// Fields
	public static readonly UIntPtr Zero; // 0x0
	private readonly void* _pointer; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	// RVA: 0x303F264 Offset: 0x303B264 VA: 0x303F264
	public void .ctor(ulong value) { }

	// RVA: 0x303F274 Offset: 0x303B274 VA: 0x303F274
	public void .ctor(uint value) { }

	// RVA: 0x303F280 Offset: 0x303B280 VA: 0x303F280 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x303F2F8 Offset: 0x303B2F8 VA: 0x303F2F8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x303F300 Offset: 0x303B300 VA: 0x303F300 Slot: 3
	public override string ToString() { }

	// RVA: 0x303F320 Offset: 0x303B320 VA: 0x303F320 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x303F3C0 Offset: 0x303B3C0 VA: 0x303F3C0
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0x303F3CC Offset: 0x303B3CC VA: 0x303F3CC
	public static bool op_Inequality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0x303F3D8 Offset: 0x303B3D8 VA: 0x303F3D8
	public static UIntPtr op_Explicit(ulong value) { }

	// RVA: 0x303F3DC Offset: 0x303B3DC VA: 0x303F3DC
	public static UIntPtr op_Explicit(uint value) { }

	// RVA: 0x303F26C Offset: 0x303B26C VA: 0x303F26C
	public static int get_Size() { }

	// RVA: 0x303F3E4 Offset: 0x303B3E4 VA: 0x303F3E4 Slot: 5
	private bool System.IEquatable<System.UIntPtr>.Equals(UIntPtr other) { }

	// RVA: 0x303F3F4 Offset: 0x303B3F4 VA: 0x303F3F4
	private static void .cctor() { }
}
