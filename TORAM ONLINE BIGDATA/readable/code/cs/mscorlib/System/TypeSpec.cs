// Assembly: mscorlib.dll
// Namespace: System
internal class TypeSpec // TypeDefIndex: 9831
{
	// Fields
	private TypeIdentifier name; // 0x10
	private string assembly_name; // 0x18
	private List<TypeIdentifier> nested; // 0x20
	private List<TypeSpec> generic_params; // 0x28
	private List<ModifierSpec> modifier_spec; // 0x30
	private bool is_byref; // 0x38
	private string display_fullname; // 0x40

	// Properties
	internal bool HasModifiers { get; }
	internal string DisplayFullName { get; }

	// Methods

	// RVA: 0x303DCA8 Offset: 0x3039CA8 VA: 0x303DCA8
	internal bool get_HasModifiers() { }

	// RVA: 0x303DCB8 Offset: 0x3039CB8 VA: 0x303DCB8
	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	// RVA: 0x303E140 Offset: 0x303A140 VA: 0x303E140
	private StringBuilder GetModifierString(StringBuilder sb) { }

	// RVA: 0x303E0FC Offset: 0x303A0FC VA: 0x303E0FC
	internal string get_DisplayFullName() { }

	// RVA: 0x302C7A4 Offset: 0x30287A4 VA: 0x302C7A4
	internal static TypeSpec Parse(string typeName) { }

	// RVA: 0x303D938 Offset: 0x3039938 VA: 0x303D938
	internal static string UnescapeInternalName(string displayName) { }

	// RVA: 0x302C874 Offset: 0x3028874 VA: 0x302C874
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) { }

	// RVA: 0x303EEF4 Offset: 0x303AEF4 VA: 0x303EEF4
	private void AddName(string type_name) { }

	// RVA: 0x303F02C Offset: 0x303B02C VA: 0x303F02C
	private void AddModifier(ModifierSpec md) { }

	// RVA: 0x303F12C Offset: 0x303B12C VA: 0x303F12C
	private static void SkipSpace(string name, ref int pos) { }

	// RVA: 0x303F1DC Offset: 0x303B1DC VA: 0x303F1DC
	private static void BoundCheck(int idx, string s) { }

	// RVA: 0x303F028 Offset: 0x303B028 VA: 0x303F028
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	// RVA: 0x303E334 Offset: 0x303A334 VA: 0x303E334
	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	// RVA: 0x303F260 Offset: 0x303B260 VA: 0x303F260
	public void .ctor() { }
}
