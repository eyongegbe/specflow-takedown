﻿using api_acceptance_tests.Support;
using TechTalk.SpecFlow;

namespace api_acceptance_tests.Steps
{
    [Binding]
    public class SharedSteps : StepsBase
    {
        [When(@"I make a request")]
        public void WhenIMakeARequest()
        {
            var uri = Retrieve<string>("uri");
            var response = HttpClient.Get(uri);

            Save("response", response);
        }     
    }
}