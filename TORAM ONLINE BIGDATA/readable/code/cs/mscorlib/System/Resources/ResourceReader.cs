// Assembly: mscorlib.dll
// Namespace: System.Resources
[ComVisible(True)]
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 10565
{
	// Fields
	private BinaryReader _store; // 0x10
	internal Dictionary<string, ResourceLocator> _resCache; // 0x18
	private long _nameSectionOffset; // 0x20
	private long _dataSectionOffset; // 0x28
	private int[] _nameHashes; // 0x30
	private int* _nameHashesPtr; // 0x38
	private int[] _namePositions; // 0x40
	private int* _namePositionsPtr; // 0x48
	private RuntimeType[] _typeTable; // 0x50
	private int[] _typeNamePositions; // 0x58
	private BinaryFormatter _objFormatter; // 0x60
	private int _numResources; // 0x68
	private UnmanagedMemoryStream _ums; // 0x70
	private int _version; // 0x78

	// Methods

	// RVA: 0x2F22ABC Offset: 0x2F1EABC VA: 0x2F22ABC
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0x2F22E8C Offset: 0x2F1EE8C VA: 0x2F22E8C Slot: 4
	public void Close() { }

	// RVA: 0x2F259C0 Offset: 0x2F219C0 VA: 0x2F259C0 Slot: 7
	public void Dispose() { }

	// RVA: 0x2F25918 Offset: 0x2F21918 VA: 0x2F25918
	private void Dispose(bool disposing) { }

	// RVA: 0x2F259C8 Offset: 0x2F219C8 VA: 0x2F259C8
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0x2F259D0 Offset: 0x2F219D0 VA: 0x2F259D0
	private void SkipString() { }

	// RVA: 0x2F25A80 Offset: 0x2F21A80 VA: 0x2F25A80
	private int GetNameHash(int index) { }

	// RVA: 0x2F25AC4 Offset: 0x2F21AC4 VA: 0x2F25AC4
	private int GetNamePosition(int index) { }

	// RVA: 0x2F25BDC Offset: 0x2F21BDC VA: 0x2F25BDC Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2F25BE0 Offset: 0x2F21BE0 VA: 0x2F25BE0 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2F2418C Offset: 0x2F2018C VA: 0x2F2418C
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0x2F23A78 Offset: 0x2F1FA78 VA: 0x2F23A78
	internal int FindPosForResource(string name) { }

	// RVA: 0x2F25CF4 Offset: 0x2F21CF4 VA: 0x2F25CF4
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0x2F25EF8 Offset: 0x2F21EF8 VA: 0x2F25EF8
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0x2F266E0 Offset: 0x2F226E0 VA: 0x2F266E0
	private object GetValueForNameIndex(int index) { }

	// RVA: 0x2F23E30 Offset: 0x2F1FE30 VA: 0x2F23E30
	internal string LoadString(int pos) { }

	// RVA: 0x2F26F30 Offset: 0x2F22F30 VA: 0x2F26F30
	internal object LoadObject(int pos) { }

	// RVA: 0x2F240D8 Offset: 0x2F200D8 VA: 0x2F240D8
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x2F26988 Offset: 0x2F22988 VA: 0x2F26988
	internal object LoadObjectV1(int pos) { }

	// RVA: 0x2F26F5C Offset: 0x2F22F5C VA: 0x2F26F5C
	private object _LoadObjectV1(int pos) { }

	// RVA: 0x2F26A80 Offset: 0x2F22A80 VA: 0x2F26A80
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x2F27974 Offset: 0x2F23974 VA: 0x2F27974
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x2F277A4 Offset: 0x2F237A4 VA: 0x2F277A4
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0x2F257A8 Offset: 0x2F217A8 VA: 0x2F257A8
	private void ReadResources() { }

	// RVA: 0x2F28090 Offset: 0x2F24090 VA: 0x2F28090
	private void _ReadResources() { }

	// RVA: 0x2F26B78 Offset: 0x2F22B78 VA: 0x2F26B78
	private RuntimeType FindType(int typeIndex) { }
}
