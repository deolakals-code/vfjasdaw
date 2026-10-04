// Assembly: Asobimo.Photon.Packet.dll
// Namespace: Asobimo.Photon.Packet
public abstract class PacketBase // TypeDefIndex: 17928
{
	// Fields
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x10
	private string errorMessage; // 0x18

	// Properties
	public abstract byte Code { get; }
	public bool IsValid { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_Code();

	[CompilerGenerated]
	// RVA: 0x16FE814 Offset: 0x16FA814 VA: 0x16FE814
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x16FE81C Offset: 0x16FA81C VA: 0x16FE81C
	protected void set_IsValid(bool value) { }

	// RVA: 0x16FE828 Offset: 0x16FA828 VA: 0x16FE828
	public void .ctor() { }

	// RVA: 0x16FE848 Offset: 0x16FA848 VA: 0x16FE848
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x16FE884 Offset: 0x16FA884 VA: 0x16FE884
	protected void SetErrorMessage(string errorMessage) { }

	// RVA: 0x16FE890 Offset: 0x16FA890 VA: 0x16FE890
	protected void SetErrorMessage(bool valid, string errorMessage) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool SetValue(Dictionary<byte, object> parameters);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Dictionary<byte, object> GetPacket();

	// RVA: -1 Offset: -1
	public static T[] GetArray<T>(object[] list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DDF38 Offset: 0x26D9F38 VA: 0x26DDF38
	|-PacketBase.GetArray<object>
	*/

	// RVA: -1 Offset: -1
	public static object[] GetPackets<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DE100 Offset: 0x26DA100 VA: 0x26DE100
	|-PacketBase.GetPackets<object>
	*/
}
