using DieselProcessing.Recipes;
using Mafi;
using Mafi.Base;
using Mafi.Core;
using Mafi.Core.Factory.Recipes;
using Mafi.Core.Mods;
using Mafi.Core.Research;
using System;

namespace DieselProcessing
{

    public sealed class DieselProcessingModData : DataOnlyMod
    {
        //To use this unique id as a prefix for ids created in this mod it's value must match following regex: [a-zA-Z_][a-zA-Z0-9_]*
        public static readonly string UniqueModId = "ADCD67B37B0942F3A6520D4F2927BB5F";

        public override string Name => "Diesel processing";

        public override int Version => 1;

        public DieselProcessingModData(CoreMod coreMod, BaseMod baseMod)
        {
            Log.Info($"'{Name}' mod was created!");
        }

        public override void RegisterPrototypes(ProtoRegistrator registrator)
        {
            // Registers all products from this assembly.
            registrator.RegisterAllProducts();

            registrator.RegisterData<DieselCrackingRecipesData>();

            registrator.RegisterDataWithInterface<IResearchNodesData>();
        }
    }
}