// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.User
public class UserLoginEvent : PacketBase // TypeDefIndex: 12855
{
	// Fields
	[CompilerGenerated]
	private UserLoginData <UserLogin>k__BackingField; // 0x20

	// Properties
	public UserLoginData UserLogin { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3669C34 Offset: 0x3665C34 VA: 0x3669C34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3669C3C Offset: 0x3665C3C VA: 0x3669C3C
	public UserLoginData get_UserLogin() { }

	[CompilerGenerated]
	// RVA: 0x3669C44 Offset: 0x3665C44 VA: 0x3669C44
	public void set_UserLogin(UserLoginData value) { }

	// RVA: 0x3669C4C Offset: 0x3665C4C VA: 0x3669C4C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3669C54 Offset: 0x3665C54 VA: 0x3669C54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3669DF0 Offset: 0x3665DF0 VA: 0x3669DF0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
