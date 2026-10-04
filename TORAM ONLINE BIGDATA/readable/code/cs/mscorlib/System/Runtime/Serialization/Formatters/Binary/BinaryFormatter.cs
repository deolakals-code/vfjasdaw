// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
[ComVisible(True)]
public sealed class BinaryFormatter // TypeDefIndex: 10411
{
	// Fields
	internal ISurrogateSelector m_surrogates; // 0x10
	internal StreamingContext m_context; // 0x18
	internal SerializationBinder m_binder; // 0x28
	internal FormatterTypeStyle m_typeFormat; // 0x30
	internal FormatterAssemblyStyle m_assemblyFormat; // 0x34
	internal TypeFilterLevel m_securityLevel; // 0x38
	internal object[] m_crossAppDomainArray; // 0x40
	private static Dictionary<Type, TypeInformation> typeNameCache; // 0x0

	// Properties
	public FormatterAssemblyStyle AssemblyFormat { set; }
	public ISurrogateSelector SurrogateSelector { set; }

	// Methods

	// RVA: 0x2F0CED0 Offset: 0x2F08ED0 VA: 0x2F0CED0
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x2F0CED8 Offset: 0x2F08ED8 VA: 0x2F0CED8 Slot: 4
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x2F0CEE0 Offset: 0x2F08EE0 VA: 0x2F0CEE0
	public void .ctor() { }

	// RVA: 0x2F0CF4C Offset: 0x2F08F4C VA: 0x2F0CF4C
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x2F0CFB0 Offset: 0x2F08FB0 VA: 0x2F0CFB0 Slot: 5
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x2F0CFC4 Offset: 0x2F08FC4 VA: 0x2F0CFC4
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x2F0CFBC Offset: 0x2F08FBC VA: 0x2F0CFBC Slot: 6
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x2F0D81C Offset: 0x2F0981C VA: 0x2F0D81C Slot: 7
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x2F0D828 Offset: 0x2F09828 VA: 0x2F0D828 Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x2F0D830 Offset: 0x2F09830 VA: 0x2F0D830
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x2F0E038 Offset: 0x2F0A038 VA: 0x2F0E038
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x2F0E2E0 Offset: 0x2F0A2E0 VA: 0x2F0E2E0
	private static void .cctor() { }
}
