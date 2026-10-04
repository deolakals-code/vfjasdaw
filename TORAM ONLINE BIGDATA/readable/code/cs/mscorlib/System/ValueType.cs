// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[Serializable]
public abstract class ValueType // TypeDefIndex: 9833
{
	// Methods

	// RVA: 0x303F43C Offset: 0x303B43C VA: 0x303F43C
	protected void .ctor() { }

	// RVA: 0x303F444 Offset: 0x303B444 VA: 0x303F444
	private static bool InternalEquals(object o1, object o2, out object[] fields) { }

	// RVA: 0x303F448 Offset: 0x303B448 VA: 0x303F448
	internal static bool DefaultEquals(object o1, object o2) { }

	// RVA: 0x303F5F8 Offset: 0x303B5F8 VA: 0x303F5F8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x303F5FC Offset: 0x303B5FC VA: 0x303F5FC
	internal static int InternalGetHashCode(object o, out object[] fields) { }

	// RVA: 0x303F600 Offset: 0x303B600 VA: 0x303F600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x303F678 Offset: 0x303B678 VA: 0x303F678 Slot: 3
	public override string ToString() { }
}
