// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public abstract class XObject : IXmlLineInfo // TypeDefIndex: 17528
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Properties
	public string BaseUri { get; }
	public abstract XmlNodeType NodeType { get; }
	public XElement Parent { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }
	internal bool HasBaseUri { get; }

	// Methods

	// RVA: 0x32BACD8 Offset: 0x32B6CD8 VA: 0x32BACD8
	internal void .ctor() { }

	// RVA: 0x32BF618 Offset: 0x32BB618 VA: 0x32BF618
	public string get_BaseUri() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x32C3374 Offset: 0x32BF374 VA: 0x32C3374
	public XElement get_Parent() { }

	// RVA: 0x32C14BC Offset: 0x32BD4BC VA: 0x32C14BC
	public void AddAnnotation(object annotation) { }

	// RVA: 0x32C33F0 Offset: 0x32BF3F0 VA: 0x32C33F0
	private object AnnotationForSealedType(Type type) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FC0F8 Offset: 0x26F80F8 VA: 0x26FC0F8
	|-XObject.Annotation<object>
	*/

	// RVA: 0x32C353C Offset: 0x32BF53C VA: 0x32C353C Slot: 4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x32C3590 Offset: 0x32BF590 VA: 0x32C3590 Slot: 5
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x32C35E4 Offset: 0x32BF5E4 VA: 0x32C35E4 Slot: 6
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x32BF5C4 Offset: 0x32BB5C4 VA: 0x32BF5C4
	internal bool get_HasBaseUri() { }

	// RVA: 0x32BD618 Offset: 0x32B9618 VA: 0x32BD618
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x32BD570 Offset: 0x32B9570 VA: 0x32BD570
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x32BF46C Offset: 0x32BB46C VA: 0x32BF46C
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x32BF4E4 Offset: 0x32BB4E4 VA: 0x32BF4E4
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x32BC7F0 Offset: 0x32B87F0 VA: 0x32BC7F0
	internal bool SkipNotify() { }

	// RVA: 0x32C2E18 Offset: 0x32BEE18 VA: 0x32C2E18
	internal SaveOptions GetSaveOptionsFromAnnotations() { }
}
