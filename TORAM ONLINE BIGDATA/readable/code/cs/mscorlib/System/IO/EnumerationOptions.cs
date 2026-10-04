// Assembly: mscorlib.dll
// Namespace: System.IO
public class EnumerationOptions // TypeDefIndex: 10712
{
	// Fields
	[CompilerGenerated]
	private static readonly EnumerationOptions <Compatible>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly EnumerationOptions <CompatibleRecursive>k__BackingField; // 0x8
	[CompilerGenerated]
	private static readonly EnumerationOptions <Default>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <RecurseSubdirectories>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IgnoreInaccessible>k__BackingField; // 0x11
	[CompilerGenerated]
	private FileAttributes <AttributesToSkip>k__BackingField; // 0x14
	[CompilerGenerated]
	private MatchType <MatchType>k__BackingField; // 0x18
	[CompilerGenerated]
	private MatchCasing <MatchCasing>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <ReturnSpecialDirectories>k__BackingField; // 0x20

	// Properties
	internal static EnumerationOptions Compatible { get; }
	internal static EnumerationOptions Default { get; }
	public bool RecurseSubdirectories { get; set; }
	public bool IgnoreInaccessible { get; set; }
	public FileAttributes AttributesToSkip { get; set; }
	public MatchType MatchType { get; set; }
	public MatchCasing MatchCasing { get; }
	public bool ReturnSpecialDirectories { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2F4A27C Offset: 0x2F4627C VA: 0x2F4A27C
	internal static EnumerationOptions get_Compatible() { }

	[CompilerGenerated]
	// RVA: 0x2F4A2D4 Offset: 0x2F462D4 VA: 0x2F4A2D4
	internal static EnumerationOptions get_Default() { }

	// RVA: 0x2F4A32C Offset: 0x2F4632C VA: 0x2F4A32C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2F4A354 Offset: 0x2F46354 VA: 0x2F4A354
	public bool get_RecurseSubdirectories() { }

	[CompilerGenerated]
	// RVA: 0x2F4A35C Offset: 0x2F4635C VA: 0x2F4A35C
	public void set_RecurseSubdirectories(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2F4A368 Offset: 0x2F46368 VA: 0x2F4A368
	public bool get_IgnoreInaccessible() { }

	[CompilerGenerated]
	// RVA: 0x2F4A370 Offset: 0x2F46370 VA: 0x2F4A370
	public void set_IgnoreInaccessible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2F4A37C Offset: 0x2F4637C VA: 0x2F4A37C
	public FileAttributes get_AttributesToSkip() { }

	[CompilerGenerated]
	// RVA: 0x2F4A384 Offset: 0x2F46384 VA: 0x2F4A384
	public void set_AttributesToSkip(FileAttributes value) { }

	[CompilerGenerated]
	// RVA: 0x2F4A38C Offset: 0x2F4638C VA: 0x2F4A38C
	public MatchType get_MatchType() { }

	[CompilerGenerated]
	// RVA: 0x2F4A394 Offset: 0x2F46394 VA: 0x2F4A394
	public void set_MatchType(MatchType value) { }

	[CompilerGenerated]
	// RVA: 0x2F4A39C Offset: 0x2F4639C VA: 0x2F4A39C
	public MatchCasing get_MatchCasing() { }

	[CompilerGenerated]
	// RVA: 0x2F4A3A4 Offset: 0x2F463A4 VA: 0x2F4A3A4
	public bool get_ReturnSpecialDirectories() { }

	// RVA: 0x2F4A3AC Offset: 0x2F463AC VA: 0x2F4A3AC
	private static void .cctor() { }
}
