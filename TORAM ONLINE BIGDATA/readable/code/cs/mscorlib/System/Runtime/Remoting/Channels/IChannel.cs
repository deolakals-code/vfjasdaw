// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannel // TypeDefIndex: 10257
{
	// Properties
	public abstract string ChannelName { get; }
	public abstract int ChannelPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ChannelName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ChannelPriority();
}
