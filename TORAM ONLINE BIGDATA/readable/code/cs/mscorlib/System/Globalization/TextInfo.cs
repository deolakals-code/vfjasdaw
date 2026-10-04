// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 10812
{
	// Fields
	[OptionalField(VersionAdded = 2)]
	private string m_listSeparator; // 0x10
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x18
	[OptionalField(VersionAdded = 3)]
	private string m_cultureName; // 0x20
	private CultureData m_cultureData; // 0x28
	private string m_textInfoName; // 0x30
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant; // 0x38
	internal static TextInfo s_Invariant; // 0x0
	[OptionalField(VersionAdded = 2)]
	private string customCultureName; // 0x40
	[OptionalField(VersionAdded = 1)]
	internal int m_nDataItem; // 0x48
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; // 0x4C
	[OptionalField(VersionAdded = 1)]
	internal int m_win32LangID; // 0x50
	private const int wordSeparatorMask = 536672256;

	// Properties
	internal static TextInfo Invariant { get; }
	[ComVisible(False)]
	public string CultureName { get; }
	private bool IsAsciiCasingSameAsInvariant { get; }

	// Methods

	// RVA: 0x2F9A238 Offset: 0x2F96238 VA: 0x2F9A238
	internal static TextInfo get_Invariant() { }

	// RVA: 0x2F9A6A8 Offset: 0x2F966A8 VA: 0x2F9A6A8
	internal void .ctor(CultureData cultureData) { }

	[OnDeserializing]
	// RVA: 0x2F9A714 Offset: 0x2F96714 VA: 0x2F9A714
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x2F9A73C Offset: 0x2F9673C VA: 0x2F9A73C
	private void OnDeserialized() { }

	[OnDeserialized]
	// RVA: 0x2F9A864 Offset: 0x2F96864 VA: 0x2F9A864
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x2F9A868 Offset: 0x2F96868 VA: 0x2F9A868
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x2F9A8F4 Offset: 0x2F968F4 VA: 0x2F9A8F4
	public string get_CultureName() { }

	[ComVisible(False)]
	// RVA: 0x2F9A8FC Offset: 0x2F968FC VA: 0x2F9A8FC Slot: 6
	public virtual object Clone() { }

	// RVA: 0x2F9A984 Offset: 0x2F96984 VA: 0x2F9A984
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x2F9A990 Offset: 0x2F96990 VA: 0x2F9A990 Slot: 7
	public virtual char ToLower(char c) { }

	// RVA: 0x2F9AF9C Offset: 0x2F96F9C VA: 0x2F9AF9C Slot: 8
	public virtual string ToLower(string str) { }

	// RVA: 0x2F9AB00 Offset: 0x2F96B00 VA: 0x2F9AB00
	private static char ToLowerAsciiInvariant(char c) { }

	// RVA: 0x2F9B0D4 Offset: 0x2F970D4 VA: 0x2F9B0D4 Slot: 9
	public virtual char ToUpper(char c) { }

	// RVA: 0x2F9B5E0 Offset: 0x2F975E0 VA: 0x2F9B5E0 Slot: 10
	public virtual string ToUpper(string str) { }

	// RVA: 0x2F9B130 Offset: 0x2F97130 VA: 0x2F9B130
	internal static char ToUpperAsciiInvariant(char c) { }

	// RVA: 0x2F9A9EC Offset: 0x2F969EC VA: 0x2F9A9EC
	private static bool IsAscii(char c) { }

	// RVA: 0x2F9A9FC Offset: 0x2F969FC VA: 0x2F9A9FC
	private bool get_IsAsciiCasingSameAsInvariant() { }

	// RVA: 0x2F9B718 Offset: 0x2F97718 VA: 0x2F9B718 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F9B7B8 Offset: 0x2F977B8 VA: 0x2F9B7B8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F9B7D8 Offset: 0x2F977D8 VA: 0x2F9B7D8 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F9B830 Offset: 0x2F97830 VA: 0x2F9B830 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x2F9B634 Offset: 0x2F97634 VA: 0x2F9B634
	private string ToUpperInternal(string str) { }

	// RVA: 0x2F9AFF0 Offset: 0x2F96FF0 VA: 0x2F9AFF0
	private string ToLowerInternal(string str) { }

	// RVA: 0x2F9B148 Offset: 0x2F97148 VA: 0x2F9B148
	private char ToUpperInternal(char c) { }

	// RVA: 0x2F9AB18 Offset: 0x2F96B18 VA: 0x2F9AB18
	private char ToLowerInternal(char c) { }

	// RVA: 0x2F9B834 Offset: 0x2F97834 VA: 0x2F9B834
	internal void ToUpperAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination) { }

	// RVA: 0x2F9B8BC Offset: 0x2F978BC VA: 0x2F9B8BC
	internal void ChangeCase(ReadOnlySpan<char> source, Span<char> destination, bool toUpper) { }

	// RVA: 0x2F9B9FC Offset: 0x2F979FC VA: 0x2F9B9FC
	internal void .ctor() { }
}
