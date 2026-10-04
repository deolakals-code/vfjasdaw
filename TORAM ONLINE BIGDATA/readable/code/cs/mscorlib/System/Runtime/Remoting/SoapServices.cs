// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class SoapServices // TypeDefIndex: 10214
{
	// Fields
	private static Hashtable _xmlTypes; // 0x0
	private static Hashtable _xmlElements; // 0x8
	private static Hashtable _soapActions; // 0x10
	private static Hashtable _soapActionsMethods; // 0x18
	private static Hashtable _typeInfos; // 0x20

	// Properties
	public static string XmlNsForClrTypeWithAssembly { get; }
	public static string XmlNsForClrTypeWithNs { get; }
	public static string XmlNsForClrTypeWithNsAndAssembly { get; }

	// Methods

	// RVA: 0x2EDE5D8 Offset: 0x2EDA5D8 VA: 0x2EDE5D8
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x2EDE618 Offset: 0x2EDA618 VA: 0x2EDE618
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x2EDE658 Offset: 0x2EDA658 VA: 0x2EDE658
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x2EDE698 Offset: 0x2EDA698 VA: 0x2EDE698
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x2EDE914 Offset: 0x2EDA914 VA: 0x2EDE914
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x2EDE97C Offset: 0x2EDA97C VA: 0x2EDE97C
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x2EDEAB0 Offset: 0x2EDAAB0 VA: 0x2EDEAB0
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x2EDEBB0 Offset: 0x2EDABB0 VA: 0x2EDEBB0
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x2EDEC44 Offset: 0x2EDAC44 VA: 0x2EDEC44
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x2EDECD8 Offset: 0x2EDACD8 VA: 0x2EDECD8
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x2ED7BA0 Offset: 0x2ED3BA0 VA: 0x2ED7BA0
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x2ED767C Offset: 0x2ED367C VA: 0x2ED767C
	public static void PreLoad(Type type) { }

	// RVA: 0x2ED7364 Offset: 0x2ED3364 VA: 0x2ED7364
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x2ED74F0 Offset: 0x2ED34F0 VA: 0x2ED74F0
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x2EDE830 Offset: 0x2EDA830 VA: 0x2EDE830
	private static string EncodeNs(string ns) { }

	// RVA: 0x2EDEDD0 Offset: 0x2EDADD0 VA: 0x2EDEDD0
	private static void .cctor() { }
}
