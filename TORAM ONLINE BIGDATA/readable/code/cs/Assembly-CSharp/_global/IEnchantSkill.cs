// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IEnchantSkill // TypeDefIndex: 3372
{
	// Properties
	public abstract bool IsEnchantStartMotion { get; }
	public abstract bool IsEnchantMotion { get; }
	public abstract bool IsStackChainCast { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsEnchantStartMotion();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsEnchantMotion();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsStackChainCast();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void EnchantStart(CharacterActionManagerBase actor);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void EnchantEnd(CharacterActionManagerBase actor);
}
