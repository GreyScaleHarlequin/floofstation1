using Content.Shared.Research.Prototypes;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.List;

namespace Content.Shared.Lathe
{
    [RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
    public sealed partial class EmagLatheRecipesComponent : Component
    {
        // FloofStation Modified
        // AlwaysPushInheritance done to remain consistent with LatheComponent
        /// <summary>
        /// All of the dynamic recipes that the lathe is capable to get using EMAG
        /// </summary>
        [DataField, AlwaysPushInheritance, AutoNetworkedField]
        public HashSet<ProtoId<LatheRecipePrototype>> EmagDynamicRecipes = new();

        // FloofStation Modified
        // Ditto from EmagDynamicRecipes
        /// <summary>
        /// All of the static recipes that the lathe is capable to get using EMAG
        /// </summary>
        [DataField, AlwaysPushInheritance, AutoNetworkedField]
        public HashSet<ProtoId<LatheRecipePrototype>> EmagStaticRecipes = new();
    }
}
