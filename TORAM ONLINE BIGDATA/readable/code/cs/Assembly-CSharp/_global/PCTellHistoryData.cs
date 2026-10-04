// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PCTellHistoryData : TellHistoryData // TypeDefIndex: 1765
{
	// Fields
	private bool isMine; // 0x3E
	private bool isNewMessage; // 0x3F

	// Properties
	public override bool IsMine { get; }
	public override bool IsNewMessage { get; }

	// Methods

	// RVA: 0x20CCEF8 Offset: 0x20C8EF8 VA: 0x20CCEF8 Slot: 5
	public override bool get_IsMine() { }

	// RVA: 0x20CCF00 Offset: 0x20C8F00 VA: 0x20CCF00 Slot: 4
	public override bool get_IsNewMessage() { }

	// RVA: 0x20CCF08 Offset: 0x20C8F08 VA: 0x20CCF08
	public void .ctor(int id, string userName, string message, byte regionCode, DateTime dateTime, bool isMine) { }

	// RVA: 0x20CD000 Offset: 0x20C9000 VA: 0x20CD000 Slot: 6
	public override void AddLineCount(int add) { }

	// RVA: 0x20CD004 Offset: 0x20C9004 VA: 0x20CD004 Slot: 7
	public override void SetOld(bool isOld) { }

	// RVA: 0x20CD018 Offset: 0x20C9018 VA: 0x20CD018 Slot: 8
	public override void ResponseTell() { }

	// RVA: 0x20CD074 Offset: 0x20C9074 VA: 0x20CD074 Slot: 9
	public override string SaveData() { }

	// RVA: 0x20CD284 Offset: 0x20C9284 VA: 0x20CD284 Slot: 10
	public override TellHistoryData Copy() { }
}
