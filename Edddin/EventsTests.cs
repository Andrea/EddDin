using System;
using Xunit;

namespace Edddin
{
    public class EventsTests
    {
        private const string ValidEventName = "Valid Name";

        [Fact]
        public void Attempting_to_create_event_with_no_name_Then_it_throws()
        {
            Assert.Throws<ArgumentException>(() => new Event(null, CreateValidEventOrganiser()));
        }

        [Fact]
        public void Attempting_to_create_event_with_no_organiser_Then_it_throws()
        {
            Assert.Throws<ArgumentException>(() => new Event(ValidEventName, null));
        }

        [Fact]
        public void When_creating_event_with_name_and_organiser_Then_event_is_created()
        {
            var theEvent = new Event(ValidEventName, CreateValidEventOrganiser());
            Assert.NotNull(theEvent);
        }

        private Person CreateValidEventOrganiser()
        {
            return new Person();
        }

    }
}
