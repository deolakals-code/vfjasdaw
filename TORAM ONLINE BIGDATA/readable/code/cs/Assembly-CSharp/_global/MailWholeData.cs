// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MailWholeData // TypeDefIndex: 2067
{
	// Fields
	[CompilerGenerated]
	private MailHeaderData <Header>k__BackingField; // 0x10
	[CompilerGenerated]
	private MailBodyData <Body>k__BackingField; // 0x18
	[CompilerGenerated]
	private MailDeliveryData <Delivery>k__BackingField; // 0x20

	// Properties
	public MailHeaderData Header { get; set; }
	public MailBodyData Body { get; set; }
	public MailDeliveryData Delivery { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2145540 Offset: 0x2141540 VA: 0x2145540
	public MailHeaderData get_Header() { }

	[CompilerGenerated]
	// RVA: 0x2145548 Offset: 0x2141548 VA: 0x2145548
	private void set_Header(MailHeaderData value) { }

	[CompilerGenerated]
	// RVA: 0x2145550 Offset: 0x2141550 VA: 0x2145550
	public MailBodyData get_Body() { }

	[CompilerGenerated]
	// RVA: 0x2145558 Offset: 0x2141558 VA: 0x2145558
	private void set_Body(MailBodyData value) { }

	[CompilerGenerated]
	// RVA: 0x2145560 Offset: 0x2141560 VA: 0x2145560
	public MailDeliveryData get_Delivery() { }

	[CompilerGenerated]
	// RVA: 0x2145568 Offset: 0x2141568 VA: 0x2145568
	private void set_Delivery(MailDeliveryData value) { }

	// RVA: 0x2145570 Offset: 0x2141570 VA: 0x2145570
	public void .ctor() { }

	// RVA: 0x2144F24 Offset: 0x2140F24 VA: 0x2144F24
	public void .ctor(MailHeaderData header, MailBodyData body, MailDeliveryData delivery) { }

	// RVA: 0x2144F84 Offset: 0x2140F84 VA: 0x2144F84
	public void SetHeaderData(MailHeaderData header) { }

	// RVA: 0x2145100 Offset: 0x2141100 VA: 0x2145100
	public void SetBodyData(MailBodyData body) { }

	// RVA: 0x2144F8C Offset: 0x2140F8C VA: 0x2144F8C
	public void SetDeliveryData(MailDeliveryData delivery) { }

	// RVA: 0x21450E4 Offset: 0x21410E4 VA: 0x21450E4
	public void ChangeState(byte state) { }
}
