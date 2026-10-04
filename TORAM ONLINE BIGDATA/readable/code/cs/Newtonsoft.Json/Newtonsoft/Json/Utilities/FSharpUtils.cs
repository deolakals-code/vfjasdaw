// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal class FSharpUtils // TypeDefIndex: 15926
{
	// Fields
	private static readonly object Lock; // 0x0
	[Nullable(2)]
	private static FSharpUtils _instance; // 0x8
	private MethodInfo _ofSeq; // 0x10
	private Type _mapType; // 0x18
	[CompilerGenerated]
	private Assembly <FSharpCoreAssembly>k__BackingField; // 0x20
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <IsUnion>k__BackingField; // 0x28
	[CompilerGenerated]
	[Nullable(new[] { 1, 2, 1 })]
	private MethodCall<object, object> <GetUnionCases>k__BackingField; // 0x30
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionTagReader>k__BackingField; // 0x38
	[CompilerGenerated]
	[Nullable(new[] { 1, 2, 1 })]
	private MethodCall<object, object> <PreComputeUnionReader>k__BackingField; // 0x40
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionConstructor>k__BackingField; // 0x48
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoDeclaringType>k__BackingField; // 0x50
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoName>k__BackingField; // 0x58
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoTag>k__BackingField; // 0x60
	[Nullable(new[] { 1, 1, 2 })]
	[CompilerGenerated]
	private MethodCall<object, object> <GetUnionCaseInfoFields>k__BackingField; // 0x68

	// Properties
	public static FSharpUtils Instance { get; }
	private Assembly FSharpCoreAssembly { set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> IsUnion { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> GetUnionCases { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionTagReader { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionReader { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionConstructor { get; set; }
	public Func<object, object> GetUnionCaseInfoDeclaringType { get; set; }
	public Func<object, object> GetUnionCaseInfoName { get; set; }
	public Func<object, object> GetUnionCaseInfoTag { get; set; }
	[Nullable(new[] { 1, 1, 2 })]
	public MethodCall<object, object> GetUnionCaseInfoFields { get; set; }

	// Methods

	// RVA: 0x308EEE4 Offset: 0x308AEE4 VA: 0x308EEE4
	private void .ctor(Assembly fsharpCoreAssembly) { }

	// RVA: 0x308F6B0 Offset: 0x308B6B0 VA: 0x308F6B0
	public static FSharpUtils get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x308F708 Offset: 0x308B708 VA: 0x308F708
	private void set_FSharpCoreAssembly(Assembly value) { }

	[CompilerGenerated]
	// RVA: 0x308F710 Offset: 0x308B710 VA: 0x308F710
	public MethodCall<object, object> get_IsUnion() { }

	[CompilerGenerated]
	// RVA: 0x308F718 Offset: 0x308B718 VA: 0x308F718
	private void set_IsUnion(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x308F720 Offset: 0x308B720 VA: 0x308F720
	public MethodCall<object, object> get_GetUnionCases() { }

	[CompilerGenerated]
	// RVA: 0x308F728 Offset: 0x308B728 VA: 0x308F728
	private void set_GetUnionCases(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x308F730 Offset: 0x308B730 VA: 0x308F730
	public MethodCall<object, object> get_PreComputeUnionTagReader() { }

	[CompilerGenerated]
	// RVA: 0x308F738 Offset: 0x308B738 VA: 0x308F738
	private void set_PreComputeUnionTagReader(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x308F740 Offset: 0x308B740 VA: 0x308F740
	public MethodCall<object, object> get_PreComputeUnionReader() { }

	[CompilerGenerated]
	// RVA: 0x308F748 Offset: 0x308B748 VA: 0x308F748
	private void set_PreComputeUnionReader(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x308F750 Offset: 0x308B750 VA: 0x308F750
	public MethodCall<object, object> get_PreComputeUnionConstructor() { }

	[CompilerGenerated]
	// RVA: 0x308F758 Offset: 0x308B758 VA: 0x308F758
	private void set_PreComputeUnionConstructor(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x308F760 Offset: 0x308B760 VA: 0x308F760
	public Func<object, object> get_GetUnionCaseInfoDeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x308F768 Offset: 0x308B768 VA: 0x308F768
	private void set_GetUnionCaseInfoDeclaringType(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x308F770 Offset: 0x308B770 VA: 0x308F770
	public Func<object, object> get_GetUnionCaseInfoName() { }

	[CompilerGenerated]
	// RVA: 0x308F778 Offset: 0x308B778 VA: 0x308F778
	private void set_GetUnionCaseInfoName(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x308F780 Offset: 0x308B780 VA: 0x308F780
	public Func<object, object> get_GetUnionCaseInfoTag() { }

	[CompilerGenerated]
	// RVA: 0x308F788 Offset: 0x308B788 VA: 0x308F788
	private void set_GetUnionCaseInfoTag(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x308F790 Offset: 0x308B790 VA: 0x308F790
	public MethodCall<object, object> get_GetUnionCaseInfoFields() { }

	[CompilerGenerated]
	// RVA: 0x308F798 Offset: 0x308B798 VA: 0x308F798
	private void set_GetUnionCaseInfoFields(MethodCall<object, object> value) { }

	// RVA: 0x308F7A0 Offset: 0x308B7A0 VA: 0x308F7A0
	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	// RVA: 0x308F440 Offset: 0x308B440 VA: 0x308F440
	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	// RVA: 0x308F4B4 Offset: 0x308B4B4 VA: 0x308F4B4
	private static MethodCall<object, object> CreateFSharpFuncCall(Type type, string methodName) { }

	// RVA: 0x308F910 Offset: 0x308B910 VA: 0x308F910
	public ObjectConstructor<object> CreateSeq(Type t) { }

	// RVA: 0x308FA18 Offset: 0x308BA18 VA: 0x308FA18
	public ObjectConstructor<object> CreateMap(Type keyType, Type valueType) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public ObjectConstructor<object> BuildMapCreator<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C1B00 Offset: 0x26BDB00 VA: 0x26C1B00
	|-FSharpUtils.BuildMapCreator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x308FBD8 Offset: 0x308BBD8 VA: 0x308FBD8
	private static void .cctor() { }
}
