// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ErrorContext // TypeDefIndex: 15985
{
	// Fields
	[CompilerGenerated]
	private bool <Traced>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Exception <Error>k__BackingField; // 0x18
	[CompilerGenerated]
	[Nullable(2)]
	private readonly object <OriginalObject>k__BackingField; // 0x20
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <Member>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <Handled>k__BackingField; // 0x38

	// Properties
	internal bool Traced { get; set; }
	public Exception Error { get; }
	public bool Handled { get; }

	// Methods

	// RVA: 0x30A3DFC Offset: 0x309FDFC VA: 0x30A3DFC
	internal void .ctor(object originalObject, object member, string path, Exception error) { }

	[CompilerGenerated]
	// RVA: 0x30A3E70 Offset: 0x309FE70 VA: 0x30A3E70
	internal bool get_Traced() { }

	[CompilerGenerated]
	// RVA: 0x30A3E78 Offset: 0x309FE78 VA: 0x30A3E78
	internal void set_Traced(bool value) { }

	[CompilerGenerated]
	// RVA: 0x30A3E84 Offset: 0x309FE84 VA: 0x30A3E84
	public Exception get_Error() { }

	[CompilerGenerated]
	// RVA: 0x30A3E8C Offset: 0x309FE8C VA: 0x30A3E8C
	public bool get_Handled() { }
}
