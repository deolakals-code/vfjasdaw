// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal class BufferX : IBuffer, IBufferDebug // TypeDefIndex: 17462
{
	// Fields
	private readonly byte[] k_WorkingBuffer; // 0x10
	private readonly char[] k_WorkingCharacterBuffer; // 0x18
	private readonly byte[] k_PayloadHeader; // 0x20
	private readonly byte[] k_HeaderEventName; // 0x28
	private readonly byte[] k_HeaderUserName; // 0x30
	private readonly byte[] k_HeaderSessionID; // 0x38
	private readonly byte[] k_HeaderEventUUID; // 0x40
	private readonly byte[] k_HeaderTimestamp; // 0x48
	private readonly byte[] k_HeaderEventVersion; // 0x50
	private readonly byte[] k_HeaderInstallationID; // 0x58
	private readonly byte[] k_HeaderPlayerID; // 0x60
	private readonly byte[] k_HeaderOpenEventParams; // 0x68
	private readonly byte[] k_CloseEvent; // 0x70
	private readonly byte k_Quote; // 0x78
	private readonly byte[] k_QuoteColon; // 0x80
	private readonly byte[] k_QuoteComma; // 0x88
	private readonly byte[] k_Comma; // 0x90
	private readonly byte[] k_OpenBrace; // 0x98
	private readonly byte[] k_CloseBraceComma; // 0xA0
	private readonly byte[] k_OpenBracket; // 0xA8
	private readonly byte[] k_CloseBracketComma; // 0xB0
	private readonly byte k_Colon; // 0xB8
	private readonly byte k_Dash; // 0xB9
	private readonly byte k_Space; // 0xBA
	private readonly byte k_Point; // 0xBB
	private readonly byte k_Positive; // 0xBC
	private readonly byte k_Negative; // 0xBD
	private readonly byte[] k_True; // 0xC0
	private readonly byte[] k_False; // 0xC8
	private readonly byte[] k_Int2CharacterByte; // 0xD0
	private readonly long[] k_Order; // 0xD8
	private readonly IBufferSystemCalls m_SystemCalls; // 0xE0
	private readonly IDiskCache m_DiskCache; // 0xE8
	private readonly IIdentityManager m_UserIdentity; // 0xF0
	private readonly ISessionManager m_Session; // 0xF8
	private readonly List<EventSummary> m_EventSummaries; // 0x100
	private string m_CurrentEventId; // 0x108
	private string m_CurrentEventName; // 0x110
	private DateTime m_CurrentEventTimestamp; // 0x118
	private MemoryStream m_SpareBuffer; // 0x120
	private MemoryStream m_Buffer; // 0x128
	[CompilerGenerated]
	private Action<string, string, DateTime, byte[]> EventRecorded; // 0x130
	[CompilerGenerated]
	private Action<HashSet<string>> EventsClearing; // 0x138
	[CompilerGenerated]
	private Action<HashSet<string>> EventsCleared; // 0x140

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x37A4454 Offset: 0x37A0454 VA: 0x37A4454 Slot: 12
	public int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x37A4478 Offset: 0x37A0478 VA: 0x37A4478 Slot: 16
	public void add_EventRecorded(Action<string, string, DateTime, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x37A452C Offset: 0x37A052C VA: 0x37A452C Slot: 17
	public void remove_EventRecorded(Action<string, string, DateTime, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x37A45E0 Offset: 0x37A05E0 VA: 0x37A45E0 Slot: 18
	public void add_EventsClearing(Action<HashSet<string>> value) { }

	[CompilerGenerated]
	// RVA: 0x37A4694 Offset: 0x37A0694 VA: 0x37A4694 Slot: 19
	public void remove_EventsClearing(Action<HashSet<string>> value) { }

	// RVA: 0x379C6F8 Offset: 0x37986F8 VA: 0x379C6F8
	public void .ctor(IBufferSystemCalls eventIdGenerator, IDiskCache diskCache, IIdentityManager userIdentity, ISessionManager session) { }

	// RVA: 0x37A47F0 Offset: 0x37A07F0 VA: 0x37A47F0
	private void WriteString(in string value) { }

	// RVA: 0x37A4878 Offset: 0x37A0878 VA: 0x37A4878
	private void WriteLong(in long value) { }

	// RVA: 0x37A4AC8 Offset: 0x37A0AC8 VA: 0x37A4AC8
	private void WriteByte(in byte value) { }

	// RVA: 0x37A4AF0 Offset: 0x37A0AF0 VA: 0x37A4AF0
	private void WriteBytes(in byte[] bytes) { }

	// RVA: 0x37A4B24 Offset: 0x37A0B24 VA: 0x37A4B24
	private void WriteName(string name) { }

	// RVA: 0x37A4B84 Offset: 0x37A0B84 VA: 0x37A4B84
	private void WriteDateTime(DateTime dateTime) { }

	// RVA: 0x37A48D0 Offset: 0x37A08D0 VA: 0x37A48D0
	private int SerializeLong(in long number, in byte[] buffer, in int startIndex, in int minimumLength) { }

	// RVA: 0x37A504C Offset: 0x37A104C VA: 0x37A504C Slot: 4
	public void PushStandardEventStart(string name, int version) { }

	// RVA: 0x37A5274 Offset: 0x37A1274 VA: 0x37A5274
	private void PushCommonEventStart(string name) { }

	// RVA: 0x37A5528 Offset: 0x37A1528 VA: 0x37A5528
	private void StripTrailingCommaIfNecessary() { }

	// RVA: 0x37A55D4 Offset: 0x37A15D4 VA: 0x37A55D4 Slot: 5
	public void PushEndEvent() { }

	// RVA: 0x37A58EC Offset: 0x37A18EC VA: 0x37A58EC Slot: 6
	public void PushDouble(string name, double value) { }

	// RVA: 0x37A5994 Offset: 0x37A1994 VA: 0x37A5994 Slot: 7
	public void PushString(string name, string value) { }

	// RVA: 0x37A5DBC Offset: 0x37A1DBC VA: 0x37A5DBC
	private int ProcessCharacterOntoWorkingBuffer(int index, char character) { }

	// RVA: 0x37A5FAC Offset: 0x37A1FAC VA: 0x37A5FAC Slot: 8
	public void PushInt64(string name, long value) { }

	// RVA: 0x37A5FE0 Offset: 0x37A1FE0 VA: 0x37A5FE0 Slot: 9
	public void PushBool(string name, bool value) { }

	// RVA: 0x37A6020 Offset: 0x37A2020 VA: 0x37A6020 Slot: 13
	public byte[] Serialize() { }

	// RVA: 0x37A4748 Offset: 0x37A0748 VA: 0x37A4748 Slot: 14
	public void ClearBuffer() { }

	// RVA: 0x37A63B8 Offset: 0x37A23B8 VA: 0x37A63B8 Slot: 15
	public void ClearBuffer(long upTo) { }

	// RVA: 0x37A674C Offset: 0x37A274C VA: 0x37A674C Slot: 10
	public void FlushToDisk() { }

	// RVA: 0x37A6800 Offset: 0x37A2800 VA: 0x37A6800 Slot: 11
	public void ClearDiskCache() { }

	// RVA: 0x379FC28 Offset: 0x379BC28 VA: 0x379FC28
	internal static string SerializeDateTime(DateTime dateTime) { }
}
