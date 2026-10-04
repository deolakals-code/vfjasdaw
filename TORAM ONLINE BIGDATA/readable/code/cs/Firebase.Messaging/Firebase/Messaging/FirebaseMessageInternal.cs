// Assembly: Firebase.Messaging.dll
// Namespace: Firebase.Messaging
internal class FirebaseMessageInternal : IDisposable // TypeDefIndex: 17708
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Properties
	public string from { get; }
	public string to { get; }
	public string collapse_key { get; }
	public IDictionary<string, string> data { get; }
	public CharVector raw_data { get; }
	public string message_id { get; }
	public string message_type { get; }
	public string priority { get; }
	public int time_to_live { get; }
	public string error { get; }
	public string error_description { get; }
	internal FirebaseNotificationInternal notification { get; }
	public bool notification_opened { get; }
	public string link { get; }

	// Methods

	// RVA: 0x2664768 Offset: 0x2660768 VA: 0x2664768
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x26647C8 Offset: 0x26607C8 VA: 0x26647C8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2664868 Offset: 0x2660868 VA: 0x2664868 Slot: 4
	public void Dispose() { }

	// RVA: 0x26648D4 Offset: 0x26608D4 VA: 0x26648D4 Slot: 5
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x2661628 Offset: 0x265D628 VA: 0x2661628
	public string get_from() { }

	// RVA: 0x2662014 Offset: 0x265E014 VA: 0x2662014
	public string get_to() { }

	// RVA: 0x26612A8 Offset: 0x265D2A8 VA: 0x26612A8
	public string get_collapse_key() { }

	// RVA: 0x2661378 Offset: 0x265D378 VA: 0x2661378
	public IDictionary<string, string> get_data() { }

	// RVA: 0x2661E34 Offset: 0x265DE34 VA: 0x2661E34
	public CharVector get_raw_data() { }

	// RVA: 0x26617C8 Offset: 0x265D7C8 VA: 0x26617C8
	public string get_message_id() { }

	// RVA: 0x2661898 Offset: 0x265D898 VA: 0x2661898
	public string get_message_type() { }

	// RVA: 0x2661D64 Offset: 0x265DD64 VA: 0x2661D64
	public string get_priority() { }

	// RVA: 0x2661F44 Offset: 0x265DF44 VA: 0x2661F44
	public int get_time_to_live() { }

	// RVA: 0x2661488 Offset: 0x265D488 VA: 0x2661488
	public string get_error() { }

	// RVA: 0x2661558 Offset: 0x265D558 VA: 0x2661558
	public string get_error_description() { }

	// RVA: 0x2661968 Offset: 0x265D968 VA: 0x2661968
	internal FirebaseNotificationInternal get_notification() { }

	// RVA: 0x2661C94 Offset: 0x265DC94 VA: 0x2661C94
	public bool get_notification_opened() { }

	// RVA: 0x26616F8 Offset: 0x265D6F8 VA: 0x26616F8
	public string get_link() { }
}
