// Assembly: mscorlib.dll
// Namespace: System.Reflection
[ClassInterface(0)]
[ComDefaultInterface(typeof(_ParameterInfo))]
[ComVisible(True)]
[Serializable]
internal class RuntimeParameterInfo : ParameterInfo // TypeDefIndex: 10654
{
	// Fields
	internal MarshalAsAttribute marshalAs; // 0x40

	// Properties
	public override object DefaultValue { get; }

	// Methods

	// RVA: 0x2F3AE38 Offset: 0x2F36E38 VA: 0x2F3AE38
	internal void .ctor(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs) { }

	// RVA: 0x2F3833C Offset: 0x2F3433C VA: 0x2F3833C
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x2F3AEE0 Offset: 0x2F36EE0 VA: 0x2F3AEE0
	internal void .ctor(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x2F3B060 Offset: 0x2F37060 VA: 0x2F3B060
	internal void .ctor(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }

	// RVA: 0x2F3B0E0 Offset: 0x2F370E0 VA: 0x2F3B0E0 Slot: 13
	public override object get_DefaultValue() { }

	// RVA: 0x2F3B3F4 Offset: 0x2F373F4 VA: 0x2F3B3F4 Slot: 15
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3B450 Offset: 0x2F37450 VA: 0x2F3B450 Slot: 16
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3AF9C Offset: 0x2F36F9C VA: 0x2F3AF9C
	internal object GetDefaultValueImpl(ParameterInfo pinfo) { }

	// RVA: 0x2F3B4BC Offset: 0x2F374BC VA: 0x2F3B4BC Slot: 14
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F3B52C Offset: 0x2F3752C VA: 0x2F3B52C
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x2F3B7AC Offset: 0x2F377AC VA: 0x2F3B7AC
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	// RVA: 0x2F3BCE4 Offset: 0x2F37CE4 VA: 0x2F3BCE4
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x2F38050 Offset: 0x2F34050 VA: 0x2F38050
	internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }
}
