using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EddDin
{
    /// <summary>
    /// Given an event organiser 
    /// When they create an event 
    /// Then the event is listed in the upcoming events list
    /// </summary>
    public class Given_an_event_organiser
    {
        [Fact]
        public void When_organiser_creates_event_Then_event_is_listed()
        {
            var createViewModel = new EventViewModel {Name = "Fpp", Location = "Loc"};

            var controller = new EventController();
            controller.Add(createViewModel);

            var events = controller.UpcomingEvents();
            Assert.Equal(1, events.Count(x => x.Name == "Fpp" && x.Location == "Loc"));
        }
    }

    public class EventController
    {
        public IEnumerable<EventViewModel> UpcomingEvents()
        {
            return new EventViewModel[0];
        }

        public void Add(EventViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }

    public class EventViewModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
}