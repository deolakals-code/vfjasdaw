// Assembly: mscorlib.dll
// Namespace: System.Diagnostics.Tracing
public class EventSource : IDisposable // TypeDefIndex: 10853
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	private string Name { set; }

	// Methods

	// RVA: 0x2FB2B6C Offset: 0x2FAEB6C VA: 0x2FB2B6C
	protected void .ctor() { }

	// RVA: 0x2FB2BB0 Offset: 0x2FAEBB0 VA: 0x2FB2BB0
	public void .ctor(string eventSourceName) { }

	// RVA: 0x2FB2BE0 Offset: 0x2FAEBE0 VA: 0x2FB2BE0
	internal void .ctor(Guid eventSourceGuid, string eventSourceName) { }

	// RVA: 0x2FB2C10 Offset: 0x2FAEC10 VA: 0x2FB2C10 Slot: 1
	protected override void Finalize() { }

	[CompilerGenerated]
	// RVA: 0x2FB2CB0 Offset: 0x2FAECB0 VA: 0x2FB2CB0
	private void set_Name(string value) { }

	// RVA: 0x2FB2CB8 Offset: 0x2FAECB8 VA: 0x2FB2CB8
	public bool IsEnabled() { }

	// RVA: 0x2FB2CC0 Offset: 0x2FAECC0 VA: 0x2FB2CC0
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	// RVA: 0x2FB2CC8 Offset: 0x2FAECC8 VA: 0x2FB2CC8 Slot: 4
	public void Dispose() { }

	// RVA: 0x2FB2D34 Offset: 0x2FAED34 VA: 0x2FB2D34 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2FB2D38 Offset: 0x2FAED38 VA: 0x2FB2D38
	protected void WriteEvent(int eventId, int arg1) { }

	// RVA: 0x2FB2E04 Offset: 0x2FAEE04 VA: 0x2FB2E04
	protected void WriteEvent(int eventId, string arg1) { }

	// RVA: 0x2FB2E98 Offset: 0x2FAEE98 VA: 0x2FB2E98
	protected void WriteEvent(int eventId, int arg1, int arg2) { }

	// RVA: 0x2FB2FB4 Offset: 0x2FAEFB4 VA: 0x2FB2FB4
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	// RVA: 0x2FB3124 Offset: 0x2FAF124 VA: 0x2FB3124
	protected void WriteEvent(int eventId, long arg1) { }

	// RVA: 0x2FB31EC Offset: 0x2FAF1EC VA: 0x2FB31EC
	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	// RVA: 0x2FB2E00 Offset: 0x2FAEE00 VA: 0x2FB2E00
	protected void WriteEvent(int eventId, object[] args) { }

	// RVA: 0x2FB32F4 Offset: 0x2FAF2F4 VA: 0x2FB32F4
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	[CLSCompliant(False)]
	// RVA: 0x2FB3400 Offset: 0x2FAF400 VA: 0x2FB3400
	protected void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data) { }
}
