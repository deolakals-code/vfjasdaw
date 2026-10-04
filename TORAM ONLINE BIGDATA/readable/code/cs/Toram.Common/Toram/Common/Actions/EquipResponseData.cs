// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class EquipResponseData : UnityHashBase // TypeDefIndex: 13158
{
	// Fields
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x1C
	[CompilerGenerated]
	private Dictionary<byte, object> <NewProperties>k__BackingField; // 0x20
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ViewFlag>k__BackingField; // 0x30

	// Properties
	public int PropertiesRevision { get; set; }
	public Dictionary<byte, object> NewProperties { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public short ViewFlag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B86A0 Offset: 0x36B46A0 VA: 0x36B86A0
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36B86A8 Offset: 0x36B46A8 VA: 0x36B86A8
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x36B86B0 Offset: 0x36B46B0 VA: 0x36B86B0
	public void set_PropertiesRevision(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B86B8 Offset: 0x36B46B8 VA: 0x36B86B8
	public Dictionary<byte, object> get_NewProperties() { }

	[CompilerGenerated]
	// RVA: 0x36B86C0 Offset: 0x36B46C0 VA: 0x36B86C0
	public void set_NewProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x36B86C8 Offset: 0x36B46C8 VA: 0x36B86C8
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36B86D0 Offset: 0x36B46D0 VA: 0x36B86D0
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36B86D8 Offset: 0x36B46D8 VA: 0x36B86D8
	public short get_ViewFlag() { }

	[CompilerGenerated]
	// RVA: 0x36B86E0 Offset: 0x36B46E0 VA: 0x36B86E0
	public void set_ViewFlag(short value) { }

	// RVA: 0x36B86E8 Offset: 0x36B46E8 VA: 0x36B86E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B86F0 Offset: 0x36B46F0 VA: 0x36B86F0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36B8A88 Offset: 0x36B4A88 VA: 0x36B8A88 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
