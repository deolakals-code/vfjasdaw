// Assembly: System.dll
// Namespace: System.ComponentModel
public abstract class PropertyDescriptor : MemberDescriptor // TypeDefIndex: 14222
{
	// Fields
	private TypeConverter _converter; // 0x60
	private Hashtable _valueChangedHandlers; // 0x68
	private object[] _editors; // 0x70
	private Type[] _editorTypes; // 0x78
	private int _editorCount; // 0x80

	// Properties
	public abstract Type ComponentType { get; }
	public virtual TypeConverter Converter { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: 0x34AD7E4 Offset: 0x34A97E4 VA: 0x34AD7E4
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x34A9AD4 Offset: 0x34A5AD4 VA: 0x34A9AD4
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Type get_ComponentType();

	// RVA: 0x34ADE38 Offset: 0x34A9E38 VA: 0x34ADE38 Slot: 14
	public virtual TypeConverter get_Converter() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool CanResetValue(object component);

	// RVA: 0x34AE4CC Offset: 0x34AA4CC VA: 0x34AE4CC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34AE2A8 Offset: 0x34AA2A8 VA: 0x34AE2A8
	protected object CreateInstance(Type type) { }

	// RVA: 0x34AE6CC Offset: 0x34AA6CC VA: 0x34AE6CC Slot: 11
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x34AE814 Offset: 0x34AA814 VA: 0x34AE814 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34AE868 Offset: 0x34AA868 VA: 0x34AE868 Slot: 12
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x34AE0AC Offset: 0x34AA0AC VA: 0x34AE0AC
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract object GetValue(object component);

	// RVA: 0x34AEA54 Offset: 0x34AAA54 VA: 0x34AEA54 Slot: 19
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ResetValue(object component);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void SetValue(object component, object value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool ShouldSerializeValue(object component);
}
