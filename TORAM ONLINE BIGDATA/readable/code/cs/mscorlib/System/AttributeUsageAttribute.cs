// Assembly: mscorlib.dll
// Namespace: System
[Usage(4, Inherited = True)]
[Serializable]
public sealed class AttributeUsageAttribute : Attribute // TypeDefIndex: 9554
{
	// Fields
	private AttributeTargets _attributeTarget; // 0x10
	private bool _allowMultiple; // 0x14
	private bool _inherited; // 0x15
	internal static AttributeUsageAttribute Default; // 0x0

	// Properties
	public bool AllowMultiple { get; set; }
	public bool Inherited { get; set; }

	// Methods

	// RVA: 0x2F73198 Offset: 0x2F6F198 VA: 0x2F73198
	public void .ctor(AttributeTargets validOn) { }

	// RVA: 0x2F731D0 Offset: 0x2F6F1D0 VA: 0x2F731D0
	public bool get_AllowMultiple() { }

	// RVA: 0x2F731D8 Offset: 0x2F6F1D8 VA: 0x2F731D8
	public void set_AllowMultiple(bool value) { }

	// RVA: 0x2F731E4 Offset: 0x2F6F1E4 VA: 0x2F731E4
	public bool get_Inherited() { }

	// RVA: 0x2F731EC Offset: 0x2F6F1EC VA: 0x2F731EC
	public void set_Inherited(bool value) { }

	// RVA: 0x2F731F8 Offset: 0x2F6F1F8 VA: 0x2F731F8
	private static void .cctor() { }
}
