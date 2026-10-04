// Assembly: System.dll
// Namespace: System.Net
internal sealed class NetEventSource : EventSource // TypeDefIndex: 14353
{
	// Fields
	public static readonly NetEventSource Log; // 0x0

	// Properties
	public static bool IsEnabled { get; }

	// Methods

	[NonEvent]
	// RVA: 0x34DAB30 Offset: 0x34D6B30 VA: 0x34DAB30
	public static void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x34DB0F0 Offset: 0x34D70F0 VA: 0x34DB0F0
	public static void Enter(object thisOrContextObject, object arg0, string memberName) { }

	[NonEvent]
	// RVA: 0x34DB5BC Offset: 0x34D75BC VA: 0x34DB5BC
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	[Event(1, Level = 4, Keywords = 4)]
	// RVA: 0x34DB074 Offset: 0x34D7074 VA: 0x34DB074
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	[NonEvent]
	// RVA: 0x34DB6D8 Offset: 0x34D76D8 VA: 0x34DB6D8
	public static void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x34DB844 Offset: 0x34D7844 VA: 0x34DB844
	public static void Exit(object thisOrContextObject, object arg0, string memberName) { }

	[Event(2, Level = 4, Keywords = 4)]
	// RVA: 0x34DB7C8 Offset: 0x34D77C8 VA: 0x34DB7C8
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	[NonEvent]
	// RVA: 0x34D9C9C Offset: 0x34D5C9C VA: 0x34D9C9C
	public static void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x34D9D8C Offset: 0x34D5D8C VA: 0x34D9D8C
	public static void Info(object thisOrContextObject, object message, string memberName) { }

	[Event(4, Level = 4, Keywords = 1)]
	// RVA: 0x34DB914 Offset: 0x34D7914 VA: 0x34DB914
	private void Info(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x34DB990 Offset: 0x34D7990 VA: 0x34DB990
	public static void Error(object thisOrContextObject, object message, string memberName) { }

	[Event(5, Level = 3, Keywords = 1)]
	// RVA: 0x34DBA60 Offset: 0x34D7A60 VA: 0x34DBA60
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x34D9684 Offset: 0x34D5684 VA: 0x34D9684
	public static void Fail(object thisOrContextObject, object message, string memberName) { }

	[Event(6, Level = 1, Keywords = 2)]
	// RVA: 0x34DBADC Offset: 0x34D7ADC VA: 0x34DBADC
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x34DBB58 Offset: 0x34D7B58 VA: 0x34DBB58
	public static void Associate(object first, object second, string memberName) { }

	[Event(3, Level = 4, Keywords = 1, Message = "[{2}]<-->[{3}]")]
	// RVA: 0x34DBC28 Offset: 0x34D7C28 VA: 0x34DBC28
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	// RVA: 0x34D9C38 Offset: 0x34D5C38 VA: 0x34D9C38
	public static bool get_IsEnabled() { }

	[NonEvent]
	// RVA: 0x34DAC20 Offset: 0x34D6C20 VA: 0x34DAC20
	public static string IdOf(object value) { }

	[NonEvent]
	// RVA: 0x34DBEBC Offset: 0x34D7EBC VA: 0x34DBEBC
	public static int GetHashCode(object value) { }

	[NonEvent]
	// RVA: 0x34DB1D8 Offset: 0x34D71D8 VA: 0x34DB1D8
	public static object Format(object value) { }

	[NonEvent]
	// RVA: 0x34DAD08 Offset: 0x34D6D08 VA: 0x34DAD08
	private static string Format(FormattableString s) { }

	[NonEvent]
	// RVA: 0x34DBCB0 Offset: 0x34D7CB0 VA: 0x34DBCB0
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	// RVA: 0x34DBED0 Offset: 0x34D7ED0 VA: 0x34DBED0
	public void .ctor() { }

	// RVA: 0x34DBED8 Offset: 0x34D7ED8 VA: 0x34DBED8
	private static void .cctor() { }
}
