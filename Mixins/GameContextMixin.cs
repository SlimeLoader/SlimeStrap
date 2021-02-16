using System;
using System.Reflection;
using SharpILMixins.Annotations;
using SharpILMixins.Annotations.Inject;

namespace SlimeStrap.Mixins {
	[Mixin("GameContext")]
	public abstract class GameContextMixin {
		[Inject(At = AtLocation.Head, Method = "Awake")]
		private void OnAwake() {
			// Call "Init" method
			// TODO: Optimize reflection
			Type.GetType("SlimeLoader.Loader.ModLoader,Assembly_CSharp")
				.GetMethod("Init")
				.Invoke(null, null);
		}
	}
}
