using System;
using TechTalk.SpecFlow;

namespace SpecFlow.Core.Test.StepDefinitions
{
    [Binding]
    public class ShapeValidationStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IShapeValidation _shapeValidation;

        public ShapeValidationStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _shapeValidation = new ShapeValidation();
        }

        [When(@"The shape is (.*)")]
        public void WhenTheShapeIs(Shapes shape)
        {
            _scenarioContext["Shape"] = shape;

            _scenarioContext["Result"] = _shapeValidation.IsATriangle(shape);
        }

        [Then(@"it is not triangle")]
        public void ThenItIsNotTriangle()
        {
            var result = (bool)_scenarioContext["Result"];
            Assert.IsFalse(result);
        }

        [Then(@"it is triangle")]
        public void ThenItIsTriangle()
        {
            var result = (bool)_scenarioContext["Result"];
            Assert.IsTrue(result);
        }
    }
}
