// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
internal sealed class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 10647
{
	// Fields
	private IntPtr klass; // 0x18
	private IntPtr handle; // 0x20

	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x2F36B74 Offset: 0x2F32B74 VA: 0x2F36B74
	private static void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info) { }

	// RVA: 0x2F36B78 Offset: 0x2F32B78 VA: 0x2F36B78
	internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev) { }

	// RVA: 0x2F36BB4 Offset: 0x2F32BB4 VA: 0x2F36BB4 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x2F36BD4 Offset: 0x2F32BD4 VA: 0x2F36BD4
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x2F36D5C Offset: 0x2F32D5C VA: 0x2F36D5C
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x2F36DE0 Offset: 0x2F32DE0 VA: 0x2F36DE0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x2F36BB8 Offset: 0x2F32BB8 VA: 0x2F36BB8
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x2F36E64 Offset: 0x2F32E64 VA: 0x2F36E64 Slot: 23
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F36BD8 Offset: 0x2F32BD8 VA: 0x2F36BD8
	internal BindingFlags GetBindingFlags() { }

	// RVA: 0x2F36EFC Offset: 0x2F32EFC VA: 0x2F36EFC Slot: 17
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x2F36F6C Offset: 0x2F32F6C VA: 0x2F36F6C Slot: 19
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x2F36FDC Offset: 0x2F32FDC VA: 0x2F36FDC Slot: 18
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x2F3704C Offset: 0x2F3304C VA: 0x2F3704C Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F37078 Offset: 0x2F33078 VA: 0x2F37078 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F370A4 Offset: 0x2F330A4 VA: 0x2F370A4 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F370D0 Offset: 0x2F330D0 VA: 0x2F370D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F37160 Offset: 0x2F33160 VA: 0x2F37160 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F371D0 Offset: 0x2F331D0 VA: 0x2F371D0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F37238 Offset: 0x2F33238 VA: 0x2F37238 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F372A8 Offset: 0x2F332A8 VA: 0x2F372A8 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x2F372AC Offset: 0x2F332AC VA: 0x2F372AC
	internal static int get_metadata_token(RuntimeEventInfo monoEvent) { }

	// RVA: 0x2F372B0 Offset: 0x2F332B0 VA: 0x2F372B0
	public void .ctor() { }
}
