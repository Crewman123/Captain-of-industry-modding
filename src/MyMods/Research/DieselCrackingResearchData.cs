using DieselProcessing.Recipes;
using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;

namespace DieselProcessing.Research
{
    public sealed class DieselCrackingResearchData : IResearchNodesData
    {
        public static readonly ResearchNodeProto.ID Id = Ids.Research.CreateId($"{DieselProcessingModData.UniqueModId}_DieselCrackingResearchId");

        public void RegisterData(ProtoRegistrator registrator)
        {
            ResearchNodeProto nodeProto = registrator.ResearchNodeProtoBuilder
                .Start("Unlock diesel cracking", Id)
                .Description("This unlocks diesel cracking recepie for cracking unit")
                .AddRecipeToUnlock(DieselCrackingRecipesData.Id)
                .SetCosts(new ResearchCostsTpl(1))
                .BuildAndAdd();

            nodeProto.GridPosition = new Vector2i(84, 36);
            nodeProto.AddParent(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.HeavyOilCracking));
        }
    }
}