// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 10610
{
	// Fields
	protected ParameterAttributes AttrsImpl; // 0x10
	protected Type ClassImpl; // 0x18
	protected object DefaultValueImpl; // 0x20
	protected MemberInfo MemberImpl; // 0x28
	protected string NameImpl; // 0x30
	protected int PositionImpl; // 0x38
	private const int MetadataToken_ParamDef = 134217728;

	// Properties
	public virtual ParameterAttributes Attributes { get; }
	public virtual MemberInfo Member { get; }
	public virtual string Name { get; }
	public virtual Type ParameterType { get; }
	public virtual int Position { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x2F2C8AC Offset: 0x2F288AC VA: 0x2F2C8AC
	protected void .ctor() { }

	// RVA: 0x2F2C8B4 Offset: 0x2F288B4 VA: 0x2F2C8B4 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x2F2C8BC Offset: 0x2F288BC VA: 0x2F2C8BC Slot: 9
	public virtual MemberInfo get_Member() { }

	// RVA: 0x2F2C8C4 Offset: 0x2F288C4 VA: 0x2F2C8C4 Slot: 10
	public virtual string get_Name() { }

	// RVA: 0x2F2C8CC Offset: 0x2F288CC VA: 0x2F2C8CC Slot: 11
	public virtual Type get_ParameterType() { }

	// RVA: 0x2F2C8D4 Offset: 0x2F288D4 VA: 0x2F2C8D4 Slot: 12
	public virtual int get_Position() { }

	// RVA: 0x2F2C8DC Offset: 0x2F288DC VA: 0x2F2C8DC
	public bool get_IsIn() { }

	// RVA: 0x2F2C8F8 Offset: 0x2F288F8 VA: 0x2F2C8F8
	public bool get_IsOptional() { }

	// RVA: 0x2F2C914 Offset: 0x2F28914 VA: 0x2F2C914
	public bool get_IsOut() { }

	// RVA: 0x2F2C930 Offset: 0x2F28930 VA: 0x2F2C930 Slot: 13
	public virtual object get_DefaultValue() { }

	// RVA: 0x2F2C958 Offset: 0x2F28958 VA: 0x2F2C958 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F2CA08 Offset: 0x2F28A08 VA: 0x2F2CA08 Slot: 15
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F2CA94 Offset: 0x2F28A94 VA: 0x2F2CA94 Slot: 16
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F2CBA4 Offset: 0x2F28BA4 VA: 0x2F2CBA4 Slot: 7
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x2F2CE00 Offset: 0x2F28E00 VA: 0x2F2CE00 Slot: 3
	public override string ToString() { }
}
