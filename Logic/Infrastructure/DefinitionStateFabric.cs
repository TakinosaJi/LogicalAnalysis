using System;

namespace Logic.Infrastructure
{
    public static class DefinitionStateFabric
    {
        public static DefinitionState? Get(Boolean? nativeState)
        {
            switch (nativeState)
            {
                case null:
                {
                    return DefinitionState.Undefined;
                }
                    break;

                case true:
                {
                    return DefinitionState.True;
                }
                    break;
                case false:
                {
                    return DefinitionState.False;
                }
                    break;
                default:
                {
                    return null;
                }
                    break;
            }
        }
    }
}