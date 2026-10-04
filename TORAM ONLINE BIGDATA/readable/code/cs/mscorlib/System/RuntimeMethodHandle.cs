// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[Serializable]
public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 9811
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x303611C Offset: 0x303211C VA: 0x303611C
	internal void .ctor(IntPtr v) { }

	// RVA: 0x3036124 Offset: 0x3032124 VA: 0x3036124
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30362AC Offset: 0x30322AC VA: 0x30362AC
	public IntPtr get_Value() { }

	// RVA: 0x30362B4 Offset: 0x30322B4 VA: 0x30362B4 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3036444 Offset: 0x3032444 VA: 0x3036444 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3036540 Offset: 0x3032540 VA: 0x3036540 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3036548 Offset: 0x3032548 VA: 0x3036548
	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	// RVA: 0x30366A0 Offset: 0x30326A0 VA: 0x30366A0
	internal bool IsNullHandle() { }
}
