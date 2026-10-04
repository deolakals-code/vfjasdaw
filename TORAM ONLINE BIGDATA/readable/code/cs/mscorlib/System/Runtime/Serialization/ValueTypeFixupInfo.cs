// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
internal sealed class ValueTypeFixupInfo // TypeDefIndex: 10348
{
	// Fields
	private readonly long _containerID; // 0x10
	private readonly FieldInfo _parentField; // 0x18
	private readonly int[] _parentIndex; // 0x20

	// Properties
	public long ContainerID { get; }
	public FieldInfo ParentField { get; }
	public int[] ParentIndex { get; }

	// Methods

	// RVA: 0x2EFBEC4 Offset: 0x2EF7EC4 VA: 0x2EFBEC4
	public void .ctor(long containerID, FieldInfo member, int[] parentIndex) { }

	// RVA: 0x2EFC03C Offset: 0x2EF803C VA: 0x2EFC03C
	public long get_ContainerID() { }

	// RVA: 0x2EFC044 Offset: 0x2EF8044 VA: 0x2EFC044
	public FieldInfo get_ParentField() { }

	// RVA: 0x2EFC04C Offset: 0x2EF804C VA: 0x2EFC04C
	public int[] get_ParentIndex() { }
}
