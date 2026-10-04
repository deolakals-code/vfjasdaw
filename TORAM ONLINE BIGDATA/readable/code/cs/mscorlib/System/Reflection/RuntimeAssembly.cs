// Assembly: mscorlib.dll
// Namespace: System.Reflection
[ComDefaultInterface(typeof(_Assembly))]
[ClassInterface(0)]
[ComVisible(True)]
[Serializable]
internal class RuntimeAssembly : Assembly // TypeDefIndex: 10645
{
	// Fields
	internal IntPtr _mono_assembly; // 0x10
	private object _evidence; // 0x18
	internal Assembly.ResolveEventHolder resolve_event_holder; // 0x20
	private object _minimum; // 0x28
	private object _optional; // 0x30
	private object _refuse; // 0x38
	private object _granted; // 0x40
	private object _denied; // 0x48
	internal bool fromByteArray; // 0x50
	internal string assemblyName; // 0x58

	// Properties
	public override string CodeBase { get; }
	public override string FullName { get; }
	internal override IntPtr MonoAssembly { get; }

	// Methods

	// RVA: 0x2F36388 Offset: 0x2F32388 VA: 0x2F36388
	protected void .ctor() { }

	// RVA: 0x2F363F4 Offset: 0x2F323F4 VA: 0x2F363F4 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3647C Offset: 0x2F3247C VA: 0x2F3647C
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x2F36504 Offset: 0x2F32504 VA: 0x2F36504
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x2F3652C Offset: 0x2F3252C VA: 0x2F3652C Slot: 18
	public override AssemblyName GetName(bool copiedName) { }

	// RVA: 0x2F36534 Offset: 0x2F32534 VA: 0x2F36534 Slot: 21
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x2F365EC Offset: 0x2F325EC VA: 0x2F365EC Slot: 22
	public override Module GetModule(string name) { }

	// RVA: 0x2F36714 Offset: 0x2F32714 VA: 0x2F36714 Slot: 23
	public override Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x2F368B0 Offset: 0x2F328B0 VA: 0x2F368B0
	internal static byte[] GetAotId() { }

	// RVA: 0x2F3690C Offset: 0x2F3290C VA: 0x2F3690C
	private static string get_code_base(Assembly a, bool escaped) { }

	// RVA: 0x2F36914 Offset: 0x2F32914 VA: 0x2F36914
	internal static string get_fullname(Assembly a) { }

	// RVA: 0x2F36908 Offset: 0x2F32908 VA: 0x2F36908
	internal static bool GetAotIdInternal(byte[] aotid) { }

	// RVA: 0x2F36918 Offset: 0x2F32918 VA: 0x2F36918
	internal static string GetCodeBase(Assembly a, bool escaped) { }

	// RVA: 0x2F36920 Offset: 0x2F32920 VA: 0x2F36920 Slot: 8
	public override string get_CodeBase() { }

	// RVA: 0x2F36928 Offset: 0x2F32928 VA: 0x2F36928 Slot: 9
	public override string get_FullName() { }

	// RVA: 0x2F3692C Offset: 0x2F3292C VA: 0x2F3692C Slot: 10
	internal override IntPtr get_MonoAssembly() { }

	// RVA: 0x2F36934 Offset: 0x2F32934 VA: 0x2F36934
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x2F36938 Offset: 0x2F32938 VA: 0x2F36938 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F369A8 Offset: 0x2F329A8 VA: 0x2F369A8 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F36A10 Offset: 0x2F32A10 VA: 0x2F36A10 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F36A80 Offset: 0x2F32A80 VA: 0x2F36A80 Slot: 20
	internal override Module[] GetModulesInternal() { }

	// RVA: 0x2F36A84 Offset: 0x2F32A84 VA: 0x2F36A84 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F36A8C Offset: 0x2F32A8C VA: 0x2F36A8C Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2F36B2C Offset: 0x2F32B2C VA: 0x2F36B2C Slot: 3
	public override string ToString() { }
}
