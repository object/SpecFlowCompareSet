using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpecFlowCompareSet.Implementation;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowCompareSet.Steps
{
    [Binding]
    public class StepDefinitions
    {
        [When(@"I have a collection")]
        public void WhenIHaveACollection(Table table)
        {
            var collection = table.CreateSet<Item>();
            ScenarioContext.Current.Add("Collection", collection);
        }

        [Then(@"it should match")]
        public void ThenItShouldMatch(Table table)
        {
            Compare(table);
        }

        [Then(@"it should exactly match")]
        public void ThenItShouldExactlyMatch(Table table)
        {
            Compare(table, TableComparison.TheTableAndSetAreAnExactMatch);
        }

        [Then(@"it should not match")]
        public void ThenItShouldNotMatch(Table table)
        {
            Compare(table, TableComparison.TheTableAndSetMatchWithoutRegardForOrder, false);
        }

        [Then(@"it should not exactly match")]
        public void ThenItShouldNotExactlyMatch(Table table)
        {
            Compare(table, TableComparison.TheTableAndSetAreAnExactMatch, false);
        }

        [Then(@"it should contain all items")]
        public void ThenItShouldContainAllItems(Table table)
        {
            Compare(table, TableComparison.AllItemsInTheTableCanBeFoundWithinTheSet);
        }

        [Then(@"it should not contain all items")]
        public void ThenItShouldNotContainAllItems(Table table)
        {
            Compare(table, TableComparison.AllItemsInTheTableCanBeFoundWithinTheSet, false);
        }

        [Then(@"it should not contain any of items")]
        public void ThenItShouldNotContainAnyOfItems(Table table)
        {
            Compare(table, TableComparison.NoneOfTheItemsInTheTableAreInTheSet);
        }

        private void Compare(Table table, TableComparison comparisonMode = TableComparison.TheTableAndSetMatchWithoutRegardForOrder, bool expectedMatch = true)
        {
            var collection = ScenarioContext.Current["Collection"] as IEnumerable<Item>;
            table.CompareToSet(collection, comparisonMode, expectedMatch);
        }
    }
}
