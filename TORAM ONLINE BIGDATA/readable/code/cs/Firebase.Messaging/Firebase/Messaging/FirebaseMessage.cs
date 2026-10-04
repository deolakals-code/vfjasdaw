// Assembly: Firebase.Messaging.dll
// Namespace: Firebase.Messaging
public sealed class FirebaseMessage // TypeDefIndex: 17700
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <CollapseKey>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private IDictionary<string, string> <Data>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Error>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <ErrorDescription>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <From>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Uri <Link>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <MessageId>k__BackingField; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <MessageType>k__BackingField; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private FirebaseNotification <Notification>k__BackingField; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <NotificationOpened>k__BackingField; // 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Priority>k__BackingField; // 0x60
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private byte[] <RawData>k__BackingField; // 0x68
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private TimeSpan <TimeToLive>k__BackingField; // 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <To>k__BackingField; // 0x78

	// Properties
	private string CollapseKey { set; }
	public IDictionary<string, string> Data { get; set; }
	private string Error { set; }
	private string ErrorDescription { set; }
	public string From { get; set; }
	private Uri Link { set; }
	public string MessageId { get; set; }
	private string MessageType { set; }
	private FirebaseNotification Notification { set; }
	private bool NotificationOpened { set; }
	private string Priority { set; }
	public byte[] RawData { get; set; }
	private TimeSpan TimeToLive { set; }
	private string To { set; }

	// Methods

	// RVA: 0x2660FE8 Offset: 0x265CFE8 VA: 0x2660FE8
	internal static FirebaseMessage FromInternal(FirebaseMessageInternal other) { }

	[CompilerGenerated]
	// RVA: 0x26620E4 Offset: 0x265E0E4 VA: 0x26620E4
	private void set_CollapseKey(string value) { }

	[CompilerGenerated]
	// RVA: 0x26620EC Offset: 0x265E0EC VA: 0x26620EC
	public IDictionary<string, string> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x26620F4 Offset: 0x265E0F4 VA: 0x26620F4
	private void set_Data(IDictionary<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x26620FC Offset: 0x265E0FC VA: 0x26620FC
	private void set_Error(string value) { }

	[CompilerGenerated]
	// RVA: 0x2662104 Offset: 0x265E104 VA: 0x2662104
	private void set_ErrorDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x266210C Offset: 0x265E10C VA: 0x266210C
	public string get_From() { }

	[CompilerGenerated]
	// RVA: 0x2662114 Offset: 0x265E114 VA: 0x2662114
	private void set_From(string value) { }

	[CompilerGenerated]
	// RVA: 0x266211C Offset: 0x265E11C VA: 0x266211C
	private void set_Link(Uri value) { }

	[CompilerGenerated]
	// RVA: 0x2662124 Offset: 0x265E124 VA: 0x2662124
	public string get_MessageId() { }

	[CompilerGenerated]
	// RVA: 0x266212C Offset: 0x265E12C VA: 0x266212C
	private void set_MessageId(string value) { }

	[CompilerGenerated]
	// RVA: 0x2662134 Offset: 0x265E134 VA: 0x2662134
	private void set_MessageType(string value) { }

	[CompilerGenerated]
	// RVA: 0x266213C Offset: 0x265E13C VA: 0x266213C
	private void set_Notification(FirebaseNotification value) { }

	[CompilerGenerated]
	// RVA: 0x2662144 Offset: 0x265E144 VA: 0x2662144
	private void set_NotificationOpened(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2662150 Offset: 0x265E150 VA: 0x2662150
	private void set_Priority(string value) { }

	[CompilerGenerated]
	// RVA: 0x2662158 Offset: 0x265E158 VA: 0x2662158
	public byte[] get_RawData() { }

	[CompilerGenerated]
	// RVA: 0x2662160 Offset: 0x265E160 VA: 0x2662160
	private void set_RawData(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x2662168 Offset: 0x265E168 VA: 0x2662168
	private void set_TimeToLive(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x2662170 Offset: 0x265E170 VA: 0x2662170
	private void set_To(string value) { }

	// RVA: 0x26612A0 Offset: 0x265D2A0 VA: 0x26612A0
	public void .ctor() { }
}
