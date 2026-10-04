// Assembly: System.Xml.dll
// Namespace: System.Xml
[DefaultMember("ItemOf")]
public abstract class XmlNodeList : IEnumerable, IDisposable // TypeDefIndex: 13413
{
	// Properties
	public abstract int Count { get; }
	public virtual XmlNode ItemOf { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNode Item(int index);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IEnumerator GetEnumerator();

	// RVA: 0x33C3DB8 Offset: 0x33BFDB8 VA: 0x33C3DB8 Slot: 9
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0x33C3DC4 Offset: 0x33BFDC4 VA: 0x33C3DC4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x33C3DD0 Offset: 0x33BFDD0 VA: 0x33C3DD0 Slot: 10
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x33C3DD4 Offset: 0x33BFDD4 VA: 0x33C3DD4
	protected void .ctor() { }
}
