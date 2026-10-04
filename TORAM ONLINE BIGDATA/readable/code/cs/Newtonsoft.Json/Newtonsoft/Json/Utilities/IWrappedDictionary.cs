// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 15893
{
	// Properties
	[Nullable(1)]
	public abstract object UnderlyingDictionary { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingDictionary();
}
