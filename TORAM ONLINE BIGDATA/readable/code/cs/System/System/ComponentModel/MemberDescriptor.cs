// Assembly: System.dll
// Namespace: System.ComponentModel
[ComVisible(True)]
public abstract class MemberDescriptor // TypeDefIndex: 14254
{
	// Fields
	private string name; // 0x10
	private string displayName; // 0x18
	private int nameHash; // 0x20
	private AttributeCollection attributeCollection; // 0x28
	private Attribute[] attributes; // 0x30
	private Attribute[] originalAttributes; // 0x38
	private bool attributesFiltered; // 0x40
	private bool attributesFilled; // 0x41
	private int metadataVersion; // 0x44
	private string category; // 0x48
	private string description; // 0x50
	private object lockCookie; // 0x58

	// Properties
	protected virtual Attribute[] AttributeArray { get; set; }
	public virtual AttributeCollection Attributes { get; }
	public virtual string Name { get; }
	protected virtual int NameHashCode { get; }
	public virtual string DisplayName { get; }

	// Methods

	// RVA: 0x34AD7E8 Offset: 0x34A97E8 VA: 0x34AD7E8
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x34AD9C0 Offset: 0x34A99C0 VA: 0x34AD9C0
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x34B7268 Offset: 0x34B3268 VA: 0x34B7268 Slot: 4
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x34B7AC0 Offset: 0x34B3AC0 VA: 0x34B7AC0 Slot: 5
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x34B7BB4 Offset: 0x34B3BB4 VA: 0x34B7BB4 Slot: 6
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x34B7CB0 Offset: 0x34B3CB0 VA: 0x34B7CB0 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x34B7D00 Offset: 0x34B3D00 VA: 0x34B7D00 Slot: 8
	protected virtual int get_NameHashCode() { }

	// RVA: 0x34AA150 Offset: 0x34A6150 VA: 0x34AA150 Slot: 9
	public virtual string get_DisplayName() { }

	// RVA: 0x34B7288 Offset: 0x34B3288 VA: 0x34B7288
	private void CheckAttributesValid() { }

	// RVA: 0x34B7D08 Offset: 0x34B3D08 VA: 0x34B7D08 Slot: 10
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x34B7D78 Offset: 0x34B3D78 VA: 0x34B7D78 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34AE720 Offset: 0x34AA720 VA: 0x34AE720 Slot: 11
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x34B7350 Offset: 0x34B3350 VA: 0x34B7350
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x34B7FEC Offset: 0x34B3FEC VA: 0x34B7FEC
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x34B7FF4 Offset: 0x34B3FF4 VA: 0x34B7FF4
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x34B8098 Offset: 0x34B4098 VA: 0x34B8098 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34AE948 Offset: 0x34AA948 VA: 0x34AE948 Slot: 12
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x34AA278 Offset: 0x34A6278 VA: 0x34AA278
	protected static ISite GetSite(object component) { }
}
