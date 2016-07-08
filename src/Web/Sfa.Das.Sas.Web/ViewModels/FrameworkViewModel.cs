﻿namespace Sfa.Das.Sas.Web.ViewModels
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class FrameworkViewModel
    {
        public int FrameworkId { get; set; }

        public string Title { get; set; }

        public int Level { get; set; }

        public string TypicalLengthMessage { get; set; }

        public string ExpiryDateString { get; set; }

        // Page specific
        public bool IsShortlisted { get; set; }

        public string SearchTerm { get; set; }

        public string Qualifications { get; set; }

        public string CompletionQualifications { get; set; }

        public string FrameworkOverview { get; set; }

        public string EntryRequirements { get; set; }

        public string ProfessionalRegistration { get; set; }

        public IEnumerable<string> JobRoles { get; set; }
    }
}