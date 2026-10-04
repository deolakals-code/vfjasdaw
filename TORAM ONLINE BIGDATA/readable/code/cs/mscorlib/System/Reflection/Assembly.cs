// Assembly: mscorlib.dll
// Namespace: System.Reflection
[ClassInterface(0)]
[ComVisible(True)]
[ComDefaultInterface(typeof(_Assembly))]
[Serializable]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 10639
{
	// Properties
	public virtual string CodeBase { get; }
	public virtual string FullName { get; }
	internal virtual IntPtr MonoAssembly { get; }
	[MonoTODO]
	public bool IsFullyTrusted { get; }

	// Methods

	// RVA: 0x2F32D08 Offset: 0x2F2ED08 VA: 0x2F32D08 Slot: 8
	public virtual string get_CodeBase() { }

	// RVA: 0x2F32D40 Offset: 0x2F2ED40 VA: 0x2F32D40 Slot: 9
	public virtual string get_FullName() { }

	// RVA: 0x2F32D78 Offset: 0x2F2ED78 VA: 0x2F32D78 Slot: 10
	internal virtual IntPtr get_MonoAssembly() { }

	// RVA: 0x2F32DB0 Offset: 0x2F2EDB0 VA: 0x2F32DB0 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F32DE8 Offset: 0x2F2EDE8 VA: 0x2F32DE8 Slot: 12
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F32E20 Offset: 0x2F2EE20 VA: 0x2F32E20 Slot: 13
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F32E58 Offset: 0x2F2EE58 VA: 0x2F32E58 Slot: 14
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F32E90 Offset: 0x2F2EE90 VA: 0x2F32E90 Slot: 15
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x2F32E98 Offset: 0x2F2EE98 VA: 0x2F32E98 Slot: 16
	public virtual Type[] GetTypes() { }

	// RVA: 0x2F32EAC Offset: 0x2F2EEAC VA: 0x2F32EAC Slot: 17
	public virtual Type GetType(string name) { }

	// RVA: 0x2F32EC4 Offset: 0x2F2EEC4 VA: 0x2F32EC4
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x2F32ED0 Offset: 0x2F2EED0 VA: 0x2F32ED0 Slot: 18
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x2F32F08 Offset: 0x2F2EF08 VA: 0x2F32F08 Slot: 19
	public virtual AssemblyName GetName() { }

	// RVA: 0x2F32F1C Offset: 0x2F2EF1C VA: 0x2F32F1C Slot: 3
	public override string ToString() { }

	// RVA: 0x2F32F24 Offset: 0x2F2EF24 VA: 0x2F32F24
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x2F32FE8 Offset: 0x2F2EFE8 VA: 0x2F32FE8
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x2F33010 Offset: 0x2F2F010 VA: 0x2F33010
	public static Assembly ReflectionOnlyLoad(string assemblyString) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2F33058 Offset: 0x2F2F058 VA: 0x2F33058
	public static Assembly LoadWithPartialName(string partialName) { }

	// RVA: 0x2F3306C Offset: 0x2F2F06C VA: 0x2F3306C
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2F33064 Offset: 0x2F2F064 VA: 0x2F33064
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x2F33070 Offset: 0x2F2F070 VA: 0x2F33070
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x2F330D8 Offset: 0x2F2F0D8 VA: 0x2F330D8 Slot: 20
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x2F33110 Offset: 0x2F2F110 VA: 0x2F33110
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x2F33150 Offset: 0x2F2F150 VA: 0x2F33150
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x2F33154 Offset: 0x2F2F154 VA: 0x2F33154 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F3315C Offset: 0x2F2F15C VA: 0x2F3315C Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2F33164 Offset: 0x2F2F164 VA: 0x2F33164
	private static Exception CreateNIE() { }

	// RVA: 0x2F331D0 Offset: 0x2F2F1D0 VA: 0x2F331D0
	public bool get_IsFullyTrusted() { }

	// RVA: 0x2F331D8 Offset: 0x2F2F1D8 VA: 0x2F331D8 Slot: 21
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x2F331FC Offset: 0x2F2F1FC VA: 0x2F331FC Slot: 22
	public virtual Module GetModule(string name) { }

	// RVA: 0x2F33220 Offset: 0x2F2F220 VA: 0x2F33220 Slot: 23
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x2F33244 Offset: 0x2F2F244 VA: 0x2F33244
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x2F33294 Offset: 0x2F2F294 VA: 0x2F33294
	public static bool op_Inequality(Assembly left, Assembly right) { }

	// RVA: 0x2F332EC Offset: 0x2F2F2EC VA: 0x2F332EC
	public void .ctor() { }
}
