// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChatManager.ChatData // TypeDefIndex: 1756
{
	// Fields
	private static readonly float CheckNGWaitTime; // 0x0
	private static readonly int MaxRetryCount; // 0x4
	private ChatManager.ChatMessageType messageType; // 0x10
	private ChatEvent chatEvent; // 0x18
	private DateTime timeStamp; // 0x20
	private bool isWait; // 0x28
	private int retryCount; // 0x2C
	private float waitingTime; // 0x30

	// Properties
	public ChatManager.ChatMessageType MessageType { get; }
	public ChatEvent ChatEvent { get; }
	public DateTime TimeStamp { get; }
	public bool IsWait { get; }

	// Methods

	// RVA: 0x20C8460 Offset: 0x20C4460 VA: 0x20C8460
	public ChatManager.ChatMessageType get_MessageType() { }

	// RVA: 0x20C8468 Offset: 0x20C4468 VA: 0x20C8468
	public ChatEvent get_ChatEvent() { }

	// RVA: 0x20C8470 Offset: 0x20C4470 VA: 0x20C8470
	public DateTime get_TimeStamp() { }

	// RVA: 0x20C8478 Offset: 0x20C4478 VA: 0x20C8478
	public bool get_IsWait() { }

	// RVA: 0x20C8480 Offset: 0x20C4480 VA: 0x20C8480
	public void .ctor() { }

	// RVA: 0x20C349C Offset: 0x20BF49C VA: 0x20C349C
	public void .ctor(string message, ChatManager.ChatMessageType type) { }

	// RVA: 0x20C2F40 Offset: 0x20BEF40 VA: 0x20C2F40
	public void .ctor(ChatEvent chat, ChatManager.ChatMessageType type) { }

	// RVA: 0x20C4444 Offset: 0x20C0444 VA: 0x20C4444
	public void .ctor(ChatData chat) { }

	// RVA: 0x20C335C Offset: 0x20BF35C VA: 0x20C335C
	public void SetWaitingFlag() { }

	// RVA: 0x20C3368 Offset: 0x20BF368 VA: 0x20C3368
	public void EndNGCheck(string message) { }

	// RVA: 0x20C28FC Offset: 0x20BE8FC VA: 0x20C28FC
	public bool IsRetryNGCheck() { }

	// RVA: 0x20C2AC0 Offset: 0x20BEAC0 VA: 0x20C2AC0
	public bool IsNGCheckTimeOut() { }

	// RVA: 0x20C2894 Offset: 0x20BE894 VA: 0x20C2894
	public bool IsRetryMax() { }

	// RVA: 0x20C8524 Offset: 0x20C4524 VA: 0x20C8524
	private static void .cctor() { }
}
