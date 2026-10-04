// Assembly: mscorlib.dll
// Namespace: System.Security.Principal
[ComVisible(True)]
[Serializable]
public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 10181
{
	// Fields
	private IntPtr _token; // 0x78
	private string _type; // 0x80
	private WindowsAccountType _account; // 0x88
	private bool _authenticated; // 0x8C
	private string _name; // 0x90
	private SerializationInfo _info; // 0x98
	private static IntPtr invalidWindows; // 0x0

	// Properties
	public sealed override string AuthenticationType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x2EC7E8C Offset: 0x2EC3E8C VA: 0x2EC7E8C
	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	// RVA: 0x2EC8050 Offset: 0x2EC4050 VA: 0x2EC8050
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisible(False)]
	// RVA: 0x2EC8080 Offset: 0x2EC4080 VA: 0x2EC8080 Slot: 14
	public void Dispose() { }

	// RVA: 0x2EC8088 Offset: 0x2EC4088 VA: 0x2EC8088
	public static WindowsIdentity GetCurrent() { }

	// RVA: 0x2EC8108 Offset: 0x2EC4108 VA: 0x2EC8108 Slot: 15
	public virtual WindowsImpersonationContext Impersonate() { }

	// RVA: 0x2EC81EC Offset: 0x2EC41EC VA: 0x2EC81EC Slot: 6
	public sealed override string get_AuthenticationType() { }

	// RVA: 0x2EC81F4 Offset: 0x2EC41F4 VA: 0x2EC81F4 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2EC8274 Offset: 0x2EC4274 VA: 0x2EC8274 Slot: 12
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x2EC857C Offset: 0x2EC457C VA: 0x2EC857C Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EC7EF4 Offset: 0x2EC3EF4 VA: 0x2EC7EF4
	private void SetToken(IntPtr token) { }

	// RVA: 0x2EC8104 Offset: 0x2EC4104 VA: 0x2EC8104
	internal static IntPtr GetCurrentToken() { }

	// RVA: 0x2EC8270 Offset: 0x2EC4270 VA: 0x2EC8270
	private static string GetTokenName(IntPtr token) { }

	// RVA: 0x2EC86E4 Offset: 0x2EC46E4 VA: 0x2EC86E4
	private static void .cctor() { }
}
