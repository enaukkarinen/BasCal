using BasCal_SilverlightClient.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Specs.SpecFlow
{
    [Binding]
    public class WeekBuilderSteps
    {

        [StepArgumentTransformation("month")]
        public DateTime TransformToday()
        {
            return DateTime.Today;
        }

        [Given("I have given a valid (.*) and a (.*)")]
        public void GivenValidMonthAndEventCollection(DateTime month)
        {

            ScenarioContext.Current.Pending();
        }

        [When("I have given a valid month")]
        public void WhenIPressAdd()
        {
            //TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("I should get a see month filled with events")]
        public void ThenTheResultShouldBe(ObservableCollection<Week> result)
        {
            //TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
    }
}
