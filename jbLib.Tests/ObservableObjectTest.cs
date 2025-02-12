using System.ComponentModel;
using jbLib.mvvm;
using Xunit;

namespace jbLib.Tests
{
    public class ObservableObjectTests
    {
        private class TestObservableObject : ObservableObject
        {
            private string _testProperty = string.Empty;
            public string TestProperty
            {
                get => _testProperty;
                set
                {
                    if (_testProperty != value)
                    {
                        OnPropertyChanging();
                        _testProperty = value;
                        OnPropertyChanged();
                    }
                }
            }
        }

        [Fact]
        public void OnPropertyChanged_ShouldRaisePropertyChangedEvent()
        {
            var obj = new TestObservableObject();
            bool eventRaised = false;

            obj.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(TestObservableObject.TestProperty))
                {
                    eventRaised = true;
                }
            };

            obj.TestProperty = "New Value";

            Assert.True(eventRaised);
        }

        [Fact]
        public void OnPropertyChanging_ShouldRaisePropertyChangingEvent()
        {
            var obj = new TestObservableObject();
            bool eventRaised = false;

            obj.PropertyChanging += (sender, args) =>
            {
                if (args.PropertyName == nameof(TestObservableObject.TestProperty))
                {
                    eventRaised = true;
                }
            };

            obj.TestProperty = "New Value";

            Assert.True(eventRaised);
        }
    }
}