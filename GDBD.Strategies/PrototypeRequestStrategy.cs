using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Strategies
{
	public sealed class PrototypeRequestStrategy : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrototypeRequestStrategy(string info)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
