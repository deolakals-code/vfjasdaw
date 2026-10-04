// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Channels
internal class CADSerializer // TypeDefIndex: 10255
{
	// Methods

	// RVA: 0x2EE95D8 Offset: 0x2EE55D8 VA: 0x2EE95D8
	internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg) { }

	// RVA: 0x2EE9094 Offset: 0x2EE5094 VA: 0x2EE9094
	internal static MemoryStream SerializeMessage(IMessage msg) { }

	// RVA: 0x2ECE08C Offset: 0x2ECA08C VA: 0x2ECE08C
	internal static object DeserializeObjectSafe(byte[] mem) { }

	// RVA: 0x2ECE19C Offset: 0x2ECA19C VA: 0x2ECE19C
	internal static MemoryStream SerializeObject(object obj) { }

	// RVA: 0x2EE99B8 Offset: 0x2EE59B8 VA: 0x2EE99B8
	internal static object DeserializeObject(MemoryStream mem) { }
}
