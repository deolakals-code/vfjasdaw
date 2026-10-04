// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Friend
public class FriendAcceptanceEvent : PacketBase // TypeDefIndex: 12850
{
	// Fields
	[CompilerGenerated]
	private FriendData <FriendData>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 173, IsOptional = True)]
	public FriendData FriendData { get; set; }
	[PacketParameter(Code = 81, IsOptional = True)]
	public short ReturnCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3668958 Offset: 0x3664958 VA: 0x3668958
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3668960 Offset: 0x3664960 VA: 0x3668960
	public FriendData get_FriendData() { }

	[CompilerGenerated]
	// RVA: 0x3668968 Offset: 0x3664968 VA: 0x3668968
	public void set_FriendData(FriendData value) { }

	[CompilerGenerated]
	// RVA: 0x3668970 Offset: 0x3664970 VA: 0x3668970
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3668978 Offset: 0x3664978 VA: 0x3668978
	public void set_ReturnCode(short value) { }

	// RVA: 0x3668980 Offset: 0x3664980 VA: 0x3668980
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3668A9C Offset: 0x3664A9C VA: 0x3668A9C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3668B18 Offset: 0x3664B18 VA: 0x3668B18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3668B20 Offset: 0x3664B20 VA: 0x3668B20 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3668C7C Offset: 0x3664C7C VA: 0x3668C7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
