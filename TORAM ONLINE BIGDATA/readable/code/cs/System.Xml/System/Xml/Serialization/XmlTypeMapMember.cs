// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class XmlTypeMapMember // TypeDefIndex: 13558
{
	// Fields
	private string _name; // 0x10
	private int _index; // 0x18
	private int _globalIndex; // 0x1C
	private int _specifiedGlobalIndex; // 0x20
	private TypeData _typeData; // 0x28
	private MemberInfo _member; // 0x30
	private MemberInfo _specifiedMember; // 0x38
	private MethodInfo _shouldSerialize; // 0x40
	private object _defaultValue; // 0x48
	private int _flags; // 0x50

	// Properties
	public string Name { get; set; }
	public object DefaultValue { get; set; }
	public TypeData TypeData { get; set; }
	public int Index { get; set; }
	public int GlobalIndex { get; set; }
	public bool IsOptionalValueType { get; set; }
	public bool IsReturnValue { get; set; }

	// Methods

	// RVA: 0x340FFDC Offset: 0x340BFDC VA: 0x340FFDC
	public void .ctor() { }

	// RVA: 0x3410054 Offset: 0x340C054 VA: 0x3410054
	public string get_Name() { }

	// RVA: 0x341005C Offset: 0x340C05C VA: 0x341005C
	public void set_Name(string value) { }

	// RVA: 0x3410064 Offset: 0x340C064 VA: 0x3410064
	public object get_DefaultValue() { }

	// RVA: 0x341006C Offset: 0x340C06C VA: 0x341006C
	public void set_DefaultValue(object value) { }

	// RVA: 0x3410074 Offset: 0x340C074 VA: 0x3410074
	public bool IsReadOnly(Type type) { }

	// RVA: 0x341039C Offset: 0x340C39C VA: 0x341039C
	public static object GetValue(object ob, string name) { }

	// RVA: 0x34091D0 Offset: 0x34051D0 VA: 0x34091D0
	public object GetValue(object ob) { }

	// RVA: 0x34104B8 Offset: 0x340C4B8 VA: 0x34104B8
	public void SetValue(object ob, object value) { }

	// RVA: 0x34105EC Offset: 0x340C5EC VA: 0x34105EC
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0x3410128 Offset: 0x340C128 VA: 0x3410128
	private void InitMember(Type type) { }

	// RVA: 0x341071C Offset: 0x340C71C VA: 0x341071C
	public TypeData get_TypeData() { }

	// RVA: 0x3410724 Offset: 0x340C724 VA: 0x3410724
	public void set_TypeData(TypeData value) { }

	// RVA: 0x341072C Offset: 0x340C72C VA: 0x341072C
	public int get_Index() { }

	// RVA: 0x3410734 Offset: 0x340C734 VA: 0x3410734
	public void set_Index(int value) { }

	// RVA: 0x341073C Offset: 0x340C73C VA: 0x341073C
	public int get_GlobalIndex() { }

	// RVA: 0x3410744 Offset: 0x340C744 VA: 0x3410744
	public void set_GlobalIndex(int value) { }

	// RVA: 0x340C79C Offset: 0x340879C VA: 0x340C79C
	public bool get_IsOptionalValueType() { }

	// RVA: 0x341074C Offset: 0x340C74C VA: 0x341074C
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0x341076C Offset: 0x340C76C VA: 0x341076C
	public bool get_IsReturnValue() { }

	// RVA: 0x3410778 Offset: 0x340C778 VA: 0x3410778
	public void set_IsReturnValue(bool value) { }

	// RVA: 0x34107A8 Offset: 0x340C7A8 VA: 0x34107A8
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0x340C7A8 Offset: 0x34087A8 VA: 0x340C7A8
	public bool GetValueSpecified(object ob) { }

	// RVA: 0x3410824 Offset: 0x340C824 VA: 0x3410824
	public void SetValueSpecified(object ob, bool value) { }
}
