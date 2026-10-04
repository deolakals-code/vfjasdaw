// Assembly: System.dll
// Namespace: System.ComponentModel
[ComVisible(True)]
[TypeConverter(typeof(ComponentConverter))]
[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", True)]
public interface IComponent : IDisposable // TypeDefIndex: 14253
{
	// Properties
	public abstract ISite Site { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISite get_Site();
}
