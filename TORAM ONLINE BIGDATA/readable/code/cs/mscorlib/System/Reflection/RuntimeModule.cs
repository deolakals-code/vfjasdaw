// Assembly: mscorlib.dll
// Namespace: System.Reflection
[ClassInterface(0)]
[ComVisible(True)]
[ComDefaultInterface(typeof(_Module))]
[Serializable]
internal class RuntimeModule : Module // TypeDefIndex: 10653
{
	// Fields
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C

	// Properties
	public override Assembly Assembly { get; }
	public override string ScopeName { get; }
	public override Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x2F3AAE0 Offset: 0x2F36AE0 VA: 0x2F3AAE0 Slot: 8
	public override Assembly get_Assembly() { }

	// RVA: 0x2F3AAE8 Offset: 0x2F36AE8 VA: 0x2F3AAE8 Slot: 10
	public override string get_ScopeName() { }

	// RVA: 0x2F3AAF0 Offset: 0x2F36AF0 VA: 0x2F3AAF0 Slot: 9
	public override Guid get_ModuleVersionId() { }

	// RVA: 0x2F3AB00 Offset: 0x2F36B00 VA: 0x2F3AB00 Slot: 11
	public override bool IsResource() { }

	// RVA: 0x2F3AB08 Offset: 0x2F36B08 VA: 0x2F3AB08 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3AB70 Offset: 0x2F36B70 VA: 0x2F3AB70 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3ABE0 Offset: 0x2F36BE0 VA: 0x2F3ABE0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F3AC50 Offset: 0x2F36C50 VA: 0x2F3AC50 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3ACE4 Offset: 0x2F36CE4 VA: 0x2F3ACE4
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x2F3AD5C Offset: 0x2F36D5C VA: 0x2F3AD5C Slot: 16
	internal override Guid GetModuleVersionId() { }

	// RVA: 0x2F3ADDC Offset: 0x2F36DDC VA: 0x2F3ADDC
	private static void GetGuidInternal(IntPtr module, byte[] guid) { }

	// RVA: 0x2F3ADE0 Offset: 0x2F36DE0 VA: 0x2F3ADE0
	public void .ctor() { }
}
