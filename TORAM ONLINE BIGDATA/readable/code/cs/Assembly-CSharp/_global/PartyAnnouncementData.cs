// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyAnnouncementData : AnnouncementBase // TypeDefIndex: 1701
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <Time>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x28

	// Properties
	public int PartyId { get; set; }
	public int SenderId { get; set; }
	public float Time { get; set; }
	public string Name { get; set; }
	public string Message { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20AC1E4 Offset: 0x20A81E4 VA: 0x20AC1E4
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x20AC1EC Offset: 0x20A81EC VA: 0x20AC1EC
	private void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x20AC1F4 Offset: 0x20A81F4 VA: 0x20AC1F4
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x20AC1FC Offset: 0x20A81FC VA: 0x20AC1FC
	private void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x20AC204 Offset: 0x20A8204 VA: 0x20AC204
	public float get_Time() { }

	[CompilerGenerated]
	// RVA: 0x20AC20C Offset: 0x20A820C VA: 0x20AC20C
	private void set_Time(float value) { }

	[CompilerGenerated]
	// RVA: 0x20AC214 Offset: 0x20A8214 VA: 0x20AC214
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x20AC21C Offset: 0x20A821C VA: 0x20AC21C
	private void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x20AC224 Offset: 0x20A8224 VA: 0x20AC224
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x20AC22C Offset: 0x20A822C VA: 0x20AC22C
	private void set_Message(string value) { }

	// RVA: 0x20AC234 Offset: 0x20A8234 VA: 0x20AC234
	public void .ctor() { }

	// RVA: 0x20A8144 Offset: 0x20A4144 VA: 0x20A8144
	public void .ctor(int partyId, int senderId, string time, string name, string message) { }

	// RVA: 0x20A81B0 Offset: 0x20A41B0 VA: 0x20A81B0
	public void UpdateData(PartyReserveData reserve) { }

	// RVA: 0x20A82E4 Offset: 0x20A42E4 VA: 0x20A82E4
	public void TimeOut() { }
}
