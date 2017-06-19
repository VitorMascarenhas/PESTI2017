using FluentNHibernate;
using FluentNHibernate.Automapping;
using System;

namespace PlataformaRPHD.Infrastructure.Data
{
    public class StoreConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace == "Mappings";
        }
    }
}
