// Assembly: System.dll
// Namespace: System.ComponentModel
public class SingleConverter : BaseNumberConverter // TypeDefIndex: 14231
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x34B22B8 Offset: 0x34AE2B8 VA: 0x34B22B8 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x34B22C0 Offset: 0x34AE2C0 VA: 0x34B22C0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x34B232C Offset: 0x34AE32C VA: 0x34B232C Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x34B23EC Offset: 0x34AE3EC VA: 0x34B23EC Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x34B245C Offset: 0x34AE45C VA: 0x34B245C Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x34B250C Offset: 0x34AE50C VA: 0x34B250C
	public void .ctor() { }
}
