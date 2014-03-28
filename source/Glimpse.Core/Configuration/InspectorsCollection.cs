﻿using Glimpse.Core.Configuration;
using Glimpse.Core.Extensibility;

namespace Glimpse.Core.Framework
{
    public class InspectorsCollection : DiscoverableCollection<IInspector>
    {
        public InspectorsCollection(
            CollectionConfiguration configuration,
            ILogger logger)
            : base(configuration, logger)
        {
        }
    }
}