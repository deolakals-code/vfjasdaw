// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public sealed class SerializationInfo // TypeDefIndex: 10370
{
	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x2F045B8 Offset: 0x2F005B8 VA: 0x2F045B8
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliant(False)]
	// RVA: 0x2F045C0 Offset: 0x2F005C0 VA: 0x2F045C0
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x2F047FC Offset: 0x2F007FC VA: 0x2F047FC
	public string get_FullTypeName() { }

	// RVA: 0x2F04804 Offset: 0x2F00804 VA: 0x2F04804
	public string get_AssemblyName() { }

	// RVA: 0x2EEC688 Offset: 0x2EE8688 VA: 0x2EEC688
	public void SetType(Type type) { }

	// RVA: 0x2F04810 Offset: 0x2F00810 VA: 0x2F04810
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x2F0480C Offset: 0x2F0080C VA: 0x2F0480C
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x2F048A4 Offset: 0x2F008A4 VA: 0x2F048A4
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x2F049D8 Offset: 0x2F009D8 VA: 0x2F049D8
	public int get_MemberCount() { }

	// RVA: 0x2F049E0 Offset: 0x2F009E0 VA: 0x2F049E0
	public Type get_ObjectType() { }

	// RVA: 0x2F049E8 Offset: 0x2F009E8 VA: 0x2F049E8
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x2F049F0 Offset: 0x2F009F0 VA: 0x2F049F0
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x2EEC12C Offset: 0x2EE812C VA: 0x2EEC12C
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x2F049F8 Offset: 0x2F009F8 VA: 0x2F049F8
	private void ExpandArrays() { }

	// RVA: 0x2F03AF4 Offset: 0x2EFFAF4 VA: 0x2F03AF4
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x2EEC7E0 Offset: 0x2EE87E0 VA: 0x2EEC7E0
	public void AddValue(string name, object value) { }

	// RVA: 0x2EEC898 Offset: 0x2EE8898 VA: 0x2EEC898
	public void AddValue(string name, bool value) { }

	// RVA: 0x2F04D0C Offset: 0x2F00D0C VA: 0x2F04D0C
	public void AddValue(string name, byte value) { }

	// RVA: 0x2F04DE0 Offset: 0x2F00DE0 VA: 0x2F04DE0
	public void AddValue(string name, short value) { }

	// RVA: 0x2EF8C50 Offset: 0x2EF4C50 VA: 0x2EF8C50
	public void AddValue(string name, int value) { }

	// RVA: 0x2F04EB4 Offset: 0x2F00EB4 VA: 0x2F04EB4
	public void AddValue(string name, long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F04F88 Offset: 0x2F00F88 VA: 0x2F04F88
	public void AddValue(string name, ulong value) { }

	// RVA: 0x2F0505C Offset: 0x2F0105C VA: 0x2F0505C
	public void AddValue(string name, float value) { }

	// RVA: 0x2F05138 Offset: 0x2F01138 VA: 0x2F05138
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x2F04B40 Offset: 0x2F00B40 VA: 0x2F04B40
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x2F00D94 Offset: 0x2EFCD94 VA: 0x2F00D94
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x2F0520C Offset: 0x2F0120C VA: 0x2F0520C
	private int FindElement(string name) { }

	// RVA: 0x2F052D0 Offset: 0x2F012D0 VA: 0x2F052D0
	private object GetElement(string name, out Type foundType) { }

	[ComVisible(True)]
	// RVA: 0x2F053E0 Offset: 0x2F013E0 VA: 0x2F053E0
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x2F03754 Offset: 0x2EFF754 VA: 0x2F03754
	public object GetValue(string name, Type type) { }

	[ComVisible(True)]
	// RVA: 0x2F0364C Offset: 0x2EFF64C VA: 0x2F0364C
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x2F0547C Offset: 0x2F0147C VA: 0x2F0547C
	public bool GetBoolean(string name) { }

	// RVA: 0x2F055FC Offset: 0x2F015FC VA: 0x2F055FC
	public int GetInt32(string name) { }

	// RVA: 0x2F05770 Offset: 0x2F01770 VA: 0x2F05770
	public long GetInt64(string name) { }

	// RVA: 0x2F058E4 Offset: 0x2F018E4 VA: 0x2F058E4
	public float GetSingle(string name) { }

	// RVA: 0x2F05A58 Offset: 0x2F01A58 VA: 0x2F05A58
	public string GetString(string name) { }
}
