// Assembly: System.dll
// Namespace: System.ComponentModel
[DesignerCategory("Component")]
[TypeConverter(typeof(ComponentConverter))]
public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider // TypeDefIndex: 14219
{
	// Fields
	private static readonly object s_eventDisposed; // 0x0
	private ISite _site; // 0x10
	private EventHandlerList _events; // 0x18

	// Properties
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual ISite Site { get; }

	// Methods

	// RVA: 0x34AC550 Offset: 0x34A8550 VA: 0x34AC550
	public void .ctor() { }

	// RVA: 0x34AC558 Offset: 0x34A8558 VA: 0x34AC558 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x34AC5F8 Offset: 0x34A85F8 VA: 0x34AC5F8 Slot: 7
	public virtual ISite get_Site() { }

	// RVA: 0x34AC600 Offset: 0x34A8600 VA: 0x34AC600 Slot: 5
	public void Dispose() { }

	// RVA: 0x34AC66C Offset: 0x34A866C VA: 0x34AC66C Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x34AC8F8 Offset: 0x34A88F8 VA: 0x34AC8F8 Slot: 9
	public virtual object GetService(Type service) { }

	// RVA: 0x34AC9AC Offset: 0x34A89AC VA: 0x34AC9AC Slot: 3
	public override string ToString() { }

	// RVA: 0x34ACADC Offset: 0x34A8ADC VA: 0x34ACADC
	private static void .cctor() { }
}
