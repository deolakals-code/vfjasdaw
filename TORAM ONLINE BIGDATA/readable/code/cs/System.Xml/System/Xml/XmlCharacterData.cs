// Assembly: System.Xml.dll
// Namespace: System.Xml
public abstract class XmlCharacterData : XmlLinkedNode // TypeDefIndex: 13390
{
	// Fields
	private string data; // 0x20

	// Properties
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public virtual string Data { get; set; }

	// Methods

	// RVA: 0x33B32C0 Offset: 0x33AF2C0 VA: 0x33B32C0
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x33B34AC Offset: 0x33AF4AC VA: 0x33B34AC Slot: 7
	public override string get_Value() { }

	// RVA: 0x33B34BC Offset: 0x33AF4BC VA: 0x33B34BC Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x33B34CC Offset: 0x33AF4CC VA: 0x33B34CC Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x33B34D8 Offset: 0x33AF4D8 VA: 0x33B34D8 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x33B34E4 Offset: 0x33AF4E4 VA: 0x33B34E4 Slot: 56
	public virtual string get_Data() { }

	// RVA: 0x33B3538 Offset: 0x33AF538 VA: 0x33B3538 Slot: 57
	public virtual void set_Data(string value) { }

	// RVA: 0x33B35FC Offset: 0x33AF5FC VA: 0x33B35FC
	internal bool CheckOnData(string data) { }
}
