// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IMobModelCacheStrategy // TypeDefIndex: 1034
{
	// Properties
	public abstract string AcceptTag { get; }
	public abstract IList<string> ObjectNames { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_AcceptTag();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IList<string> get_ObjectNames();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IList<string> AddCache(string name);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void RemoveCache(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Contains(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Clear();
}
