// Assembly: Firebase.Messaging.dll
// Namespace: Firebase.Messaging
internal class FirebaseNotificationInternal : IDisposable // TypeDefIndex: 17707
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Properties
	public string title { get; }
	public string body { get; }
	public string icon { get; }
	public string sound { get; }
	public string badge { get; }
	public string tag { get; }
	public string color { get; }
	public string click_action { get; }
	public string body_loc_key { get; }
	public IEnumerable<string> body_loc_args { get; }
	public string title_loc_key { get; }
	public IEnumerable<string> title_loc_args { get; }
	internal AndroidNotificationParamsInternal android { get; }

	// Methods

	// RVA: 0x2663C88 Offset: 0x265FC88 VA: 0x2663C88
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2663CE8 Offset: 0x265FCE8 VA: 0x2663CE8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2663D88 Offset: 0x265FD88 VA: 0x2663D88 Slot: 4
	public void Dispose() { }

	// RVA: 0x2663DF4 Offset: 0x265FDF4 VA: 0x2663DF4 Slot: 5
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x2663430 Offset: 0x265F430 VA: 0x2663430
	public string get_title() { }

	// RVA: 0x2662D70 Offset: 0x265ED70 VA: 0x2662D70
	public string get_body() { }

	// RVA: 0x26631C0 Offset: 0x265F1C0 VA: 0x26631C0
	public string get_icon() { }

	// RVA: 0x2663290 Offset: 0x265F290 VA: 0x2663290
	public string get_sound() { }

	// RVA: 0x2662CA0 Offset: 0x265ECA0 VA: 0x2662CA0
	public string get_badge() { }

	// RVA: 0x2663360 Offset: 0x265F360 VA: 0x2663360
	public string get_tag() { }

	// RVA: 0x26630F0 Offset: 0x265F0F0 VA: 0x26630F0
	public string get_color() { }

	// RVA: 0x2663020 Offset: 0x265F020 VA: 0x2663020
	public string get_click_action() { }

	// RVA: 0x2662F50 Offset: 0x265EF50 VA: 0x2662F50
	public string get_body_loc_key() { }

	// RVA: 0x2662E40 Offset: 0x265EE40 VA: 0x2662E40
	public IEnumerable<string> get_body_loc_args() { }

	// RVA: 0x2663610 Offset: 0x265F610 VA: 0x2663610
	public string get_title_loc_key() { }

	// RVA: 0x2663500 Offset: 0x265F500 VA: 0x2663500
	public IEnumerable<string> get_title_loc_args() { }

	// RVA: 0x2662B94 Offset: 0x265EB94 VA: 0x2662B94
	internal AndroidNotificationParamsInternal get_android() { }
}
