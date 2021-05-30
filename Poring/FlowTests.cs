using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using Poring.Class;

namespace Poring
{
    public class FlowTests
    {
        private FlowService _flowService;
        private OtherFlowService _otherFlowService;
        private IService1 _service1;

        [SetUp]
        public void SetUp()
        {
            _service1 = Substitute.For<IService1>();
            _flowService = new FlowService(_service1);
            _otherFlowService = new OtherFlowService(_service1);
        }

        [Test]
        public void flow_result_should_be_correct()
        {
            GivenId(9527);
            _flowService.GetResult().Should().Be("9527");
        }


        [Test]
        public void other_flow_result_should_be_correct()
        {
            GivenId(9527);
            _otherFlowService.GetReversedResult().Should().Be("7259");
        }

        private void GivenId(int id)
        {
            _service1.GetId().Returns(id);
        }
    }
}