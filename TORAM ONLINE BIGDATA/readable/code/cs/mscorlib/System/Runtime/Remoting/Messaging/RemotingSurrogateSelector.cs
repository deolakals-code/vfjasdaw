// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class RemotingSurrogateSelector : ISurrogateSelector // TypeDefIndex: 10321
{
	// Fields
	private static Type s_cachedTypeObjRef; // 0x0
	private static ObjRefSurrogate _objRefSurrogate; // 0x8
	private static RemotingSurrogate _objRemotingSurrogate; // 0x10
	private ISurrogateSelector _next; // 0x10

	// Methods

	// RVA: 0x2EF8D78 Offset: 0x2EF4D78 VA: 0x2EF8D78
	public void .ctor() { }

	// RVA: 0x2EF8D80 Offset: 0x2EF4D80 VA: 0x2EF8D80 Slot: 5
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

	// RVA: 0x2EF8F40 Offset: 0x2EF4F40 VA: 0x2EF8F40
	private static void .cctor() { }
}
