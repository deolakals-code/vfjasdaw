// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
public sealed class SerializationInfoEnumerator : IEnumerator // TypeDefIndex: 10336
{
	// Fields
	private readonly string[] _members; // 0x10
	private readonly object[] _data; // 0x18
	private readonly Type[] _types; // 0x20
	private readonly int _numItems; // 0x28
	private int _currItem; // 0x2C
	private bool _current; // 0x30

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public SerializationEntry Current { get; }
	public string Name { get; }
	public object Value { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x2EFA9CC Offset: 0x2EF69CC VA: 0x2EFA9CC
	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	// RVA: 0x2EEC31C Offset: 0x2EE831C VA: 0x2EEC31C Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2EFAA44 Offset: 0x2EF6A44 VA: 0x2EFAA44 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2EF3D5C Offset: 0x2EEFD5C VA: 0x2EF3D5C
	public SerializationEntry get_Current() { }

	// RVA: 0x2EFAABC Offset: 0x2EF6ABC VA: 0x2EFAABC Slot: 6
	public void Reset() { }

	// RVA: 0x2EEC1A4 Offset: 0x2EE81A4 VA: 0x2EEC1A4
	public string get_Name() { }

	// RVA: 0x2EEC228 Offset: 0x2EE8228 VA: 0x2EEC228
	public object get_Value() { }

	// RVA: 0x2EFAACC Offset: 0x2EF6ACC VA: 0x2EFAACC
	public Type get_ObjectType() { }
}
