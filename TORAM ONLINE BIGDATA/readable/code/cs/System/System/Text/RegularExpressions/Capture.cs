// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
public class Capture // TypeDefIndex: 14060
{
	// Fields
	[CompilerGenerated]
	private int <Index>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Length>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <Text>k__BackingField; // 0x18

	// Properties
	public int Index { get; set; }
	public int Length { get; set; }
	internal string Text { get; set; }
	public string Value { get; }

	// Methods

	// RVA: 0x3469710 Offset: 0x3465710 VA: 0x3469710
	internal void .ctor(string text, int index, int length) { }

	[CompilerGenerated]
	// RVA: 0x3469758 Offset: 0x3465758 VA: 0x3469758
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3469760 Offset: 0x3465760 VA: 0x3469760
	internal void set_Index(int value) { }

	[CompilerGenerated]
	// RVA: 0x3469768 Offset: 0x3465768 VA: 0x3469768
	public int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x3469770 Offset: 0x3465770 VA: 0x3469770
	internal void set_Length(int value) { }

	[CompilerGenerated]
	// RVA: 0x3469778 Offset: 0x3465778 VA: 0x3469778
	internal string get_Text() { }

	[CompilerGenerated]
	// RVA: 0x3469780 Offset: 0x3465780 VA: 0x3469780
	internal void set_Text(string value) { }

	// RVA: 0x3469788 Offset: 0x3465788 VA: 0x3469788
	public string get_Value() { }

	// RVA: 0x34697AC Offset: 0x34657AC VA: 0x34697AC Slot: 3
	public override string ToString() { }

	// RVA: 0x34697B0 Offset: 0x34657B0 VA: 0x34697B0
	internal ReadOnlySpan<char> GetLeftSubstring() { }

	// RVA: 0x3469838 Offset: 0x3465838 VA: 0x3469838
	internal ReadOnlySpan<char> GetRightSubstring() { }

	// RVA: 0x34698C8 Offset: 0x34658C8 VA: 0x34698C8
	internal void .ctor() { }
}
