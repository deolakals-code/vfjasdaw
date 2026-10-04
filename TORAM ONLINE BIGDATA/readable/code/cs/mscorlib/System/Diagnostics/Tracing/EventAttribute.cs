// Assembly: mscorlib.dll
// Namespace: System.Diagnostics.Tracing
[Usage(64)]
public sealed class EventAttribute : Attribute // TypeDefIndex: 10851
{
	// Fields
	[CompilerGenerated]
	private int <EventId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EventLevel <Level>k__BackingField; // 0x14
	[CompilerGenerated]
	private EventKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x20

	// Properties
	private int EventId { set; }
	public EventLevel Level { set; }
	public EventKeywords Keywords { set; }
	public string Message { set; }

	// Methods

	// RVA: 0x2FB2B24 Offset: 0x2FAEB24 VA: 0x2FB2B24
	public void .ctor(int eventId) { }

	[CompilerGenerated]
	// RVA: 0x2FB2B4C Offset: 0x2FAEB4C VA: 0x2FB2B4C
	private void set_EventId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2FB2B54 Offset: 0x2FAEB54 VA: 0x2FB2B54
	public void set_Level(EventLevel value) { }

	[CompilerGenerated]
	// RVA: 0x2FB2B5C Offset: 0x2FAEB5C VA: 0x2FB2B5C
	public void set_Keywords(EventKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x2FB2B64 Offset: 0x2FAEB64 VA: 0x2FB2B64
	public void set_Message(string value) { }
}
