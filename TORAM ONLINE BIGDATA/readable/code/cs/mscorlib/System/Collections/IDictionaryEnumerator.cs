// Assembly: mscorlib.dll
// Namespace: System.Collections
public interface IDictionaryEnumerator : IEnumerator // TypeDefIndex: 10864
{
	// Properties
	public abstract object Key { get; }
	public abstract object Value { get; }
	public abstract DictionaryEntry Entry { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DictionaryEntry get_Entry();
}
