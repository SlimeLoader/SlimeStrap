using System;
using SharpILMixins.Annotations;
using SharpILMixins.Annotations.Inject;

namespace SlimeStrap.Mixins {
	[Mixin("GameContext")]
	public abstract class GameContextMixin {
		[Inject(At = AtLocation.Head, Method = "Awake")]
		private void OnAwake() {
			// Call "Init" method
		}
	}
}
