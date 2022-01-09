using Mafi;
using Mafi.Base;
using Mafi.Core.Factory.Recipes;
using Mafi.Core.Mods;
using static Mafi.Base.Ids;

namespace DieselProcessing.Recipes
{
    public sealed class DieselCrackingRecipesData : IModData
    {
        public static readonly RecipeProto.ID Id = Ids.Recipes.CreateId($"{DieselProcessingModData.UniqueModId}_DieselCracking");

        public void RegisterData(ProtoRegistrator registrator)
        {
            Duration oilDuration = (Duration)typeof(BaseMod).Assembly.GetType("Mafi.Base.Prototypes.Machines.OilDistillationData").GetField("DURATION").GetValue(null);

            registrator.RecipeProtoBuilder
                .Start(name: "Diesel cracking", recipeId: Id, machineId: Machines.HydroCrackerT1)
                .AddInput(8, Ids.Products.Diesel)
                .AddInput(8, Ids.Products.Oxygen)
                .SetDuration(oilDuration)
                .AddOutput(8, Ids.Products.FuelGas, "X")
                .AddOutput(8, Ids.Products.CarbonDioxide, "Y")
                .BuildAndAdd();
        }
    }
}