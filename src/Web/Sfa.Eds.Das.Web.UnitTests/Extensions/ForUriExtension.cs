﻿namespace Sfa.Eds.Das.Web.UnitTests.Extensions
{
    using System;

    using FluentAssertions;

    using NUnit.Framework;

    using Sfa.Eds.Das.Web.Extensions;

    [TestFixture]
    public class ForUriExtension
    {
        [Test]
        public void WhenPreviousSearchIsUnknown()
        {
            var uri = new Uri("http://www.sfatest.co.uk/path/to/page");
            var resultUrl = uri.GetSearchResultUrl("action/url").Url;
            var resultTitle = uri.GetSearchResultUrl("action/url").Title;

            resultUrl.ShouldBeEquivalentTo("action/url");
            resultTitle.ShouldBeEquivalentTo("Back to search page");
        }

        [Test]
        public void WhenPreviousSearchIsKnown()
        {
            var uri = new Uri("http://www.sfatest.co.uk/path/to/page?keywords=hello+world");
            var resultUrl = uri.GetSearchResultUrl("action/url").Url;
            var resultTitle = uri.GetSearchResultUrl("action/url").Title;

            resultUrl.ShouldBeEquivalentTo("http://www.sfatest.co.uk/path/to/page?keywords=hello+world");
            resultTitle.ShouldBeEquivalentTo("Results");
        }
    }
}