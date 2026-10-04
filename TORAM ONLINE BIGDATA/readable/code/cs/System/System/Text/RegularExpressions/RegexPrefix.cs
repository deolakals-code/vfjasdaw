// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
[IsReadOnly]
internal struct RegexPrefix // TypeDefIndex: 14089
{
	// Fields
	[CompilerGenerated]
	private readonly bool <CaseInsensitive>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly RegexPrefix <Empty>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly string <Prefix>k__BackingField; // 0x8

	// Properties
	internal bool CaseInsensitive { get; }
	internal static RegexPrefix Empty { get; }
	internal string Prefix { get; }

	// Methods

	// RVA: 0x347974C Offset: 0x347574C VA: 0x347974C
	internal void .ctor(string prefix, bool ci) { }

	[CompilerGenerated]
	// RVA: 0x3483C74 Offset: 0x347FC74 VA: 0x3483C74
	internal bool get_CaseInsensitive() { }

	[CompilerGenerated]
	// RVA: 0x3483C7C Offset: 0x347FC7C VA: 0x3483C7C
	internal static RegexPrefix get_Empty() { }

	[CompilerGenerated]
	// RVA: 0x3483CD4 Offset: 0x347FCD4 VA: 0x3483CD4
	internal string get_Prefix() { }

	// RVA: 0x3483CDC Offset: 0x347FCDC VA: 0x3483CDC
	private static void .cctor() { }
}
