// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.User
public class UserReLoginEvent : PacketBase // TypeDefIndex: 12856
{
	// Fields
	[CompilerGenerated]
	private UserLoginData <UserLogin>k__BackingField; // 0x20

	// Properties
	public UserLoginData UserLogin { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3669EA8 Offset: 0x3665EA8 VA: 0x3669EA8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3669EB0 Offset: 0x3665EB0 VA: 0x3669EB0
	public UserLoginData get_UserLogin() { }

	[CompilerGenerated]
	// RVA: 0x3669EB8 Offset: 0x3665EB8 VA: 0x3669EB8
	public void set_UserLogin(UserLoginData value) { }

	// RVA: 0x3669EC0 Offset: 0x3665EC0 VA: 0x3669EC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3669EC8 Offset: 0x3665EC8 VA: 0x3669EC8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366A064 Offset: 0x3666064 VA: 0x366A064 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
