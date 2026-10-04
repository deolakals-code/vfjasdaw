// Assembly: mscorlib.dll
// Namespace: System
[ClassInterface(2)]
[ComVisible(True)]
[Serializable]
public class Object // TypeDefIndex: 9807
{
	// Methods

	// RVA: 0x3035C6C Offset: 0x3031C6C VA: 0x3035C6C Slot: 0
	public virtual bool Equals(object obj) { }

	// RVA: 0x3035C78 Offset: 0x3031C78 VA: 0x3035C78
	public static bool Equals(object objA, object objB) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x3027DCC Offset: 0x3023DCC VA: 0x3027DCC
	public void .ctor() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3035CA4 Offset: 0x3031CA4 VA: 0x3035CA4 Slot: 1
	protected virtual void Finalize() { }

	// RVA: 0x3035CA8 Offset: 0x3031CA8 VA: 0x3035CA8 Slot: 2
	public virtual int GetHashCode() { }

	// RVA: 0x3028594 Offset: 0x3024594 VA: 0x3028594
	public Type GetType() { }

	// RVA: 0x30300C0 Offset: 0x302C0C0 VA: 0x30300C0
	protected object MemberwiseClone() { }

	// RVA: 0x3035CB0 Offset: 0x3031CB0 VA: 0x3035CB0 Slot: 3
	public virtual string ToString() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3035CD0 Offset: 0x3031CD0 VA: 0x3035CD0
	public static bool ReferenceEquals(object objA, object objB) { }

	// RVA: 0x3035CAC Offset: 0x3031CAC VA: 0x3035CAC
	internal static int InternalGetHashCode(object o) { }

	// RVA: 0x3035CDC Offset: 0x3031CDC VA: 0x3035CDC
	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	// RVA: 0x3035CE0 Offset: 0x3031CE0 VA: 0x3035CE0
	private void FieldSetter(string typeName, string fieldName, object val) { }
}
