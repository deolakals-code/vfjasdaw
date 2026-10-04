// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MiniMailManager // TypeDefIndex: 2066
{
	// Fields
	[CompilerGenerated]
	private bool <IsExpire>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<MailHistoryData> <HistoryMailList>k__BackingField; // 0x18
	[CompilerGenerated]
	private int[] <MailCounts>k__BackingField; // 0x20
	[CompilerGenerated]
	private MailCountType <SelectMailType>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<long, MailWholeData> <MailWholeDataList>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<long, MailBodyData> <MailBodyDataList>k__BackingField; // 0x38
	[CompilerGenerated]
	private DateTime <ServerTime>k__BackingField; // 0x40
	private int announcementMailCount; // 0x48
	private int announcementDeliveryCount; // 0x4C
	private int announcementPresentCount; // 0x50
	private int exchangeCount; // 0x54
	private long delivartyItemUniqueId; // 0x58

	// Properties
	public bool IsExpire { get; set; }
	public List<MailHistoryData> HistoryMailList { get; set; }
	public int[] MailCounts { get; set; }
	public MailCountType SelectMailType { get; set; }
	public Dictionary<long, MailWholeData> MailWholeDataList { get; set; }
	public Dictionary<long, MailBodyData> MailBodyDataList { get; set; }
	public DateTime ServerTime { get; set; }
	private bool IsUpdateRoom { get; }
	public int ExchangeCount { get; }
	public int ExchangeCountMax { get; }
	public bool IsMaxExchangeCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2142FB8 Offset: 0x213EFB8 VA: 0x2142FB8
	public bool get_IsExpire() { }

	[CompilerGenerated]
	// RVA: 0x2142FC0 Offset: 0x213EFC0 VA: 0x2142FC0
	private void set_IsExpire(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2142FCC Offset: 0x213EFCC VA: 0x2142FCC
	public List<MailHistoryData> get_HistoryMailList() { }

	[CompilerGenerated]
	// RVA: 0x2142FD4 Offset: 0x213EFD4 VA: 0x2142FD4
	private void set_HistoryMailList(List<MailHistoryData> value) { }

	[CompilerGenerated]
	// RVA: 0x2142FDC Offset: 0x213EFDC VA: 0x2142FDC
	public int[] get_MailCounts() { }

	[CompilerGenerated]
	// RVA: 0x2142FE4 Offset: 0x213EFE4 VA: 0x2142FE4
	private void set_MailCounts(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x2142FEC Offset: 0x213EFEC VA: 0x2142FEC
	public MailCountType get_SelectMailType() { }

	[CompilerGenerated]
	// RVA: 0x2142FF4 Offset: 0x213EFF4 VA: 0x2142FF4
	private void set_SelectMailType(MailCountType value) { }

	[CompilerGenerated]
	// RVA: 0x2142FFC Offset: 0x213EFFC VA: 0x2142FFC
	public Dictionary<long, MailWholeData> get_MailWholeDataList() { }

	[CompilerGenerated]
	// RVA: 0x2143004 Offset: 0x213F004 VA: 0x2143004
	private void set_MailWholeDataList(Dictionary<long, MailWholeData> value) { }

	[CompilerGenerated]
	// RVA: 0x214300C Offset: 0x213F00C VA: 0x214300C
	public Dictionary<long, MailBodyData> get_MailBodyDataList() { }

	[CompilerGenerated]
	// RVA: 0x2143014 Offset: 0x213F014 VA: 0x2143014
	private void set_MailBodyDataList(Dictionary<long, MailBodyData> value) { }

	[CompilerGenerated]
	// RVA: 0x214301C Offset: 0x213F01C VA: 0x214301C
	public DateTime get_ServerTime() { }

	[CompilerGenerated]
	// RVA: 0x2143024 Offset: 0x213F024 VA: 0x2143024
	private void set_ServerTime(DateTime value) { }

	// RVA: 0x214302C Offset: 0x213F02C VA: 0x214302C
	private bool get_IsUpdateRoom() { }

	// RVA: 0x21431C4 Offset: 0x213F1C4 VA: 0x21431C4
	public int get_ExchangeCount() { }

	// RVA: 0x21431CC Offset: 0x213F1CC VA: 0x21431CC
	public int get_ExchangeCountMax() { }

	// RVA: 0x21431D4 Offset: 0x213F1D4 VA: 0x21431D4
	public bool get_IsMaxExchangeCount() { }

	// RVA: 0x21431E4 Offset: 0x213F1E4 VA: 0x21431E4
	public void .ctor() { }

	// RVA: 0x214335C Offset: 0x213F35C VA: 0x214335C
	public List<MailWholeData> GetMailList(MailCountType state) { }

	// RVA: 0x2143A24 Offset: 0x213FA24 VA: 0x2143A24
	public void SwitchIsExpire(bool flag) { }

	// RVA: 0x2143A30 Offset: 0x213FA30 VA: 0x2143A30
	public void ChangeMailState(Dictionary<long, byte> updateMailStates) { }

	// RVA: 0x2143A88 Offset: 0x213FA88 VA: 0x2143A88
	public void ChangeMailState(long uniqueId, byte state) { }

	// RVA: 0x2143B54 Offset: 0x213FB54 VA: 0x2143B54
	public bool ChangeNewMailStateToUnread() { }

	// RVA: 0x2143DC8 Offset: 0x213FDC8 VA: 0x2143DC8
	public void CheckNewMail() { }

	// RVA: 0x2143E20 Offset: 0x213FE20 VA: 0x2143E20
	public void GetDeliveryItem(long uniqueId) { }

	// RVA: 0x2143E88 Offset: 0x213FE88 VA: 0x2143E88
	public void SendMail(int toAvatarUuid, byte mailType, string title, string message, ItemSelectData data, byte sendType) { }

	// RVA: 0x2143F20 Offset: 0x213FF20 VA: 0x2143F20
	public void MailHistoryCheck() { }

	// RVA: 0x2143F70 Offset: 0x213FF70 VA: 0x2143F70
	public void MailGetMessage() { }

	// RVA: 0x2143FC0 Offset: 0x213FFC0 VA: 0x2143FC0
	public void MailGetBox(MailCountType mailType, long mailUniqueId, int page, Dictionary<long, byte> mailUpdateStates) { }

	// RVA: 0x2144048 Offset: 0x2140048 VA: 0x2144048
	public void MailGetBody(long mailUniqueId) { }

	// RVA: 0x21440A0 Offset: 0x21400A0 VA: 0x21440A0
	public void MailReply(int toAvatarUuid, byte mailType, string title, string message, long replyMailId, string toAvatarName) { }

	// RVA: 0x2144138 Offset: 0x2140138 VA: 0x2144138
	public bool MailDeleteExpired() { }

	// RVA: 0x2144430 Offset: 0x2140430 VA: 0x2144430
	public void ReceiveChangeStateMail(int[] mailCounts, Dictionary<long, byte> updateMailStates) { }

	// RVA: 0x2144990 Offset: 0x2140990 VA: 0x2144990
	public void ReceiveMailCount(int[] mailCounts, int exchangeCount) { }

	// RVA: 0x21449C4 Offset: 0x21409C4 VA: 0x21449C4
	public void RecieveDeliveryItem(MailBodyData mail, int[] mailCounts) { }

	// RVA: 0x2144AC8 Offset: 0x2140AC8 VA: 0x2144AC8
	public void ReceiveMailHistoryCheck(MailHistoryData[] data) { }

	// RVA: 0x2144C5C Offset: 0x2140C5C VA: 0x2144C5C
	public void ReceiveMialSend(int exchangeCount) { }

	// RVA: 0x2144C64 Offset: 0x2140C64 VA: 0x2144C64
	public void ReceiveMailGetMessage(int[] mailCounts) { }

	// RVA: 0x2144C74 Offset: 0x2140C74 VA: 0x2144C74
	public void ReceiveMailGetBox(MailGetBoxResponse response) { }

	// RVA: 0x2144F94 Offset: 0x2140F94 VA: 0x2144F94
	public void ReceiveMailGetBody(MailGetBodyResponse response) { }

	// RVA: 0x214446C Offset: 0x214046C VA: 0x214446C
	private void UpdateMailState(Dictionary<long, byte> updateMailStates) { }

	// RVA: 0x2144FB4 Offset: 0x2140FB4 VA: 0x2144FB4
	private void SetBodyData(MailBodyData data) { }

	// RVA: 0x214475C Offset: 0x214075C VA: 0x214475C
	private void AnnounceUpdate() { }
}
