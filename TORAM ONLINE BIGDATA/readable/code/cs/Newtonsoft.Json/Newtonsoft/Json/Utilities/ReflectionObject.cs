// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal class ReflectionObject // TypeDefIndex: 15951
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private readonly ObjectConstructor<object> <Creator>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IDictionary<string, ReflectionMember> <Members>k__BackingField; // 0x18

	// Properties
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> Creator { get; }
	public IDictionary<string, ReflectionMember> Members { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3093F8C Offset: 0x308FF8C VA: 0x3093F8C
	public ObjectConstructor<object> get_Creator() { }

	[CompilerGenerated]
	// RVA: 0x3093F94 Offset: 0x308FF94 VA: 0x3093F94
	public IDictionary<string, ReflectionMember> get_Members() { }

	// RVA: 0x3093F9C Offset: 0x308FF9C VA: 0x3093F9C
	private void .ctor(ObjectConstructor<object> creator) { }

	// RVA: 0x3094038 Offset: 0x3090038 VA: 0x3094038
	public object GetValue(object target, string member) { }

	// RVA: 0x309410C Offset: 0x309010C VA: 0x309410C
	public void SetValue(object target, string member, object value) { }

	// RVA: 0x30941E8 Offset: 0x30901E8 VA: 0x30941E8
	public Type GetType(string member) { }

	// RVA: 0x309429C Offset: 0x309029C VA: 0x309429C
	public static ReflectionObject Create(Type t, string[] memberNames) { }

	// RVA: 0x30942A8 Offset: 0x30902A8 VA: 0x30942A8
	public static ReflectionObject Create(Type t, MethodBase creator, string[] memberNames) { }
}
