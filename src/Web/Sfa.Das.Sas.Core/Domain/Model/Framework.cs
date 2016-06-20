﻿namespace Sfa.Das.Sas.Core.Domain.Model
{
    using System;

    public sealed class Framework
    {
        public int FrameworkId { get; set; }

        public string Title { get; set; }

        public string FrameworkName { get; set; }

        public string PathwayName { get; set; }

        public int FrameworkCode { get; set; }

        public int PathwayCode { get; set; }

        public int Level { get; set; }

        public TypicalLength TypicalLength { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
