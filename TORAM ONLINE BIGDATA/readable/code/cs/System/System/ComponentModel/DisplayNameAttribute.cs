// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(708)]
public class DisplayNameAttribute : Attribute // TypeDefIndex: 14168
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	[CompilerGenerated]
	private string <DisplayNameValue>k__BackingField; // 0x10

	// Properties
	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; set; }

	// Methods

	// RVA: 0x349E344 Offset: 0x349A344 VA: 0x349E344
	public void .ctor() { }

	// RVA: 0x349E3A8 Offset: 0x349A3A8 VA: 0x349E3A8
	public void .ctor(string displayName) { }

	// RVA: 0x349E3D8 Offset: 0x349A3D8 VA: 0x349E3D8 Slot: 7
	public virtual string get_DisplayName() { }

	[CompilerGenerated]
	// RVA: 0x349E3E0 Offset: 0x349A3E0 VA: 0x349E3E0
	protected string get_DisplayNameValue() { }

	[CompilerGenerated]
	// RVA: 0x349E3E8 Offset: 0x349A3E8 VA: 0x349E3E8
	protected void set_DisplayNameValue(string value) { }

	// RVA: 0x349E3F0 Offset: 0x349A3F0 VA: 0x349E3F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x349E4BC Offset: 0x349A4BC VA: 0x349E4BC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x349E4E4 Offset: 0x349A4E4 VA: 0x349E4E4 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x349E54C Offset: 0x349A54C VA: 0x349E54C
	private static void .cctor() { }
}
